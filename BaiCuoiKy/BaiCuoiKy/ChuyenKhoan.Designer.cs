namespace BaiCuoiKyDB
{
    partial class ChuyenKhoan
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.PickTime1 = new System.Windows.Forms.DateTimePicker();
            this.txtSoTienChuyen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbViChuyen = new System.Windows.Forms.ComboBox();
            this.cbViNhan = new System.Windows.Forms.ComboBox();
            this.txtSoDuHT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(257, 246);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(78, 31);
            this.btnThoat.TabIndex = 80;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(86, 201);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 79;
            this.label6.Text = "Ghi chú";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Enabled = false;
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(207, 200);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(217, 20);
            this.txtGhiChu.TabIndex = 78;
            this.txtGhiChu.Text = "Chuyển khoản";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(139, 246);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(78, 31);
            this.btnLuu.TabIndex = 74;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // PickTime1
            // 
            this.PickTime1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PickTime1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.PickTime1.Location = new System.Drawing.Point(207, 170);
            this.PickTime1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PickTime1.MaxDate = new System.DateTime(2024, 4, 30, 0, 0, 0, 0);
            this.PickTime1.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.PickTime1.Name = "PickTime1";
            this.PickTime1.Size = new System.Drawing.Size(217, 20);
            this.PickTime1.TabIndex = 70;
            this.PickTime1.Value = new System.DateTime(2023, 11, 28, 0, 0, 0, 0);
            // 
            // txtSoTienChuyen
            // 
            this.txtSoTienChuyen.Location = new System.Drawing.Point(207, 75);
            this.txtSoTienChuyen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoTienChuyen.Name = "txtSoTienChuyen";
            this.txtSoTienChuyen.Size = new System.Drawing.Size(217, 20);
            this.txtSoTienChuyen.TabIndex = 69;
            this.txtSoTienChuyen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSoTienChuyen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoTienChuyen_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 173);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 75;
            this.label3.Text = "Ví chuyển";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 82;
            this.label4.Text = "Ví nhận";
            // 
            // cbViChuyen
            // 
            this.cbViChuyen.FormattingEnabled = true;
            this.cbViChuyen.Location = new System.Drawing.Point(207, 108);
            this.cbViChuyen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbViChuyen.Name = "cbViChuyen";
            this.cbViChuyen.Size = new System.Drawing.Size(217, 21);
            this.cbViChuyen.TabIndex = 83;
            this.cbViChuyen.SelectedIndexChanged += new System.EventHandler(this.cbViChuyen_SelectedIndexChanged);
            // 
            // cbViNhan
            // 
            this.cbViNhan.FormattingEnabled = true;
            this.cbViNhan.Location = new System.Drawing.Point(207, 141);
            this.cbViNhan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbViNhan.Name = "cbViNhan";
            this.cbViNhan.Size = new System.Drawing.Size(217, 21);
            this.cbViNhan.TabIndex = 84;
            // 
            // txtSoDuHT
            // 
            this.txtSoDuHT.Location = new System.Drawing.Point(207, 45);
            this.txtSoDuHT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoDuHT.Name = "txtSoDuHT";
            this.txtSoDuHT.Size = new System.Drawing.Size(217, 20);
            this.txtSoDuHT.TabIndex = 85;
            this.txtSoDuHT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "Số tiền muốn chuyển";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 86;
            this.label5.Text = "Số dư ví khả dụng";
            // 
            // ChuyenKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 311);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSoDuHT);
            this.Controls.Add(this.cbViNhan);
            this.Controls.Add(this.cbViChuyen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.PickTime1);
            this.Controls.Add(this.txtSoTienChuyen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ChuyenKhoan";
            this.Text = "ChuyenKhoan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChuyenKhoan_FormClosing);
            this.Load += new System.EventHandler(this.ChuyenKhoan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DateTimePicker PickTime1;
        private System.Windows.Forms.TextBox txtSoTienChuyen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbViChuyen;
        private System.Windows.Forms.ComboBox cbViNhan;
        private System.Windows.Forms.TextBox txtSoDuHT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}