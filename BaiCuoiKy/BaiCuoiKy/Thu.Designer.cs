namespace BaiCuoiKyDB
{
    partial class Thu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.cbDanhMuc = new System.Windows.Forms.ComboBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bntThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.bntXoa = new System.Windows.Forms.Button();
            this.PickTime1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaThu = new System.Windows.Forms.TextBox();
            this.PickTime2 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cbDanhMuc2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GridView_Thu = new System.Windows.Forms.DataGridView();
            this.cl_MaThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_TenVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_SoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_DanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gb_Loc = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSoDu = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Thu)).BeginInit();
            this.gb_Loc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTien
            // 
            this.txtTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTien.Location = new System.Drawing.Point(123, 198);
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(324, 26);
            this.txtTien.TabIndex = 42;
            this.txtTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTien_KeyPress);
            // 
            // cbDanhMuc
            // 
            this.cbDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDanhMuc.FormattingEnabled = true;
            this.cbDanhMuc.Location = new System.Drawing.Point(123, 305);
            this.cbDanhMuc.Name = "cbDanhMuc";
            this.cbDanhMuc.Size = new System.Drawing.Size(324, 28);
            this.cbDanhMuc.TabIndex = 43;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(123, 368);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(324, 70);
            this.txtGhiChu.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Số tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "Ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 49;
            this.label4.Text = "Danh mục";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 51;
            this.label5.Text = "Ghi chú";
            // 
            // bntThem
            // 
            this.bntThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bntThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntThem.Location = new System.Drawing.Point(31, 503);
            this.bntThem.Name = "bntThem";
            this.bntThem.Size = new System.Drawing.Size(96, 43);
            this.bntThem.TabIndex = 52;
            this.bntThem.Text = "Thêm";
            this.bntThem.UseVisualStyleBackColor = false;
            this.bntThem.Click += new System.EventHandler(this.bntThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(182, 503);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(103, 43);
            this.btnSua.TabIndex = 53;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // bntXoa
            // 
            this.bntXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntXoa.Location = new System.Drawing.Point(351, 503);
            this.bntXoa.Name = "bntXoa";
            this.bntXoa.Size = new System.Drawing.Size(96, 43);
            this.bntXoa.TabIndex = 54;
            this.bntXoa.Text = "Xóa";
            this.bntXoa.UseVisualStyleBackColor = true;
            this.bntXoa.Click += new System.EventHandler(this.bntXoa_Click);
            // 
            // PickTime1
            // 
            this.PickTime1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PickTime1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.PickTime1.Location = new System.Drawing.Point(123, 257);
            this.PickTime1.MaxDate = new System.DateTime(2024, 4, 30, 0, 0, 0, 0);
            this.PickTime1.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.PickTime1.Name = "PickTime1";
            this.PickTime1.Size = new System.Drawing.Size(324, 26);
            this.PickTime1.TabIndex = 55;
            this.PickTime1.Value = new System.DateTime(2023, 10, 16, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 56;
            this.label7.Text = "Mã Thu";
            // 
            // txtMaThu
            // 
            this.txtMaThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaThu.Location = new System.Drawing.Point(123, 140);
            this.txtMaThu.Name = "txtMaThu";
            this.txtMaThu.Size = new System.Drawing.Size(134, 26);
            this.txtMaThu.TabIndex = 57;
            // 
            // PickTime2
            // 
            this.PickTime2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.PickTime2.Location = new System.Drawing.Point(30, 75);
            this.PickTime2.MaxDate = new System.DateTime(2024, 3, 31, 0, 0, 0, 0);
            this.PickTime2.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.PickTime2.Name = "PickTime2";
            this.PickTime2.Size = new System.Drawing.Size(323, 26);
            this.PickTime2.TabIndex = 20;
            this.PickTime2.Value = new System.DateTime(2023, 10, 23, 0, 0, 0, 0);
            this.PickTime2.ValueChanged += new System.EventHandler(this.PickTime2_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(396, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Danh mục";
            // 
            // cbDanhMuc2
            // 
            this.cbDanhMuc2.FormattingEnabled = true;
            this.cbDanhMuc2.Items.AddRange(new object[] {
            "Tất cả"});
            this.cbDanhMuc2.Location = new System.Drawing.Point(400, 73);
            this.cbDanhMuc2.Name = "cbDanhMuc2";
            this.cbDanhMuc2.Size = new System.Drawing.Size(235, 28);
            this.cbDanhMuc2.TabIndex = 10;
            this.cbDanhMuc2.SelectedIndexChanged += new System.EventHandler(this.cbDanhMuc2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ngày";
            // 
            // GridView_Thu
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView_Thu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridView_Thu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_Thu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_MaThu,
            this.cl_TenVi,
            this.cl_SoTien,
            this.cl_Ngay,
            this.cl_DanhMuc,
            this.cl_GhiChu});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridView_Thu.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridView_Thu.Location = new System.Drawing.Point(30, 128);
            this.GridView_Thu.Name = "GridView_Thu";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView_Thu.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridView_Thu.RowHeadersWidth = 62;
            this.GridView_Thu.RowTemplate.Height = 28;
            this.GridView_Thu.Size = new System.Drawing.Size(726, 388);
            this.GridView_Thu.TabIndex = 24;
            this.GridView_Thu.SelectionChanged += new System.EventHandler(this.GridView_Thu_SelectionChanged);
            // 
            // cl_MaThu
            // 
            this.cl_MaThu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cl_MaThu.DataPropertyName = "MaThu";
            this.cl_MaThu.HeaderText = "Mã Thu";
            this.cl_MaThu.MinimumWidth = 8;
            this.cl_MaThu.Name = "cl_MaThu";
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
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(528, 540);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(228, 26);
            this.txtTongTien.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(438, 546);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Tổng tiền";
            // 
            // gb_Loc
            // 
            this.gb_Loc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gb_Loc.Controls.Add(this.label8);
            this.gb_Loc.Controls.Add(this.txtTongTien);
            this.gb_Loc.Controls.Add(this.GridView_Thu);
            this.gb_Loc.Controls.Add(this.label1);
            this.gb_Loc.Controls.Add(this.cbDanhMuc2);
            this.gb_Loc.Controls.Add(this.label6);
            this.gb_Loc.Controls.Add(this.PickTime2);
            this.gb_Loc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Loc.ForeColor = System.Drawing.Color.Black;
            this.gb_Loc.Location = new System.Drawing.Point(486, 12);
            this.gb_Loc.Name = "gb_Loc";
            this.gb_Loc.Size = new System.Drawing.Size(786, 588);
            this.gb_Loc.TabIndex = 58;
            this.gb_Loc.TabStop = false;
            this.gb_Loc.Text = "Lọc";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label10.Location = new System.Drawing.Point(263, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 23);
            this.label10.TabIndex = 46;
            this.label10.Text = "CHI";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtSoDu
            // 
            this.txtSoDu.Location = new System.Drawing.Point(157, 18);
            this.txtSoDu.Name = "txtSoDu";
            this.txtSoDu.Size = new System.Drawing.Size(290, 26);
            this.txtSoDu.TabIndex = 59;
            this.txtSoDu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(242, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 36);
            this.label12.TabIndex = 50;
            this.label12.Text = "/";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 20);
            this.label9.TabIndex = 60;
            this.label9.Text = "Số dư hiện tại";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label11.Location = new System.Drawing.Point(161, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 36);
            this.label11.TabIndex = 47;
            this.label11.Text = "THU";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Thu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 612);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtSoDu);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.gb_Loc);
            this.Controls.Add(this.txtMaThu);
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
            this.Name = "Thu";
            this.Text = "Thu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Thu_FormClosing_1);
            this.Load += new System.EventHandler(this.Thu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Thu)).EndInit();
            this.gb_Loc.ResumeLayout(false);
            this.gb_Loc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.ComboBox cbDanhMuc;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bntThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button bntXoa;
        private System.Windows.Forms.DateTimePicker PickTime1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaThu;
        private System.Windows.Forms.DateTimePicker PickTime2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbDanhMuc2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridView_Thu;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gb_Loc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSoDu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_MaThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_TenVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_SoTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_DanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_GhiChu;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}