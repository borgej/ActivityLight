using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LuxaforSharp;

using Microsoft.Exchange.WebServices.Data;

namespace ActivityLighter
{
    public partial class Form1 : Form
    {
        private ExchangeService exchangeService;
        
        private bool _isAutomatic = false;
        private bool _isGreen = false;
        private bool _isYellow = false;
        private bool _isRed = false;

        // luxafor device
        private IDevice _device;

        public Form1()
        {
            ConnectLuxafor();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
                return false;
            }

            return true;
        }

        private bool ToggleAutomatic()
        {
            try
            {
                //_device.SetColor(LedTarget.All, new LuxaforSharp.Color(0, 0, 255));
                // Immediatly switches all leds to green
                _isAutomatic = true;
                _isRed = _isYellow = _isGreen = false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message.ToString());
                return _isAutomatic;
            }
            return _isAutomatic;
        }

        private bool PushGreen()
        {
            try
            {
                _device.SetColor(LedTarget.All, new LuxaforSharp.Color(0, 0, 255));
                    // Immediatly switches all leds to green
                _isGreen = true;
                _isRed = _isYellow = _isAutomatic = false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message.ToString());
                return _isGreen;
            }
            return _isGreen;
        }

        private bool PushYellow()
        {
            try
            {
                _device.SetColor(LedTarget.All, new LuxaforSharp.Color(255, 255, 0));
                    // Immediatly switches all leds to yellow
                _isYellow = true;
                _isRed = _isGreen = _isAutomatic = false;

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message.ToString());
                return _isYellow;
            }

            return _isYellow;
        }

        private bool PushRed()
        {
            try
            {
                _device.SetColor(LedTarget.All, new LuxaforSharp.Color(255, 0, 0));
                    // Immediatly switches all leds to red
                _isRed = true;
                _isGreen = _isYellow = _isAutomatic = false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message.ToString());
                return _isRed;
            }
            return _isRed;
        }



        private void button_green_Click(object sender, EventArgs e)
        {
            PushGreen();
        }

        private void button_yellow_Click(object sender, EventArgs e)
        {
            PushYellow();
        }

        private void button_red_Click(object sender, EventArgs e)
        {
            PushRed();
        }

        private void button_automatic_Click(object sender, EventArgs e)
        {
            ToggleAutomatic();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            ToggleAutomatic();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            UserLogin testDialog = new UserLogin();
            testDialog.ShowDialog();
            //// Show testDialog as a modal dialog and determine if DialogResult = OK.
            //if (testDialog.ShowDialog(this) == DialogResult.OK)
            //{

            //}
            //else
            //{

            //}
            testDialog.Dispose();
        }


        //private void ImportStatusForm_Resize(object sender, EventArgs e)
        //{
        //    if (this.WindowState == FormWindowState.Minimized)
        //    {
        //        .Visible = true;
        //        notifyIcon.ShowBalloonTip(3000);
        //        this.ShowInTaskbar = false;
        //    }
        //}

        //private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        //{
        //    this.WindowState = FormWindowState.Normal;
        //    this.ShowInTaskbar = true;
        //    notifyIcon.Visible = false;
        //}

        void RefreshExchangeStatus()
        {
            if (ReadSetting("username") != null)
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
                exchangeService.Url = new Uri("your asmx url");
                exchangeService.Credentials = new WebCredentials(ReadSetting("username"), ReadSetting("password"));
                var userStatus = exchangeService.GetUserAvailability(attendees,new TimeWindow(DateTime.Now, DateTime.Now.AddDays(1)),
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

        private void RefreshLyncStatus()
        {
            
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
    }


}
