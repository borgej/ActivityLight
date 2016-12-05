using System.Drawing;
using System.Windows.Forms;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusBarText = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.availableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.awayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buzyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automaticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_green = new System.Windows.Forms.Button();
            this.button_yellow = new System.Windows.Forms.Button();
            this.button_red = new System.Windows.Forms.Button();
            this.button_automatic = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.loginButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.showAppMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.notifyIconMenu.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            // 
            // statusBarText
            // 
            this.statusBarText.Name = "statusBarText";
            resources.ApplyResources(this.statusBarText, "statusBarText");
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarText});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.notifyIconMenu;
            resources.ApplyResources(this.notifyIcon1, "notifyIcon1");
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // notifyIconMenu
            // 
            this.notifyIconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAppMenuItem,
            this.availableToolStripMenuItem,
            this.awayToolStripMenuItem,
            this.buzyToolStripMenuItem,
            this.automaticToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.notifyIconMenu.Name = "contextMenuStrip1";
            resources.ApplyResources(this.notifyIconMenu, "notifyIconMenu");
            // 
            // availableToolStripMenuItem
            // 
            this.availableToolStripMenuItem.Name = "availableToolStripMenuItem";
            resources.ApplyResources(this.availableToolStripMenuItem, "availableToolStripMenuItem");
            this.availableToolStripMenuItem.Click += new System.EventHandler(this.availableToolStripMenuItem_Click);
            // 
            // awayToolStripMenuItem
            // 
            this.awayToolStripMenuItem.Name = "awayToolStripMenuItem";
            resources.ApplyResources(this.awayToolStripMenuItem, "awayToolStripMenuItem");
            this.awayToolStripMenuItem.Click += new System.EventHandler(this.awayToolStripMenuItem_Click);
            // 
            // buzyToolStripMenuItem
            // 
            this.buzyToolStripMenuItem.Name = "buzyToolStripMenuItem";
            resources.ApplyResources(this.buzyToolStripMenuItem, "buzyToolStripMenuItem");
            this.buzyToolStripMenuItem.Click += new System.EventHandler(this.buzyToolStripMenuItem_Click);
            // 
            // automaticToolStripMenuItem
            // 
            this.automaticToolStripMenuItem.Name = "automaticToolStripMenuItem";
            resources.ApplyResources(this.automaticToolStripMenuItem, "automaticToolStripMenuItem");
            this.automaticToolStripMenuItem.Click += new System.EventHandler(this.automaticToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button_green);
            this.flowLayoutPanel1.Controls.Add(this.button_yellow);
            this.flowLayoutPanel1.Controls.Add(this.button_red);
            this.flowLayoutPanel1.Controls.Add(this.button_automatic);
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // button_green
            // 
            this.button_green.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_green.BackColor = System.Drawing.Color.Transparent;
            this.button_green.BackgroundImage = global::ActivityLighter.Properties.Resources.greenButton;
            resources.ApplyResources(this.button_green, "button_green");
            this.button_green.FlatAppearance.BorderSize = 0;
            this.button_green.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button_green.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_green.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button_green.Name = "button_green";
            this.button_green.UseVisualStyleBackColor = false;
            this.button_green.Click += new System.EventHandler(this.button_green_Click);
            // 
            // button_yellow
            // 
            this.button_yellow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_yellow.BackColor = System.Drawing.Color.Transparent;
            this.button_yellow.BackgroundImage = global::ActivityLighter.Properties.Resources.yellowButton;
            resources.ApplyResources(this.button_yellow, "button_yellow");
            this.button_yellow.FlatAppearance.BorderSize = 0;
            this.button_yellow.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button_yellow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_yellow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button_yellow.Name = "button_yellow";
            this.button_yellow.UseVisualStyleBackColor = false;
            this.button_yellow.Click += new System.EventHandler(this.button_yellow_Click);
            // 
            // button_red
            // 
            this.button_red.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_red.BackColor = System.Drawing.Color.Transparent;
            this.button_red.BackgroundImage = global::ActivityLighter.Properties.Resources.redButton;
            resources.ApplyResources(this.button_red, "button_red");
            this.button_red.FlatAppearance.BorderSize = 0;
            this.button_red.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button_red.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_red.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button_red.Name = "button_red";
            this.button_red.UseVisualStyleBackColor = false;
            this.button_red.Click += new System.EventHandler(this.button_red_Click);
            // 
            // button_automatic
            // 
            this.button_automatic.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_automatic.BackColor = System.Drawing.Color.Transparent;
            this.button_automatic.BackgroundImage = global::ActivityLighter.Properties.Resources.automaticButton;
            resources.ApplyResources(this.button_automatic, "button_automatic");
            this.button_automatic.FlatAppearance.BorderSize = 0;
            this.button_automatic.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button_automatic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_automatic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button_automatic.Name = "button_automatic";
            this.button_automatic.UseVisualStyleBackColor = false;
            this.button_automatic.Click += new System.EventHandler(this.button_automatic_Click);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.loginButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.exitButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.aboutButton, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // loginButton
            // 
            this.loginButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.loginButton, "loginButton");
            this.loginButton.BackgroundImage = global::ActivityLighter.Properties.Resources.gear;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.Name = "loginButton";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.exitButton, "exitButton");
            this.exitButton.BackgroundImage = global::ActivityLighter.Properties.Resources.exit;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.Name = "exitButton";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            resources.ApplyResources(this.aboutButton, "aboutButton");
            this.aboutButton.BackgroundImage = global::ActivityLighter.Properties.Resources.about;
            this.aboutButton.FlatAppearance.BorderSize = 0;
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // showAppMenuItem
            // 
            this.showAppMenuItem.Name = "showAppMenuItem";
            resources.ApplyResources(this.showAppMenuItem, "showAppMenuItem");
            this.showAppMenuItem.Click += new System.EventHandler(this.showAppMenuItem_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.notifyIconMenu.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_green;
        private System.Windows.Forms.Button button_yellow;
        private System.Windows.Forms.Button button_red;
        private System.Windows.Forms.Button button_automatic;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.ToolStripStatusLabel statusBarText;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip notifyIconMenu;
        private System.Windows.Forms.ToolStripMenuItem availableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem awayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buzyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem automaticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ToolStripMenuItem showAppMenuItem;
    }
}

