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
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.statusbar = new System.Windows.Forms.StatusStrip();
            this.button_automatic = new System.Windows.Forms.Button();
            this.button_red = new System.Windows.Forms.Button();
            this.button_yellow = new System.Windows.Forms.Button();
            this.button_green = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.tableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayout
            // 
            this.tableLayout.ColumnCount = 1;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayout.Controls.Add(this.button_automatic, 0, 4);
            this.tableLayout.Controls.Add(this.button_red, 0, 3);
            this.tableLayout.Controls.Add(this.button_yellow, 0, 2);
            this.tableLayout.Controls.Add(this.button_green, 0, 1);
            this.tableLayout.Controls.Add(this.loginButton, 0, 0);
            this.tableLayout.Location = new System.Drawing.Point(0, 0);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 4;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 211F));
            this.tableLayout.Size = new System.Drawing.Size(267, 382);
            this.tableLayout.TabIndex = 3;
            // 
            // statusbar
            // 
            this.statusbar.Location = new System.Drawing.Point(0, 391);
            this.statusbar.Name = "statusbar";
            this.statusbar.ShowItemToolTips = true;
            this.statusbar.Size = new System.Drawing.Size(270, 22);
            this.statusbar.TabIndex = 2;
            // 
            // button_automatic
            // 
            this.button_automatic.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_automatic.BackgroundImage = global::ActivityLighter.Properties.Resources.automaticButton;
            this.button_automatic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_automatic.FlatAppearance.BorderSize = 0;
            this.button_automatic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_automatic.Location = new System.Drawing.Point(3, 262);
            this.button_automatic.Name = "button_automatic";
            this.button_automatic.Size = new System.Drawing.Size(258, 112);
            this.button_automatic.TabIndex = 3;
            this.button_automatic.UseVisualStyleBackColor = true;
            this.button_automatic.Click += new System.EventHandler(this.button_automatic_Click);
            // 
            // button_red
            // 
            this.button_red.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_red.BackColor = System.Drawing.Color.Red;
            this.button_red.BackgroundImage = global::ActivityLighter.Properties.Resources.redButton;
            this.button_red.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_red.FlatAppearance.BorderSize = 0;
            this.button_red.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_red.Location = new System.Drawing.Point(3, 182);
            this.button_red.Name = "button_red";
            this.button_red.Size = new System.Drawing.Size(258, 74);
            this.button_red.TabIndex = 2;
            this.button_red.UseVisualStyleBackColor = false;
            this.button_red.Click += new System.EventHandler(this.button_red_Click);
            // 
            // button_yellow
            // 
            this.button_yellow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_yellow.BackColor = System.Drawing.Color.Yellow;
            this.button_yellow.BackgroundImage = global::ActivityLighter.Properties.Resources.yellowButton;
            this.button_yellow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_yellow.FlatAppearance.BorderSize = 0;
            this.button_yellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_yellow.Location = new System.Drawing.Point(3, 113);
            this.button_yellow.Name = "button_yellow";
            this.button_yellow.Size = new System.Drawing.Size(258, 63);
            this.button_yellow.TabIndex = 1;
            this.button_yellow.UseVisualStyleBackColor = false;
            this.button_yellow.Click += new System.EventHandler(this.button_yellow_Click);
            // 
            // button_green
            // 
            this.button_green.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_green.BackColor = System.Drawing.Color.Lime;
            this.button_green.BackgroundImage = global::ActivityLighter.Properties.Resources.greenButton;
            this.button_green.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_green.FlatAppearance.BorderSize = 0;
            this.button_green.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_green.Location = new System.Drawing.Point(3, 41);
            this.button_green.Name = "button_green";
            this.button_green.Size = new System.Drawing.Size(258, 63);
            this.button_green.TabIndex = 0;
            this.button_green.UseVisualStyleBackColor = false;
            this.button_green.Click += new System.EventHandler(this.button_green_Click);
            // 
            // loginButton
            // 
            this.loginButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.loginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loginButton.BackgroundImage = global::ActivityLighter.Properties.Resources.gear;
            this.loginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Location = new System.Drawing.Point(236, 3);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(28, 28);
            this.loginButton.TabIndex = 0;
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 413);
            this.Controls.Add(this.statusbar);
            this.Controls.Add(this.tableLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayout.ResumeLayout(false);
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
    }
}

