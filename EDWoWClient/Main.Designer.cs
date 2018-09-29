namespace EDWoWClient
{
    partial class mainForm
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
            this.MainTheme = new GGenTheme();
            this.lblconnection = new System.Windows.Forms.Label();
            this.closeBtn = new GButton();
            this.minBtn = new GButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.btnConnect = new GButton();
            this.btnLogout = new GButton();
            this.btnTickets = new GButton();
            this.MainTheme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTheme
            // 
            this.MainTheme.Controls.Add(this.lblconnection);
            this.MainTheme.Controls.Add(this.closeBtn);
            this.MainTheme.Controls.Add(this.minBtn);
            this.MainTheme.Controls.Add(this.pictureBox1);
            this.MainTheme.Controls.Add(this.textBoxPassword);
            this.MainTheme.Controls.Add(this.textBoxUsername);
            this.MainTheme.Controls.Add(this.btnConnect);
            this.MainTheme.Controls.Add(this.btnLogout);
            this.MainTheme.Controls.Add(this.btnTickets);
            this.MainTheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTheme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.MainTheme.Image = null;
            this.MainTheme.Location = new System.Drawing.Point(0, 0);
            this.MainTheme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MainTheme.MoveHeight = 28;
            this.MainTheme.Name = "MainTheme";
            this.MainTheme.Resizable = true;
            this.MainTheme.Size = new System.Drawing.Size(392, 373);
            this.MainTheme.TabIndex = 4;
            this.MainTheme.Text = "EDWoW Client";
            // 
            // lblconnection
            // 
            this.lblconnection.AutoSize = true;
            this.lblconnection.BackColor = System.Drawing.Color.Transparent;
            this.lblconnection.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblconnection.Location = new System.Drawing.Point(144, 297);
            this.lblconnection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblconnection.Name = "lblconnection";
            this.lblconnection.Size = new System.Drawing.Size(94, 17);
            this.lblconnection.TabIndex = 12;
            this.lblconnection.Text = "Disconnected";
            this.lblconnection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.closeBtn.Image = null;
            this.closeBtn.Location = new System.Drawing.Point(355, 5);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(32, 28);
            this.closeBtn.TabIndex = 8;
            this.closeBtn.Text = "x";
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            this.closeBtn.MouseEnter += new System.EventHandler(this.closeBtn_MouseEnter);
            this.closeBtn.MouseLeave += new System.EventHandler(this.closeBtn_MouseLeave);
            // 
            // minBtn
            // 
            this.minBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.minBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.minBtn.Image = null;
            this.minBtn.Location = new System.Drawing.Point(324, 5);
            this.minBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.minBtn.Name = "minBtn";
            this.minBtn.Size = new System.Drawing.Size(32, 28);
            this.minBtn.TabIndex = 7;
            this.minBtn.Text = "-";
            this.minBtn.Click += new System.EventHandler(this.minBtn_Click);
            this.minBtn.MouseEnter += new System.EventHandler(this.minBtn_MouseEnter);
            this.minBtn.MouseLeave += new System.EventHandler(this.minBtn_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::EDWoWClient.Properties.Resources.World_of_Warcraft;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(115, 42);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 126);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxPassword.Location = new System.Drawing.Point(124, 214);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(132, 22);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.Text = "Password";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxUsername.Location = new System.Drawing.Point(124, 182);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(132, 22);
            this.textBoxUsername.TabIndex = 1;
            this.textBoxUsername.Text = "Username";
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnConnect.Image = null;
            this.btnConnect.Location = new System.Drawing.Point(123, 254);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(133, 28);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            this.btnConnect.MouseEnter += new System.EventHandler(this.btnConnect_MouseEnter);
            this.btnConnect.MouseLeave += new System.EventHandler(this.btnConnect_MouseLeave);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnLogout.Image = null;
            this.btnLogout.Location = new System.Drawing.Point(124, 254);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(133, 28);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            this.btnLogout.MouseEnter += new System.EventHandler(this.btnLogout_MouseEnter);
            this.btnLogout.MouseLeave += new System.EventHandler(this.btnLogout_MouseLeave);
            // 
            // btnTickets
            // 
            this.btnTickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnTickets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTickets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnTickets.Image = null;
            this.btnTickets.Location = new System.Drawing.Point(124, 218);
            this.btnTickets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTickets.Name = "btnTickets";
            this.btnTickets.Size = new System.Drawing.Size(133, 28);
            this.btnTickets.TabIndex = 9;
            this.btnTickets.Text = "Tickets";
            this.btnTickets.Click += new System.EventHandler(this.btnTickets_Click);
            this.btnTickets.MouseEnter += new System.EventHandler(this.btnTickets_MouseEnter);
            this.btnTickets.MouseLeave += new System.EventHandler(this.btnTickets_MouseLeave);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 373);
            this.Controls.Add(this.MainTheme);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EDWoWClient";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.MainTheme.ResumeLayout(false);
            this.MainTheme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private GGenTheme MainTheme;
        private GButton btnConnect;
        private System.Windows.Forms.PictureBox pictureBox1;
        private GButton closeBtn;
        private GButton minBtn;
        private GButton btnTickets;
        private GButton btnLogout;
        private System.Windows.Forms.Label lblconnection;
    }
}

