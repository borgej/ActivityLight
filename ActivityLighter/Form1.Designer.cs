using System.Drawing;

namespace ActivityLighter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.button_green = new System.Windows.Forms.Button();
            this.button_yellow = new System.Windows.Forms.Button();
            this.button_red = new System.Windows.Forms.Button();
            this.button_automatic = new System.Windows.Forms.Button();
            this.statusbar = new System.Windows.Forms.StatusStrip();
            this.settingsButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.tableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayout
            // 
            resources.ApplyResources(this.tableLayout, "tableLayout");
            this.tableLayout.Controls.Add(this.button_green, 0, 0);
            this.tableLayout.Controls.Add(this.button_yellow, 0, 1);
            this.tableLayout.Controls.Add(this.button_red, 0, 2);
            this.tableLayout.Controls.Add(this.button_automatic, 0, 4);
            this.tableLayout.Name = "tableLayout";
            // 
            // button_green
            // 
            this.button_green.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.button_green, "button_green");
            this.button_green.BackColor = System.Drawing.Color.Lime;
            this.button_green.BackgroundImage = global::ActivityLighter.Properties.Resources.greenButton;
            this.button_green.FlatAppearance.BorderSize = 0;
            this.button_green.Name = "button_green";
            this.button_green.UseVisualStyleBackColor = false;
            this.button_green.Click += new System.EventHandler(this.button_green_Click);
            // 
            // button_yellow
            // 
            this.button_yellow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.button_yellow, "button_yellow");
            this.button_yellow.BackColor = System.Drawing.Color.Yellow;
            this.button_yellow.BackgroundImage = global::ActivityLighter.Properties.Resources.yellowButton;
            this.button_yellow.FlatAppearance.BorderSize = 0;
            this.button_yellow.Name = "button_yellow";
            this.button_yellow.UseVisualStyleBackColor = false;
            this.button_yellow.Click += new System.EventHandler(this.button_yellow_Click);
            // 
            // button_red
            // 
            this.button_red.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.button_red, "button_red");
            this.button_red.BackColor = System.Drawing.Color.Red;
            this.button_red.BackgroundImage = global::ActivityLighter.Properties.Resources.redButton;
            this.button_red.FlatAppearance.BorderSize = 0;
            this.button_red.Name = "button_red";
            this.button_red.UseVisualStyleBackColor = false;
            this.button_red.Click += new System.EventHandler(this.button_red_Click);
            // 
            // button_automatic
            // 
            this.button_automatic.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_automatic.BackgroundImage = global::ActivityLighter.Properties.Resources.automaticButton;
            resources.ApplyResources(this.button_automatic, "button_automatic");
            this.button_automatic.FlatAppearance.BorderSize = 0;
            this.button_automatic.Name = "button_automatic";
            this.button_automatic.UseVisualStyleBackColor = true;
            this.button_automatic.Click += new System.EventHandler(this.button_automatic_Click);
            // 
            // statusbar
            // 
            resources.ApplyResources(this.statusbar, "statusbar");
            this.statusbar.Name = "statusbar";
            this.statusbar.ShowItemToolTips = true;
            // 
            // settingsButton
            // 
            this.settingsButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.settingsButton.BackgroundImage = global::ActivityLighter.Properties.Resources.gear;
            resources.ApplyResources(this.settingsButton, "settingsButton");
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.loginButton.BackgroundImage = global::ActivityLighter.Properties.Resources.user;
            resources.ApplyResources(this.loginButton, "loginButton");
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.Name = "loginButton";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.statusbar);
            this.Controls.Add(this.tableLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayout.ResumeLayout(false);
            this.tableLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.StatusStrip statusbar;
        private System.Windows.Forms.Button button_green;
        private System.Windows.Forms.Button button_yellow;
        private System.Windows.Forms.Button button_red;
        private System.Windows.Forms.Button button_automatic;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button settingsButton;
    }
}

