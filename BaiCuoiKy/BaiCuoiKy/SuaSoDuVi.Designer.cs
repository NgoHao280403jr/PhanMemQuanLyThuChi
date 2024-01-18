namespace BaiCuoiKyDB
{
    partial class SuaSoDuVi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoDuMoi = new System.Windows.Forms.TextBox();
            this.PickTime1 = new System.Windows.Forms.DateTimePicker();
            this.cbDanhMuc = new System.Windows.Forms.ComboBox();
            this.txtSoDuHT = new System.Windows.Forms.TextBox();
            this.txtChenhLech = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số dư muốn thay đổi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày";
            // 
            // txtSoDuMoi
            // 
            this.txtSoDuMoi.Location = new System.Drawing.Point(289, 117);
            this.txtSoDuMoi.Name = "txtSoDuMoi";
            this.txtSoDuMoi.Size = new System.Drawing.Size(324, 26);
            this.txtSoDuMoi.TabIndex = 2;
            this.txtSoDuMoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSoDuMoi.TextChanged += new System.EventHandler(this.txtSoDuMoi_TextChanged);
            this.txtSoDuMoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoDuMoi_KeyPress);
            // 
            // PickTime1
            // 
            this.PickTime1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PickTime1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.PickTime1.Location = new System.Drawing.Point(289, 217);
            this.PickTime1.MaxDate = new System.DateTime(2024, 4, 30, 0, 0, 0, 0);
            this.PickTime1.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.PickTime1.Name = "PickTime1";
            this.PickTime1.Size = new System.Drawing.Size(324, 26);
            this.PickTime1.TabIndex = 56;
            this.PickTime1.Value = new System.DateTime(2023, 10, 16, 0, 0, 0, 0);
            // 
            // cbDanhMuc
            // 
            this.cbDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDanhMuc.FormattingEnabled = true;
            this.cbDanhMuc.Location = new System.Drawing.Point(289, 265);
            this.cbDanhMuc.Name = "cbDanhMuc";
            this.cbDanhMuc.Size = new System.Drawing.Size(324, 28);
            this.cbDanhMuc.TabIndex = 57;
            // 
            // txtSoDuHT
            // 
            this.txtSoDuHT.Enabled = false;
            this.txtSoDuHT.Location = new System.Drawing.Point(289, 67);
            this.txtSoDuHT.Name = "txtSoDuHT";
            this.txtSoDuHT.Size = new System.Drawing.Size(324, 26);
            this.txtSoDuHT.TabIndex = 58;
            this.txtSoDuHT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtChenhLech
            // 
            this.txtChenhLech.Enabled = false;
            this.txtChenhLech.ForeColor = System.Drawing.Color.Black;
            this.txtChenhLech.Location = new System.Drawing.Point(289, 166);
            this.txtChenhLech.Name = "txtChenhLech";
            this.txtChenhLech.Size = new System.Drawing.Size(324, 26);
            this.txtChenhLech.TabIndex = 59;
            this.txtChenhLech.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(208, 377);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(117, 47);
            this.btnLuu.TabIndex = 60;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.bntLuu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 61;
            this.label3.Text = "Số dư trên ví hiện tại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(107, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 62;
            this.label4.Text = "Chênh lệch";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 63;
            this.label5.Text = "Danh mục";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(107, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 65;
            this.label6.Text = "Ghi chú";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Enabled = false;
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(289, 309);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(324, 26);
            this.txtGhiChu.TabIndex = 64;
            this.txtGhiChu.Text = "Điều chỉnh số dư ví";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(386, 377);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(117, 47);
            this.btnThoat.TabIndex = 66;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // SuaSoDuVi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 478);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtChenhLech);
            this.Controls.Add(this.txtSoDuHT);
            this.Controls.Add(this.cbDanhMuc);
            this.Controls.Add(this.PickTime1);
            this.Controls.Add(this.txtSoDuMoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SuaSoDuVi";
            this.Text = "SuaSoDuVi";
            this.Load += new System.EventHandler(this.SuaSoDuVi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoDuMoi;
        private System.Windows.Forms.DateTimePicker PickTime1;
        private System.Windows.Forms.ComboBox cbDanhMuc;
        private System.Windows.Forms.TextBox txtSoDuHT;
        private System.Windows.Forms.TextBox txtChenhLech;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnThoat;
    }
}