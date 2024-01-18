using System;
using System.Data;
using System.Data.SqlClient;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Forms;


namespace BaiCuoiKyDB
{
    public partial class Thu : Form
    {
        string taikhoan = "";
        string mavi = "Vi_TD";
        public object BindingMode { get; private set; }

        //public Thu()
        //{
        //    InitializeComponent();
        //}
        public Thu(string taikhoan)
        {
            InitializeComponent();
            this.taikhoan = taikhoan;
        }

        //Khai báo
        DataSet dt;
        DataSet dscb;
        DataSet ds;
        int loai = 1;

        //Load dữ liệu
        //Load Form
        private void Thu_Load(object sender, EventArgs e)
        {
            //Mặc định ban đầu
            txtMaThu.Enabled = false;
            btnSua.Enabled = false;
            bntXoa.Enabled = false;
            PickTime1.Value = DateTime.Now;
            PickTime2.Value = DateTime.Now;
            //Load Cmb
            LoadcbBoxDanhMuc(cbDanhMuc, loai);
            loai = 2;
            LoadcbBoxDanhMuc(cbDanhMuc2, loai);
            //Tạo mã Thu ban đầu
            txtMaThu.Text = TaoMaThuTuDong();
            //Clear dữ liệu
            txtTien.Clear();
            txtGhiChu.Clear();
            //lấy số dư ví hiện tại
            txtSoDu.Text = LaySoDu(taikhoan, mavi).ToString();
        }

        //Tạo mã Thu tự động
        string TaoMaThuTuDong()
        {
            DBConnect db = new DBConnect();
            string sqlquery = "";
            sqlquery = "select count(*) from Thu";
            int soDong = db.getScalar(sqlquery);
            string mathu;
            if (soDong < 9)
            {
                mathu = "Ma0" + (soDong + 1).ToString();
            }
            else
            {
                mathu = "Ma" + (soDong + 1).ToString();
            }
            return mathu;
        }

        //Thống kê tiền hiển thị ở GridView
        float TinhTong(DataSet data)
        {
            DBConnect db = new DBConnect();
            float Tong = 0;
            int i = 0;
            while (i < data.Tables[0].Rows.Count)
            {
                float value = float.Parse(GridView_Thu.Rows[i].Cells[2].Value.ToString());
                Tong = Tong + value;
                i++;
            }
            return Tong;
        }

        //Xem/Lấy số dư hiện tại
        public decimal LaySoDu(string taikhoan, string maVi)
        {
            using (SqlConnection connection = new SqlConnection(DBConnect.chuoiketnoi))
            {
                connection.Open();
                string sqlQuery = "SELECT SoTien FROM SoDu WHERE TaiKhoan = @TaiKhoan AND MaVi = @MaVi ";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@TaiKhoan", taikhoan);
                    cmd.Parameters.AddWithValue("@MaVi", maVi);
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return (decimal)result;
                    }
                }
            }
            return 0.0m;
        }

        //Cập nhật số dư vào tài khoản tiền
        public void CapNhatVi(string taikhoan, string maVi, decimal soDuMoi)
        {
            // Cập nhật số dư mới vào cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(DBConnect.chuoiketnoi))
            {
                connection.Open();
                string sqlUpdate = "UPDATE SoDu SET SoTien = @SoTien WHERE TaiKhoan = @TaiKhoan AND MaVi = @MaVi";
                using (SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, connection))
                {
                    cmdUpdate.Parameters.AddWithValue("@SoTien", soDuMoi);
                    cmdUpdate.Parameters.AddWithValue("@TaiKhoan", taikhoan);
                    cmdUpdate.Parameters.AddWithValue("@MaVi", maVi);

                    cmdUpdate.ExecuteNonQuery();
                }
            }
        }

        //Truy xuất tiền theo mã thu
        public decimal SoTienHT_Thu(string maThu)
        {
            using (SqlConnection connection = new SqlConnection(DBConnect.chuoiketnoi))
            {
                connection.Open();
                string sqlquery = "select SoTien from Thu where MaThu='" + maThu + "'";
                SqlCommand cmd = new SqlCommand(sqlquery, connection);
                decimal SoTienThuHT = (decimal)cmd.ExecuteScalar(); //số tiền đơn đó
                return SoTienThuHT;
            }
        }


        //Thêm tiền thu (tiền thêm vào ví)
        public void CongTienThuVaoVi(string taikhoan, string maVi, decimal soTienThu)
        {
            using (SqlConnection connection = new SqlConnection(DBConnect.chuoiketnoi))
            {
                connection.Open();

                // Truy xuất số dư ví hiện tại
                decimal soDuHienTai = LaySoDu(taikhoan, maVi);

                // Thực hiện phép cộng
                decimal soDuMoi = soDuHienTai + soTienThu;

                // Cập nhật số dư mới vào cơ sở dữ liệu
                CapNhatVi(taikhoan, maVi, soDuMoi);
            }
        }

        //Xóa tiền thu (trừ tiền khỏi ví)
        public bool TruTienThuKhoiVi(string taikhoan, string maVi, decimal soTienThu)
        {
            using (SqlConnection connection = new SqlConnection(DBConnect.chuoiketnoi))
            {
                connection.Open();
                // Truy xuất số dư ví hiện tại
                decimal soDuHienTai = LaySoDu(taikhoan, maVi);
                // Thực hiện phép trừ
                decimal soDuMoi = soDuHienTai;
                if (soTienThu <= soDuHienTai)
                {
                    soDuMoi = soDuHienTai - soTienThu;
                }
                else
                {
                    MessageBox.Show("Số dư Ví không đủ để thay đổi");
                    return false;
                }
                //Cập nhật số dư ví 
                CapNhatVi(taikhoan, maVi, soDuMoi);
                return true;
            }
        }

        //Sửa tiền thu (thay đổi tiền ví)
        public bool SuaTienThuTrongVi(string taikhoan, string maVi, string maThu, decimal soTienThuMoi)
        {
            using (SqlConnection connection = new SqlConnection(DBConnect.chuoiketnoi))
            {
                connection.Open();
                // Truy xuất số dư ví hiện tại
                decimal soDuHienTai = LaySoDu(taikhoan, maVi);
                //Truy xuất số tiền hiện tại của mã thu được chọn
                decimal SoTienThuHT = SoTienHT_Thu(maThu);
                decimal KhoanTienThayDoi;
                decimal soDuMoi = soDuHienTai;
                //So sánh tiền mới, tiền hiện tại
                bool Giam = false;
                if (soTienThuMoi >= SoTienThuHT) //số tiền thu mới lớn hơn tiền thu hiện tại => tiền ví tăng lên
                {
                    KhoanTienThayDoi = soTienThuMoi - SoTienThuHT;
                    soDuMoi = soDuHienTai + KhoanTienThayDoi;
                }
                else
                {
                    KhoanTienThayDoi = SoTienThuHT - soTienThuMoi; // số tiền thu mới bé hơn tiền thu hiện tại => tiền ví bị giảm xuống
                    Giam = true;
                }

                if (Giam) //nếu tiền ví bị giảm
                {
                    if (KhoanTienThayDoi <= soDuHienTai)
                    {
                        soDuMoi = soDuHienTai - KhoanTienThayDoi;
                    }
                    else
                    {
                        MessageBox.Show("Số dư Ví không đủ để thay đổi");
                        return false;
                    }
                }
                //Cập nhật số dư ví 
                CapNhatVi(taikhoan, maVi, soDuMoi);
                return true;
            }
        }

        //Form đóng
        private void Thu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            { e.Cancel = true; }
        }

        //Load ComboBox
        void LoadcbBoxDanhMuc(ComboBox cb, int loai)
        {
            DBConnect db = new DBConnect();
            string sqlquery = "select * from DanhMuc where substring(MaDanhMuc,1,1)='T'";
            dscb = db.getDataSet(sqlquery);
            if (loai == 2)
            {
                DataRow addnewR = dscb.Tables[0].NewRow();
                addnewR["MaDanhMuc"] = "";
                addnewR["TenDanhMuc"] = "Tất Cả";
                dscb.Tables[0].Rows.InsertAt(addnewR, 0);
            }
            cb.DataSource = dscb.Tables[0];
            cb.DisplayMember = "TenDanhMuc";
            cb.ValueMember = "MaDanhMuc";
        }

        //Hiển thị sau khi ấn nút thêm
        DataSet GridView_DSThu()
        {
            DBConnect db = new DBConnect();
            string sqlquery = "";
            sqlquery = "select MaThu,Ngay,SoTien,GhiChu,TenDanhMuc,TenVi from Thu,DanhMuc,Vi where Thu.TaiKhoan='" + taikhoan + "' AND Thu.MaDanhMuc = DanhMuc.MaDanhMuc AND Thu.MaVi=Vi.MaVi AND Ngay='" + PickTime1.Value.ToString("yyyy-MM-dd") + "'";
            ds = db.getDataSet(sqlquery);
            GridView_Thu.DataSource = ds.Tables[0];
            DataBindings(ds);
            float kq = TinhTong(ds);
            txtTongTien.Text = kq.ToString();
            txtSoDu.Text = LaySoDu(taikhoan, mavi).ToString();
            return ds;
        }

        //Lọc
        DataSet GridView_Loc()
        {
            DBConnect db = new DBConnect();
            string sqlquery = "";
            sqlquery = "select MaThu,Ngay,SoTien,GhiChu,DanhMuc.TenDanhMuc,TenVi from Thu,DanhMuc,Vi where  Thu.TaiKhoan='" + taikhoan + "' AND Thu.MaDanhMuc = DanhMuc.MaDanhMuc AND Thu.MaVi=Vi.MaVi AND Ngay='" + PickTime2.Value.ToString("yyyy-MM-dd") + "'";
            dt = db.getDataSet(sqlquery);
            GridView_Thu.DataSource = dt.Tables[0];
            DataBindings(dt);
            float kq = TinhTong(dt);
            txtTongTien.Text = kq.ToString();
            return dt;
        }

        private void PickTime2_ValueChanged(object sender, EventArgs e)
        {
            GridView_Loc();
        }

        private void cbDanhMuc2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();
            if (cbDanhMuc2.SelectedValue == null) return;
            string selectCb = cbDanhMuc2.SelectedValue.ToString();
            if (selectCb == "")
            {
                string sqlquery = "select MaThu,TenVi,SoTien,Ngay,DanhMuc.TenDanhMuc,GhiChu from Thu,DanhMuc,Vi where Thu.TaiKhoan='" + taikhoan + "' AND Thu.MaVi=Vi.MaVi AND DanhMuc.MaDanhMuc = Thu.MaDanhMuc AND  Ngay='" + PickTime2.Value.ToString("yyyy-MM-dd") + "'";
                dt = db.getDataSet(sqlquery);
            }
            else
            {
                string sqlquery = "select MaThu,TenVi,SoTien,Ngay,DanhMuc.TenDanhMuc,GhiChu from Thu,DanhMuc,Vi where Thu.TaiKhoan='" + taikhoan + "' AND Thu.MaVi=Vi.MaVi AND DanhMuc.MaDanhMuc = Thu.MaDanhMuc AND  Ngay='" + PickTime2.Value.ToString("yyyy-MM-dd") + "' AND Thu.MaDanhMuc='" + cbDanhMuc2.SelectedValue + "'";
                dt = db.getDataSet(sqlquery);

            }
            GridView_Thu.DataSource = dt.Tables[0];
            DataBindings(dt);
        }

        void DataBindings(DataSet ds)
        {
            txtMaThu.DataBindings.Clear();
            txtTien.DataBindings.Clear();
            PickTime1.DataBindings.Clear();
            cbDanhMuc.DataBindings.Clear();
            txtGhiChu.DataBindings.Clear();
            txtMaThu.DataBindings.Add("Text", ds.Tables[0], "MaThu");
            txtTien.DataBindings.Add("Text", ds.Tables[0], "SoTien");
            PickTime1.DataBindings.Add("Text", ds.Tables[0], "Ngay");
            cbDanhMuc.DataBindings.Add("Text", ds.Tables[0], "TenDanhMuc");
            txtGhiChu.DataBindings.Add("Text", ds.Tables[0], "GhiChu");
        }
        private void GridView_Thu_SelectionChanged(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
            bntXoa.Enabled = true;
        }
        bool XetTextBoxDeTrong()
        {
            return !this.Controls.OfType<TextBox>().Any(txt => txt.Text.Length == 0);
        }

        //Thêm,Xóa,Sửa
        //Thêm
        private void bntThem_Click(object sender, EventArgs e)
        {
            if (!XetTextBoxDeTrong())
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu");
                return;
            }
            DBConnect db = new DBConnect();
            if (txtTien.Text.Trim().Length > 0)
            {
                string mathu = TaoMaThuTuDong();
                string chuoitruyvan = "insert into Thu values (N'" + mathu + "','" + decimal.Parse(txtTien.Text) + "', '" + PickTime1.Value.ToString("yyyy-MM-dd") + "', N'" + txtGhiChu.Text + "','" + cbDanhMuc.SelectedValue + "','" + mavi + "','" + taikhoan + "')";
                int kq = db.getNonQuery(chuoitruyvan);
                CongTienThuVaoVi(taikhoan, mavi, decimal.Parse(txtTien.Text));
                txtSoDu.Text = LaySoDu(taikhoan, mavi).ToString();
                if (kq == 1)
                {
                    MessageBox.Show("Thêm dữ liệu thành công !!");
                    GridView_DSThu();
                }
                else
                {
                    MessageBox.Show("Thêm dữ liệu không thành công !!");
                }
            }
        }


        //Xóa
        private void bntXoa_Click(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();
            string maThuXoa = txtMaThu.Text;
            bool KetQua = TruTienThuKhoiVi(taikhoan, mavi, decimal.Parse(txtTien.Text));
            if (KetQua) //nếu ví hợp lệ 
            {
                string chuoitruyvan = "delete Thu where MaThu='" + txtMaThu.Text + "'";
                int tv = db.getNonQuery(chuoitruyvan);
                if (tv == 1)
                {
                    int kq= ThucHienDoiMaThu(maThuXoa);
                    if (kq ==1)
                    {
                        MessageBox.Show("Xóa dữ liệu thành công !!");
                        GridView_DSThu();
                    } 
                }    
            }
            else
            {
                MessageBox.Show("Xóa dữ liệu không thành công !!");
            }
        }
        int ThucHienDoiMaThu(string maThuXoa)
        {
            DBConnect db = new DBConnect();
            string sql1 = "select TOP 1 MaThu from Thu ORDER BY MaThu DESC";
            DataSet dt = db.getDataSet(sql1);
            string maThuCuoi = dt.Tables[0].Rows[0]["MaThu"].ToString();
            string sql2 = "update Thu set MaThu='" + maThuXoa + "' where MaThu='" + maThuCuoi + "'";
            int tv = db.getNonQuery(sql2);
            return tv;
        }

        //Sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!XetTextBoxDeTrong())
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu");
                return;
            }
            DBConnect db = new DBConnect();
            //xét ví
            bool KetQua = SuaTienThuTrongVi(taikhoan, mavi, txtMaThu.Text, decimal.Parse(txtTien.Text));
            if (KetQua) //nếu ví hợp lệ 
            {
                string chuoitruyvan = "update Thu set SoTien='" + decimal.Parse(txtTien.Text) + "', Ngay= '" + PickTime1.Value.ToString("yyyy-MM-dd") + "', MaDanhMuc='" + cbDanhMuc.SelectedValue + "' ,GhiChu= N'" + txtGhiChu.Text + "' where MaThu ='" + txtMaThu.Text + "'";
                int tv = db.getNonQuery(chuoitruyvan);
                if (tv == 1)
                {
                    MessageBox.Show("Sửa dữ liệu thành công !!");
                    GridView_DSThu();
                }
            }
            else
            {
                GridView_DSThu();
                MessageBox.Show("Sửa dữ liệu không thành công !!");
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Chi form = new Chi(taikhoan);
            form.ShowDialog();
        }

        private void txtTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                string message = "Chỉ được nhập số";
                string title = "Thông báo";
                MessageBox.Show(message, title);
            }
        }

        private void Thu_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            { e.Cancel = true; }
            else
            {
                this.Hide();
            }
        }
    }
}
