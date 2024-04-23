namespace WindowsFormsApp1
{
    partial class FormDN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDN));
            this.panel_title = new Guna.UI2.WinForms.Guna2Panel();
            this.panel_background = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_DN = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.picbox_exit = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picbox_maximize = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picbox_minimize = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel_login = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_login = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.pic_user = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pic_pass = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btn_Login = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lbl_forgetpass = new System.Windows.Forms.LinkLabel();
            this.lbl_About = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel_title.SuspendLayout();
            this.panel_background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_minimize)).BeginInit();
            this.panel_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pass)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_title
            // 
            this.panel_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(26)))), ((int)(((byte)(166)))));
            this.panel_title.Controls.Add(this.picbox_minimize);
            this.panel_title.Controls.Add(this.picbox_maximize);
            this.panel_title.Controls.Add(this.picbox_exit);
            this.panel_title.Controls.Add(this.lbl_DN);
            this.panel_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_title.Location = new System.Drawing.Point(0, 0);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(684, 30);
            this.panel_title.TabIndex = 0;
            this.panel_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_title_MouseDown);
            // 
            // panel_background
            // 
            this.panel_background.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_background.BackgroundImage")));
            this.panel_background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_background.Controls.Add(this.lbl_About);
            this.panel_background.Controls.Add(this.panel_login);
            this.panel_background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_background.Location = new System.Drawing.Point(0, 30);
            this.panel_background.Name = "panel_background";
            this.panel_background.Size = new System.Drawing.Size(684, 420);
            this.panel_background.TabIndex = 1;
            // 
            // lbl_DN
            // 
            this.lbl_DN.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DN.Font = new System.Drawing.Font("Papyrus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DN.ForeColor = System.Drawing.Color.White;
            this.lbl_DN.Location = new System.Drawing.Point(12, 3);
            this.lbl_DN.Name = "lbl_DN";
            this.lbl_DN.Size = new System.Drawing.Size(104, 26);
            this.lbl_DN.TabIndex = 0;
            this.lbl_DN.Text = "My Company";
            // 
            // picbox_exit
            // 
            this.picbox_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picbox_exit.FillColor = System.Drawing.Color.Transparent;
            this.picbox_exit.Image = ((System.Drawing.Image)(resources.GetObject("picbox_exit.Image")));
            this.picbox_exit.ImageRotate = 0F;
            this.picbox_exit.Location = new System.Drawing.Point(649, 3);
            this.picbox_exit.Name = "picbox_exit";
            this.picbox_exit.Size = new System.Drawing.Size(24, 24);
            this.picbox_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picbox_exit.TabIndex = 1;
            this.picbox_exit.TabStop = false;
            this.picbox_exit.Click += new System.EventHandler(this.picbox_exit_Click);
            // 
            // picbox_maximize
            // 
            this.picbox_maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picbox_maximize.FillColor = System.Drawing.Color.Transparent;
            this.picbox_maximize.Image = ((System.Drawing.Image)(resources.GetObject("picbox_maximize.Image")));
            this.picbox_maximize.ImageRotate = 0F;
            this.picbox_maximize.Location = new System.Drawing.Point(620, 3);
            this.picbox_maximize.Name = "picbox_maximize";
            this.picbox_maximize.Size = new System.Drawing.Size(24, 24);
            this.picbox_maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picbox_maximize.TabIndex = 2;
            this.picbox_maximize.TabStop = false;
            this.picbox_maximize.Click += new System.EventHandler(this.picbox_maximize_Click);
            // 
            // picbox_minimize
            // 
            this.picbox_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picbox_minimize.FillColor = System.Drawing.Color.Transparent;
            this.picbox_minimize.Image = ((System.Drawing.Image)(resources.GetObject("picbox_minimize.Image")));
            this.picbox_minimize.ImageRotate = 0F;
            this.picbox_minimize.Location = new System.Drawing.Point(591, 3);
            this.picbox_minimize.Name = "picbox_minimize";
            this.picbox_minimize.Size = new System.Drawing.Size(24, 24);
            this.picbox_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picbox_minimize.TabIndex = 3;
            this.picbox_minimize.TabStop = false;
            this.picbox_minimize.Click += new System.EventHandler(this.picbox_minimize_Click);
            // 
            // panel_login
            // 
            this.panel_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_login.BackColor = System.Drawing.Color.Transparent;
            this.panel_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_login.BackgroundImage")));
            this.panel_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_login.Controls.Add(this.lbl_forgetpass);
            this.panel_login.Controls.Add(this.btn_Login);
            this.panel_login.Controls.Add(this.pic_pass);
            this.panel_login.Controls.Add(this.pic_user);
            this.panel_login.Controls.Add(this.guna2Panel2);
            this.panel_login.Controls.Add(this.guna2Panel1);
            this.panel_login.Controls.Add(this.guna2TextBox1);
            this.panel_login.Controls.Add(this.lbl_login);
            this.panel_login.Controls.Add(this.txt_username);
            this.panel_login.FillColor = System.Drawing.Color.Transparent;
            this.panel_login.ForeColor = System.Drawing.Color.White;
            this.panel_login.Location = new System.Drawing.Point(203, 54);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(301, 318);
            this.panel_login.TabIndex = 0;
            // 
            // lbl_login
            // 
            this.lbl_login.BackColor = System.Drawing.Color.Transparent;
            this.lbl_login.Font = new System.Drawing.Font("Script MT Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.ForeColor = System.Drawing.Color.White;
            this.lbl_login.Location = new System.Drawing.Point(22, 43);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(64, 35);
            this.lbl_login.TabIndex = 0;
            this.lbl_login.Text = "Login";
            // 
            // txt_username
            // 
            this.txt_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.txt_username.BorderThickness = 0;
            this.txt_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_username.DefaultText = "";
            this.txt_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_username.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.txt_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_username.FocusedState.FillColor = System.Drawing.Color.Transparent;
            this.txt_username.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_username.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.txt_username.Location = new System.Drawing.Point(46, 119);
            this.txt_username.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_username.Name = "txt_username";
            this.txt_username.PasswordChar = '\0';
            this.txt_username.PlaceholderText = "User Name";
            this.txt_username.SelectedText = "";
            this.txt_username.Size = new System.Drawing.Size(237, 36);
            this.txt_username.TabIndex = 1;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2TextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.guna2TextBox1.BorderThickness = 0;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.FillColor = System.Drawing.Color.Transparent;
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.guna2TextBox1.Location = new System.Drawing.Point(46, 181);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '*';
            this.guna2TextBox1.PlaceholderText = "Password";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(237, 36);
            this.guna2TextBox1.TabIndex = 2;
            this.guna2TextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.guna2TextBox1_KeyPress);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(46, 154);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(237, 1);
            this.guna2Panel1.TabIndex = 3;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(46, 216);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(237, 1);
            this.guna2Panel2.TabIndex = 4;
            // 
            // pic_user
            // 
            this.pic_user.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic_user.FillColor = System.Drawing.Color.Transparent;
            this.pic_user.Image = ((System.Drawing.Image)(resources.GetObject("pic_user.Image")));
            this.pic_user.ImageRotate = 0F;
            this.pic_user.Location = new System.Drawing.Point(16, 131);
            this.pic_user.Name = "pic_user";
            this.pic_user.Size = new System.Drawing.Size(24, 24);
            this.pic_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_user.TabIndex = 5;
            this.pic_user.TabStop = false;
            // 
            // pic_pass
            // 
            this.pic_pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic_pass.FillColor = System.Drawing.Color.Transparent;
            this.pic_pass.Image = ((System.Drawing.Image)(resources.GetObject("pic_pass.Image")));
            this.pic_pass.ImageRotate = 0F;
            this.pic_pass.Location = new System.Drawing.Point(16, 193);
            this.pic_pass.Name = "pic_pass";
            this.pic_pass.Size = new System.Drawing.Size(24, 24);
            this.pic_pass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_pass.TabIndex = 6;
            this.pic_pass.TabStop = false;
            // 
            // btn_Login
            // 
            this.btn_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Login.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Login.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(56, 261);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(180, 45);
            this.btn_Login.TabIndex = 7;
            this.btn_Login.Text = "Login account";
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lbl_forgetpass
            // 
            this.lbl_forgetpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_forgetpass.AutoSize = true;
            this.lbl_forgetpass.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_forgetpass.LinkColor = System.Drawing.Color.Gainsboro;
            this.lbl_forgetpass.Location = new System.Drawing.Point(212, 232);
            this.lbl_forgetpass.Name = "lbl_forgetpass";
            this.lbl_forgetpass.Size = new System.Drawing.Size(85, 13);
            this.lbl_forgetpass.TabIndex = 8;
            this.lbl_forgetpass.TabStop = true;
            this.lbl_forgetpass.Text = "Quên mật khẩu?";
            this.lbl_forgetpass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_forgetpass_LinkClicked);
            // 
            // lbl_About
            // 
            this.lbl_About.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_About.BackColor = System.Drawing.Color.Transparent;
            this.lbl_About.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_About.Location = new System.Drawing.Point(228, 402);
            this.lbl_About.Name = "lbl_About";
            this.lbl_About.Size = new System.Drawing.Size(228, 15);
            this.lbl_About.TabIndex = 1;
            this.lbl_About.Text = "Phần mềm được phát triển bởi Trần Quốc Hưng";
            // 
            // FormDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.panel_background);
            this.Controls.Add(this.panel_title);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDN";
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.FormDN_Load);
            this.Resize += new System.EventHandler(this.FormDN_Resize);
            this.panel_title.ResumeLayout(false);
            this.panel_title.PerformLayout();
            this.panel_background.ResumeLayout(false);
            this.panel_background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_minimize)).EndInit();
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panel_title;
        private Guna.UI2.WinForms.Guna2Panel panel_background;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_DN;
        private Guna.UI2.WinForms.Guna2PictureBox picbox_minimize;
        private Guna.UI2.WinForms.Guna2PictureBox picbox_maximize;
        private Guna.UI2.WinForms.Guna2PictureBox picbox_exit;
        private Guna.UI2.WinForms.Guna2Panel panel_login;
        private Guna.UI2.WinForms.Guna2TextBox txt_username;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_login;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox pic_pass;
        private Guna.UI2.WinForms.Guna2PictureBox pic_user;
        private System.Windows.Forms.LinkLabel lbl_forgetpass;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Login;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_About;
    }
}

