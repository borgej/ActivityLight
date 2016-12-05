using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LuxaforSharp;
using Microsoft.Lync.Model;
using Microsoft.Exchange.WebServices.Data;
using Microsoft.Lync.Model.Extensibility;
using Color = System.Drawing.Color;
using Contact = Microsoft.Lync.Model.Contact;

namespace ActivityLighter
{
    public partial class Form1 : Form
    {
        private ExchangeService exchangeService;
        private LyncClient lyncClient;

        private System.Threading.Thread t;

        private bool _isAutomatic = false;
        private bool _isGreen = false;
        private bool _isYellow = false;
        private bool _isRed = false;

        private const byte BLINKSPEED = 15;
        private const byte TIMEOUT = 0;
        private const byte REPEAT = Byte.MaxValue;

        // luxafor device
        private IDevice _device;

        public Form1()
        {
            
            InitializeComponent();
            ConnectLuxafor();

            t = new System.Threading.Thread(RefreshRunner);
            t.IsBackground = true;
            t.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button_automatic_Click(null, null);
        }

        public bool isAutomatic()
        {
            return _isAutomatic;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            

            bool cursorNotInTaskbar = Screen.GetWorkingArea(this).Contains(Cursor.Position);

            if (this.WindowState == FormWindowState.Minimized && cursorNotInTaskbar)
            {

                notifyIcon1.Visible = true;

                this.Hide();
            }

                
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
                notifyIcon1.BalloonTipTitle = "Activitylight";
                notifyIcon1.BalloonTipText = "Activitylight is running in system tray";
                notifyIcon1.ShowBalloonTip(2000);
                this.Hide();
            }
        }

        public void RefreshRunner()
        {
            while (true)
            {
                if (isAutomatic())
                {
                    Console.WriteLine("Info: Refreshing status from Skype/Exchange");
                    //GetExchangeStatus();
                    GetLyncStatus();
                }

                Thread.Sleep(5000);
            }
        }

        private bool ConnectLuxafor()
        {
            try
            {
                IDeviceList list = new DeviceList();
                list.Scan();
                _device = list.First();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message.ToString());
                setStatusText("Error: Can't find Luxafor device.");
                return false;
            }

            ToggleAutomatic();
            return true;
        }

        private bool ToggleAutomatic()
        {
            try
            {
                _isAutomatic = true;
                _isRed = _isYellow = _isGreen = false;
                GetLyncStatus();
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message.ToString());
                setStatusText("Error: " + e.Message.ToString());
                return _isAutomatic;
            }
            return _isAutomatic;
        }

        private bool PushGreen()
        {
            try
            {
                _isGreen = true;
                _isRed = _isYellow = _isAutomatic = false;
                setColor("green");
                setStatusText("GREEN is chosen.");
                // Immediatly switches all leds to green
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message.ToString());
                setStatusText("Error: " + e.Message.ToString());
                return _isGreen;
            }
            return _isGreen;
        }

        private void setColor(string color, bool blink = false)
        {

            try
            {
                bool set = false;
                switch (color)
                {
                    case "red":
                        if (blink)
                        {
                            _device.Blink(LedTarget.All, new LuxaforSharp.Color(255, 0, 0), BLINKSPEED, REPEAT,
                                TIMEOUT);
                            
                            break;

                        }
                        _device.SetColor(LedTarget.All, new LuxaforSharp.Color(255, 0, 0));
                        break;
                    case "green":
                        if (blink)
                        {
                            _device.Blink(LedTarget.All, new LuxaforSharp.Color(0, 255, 0), BLINKSPEED, REPEAT,
                                TIMEOUT);
                            break;

                        }
                        _device.SetColor(LedTarget.All, new LuxaforSharp.Color(0, 255, 0));
                        break;
                    case "yellow":
                        if (blink)
                        {
                            _device.Blink(LedTarget.All, new LuxaforSharp.Color(255, 215, 0), BLINKSPEED, REPEAT,
                                TIMEOUT);
                            break;

                        }
                        _device.SetColor(LedTarget.All, new LuxaforSharp.Color(255, 215, 0));
                        break;
                    
                }
                
            }
            catch (Exception e)
            {

                throw new Exception("Can't set color on Luxafor device...");
            }
        }

        private bool PushYellow()
        {
            try
            {
                _isYellow = true;
                _isRed = _isGreen = _isAutomatic = false;
                setColor("yellow");
                setStatusText("YELLOW is chosen");
                // Immediatly switches all leds to yellow
                

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message.ToString());
                setStatusText("Error: " + e.Message.ToString());
                return _isYellow;
            }

            return _isYellow;
        }

        private bool PushRed()
        {
            try
            {
                _isRed = true;
                _isGreen = _isYellow = _isAutomatic = false;
                setColor("red");
                setStatusText("RED is chosen");
                // Immediatly switches all leds to red
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message.ToString());
                setStatusText("Error: " + e.Message.ToString());
                return _isRed;
            }
            return _isRed;
        }



        private void button_green_Click(object sender, EventArgs e)
        {
            availableToolStripMenuItem.Checked = true;
            awayToolStripMenuItem.Checked = false;
            buzyToolStripMenuItem.Checked = false;
            automaticToolStripMenuItem.Checked = false;

            PushGreen();
            SetLyncStatus("green");
            MarkLastClickedButton(button_green);
            
        }

        private void button_yellow_Click(object sender, EventArgs e)
        {
            availableToolStripMenuItem.Checked = false;
            awayToolStripMenuItem.Checked = true;
            buzyToolStripMenuItem.Checked = false;
            automaticToolStripMenuItem.Checked = false;

            PushYellow();
            SetLyncStatus("yellow");
            MarkLastClickedButton(button_yellow);
            
        }

        private void button_red_Click(object sender, EventArgs e)
        {
            availableToolStripMenuItem.Checked = false;
            awayToolStripMenuItem.Checked = false;
            buzyToolStripMenuItem.Checked = true;
            automaticToolStripMenuItem.Checked = false;

            PushRed();
            SetLyncStatus("red");
            MarkLastClickedButton(button_red);

        }

        private void button_automatic_Click(object sender, EventArgs e)
        {
            availableToolStripMenuItem.Checked = false;
            awayToolStripMenuItem.Checked = false;
            buzyToolStripMenuItem.Checked = false;
            automaticToolStripMenuItem.Checked = true;

            ToggleAutomatic();
            //GetExchangeStatus();
            GetLyncStatus();
            MarkLastClickedButton(button_automatic);
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            UserLogin testDialog = new UserLogin();
            testDialog.ShowDialog();

            testDialog.Dispose();
        }


        /// <summary>
        /// Get exchange status
        /// </summary>
        void GetExchangeStatus()
        {
            try
            {
                if (ReadSetting("username") != null || ReadSetting("username") == "" && ReadSetting("exchangeHost") != null || ReadSetting("exchangeHost") == "")
                {
                    exchangeService = new ExchangeService(ExchangeVersion.Exchange2013);
                    AvailabilityOptions myOptions = new AvailabilityOptions();
                    myOptions.MeetingDuration = 2;
                    myOptions.RequestedFreeBusyView = FreeBusyViewType.FreeBusy;

                    List<AttendeeInfo> attendees = new List<AttendeeInfo>();

                    attendees.Add(new AttendeeInfo()
                    {
                        SmtpAddress = ReadSetting("epost"),
                        AttendeeType = MeetingAttendeeType.Required
                    });

                    // TODO: get url for webservice
                    exchangeService.Url = new Uri(ReadSetting("exchangeHost"));
                    exchangeService.Credentials = new WebCredentials(ReadSetting("username"), StringCipher.Decrypt(ReadSetting("password")));
                    var userStatus = exchangeService.GetUserAvailability(attendees, new TimeWindow(DateTime.Now, DateTime.Now.AddDays(1)),
                                                                             AvailabilityData.FreeBusy,
                                                                             myOptions);

                    var userDetailedStatus = userStatus.AttendeesAvailability.First();

                    // initial green
                    PushGreen();

                    foreach (var calendarItem in userDetailedStatus.CalendarEvents)
                    {
                        Console.WriteLine("User status for: " + ReadSetting("username"));
                        Console.WriteLine("  Free/busy status: " + calendarItem.FreeBusyStatus);
                        Console.WriteLine("  Start time: " + calendarItem.StartTime);
                        Console.WriteLine("  End time: " + calendarItem.EndTime);

                        if (calendarItem.StartTime <= DateTime.Now && DateTime.Now <= calendarItem.EndTime &&
                            calendarItem.FreeBusyStatus == LegacyFreeBusyStatus.Busy)
                        {
                            PushRed();
                        }
                        else if (calendarItem.StartTime <= DateTime.Now && DateTime.Now <= calendarItem.EndTime &&
                            calendarItem.FreeBusyStatus == LegacyFreeBusyStatus.Free)
                        {
                            PushGreen();
                        }
                        else if (calendarItem.StartTime <= DateTime.Now && DateTime.Now <= calendarItem.EndTime &&
                            calendarItem.FreeBusyStatus == LegacyFreeBusyStatus.OOF || calendarItem.FreeBusyStatus == LegacyFreeBusyStatus.Tentative || calendarItem.FreeBusyStatus == LegacyFreeBusyStatus.WorkingElsewhere)
                        {
                            PushYellow();
                        }


                    }

                }
            }
            catch (Exception ex)
            {
                //statusbar.Text = "Error: Problemer med exchange tilkobling...";

                setStatusText("Error: Problems with Exchange connection...");
            }
        }

        private void GetLyncStatus()
        {
            try
            {
                

                lyncClient = LyncClient.GetClient();
                

                var selfStatus = lyncClient.Self.Contact.GetContactInformation(ContactInformationType.Availability);
                var selfStatusId = lyncClient.Self.Contact.GetContactInformation(ContactInformationType.ActivityId);

                if (selfStatusId.ToString() == "in-a-call")
                {
                    setColor("red", true);
                }
                else
                {
                    switch (selfStatus.ToString())
                    {
                        // red, bizzi bee
                        case "6500":
                            setColor("red");
                            //statusbar.Text = "Lync viser opptatt, endret til RØD";
                            setStatusText("Skype shows buzy, RED chosen");
                            break;
                        // red, do not disturb
                        case "9500":
                            setColor("red");
                            //statusbar.Text = "Lync viser opptatt, endret til RØD";

                            setStatusText("Skype shows don't disturb, RED chosen");
                            break;
                        // available
                        case "3500":
                            setColor("green");
                            //statusbar.Text = "Lync viser opptatt, endret til GRØNN";
                            setStatusText("Skype shows available, GREEN chosen");
                            break;
                        // yellow, "away"
                        case "12500":
                            setColor("yellow");
                            //statusbar.Text = "Lync viser borte, endret til GUL";
                            setStatusText("Skype shows away, YELLOW chosen");
                            break;
                        case "15500":
                            setColor("yellow");
                            //statusbar.Text = "Lync viser borte, endret til GUL";

                            setStatusText("Skype shows away, YELLOW chosen");
                            break;
                    }
                }
                


            }
            catch (Exception ex)
            {
                setStatusText("Error: Can't find Skype client...");
            }

        }

        private void SetLyncStatus(string status)
        {
            
            try
            {
                if (!Convert.ToBoolean(ReadSetting("mirrorToLync")))
                {
                    return;
                }

                lyncClient = LyncClient.GetClient();
                var availability = new ContactAvailability();

                switch (status)
                {
                    case "green":
                        availability = ContactAvailability.Free;
                        break;
                    case "yellow":
                        availability = ContactAvailability.Away;
                        break;
                    case "red":
                        availability = ContactAvailability.Busy;
                        break;
                    default:
                        availability = ContactAvailability.Free;
                        break;
                }
                if (lyncClient.State == ClientState.SignedIn)
                {
                    Dictionary<PublishableContactInformationType, object> st = new Dictionary<PublishableContactInformationType, object>();
                    st.Add(PublishableContactInformationType.Availability, availability);
                    lyncClient.Self.BeginPublishContactInformation(st, null, null);
                }
            }
            catch (Exception exception)
            {
                setStatusText("Error: " + "Can't set Skype status, client not found...");

            }
        }

        static string ReadSetting(string key)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                string result = appSettings[key] ?? "Not Found";

                Console.WriteLine(result);
                return result;
            }
            catch (ConfigurationErrorsException e)
            {
                return null;
                Console.WriteLine("Error: Error reading app settings, " + e.Message);
            }
        }

        static bool AddUpdateAppSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
                return true;
            }
            catch (ConfigurationErrorsException e)
            {

                Console.WriteLine("Error: Error writing app settings, " + e.Message);
                return false;
            }
        }

        private void MarkLastClickedButton(Button btn)
        {
            ResetClickedButtons();

            btn.BackColor = Color.LightGray;


        }

        private void ResetClickedButtons()
        {
            button_green.BackColor = Color.Transparent;
            button_yellow.BackColor = Color.Transparent;
            button_red.BackColor = Color.Transparent;
            button_automatic.BackColor = Color.Transparent;
        }

        private void setStatusText(string text)
        {
            statusBarText.Text = text;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void availableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_green_Click(sender, e);

        }

        private void awayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_yellow_Click(sender, e);

        }

        private void buzyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_red_Click(sender, e);
            
        }

        private void automaticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_automatic_Click(sender, e);
            
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.notifyIconMenu.Close();
            showAppMenuItem_Click(sender, e);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            _device.Dispose();
            Application.Exit();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutDialog = new AboutBox1();
            aboutDialog.ShowDialog();

            aboutDialog.Dispose();
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            notifyIconMenu.Show(Cursor.Position);
        }

        private void showAppMenuItem_Click(object sender, EventArgs e)
        {
            
            this.ShowInTaskbar = true;
            notifyIcon1.Visible = false;
            this.WindowState = FormWindowState.Normal;
            this.Visible = true;
            this.Show();

        }
    }


}
