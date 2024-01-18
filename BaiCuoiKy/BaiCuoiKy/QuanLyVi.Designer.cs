namespace BaiCuoiKyDB
{
    partial class QuanLyVi
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
            this.btn_SuaSoDu = new System.Windows.Forms.Button();
            this.btn_ChuyenKhoan = new System.Windows.Forms.Button();
            this.GridView_Vi = new System.Windows.Forms.DataGridView();
            this.clMaVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Vi)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_SuaSoDu
            // 
            this.btn_SuaSoDu.Location = new System.Drawing.Point(117, 228);
            this.btn_SuaSoDu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SuaSoDu.Name = "btn_SuaSoDu";
            this.btn_SuaSoDu.Size = new System.Drawing.Size(79, 23);
            this.btn_SuaSoDu.TabIndex = 0;
            this.btn_SuaSoDu.Text = "Sửa Số Dư";
            this.btn_SuaSoDu.UseVisualStyleBackColor = true;
            this.btn_SuaSoDu.Click += new System.EventHandler(this.btn_SuaSoDu_Click);
            // 
            // btn_ChuyenKhoan
            // 
            this.btn_ChuyenKhoan.Location = new System.Drawing.Point(271, 228);
            this.btn_ChuyenKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ChuyenKhoan.Name = "btn_ChuyenKhoan";
            this.btn_ChuyenKhoan.Size = new System.Drawing.Size(91, 23);
            this.btn_ChuyenKhoan.TabIndex = 1;
            this.btn_ChuyenKhoan.Text = "Chuyển Khoản";
            this.btn_ChuyenKhoan.UseVisualStyleBackColor = true;
            this.btn_ChuyenKhoan.Click += new System.EventHandler(this.btn_ChuyenKhoan_Click);
            // 
            // GridView_Vi
            // 
            this.GridView_Vi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_Vi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaVi,
            this.clTaiKhoan,
            this.clSoTien});
            this.GridView_Vi.Location = new System.Drawing.Point(41, 29);
            this.GridView_Vi.Margin = new System.Windows.Forms.Padding(2);
            this.GridView_Vi.Name = "GridView_Vi";
            this.GridView_Vi.RowHeadersWidth = 62;
            this.GridView_Vi.RowTemplate.Height = 28;
            this.GridView_Vi.Size = new System.Drawing.Size(433, 175);
            this.GridView_Vi.TabIndex = 3;
            this.GridView_Vi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_Vi_CellClick);
            // 
            // clMaVi
            // 
            this.clMaVi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clMaVi.DataPropertyName = "MaVi";
            this.clMaVi.HeaderText = "Mã Ví";
            this.clMaVi.Name = "clMaVi";
            // 
            // clTaiKhoan
            // 
            this.clTaiKhoan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clTaiKhoan.DataPropertyName = "TaiKhoan";
            this.clTaiKhoan.HeaderText = "Tài Khoản";
            this.clTaiKhoan.Name = "clTaiKhoan";
            // 
            // clSoTien
            // 
            this.clSoTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clSoTien.DataPropertyName = "SoTien";
            this.clSoTien.HeaderText = "Số Tiền";
            this.clSoTien.Name = "clSoTien";
            // 
            // QuanLyVi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.GridView_Vi);
            this.Controls.Add(this.btn_ChuyenKhoan);
            this.Controls.Add(this.btn_SuaSoDu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QuanLyVi";
            this.Text = "QuanLyVi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuanLyVi_FormClosing);
            this.Load += new System.EventHandler(this.QuanLyVi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Vi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_SuaSoDu;
        private System.Windows.Forms.Button btn_ChuyenKhoan;
        private System.Windows.Forms.DataGridView GridView_Vi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoTien;
    }
}