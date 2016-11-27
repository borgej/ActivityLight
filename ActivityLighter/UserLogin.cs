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

namespace ActivityLighter
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
            
            this.username.Text = ReadSetting("username");
            this.password.Text = ReadSetting("epost");
            this.password.Text = ReadSetting("password");
            this.exchangeHost.Text = ReadSetting("exchangeHost");

            if (Convert.ToBoolean(ReadSetting("mirrorToLync")))
            {
                this.mirrorToLync.Checked = true;
            }
            else
            {
                this.mirrorToLync.Checked = false;
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
                return "Inget "+ key+" satt";
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

        private void lagreBtn_Click(object sender, EventArgs e)
        {
            try
            {
                AddUpdateAppSettings("username", this.username.Text);
                AddUpdateAppSettings("epost", this.epost.Text);
                AddUpdateAppSettings("password", this.password.Text);
                AddUpdateAppSettings("exchangeHost", this.exchangeHost.Text);

                if (this.mirrorToLync.Checked)
                {
                    AddUpdateAppSettings("mirrorToLync", "true");
                }
                else
                {
                    AddUpdateAppSettings("mirrorToLync", "false");
                }

            }
            catch (Exception d)
	        {
                Console.WriteLine("Error: Error writing app settings, " + d.Message);
            }
            this.Dispose();
        }


        private void SelectAllPasswordOnFocus(object sender, EventArgs e)
        {
            this.password.SelectAll();
        }

        private void input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                lagreBtn_Click(null, null);
            }
        }


    }
}
