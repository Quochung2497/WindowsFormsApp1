namespace WindowsFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel_title = new Guna.UI2.WinForms.Guna2Panel();
            this.picbox_minimize = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picbox_maximize = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picbox_exit = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbl_DN = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel_content = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lbl_KQ = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Btn_KQ = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txt_so2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_so1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_So2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_so1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_Title = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_tru = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_nhan = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_chia = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_exit)).BeginInit();
            this.panel_content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
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
            this.panel_title.Size = new System.Drawing.Size(489, 30);
            this.panel_title.TabIndex = 1;
            this.panel_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_title_MouseDown);
            // 
            // picbox_minimize
            // 
            this.picbox_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picbox_minimize.FillColor = System.Drawing.Color.Transparent;
            this.picbox_minimize.Image = ((System.Drawing.Image)(resources.GetObject("picbox_minimize.Image")));
            this.picbox_minimize.ImageRotate = 0F;
            this.picbox_minimize.Location = new System.Drawing.Point(396, 3);
            this.picbox_minimize.Name = "picbox_minimize";
            this.picbox_minimize.Size = new System.Drawing.Size(24, 24);
            this.picbox_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picbox_minimize.TabIndex = 3;
            this.picbox_minimize.TabStop = false;
            this.picbox_minimize.Click += new System.EventHandler(this.picbox_minimize_Click);
            // 
            // picbox_maximize
            // 
            this.picbox_maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picbox_maximize.FillColor = System.Drawing.Color.Transparent;
            this.picbox_maximize.Image = ((System.Drawing.Image)(resources.GetObject("picbox_maximize.Image")));
            this.picbox_maximize.ImageRotate = 0F;
            this.picbox_maximize.Location = new System.Drawing.Point(425, 3);
            this.picbox_maximize.Name = "picbox_maximize";
            this.picbox_maximize.Size = new System.Drawing.Size(24, 24);
            this.picbox_maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picbox_maximize.TabIndex = 2;
            this.picbox_maximize.TabStop = false;
            this.picbox_maximize.Click += new System.EventHandler(this.picbox_maximize_Click);
            // 
            // picbox_exit
            // 
            this.picbox_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picbox_exit.FillColor = System.Drawing.Color.Transparent;
            this.picbox_exit.Image = ((System.Drawing.Image)(resources.GetObject("picbox_exit.Image")));
            this.picbox_exit.ImageRotate = 0F;
            this.picbox_exit.Location = new System.Drawing.Point(454, 3);
            this.picbox_exit.Name = "picbox_exit";
            this.picbox_exit.Size = new System.Drawing.Size(24, 24);
            this.picbox_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picbox_exit.TabIndex = 1;
            this.picbox_exit.TabStop = false;
            this.picbox_exit.Click += new System.EventHandler(this.picbox_exit_Click);
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
            // panel_content
            // 
            this.panel_content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(26)))), ((int)(((byte)(146)))));
            this.panel_content.Controls.Add(this.btn_chia);
            this.panel_content.Controls.Add(this.btn_nhan);
            this.panel_content.Controls.Add(this.btn_tru);
            this.panel_content.Controls.Add(this.guna2CirclePictureBox1);
            this.panel_content.Controls.Add(this.lbl_KQ);
            this.panel_content.Controls.Add(this.Btn_KQ);
            this.panel_content.Controls.Add(this.guna2Panel2);
            this.panel_content.Controls.Add(this.guna2Panel1);
            this.panel_content.Controls.Add(this.txt_so2);
            this.panel_content.Controls.Add(this.txt_so1);
            this.panel_content.Controls.Add(this.lbl_So2);
            this.panel_content.Controls.Add(this.lbl_so1);
            this.panel_content.Controls.Add(this.lbl_Title);
            this.panel_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_content.Location = new System.Drawing.Point(0, 30);
            this.panel_content.Name = "panel_content";
            this.panel_content.Size = new System.Drawing.Size(489, 364);
            this.panel_content.TabIndex = 2;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(450, 6);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(36, 33);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.guna2CirclePictureBox1.TabIndex = 11;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
            // 
            // lbl_KQ
            // 
            this.lbl_KQ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_KQ.BackColor = System.Drawing.Color.Transparent;
            this.lbl_KQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KQ.ForeColor = System.Drawing.Color.White;
            this.lbl_KQ.Location = new System.Drawing.Point(369, 308);
            this.lbl_KQ.Name = "lbl_KQ";
            this.lbl_KQ.Size = new System.Drawing.Size(19, 33);
            this.lbl_KQ.TabIndex = 10;
            this.lbl_KQ.Text = "0";
            // 
            // Btn_KQ
            // 
            this.Btn_KQ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_KQ.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_KQ.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_KQ.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_KQ.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_KQ.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_KQ.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_KQ.ForeColor = System.Drawing.Color.White;
            this.Btn_KQ.Location = new System.Drawing.Point(19, 245);
            this.Btn_KQ.Name = "Btn_KQ";
            this.Btn_KQ.Size = new System.Drawing.Size(88, 45);
            this.Btn_KQ.TabIndex = 9;
            this.Btn_KQ.Text = "Tính phép cộng";
            this.Btn_KQ.Click += new System.EventHandler(this.Btn_KQ_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(151, 217);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(237, 1);
            this.guna2Panel2.TabIndex = 8;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(151, 142);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(237, 1);
            this.guna2Panel1.TabIndex = 7;
            // 
            // txt_so2
            // 
            this.txt_so2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_so2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(26)))), ((int)(((byte)(146)))));
            this.txt_so2.BorderThickness = 0;
            this.txt_so2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_so2.DefaultText = "";
            this.txt_so2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_so2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_so2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_so2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_so2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(26)))), ((int)(((byte)(146)))));
            this.txt_so2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_so2.FocusedState.FillColor = System.Drawing.Color.Transparent;
            this.txt_so2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_so2.ForeColor = System.Drawing.Color.White;
            this.txt_so2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_so2.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.txt_so2.Location = new System.Drawing.Point(151, 182);
            this.txt_so2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_so2.Name = "txt_so2";
            this.txt_so2.PasswordChar = '\0';
            this.txt_so2.PlaceholderText = "";
            this.txt_so2.SelectedText = "";
            this.txt_so2.Size = new System.Drawing.Size(237, 36);
            this.txt_so2.TabIndex = 6;
            this.txt_so2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_so2_KeyPress);
            // 
            // txt_so1
            // 
            this.txt_so1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_so1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(26)))), ((int)(((byte)(146)))));
            this.txt_so1.BorderThickness = 0;
            this.txt_so1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_so1.DefaultText = "";
            this.txt_so1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_so1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_so1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_so1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_so1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(26)))), ((int)(((byte)(146)))));
            this.txt_so1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_so1.FocusedState.FillColor = System.Drawing.Color.Transparent;
            this.txt_so1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_so1.ForeColor = System.Drawing.Color.White;
            this.txt_so1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_so1.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.txt_so1.Location = new System.Drawing.Point(151, 107);
            this.txt_so1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_so1.Name = "txt_so1";
            this.txt_so1.PasswordChar = '\0';
            this.txt_so1.PlaceholderText = "";
            this.txt_so1.SelectedText = "";
            this.txt_so1.Size = new System.Drawing.Size(237, 36);
            this.txt_so1.TabIndex = 5;
            this.txt_so1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_so1_KeyPress);
            // 
            // lbl_So2
            // 
            this.lbl_So2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_So2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_So2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_So2.ForeColor = System.Drawing.Color.White;
            this.lbl_So2.Location = new System.Drawing.Point(111, 158);
            this.lbl_So2.Name = "lbl_So2";
            this.lbl_So2.Size = new System.Drawing.Size(34, 20);
            this.lbl_So2.TabIndex = 2;
            this.lbl_So2.Text = "Số 2";
            // 
            // lbl_so1
            // 
            this.lbl_so1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_so1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_so1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_so1.ForeColor = System.Drawing.Color.White;
            this.lbl_so1.Location = new System.Drawing.Point(111, 89);
            this.lbl_so1.Name = "lbl_so1";
            this.lbl_so1.Size = new System.Drawing.Size(34, 20);
            this.lbl_so1.TabIndex = 1;
            this.lbl_so1.Text = "Số 1";
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("Script MT Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(175, 37);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(129, 40);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Caculator";
            // 
            // btn_tru
            // 
            this.btn_tru.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_tru.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_tru.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_tru.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_tru.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_tru.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_tru.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_tru.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_tru.ForeColor = System.Drawing.Color.White;
            this.btn_tru.Location = new System.Drawing.Point(142, 245);
            this.btn_tru.Name = "btn_tru";
            this.btn_tru.Size = new System.Drawing.Size(88, 45);
            this.btn_tru.TabIndex = 12;
            this.btn_tru.Text = "Tính phép trừ";
            this.btn_tru.Click += new System.EventHandler(this.btn_tru_Click);
            // 
            // btn_nhan
            // 
            this.btn_nhan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_nhan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_nhan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_nhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_nhan.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_nhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_nhan.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_nhan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_nhan.ForeColor = System.Drawing.Color.White;
            this.btn_nhan.Location = new System.Drawing.Point(265, 245);
            this.btn_nhan.Name = "btn_nhan";
            this.btn_nhan.Size = new System.Drawing.Size(88, 45);
            this.btn_nhan.TabIndex = 13;
            this.btn_nhan.Text = "Tính phép nhân";
            this.btn_nhan.Click += new System.EventHandler(this.btn_nhan_Click);
            // 
            // btn_chia
            // 
            this.btn_chia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_chia.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_chia.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_chia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_chia.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_chia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_chia.FillColor2 = System.Drawing.Color.Red;
            this.btn_chia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_chia.ForeColor = System.Drawing.Color.White;
            this.btn_chia.Location = new System.Drawing.Point(388, 245);
            this.btn_chia.Name = "btn_chia";
            this.btn_chia.Size = new System.Drawing.Size(88, 45);
            this.btn_chia.TabIndex = 14;
            this.btn_chia.Text = "Tính phép chia";
            this.btn_chia.Click += new System.EventHandler(this.btn_chia_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 394);
            this.Controls.Add(this.panel_content);
            this.Controls.Add(this.panel_title);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Resize += new System.EventHandler(this.Form2_Resize);
            this.panel_title.ResumeLayout(false);
            this.panel_title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_exit)).EndInit();
            this.panel_content.ResumeLayout(false);
            this.panel_content.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panel_title;
        private Guna.UI2.WinForms.Guna2PictureBox picbox_minimize;
        private Guna.UI2.WinForms.Guna2PictureBox picbox_maximize;
        private Guna.UI2.WinForms.Guna2PictureBox picbox_exit;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_DN;
        private Guna.UI2.WinForms.Guna2Panel panel_content;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_Title;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_So2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_so1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_KQ;
        private Guna.UI2.WinForms.Guna2GradientButton Btn_KQ;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox txt_so2;
        private Guna.UI2.WinForms.Guna2TextBox txt_so1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton btn_chia;
        private Guna.UI2.WinForms.Guna2GradientButton btn_nhan;
        private Guna.UI2.WinForms.Guna2GradientButton btn_tru;
    }
}