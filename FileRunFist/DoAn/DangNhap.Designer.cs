
namespace DoAn
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.linkLabel_DangKy = new System.Windows.Forms.LinkLabel();
            this.linkLabel_QuenPass = new System.Windows.Forms.LinkLabel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button_DangNhap = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Button_Close = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel_DangKy
            // 
            this.linkLabel_DangKy.AutoSize = true;
            this.linkLabel_DangKy.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel_DangKy.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.linkLabel_DangKy.Location = new System.Drawing.Point(320, 350);
            this.linkLabel_DangKy.Name = "linkLabel_DangKy";
            this.linkLabel_DangKy.Size = new System.Drawing.Size(47, 13);
            this.linkLabel_DangKy.TabIndex = 14;
            this.linkLabel_DangKy.TabStop = true;
            this.linkLabel_DangKy.Text = "Đăng ký";
            this.linkLabel_DangKy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_DangKy_LinkClicked);
            // 
            // linkLabel_QuenPass
            // 
            this.linkLabel_QuenPass.AutoSize = true;
            this.linkLabel_QuenPass.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel_QuenPass.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.linkLabel_QuenPass.Location = new System.Drawing.Point(50, 350);
            this.linkLabel_QuenPass.Name = "linkLabel_QuenPass";
            this.linkLabel_QuenPass.Size = new System.Drawing.Size(83, 13);
            this.linkLabel_QuenPass.TabIndex = 13;
            this.linkLabel_QuenPass.TabStop = true;
            this.linkLabel_QuenPass.Text = "Quên mật khẩu ";
            this.linkLabel_QuenPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_QuenPass_LinkClicked);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox2.Location = new System.Drawing.Point(121, 275);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(220, 36);
            this.textBox2.TabIndex = 12;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBox1.Location = new System.Drawing.Point(121, 196);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 36);
            this.textBox1.TabIndex = 10;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::DoAn.Properties.Resources.Icons8_Ios7_User_Interface_Password_512;
            this.pictureBox3.Location = new System.Drawing.Point(38, 275);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown);
            this.pictureBox3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::DoAn.Properties.Resources.Custom_Icon_Design_Silky_Line_User_Users2_3_512;
            this.pictureBox2.Location = new System.Drawing.Point(38, 196);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.Image = global::DoAn.Properties.Resources._0af3c9613761d2d2394d99312aeba397;
            this.pictureBox1.Location = new System.Drawing.Point(121, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // button_DangNhap
            // 
            this.button_DangNhap.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.button_DangNhap.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button_DangNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_DangNhap.BorderRadius = -50;
            this.button_DangNhap.ButtonText = "Đăng nhập ";
            this.button_DangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_DangNhap.DisabledColor = System.Drawing.Color.Gray;
            this.button_DangNhap.Iconcolor = System.Drawing.Color.Transparent;
            this.button_DangNhap.Iconimage = ((System.Drawing.Image)(resources.GetObject("button_DangNhap.Iconimage")));
            this.button_DangNhap.Iconimage_right = null;
            this.button_DangNhap.Iconimage_right_Selected = null;
            this.button_DangNhap.Iconimage_Selected = null;
            this.button_DangNhap.IconMarginLeft = 0;
            this.button_DangNhap.IconMarginRight = 0;
            this.button_DangNhap.IconRightVisible = true;
            this.button_DangNhap.IconRightZoom = 0D;
            this.button_DangNhap.IconVisible = true;
            this.button_DangNhap.IconZoom = 90D;
            this.button_DangNhap.IsTab = false;
            this.button_DangNhap.Location = new System.Drawing.Point(153, 380);
            this.button_DangNhap.Name = "button_DangNhap";
            this.button_DangNhap.Normalcolor = System.Drawing.Color.LightSeaGreen;
            this.button_DangNhap.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.button_DangNhap.OnHoverTextColor = System.Drawing.Color.White;
            this.button_DangNhap.selected = false;
            this.button_DangNhap.Size = new System.Drawing.Size(155, 43);
            this.button_DangNhap.TabIndex = 18;
            this.button_DangNhap.Text = "Đăng nhập ";
            this.button_DangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_DangNhap.Textcolor = System.Drawing.Color.White;
            this.button_DangNhap.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DangNhap.Click += new System.EventHandler(this.button_DangNhap_Click_1);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackgroundImage = global::DoAn.Properties.Resources.Iconsmind_Outline_Minimize_Window1;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuFlatButton2.BorderRadius = -25;
            this.bunifuFlatButton2.ButtonText = "";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(779, 12);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.Silver;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(25, 25);
            this.bunifuFlatButton2.TabIndex = 20;
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // Button_Close
            // 
            this.Button_Close.Activecolor = System.Drawing.Color.Transparent;
            this.Button_Close.BackColor = System.Drawing.Color.White;
            this.Button_Close.BackgroundImage = global::DoAn.Properties.Resources.Custom_Icon_Design_Mono_General_1_Delete_48;
            this.Button_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button_Close.BorderRadius = -25;
            this.Button_Close.ButtonText = "";
            this.Button_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Close.DisabledColor = System.Drawing.Color.Gray;
            this.Button_Close.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button_Close.Iconcolor = System.Drawing.Color.DimGray;
            this.Button_Close.Iconimage = null;
            this.Button_Close.Iconimage_right = null;
            this.Button_Close.Iconimage_right_Selected = null;
            this.Button_Close.Iconimage_Selected = null;
            this.Button_Close.IconMarginLeft = 0;
            this.Button_Close.IconMarginRight = 0;
            this.Button_Close.IconRightVisible = true;
            this.Button_Close.IconRightZoom = 0D;
            this.Button_Close.IconVisible = true;
            this.Button_Close.IconZoom = 90D;
            this.Button_Close.IsTab = false;
            this.Button_Close.Location = new System.Drawing.Point(814, 12);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Normalcolor = System.Drawing.Color.Transparent;
            this.Button_Close.OnHovercolor = System.Drawing.Color.Maroon;
            this.Button_Close.OnHoverTextColor = System.Drawing.Color.White;
            this.Button_Close.selected = false;
            this.Button_Close.Size = new System.Drawing.Size(25, 25);
            this.Button_Close.TabIndex = 21;
            this.Button_Close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_Close.Textcolor = System.Drawing.Color.White;
            this.Button_Close.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::DoAn.Properties.Resources.t_52_tieu_dung_so;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(855, 452);
            this.Controls.Add(this.Button_Close);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.button_DangNhap);
            this.Controls.Add(this.linkLabel_DangKy);
            this.Controls.Add(this.linkLabel_QuenPass);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangNhap";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkLabel_DangKy;
        private System.Windows.Forms.LinkLabel linkLabel_QuenPass;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton button_DangNhap;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton Button_Close;
    }
}