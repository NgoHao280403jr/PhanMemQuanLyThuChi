namespace BaiCuoiKyDB
{
    partial class Chi
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
            this.label9 = new System.Windows.Forms.Label();
            this.txtSoDu = new System.Windows.Forms.TextBox();
            this.gb_Loc = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.GridView_Chi = new System.Windows.Forms.DataGridView();
            this.cl_MaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_TenVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_SoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_DanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDanhMuc2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PickTime2 = new System.Windows.Forms.DateTimePicker();
            this.txtMaChi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PickTime1 = new System.Windows.Forms.DateTimePicker();
            this.bntXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.bntThem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.cbDanhMuc = new System.Windows.Forms.ComboBox();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gb_Loc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Chi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 21);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Số dư hiện tại";
            // 
            // txtSoDu
            // 
            this.txtSoDu.Location = new System.Drawing.Point(110, 18);
            this.txtSoDu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoDu.Name = "txtSoDu";
            this.txtSoDu.Size = new System.Drawing.Size(195, 20);
            this.txtSoDu.TabIndex = 40;
            this.txtSoDu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gb_Loc
            // 
            this.gb_Loc.BackColor = System.Drawing.Color.LightCoral;
            this.gb_Loc.Controls.Add(this.label8);
            this.gb_Loc.Controls.Add(this.txtTongTien);
            this.gb_Loc.Controls.Add(this.GridView_Chi);
            this.gb_Loc.Controls.Add(this.label1);
            this.gb_Loc.Controls.Add(this.cbDanhMuc2);
            this.gb_Loc.Controls.Add(this.label6);
            this.gb_Loc.Controls.Add(this.PickTime2);
            this.gb_Loc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Loc.ForeColor = System.Drawing.Color.Black;
            this.gb_Loc.Location = new System.Drawing.Point(329, 14);
            this.gb_Loc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_Loc.Name = "gb_Loc";
            this.gb_Loc.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_Loc.Size = new System.Drawing.Size(524, 382);
            this.gb_Loc.TabIndex = 39;
            this.gb_Loc.TabStop = false;
            this.gb_Loc.Text = "Lọc";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(292, 355);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Tổng tiền";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(352, 351);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(153, 20);
            this.txtTongTien.TabIndex = 24;
            // 
            // GridView_Chi
            // 
            this.GridView_Chi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_Chi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_MaChi,
            this.cl_TenVi,
            this.cl_SoTien,
            this.cl_Ngay,
            this.cl_DanhMuc,
            this.cl_GhiChu});
            this.GridView_Chi.Location = new System.Drawing.Point(20, 83);
            this.GridView_Chi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GridView_Chi.Name = "GridView_Chi";
            this.GridView_Chi.RowHeadersWidth = 62;
            this.GridView_Chi.RowTemplate.Height = 28;
            this.GridView_Chi.Size = new System.Drawing.Size(484, 252);
            this.GridView_Chi.TabIndex = 24;
            this.GridView_Chi.SelectionChanged += new System.EventHandler(this.GridView_Chi_SelectionChanged);
            // 
            // cl_MaChi
            // 
            this.cl_MaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cl_MaChi.DataPropertyName = "MaChi";
            this.cl_MaChi.HeaderText = "Mã Chi";
            this.cl_MaChi.MinimumWidth = 8;
            this.cl_MaChi.Name = "cl_MaChi";
            // 
            // cl_TenVi
            // 
            this.cl_TenVi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cl_TenVi.DataPropertyName = "TenVi";
            this.cl_TenVi.HeaderText = "Tên Ví";
            this.cl_TenVi.MinimumWidth = 8;
            this.cl_TenVi.Name = "cl_TenVi";
            // 
            // cl_SoTien
            // 
            this.cl_SoTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cl_SoTien.DataPropertyName = "SoTien";
            this.cl_SoTien.HeaderText = "Số Tiền";
            this.cl_SoTien.MinimumWidth = 8;
            this.cl_SoTien.Name = "cl_SoTien";
            // 
            // cl_Ngay
            // 
            this.cl_Ngay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cl_Ngay.DataPropertyName = "Ngay";
            this.cl_Ngay.HeaderText = "Ngày";
            this.cl_Ngay.MinimumWidth = 8;
            this.cl_Ngay.Name = "cl_Ngay";
            // 
            // cl_DanhMuc
            // 
            this.cl_DanhMuc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cl_DanhMuc.DataPropertyName = "TenDanhMuc";
            this.cl_DanhMuc.HeaderText = "Danh Mục";
            this.cl_DanhMuc.MinimumWidth = 8;
            this.cl_DanhMuc.Name = "cl_DanhMuc";
            // 
            // cl_GhiChu
            // 
            this.cl_GhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cl_GhiChu.DataPropertyName = "GhiChu";
            this.cl_GhiChu.HeaderText = "Ghi Chú";
            this.cl_GhiChu.MinimumWidth = 8;
            this.cl_GhiChu.Name = "cl_GhiChu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ngày";
            // 
            // cbDanhMuc2
            // 
            this.cbDanhMuc2.FormattingEnabled = true;
            this.cbDanhMuc2.Items.AddRange(new object[] {
            "Tất cả"});
            this.cbDanhMuc2.Location = new System.Drawing.Point(267, 47);
            this.cbDanhMuc2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbDanhMuc2.Name = "cbDanhMuc2";
            this.cbDanhMuc2.Size = new System.Drawing.Size(158, 21);
            this.cbDanhMuc2.TabIndex = 10;
            this.cbDanhMuc2.SelectedIndexChanged += new System.EventHandler(this.cbDanhMuc2_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Danh mục";
            // 
            // PickTime2
            // 
            this.PickTime2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.PickTime2.Location = new System.Drawing.Point(20, 49);
            this.PickTime2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PickTime2.MaxDate = new System.DateTime(2024, 3, 31, 0, 0, 0, 0);
            this.PickTime2.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.PickTime2.Name = "PickTime2";
            this.PickTime2.Size = new System.Drawing.Size(217, 20);
            this.PickTime2.TabIndex = 20;
            this.PickTime2.Value = new System.DateTime(2023, 10, 23, 0, 0, 0, 0);
            this.PickTime2.ValueChanged += new System.EventHandler(this.PickTime2_ValueChanged);
            // 
            // txtMaChi
            // 
            this.txtMaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaChi.Location = new System.Drawing.Point(87, 97);
            this.txtMaChi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaChi.Name = "txtMaChi";
            this.txtMaChi.Size = new System.Drawing.Size(91, 20);
            this.txtMaChi.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 101);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Mã Chi";
            // 
            // PickTime1
            // 
            this.PickTime1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PickTime1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.PickTime1.Location = new System.Drawing.Point(87, 173);
            this.PickTime1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PickTime1.MaxDate = new System.DateTime(2024, 4, 30, 0, 0, 0, 0);
            this.PickTime1.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.PickTime1.Name = "PickTime1";
            this.PickTime1.Size = new System.Drawing.Size(217, 20);
            this.PickTime1.TabIndex = 36;
            this.PickTime1.Value = new System.DateTime(2023, 10, 16, 0, 0, 0, 0);
            // 
            // bntXoa
            // 
            this.bntXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntXoa.Location = new System.Drawing.Point(239, 333);
            this.bntXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bntXoa.Name = "bntXoa";
            this.bntXoa.Size = new System.Drawing.Size(64, 28);
            this.bntXoa.TabIndex = 35;
            this.bntXoa.Text = "Xóa";
            this.bntXoa.UseVisualStyleBackColor = true;
            this.bntXoa.Click += new System.EventHandler(this.bntXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(127, 333);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(69, 28);
            this.btnSua.TabIndex = 34;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // bntThem
            // 
            this.bntThem.BackColor = System.Drawing.Color.LightCoral;
            this.bntThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntThem.Location = new System.Drawing.Point(26, 333);
            this.bntThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bntThem.Name = "bntThem";
            this.bntThem.Size = new System.Drawing.Size(64, 28);
            this.bntThem.TabIndex = 33;
            this.bntThem.Text = "Thêm";
            this.bntThem.UseVisualStyleBackColor = false;
            this.bntThem.Click += new System.EventHandler(this.bntThem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 245);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Ghi chú";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 209);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Danh mục";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 173);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Số tiền";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(87, 245);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(217, 47);
            this.txtGhiChu.TabIndex = 28;
            // 
            // cbDanhMuc
            // 
            this.cbDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDanhMuc.FormattingEnabled = true;
            this.cbDanhMuc.Location = new System.Drawing.Point(87, 204);
            this.cbDanhMuc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbDanhMuc.Name = "cbDanhMuc";
            this.cbDanhMuc.Size = new System.Drawing.Size(217, 21);
            this.cbDanhMuc.TabIndex = 27;
            // 
            // txtTien
            // 
            this.txtTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTien.Location = new System.Drawing.Point(87, 135);
            this.txtTien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(217, 20);
            this.txtTien.TabIndex = 26;
            this.txtTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTien_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(141, 54);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 25);
            this.label12.TabIndex = 31;
            this.label12.Text = "/";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Firebrick;
            this.label11.Location = new System.Drawing.Point(155, 55);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 25);
            this.label11.TabIndex = 30;
            this.label11.Text = "CHI";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label10.Location = new System.Drawing.Point(107, 61);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 17);
            this.label10.TabIndex = 29;
            this.label10.Text = "THU";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Chi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 411);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtSoDu);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.gb_Loc);
            this.Controls.Add(this.txtMaChi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PickTime1);
            this.Controls.Add(this.bntXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.bntThem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.cbDanhMuc);
            this.Controls.Add(this.txtTien);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Chi";
            this.Text = "Chi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Chi_FormClosing_1);
            this.Load += new System.EventHandler(this.Chi_Load);
            this.gb_Loc.ResumeLayout(false);
            this.gb_Loc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Chi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSoDu;
        private System.Windows.Forms.GroupBox gb_Loc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.DataGridView GridView_Chi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDanhMuc2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker PickTime2;
        private System.Windows.Forms.TextBox txtMaChi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker PickTime1;
        private System.Windows.Forms.Button bntXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button bntThem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.ComboBox cbDanhMuc;
        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_MaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_TenVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_SoTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_DanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_GhiChu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}