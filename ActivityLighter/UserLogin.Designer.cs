namespace ActivityLighter
{
    partial class UserLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogin));
            this.username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lagreBtn = new System.Windows.Forms.Button();
            this.verifiserBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.MaskedTextBox();
            this.epost = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.exchangeHost = new System.Windows.Forms.TextBox();
            this.mirrorToLync = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username.Location = new System.Drawing.Point(3, 16);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(159, 20);
            this.username.TabIndex = 0;
            this.username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_KeyDown);
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // lagreBtn
            // 
            this.lagreBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lagreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lagreBtn.Location = new System.Drawing.Point(84, 182);
            this.lagreBtn.Name = "lagreBtn";
            this.lagreBtn.Size = new System.Drawing.Size(75, 23);
            this.lagreBtn.TabIndex = 6;
            this.lagreBtn.Text = "OK";
            this.lagreBtn.UseVisualStyleBackColor = true;
            this.lagreBtn.Click += new System.EventHandler(this.lagreBtn_Click);
            // 
            // verifiserBtn
            // 
            this.verifiserBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.verifiserBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.verifiserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verifiserBtn.Location = new System.Drawing.Point(3, 182);
            this.verifiserBtn.Name = "verifiserBtn";
            this.verifiserBtn.Size = new System.Drawing.Size(75, 23);
            this.verifiserBtn.TabIndex = 5;
            this.verifiserBtn.Text = "Verify";
            this.verifiserBtn.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Passord";
            // 
            // password
            // 
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password.Location = new System.Drawing.Point(3, 94);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(159, 20);
            this.password.TabIndex = 2;
            this.password.Enter += new System.EventHandler(this.SelectAllPasswordOnFocus);
            this.password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_KeyDown);
            // 
            // epost
            // 
            this.epost.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.epost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.epost.Location = new System.Drawing.Point(3, 55);
            this.epost.Name = "epost";
            this.epost.Size = new System.Drawing.Size(159, 20);
            this.epost.TabIndex = 1;
            this.epost.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_KeyDown);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.username);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.epost);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.password);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.exchangeHost);
            this.flowLayoutPanel1.Controls.Add(this.mirrorToLync);
            this.flowLayoutPanel1.Controls.Add(this.verifiserBtn);
            this.flowLayoutPanel1.Controls.Add(this.lagreBtn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(170, 229);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Exchange Web Service URL";
            // 
            // exchangeHost
            // 
            this.exchangeHost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.exchangeHost.Location = new System.Drawing.Point(3, 133);
            this.exchangeHost.Name = "exchangeHost";
            this.exchangeHost.Size = new System.Drawing.Size(159, 20);
            this.exchangeHost.TabIndex = 3;
            this.exchangeHost.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_KeyDown);
            // 
            // mirrorToLync
            // 
            this.mirrorToLync.AutoSize = true;
            this.mirrorToLync.Location = new System.Drawing.Point(3, 159);
            this.mirrorToLync.Name = "mirrorToLync";
            this.mirrorToLync.Size = new System.Drawing.Size(127, 17);
            this.mirrorToLync.TabIndex = 4;
            this.mirrorToLync.Text = "Mirror status to Lync?";
            this.mirrorToLync.UseVisualStyleBackColor = true;
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 249);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserLogin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.UserLogin_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button verifiserBtn;
        private System.Windows.Forms.Button lagreBtn;
        private System.Windows.Forms.MaskedTextBox password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox epost;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox exchangeHost;
        private System.Windows.Forms.CheckBox mirrorToLync;
    }
}