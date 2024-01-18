using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Windows.Forms;

namespace BaiCuoiKyDB
{
    public partial class Chi : Form
    {
        //public Chi()
        //{
        //    InitializeComponent();
        //}
        string taikhoan = "";
        string mavi = "Vi_TD";
        public object BindingMode { get; private set; }
        public Chi(string taikhoan)
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
        private void Chi_Load(object sender, EventArgs e)
        {
            //Mặc định ban đầu
            txtMaChi.Enabled = false;
            btnSua.Enabled = false;
            bntXoa.Enabled = false;
            PickTime1.Value = DateTime.Now;
            PickTime2.Value = DateTime.Now;
            //Load Cmb
            LoadcbBoxDanhMuc(cbDanhMuc, loai);
            loai = 2;
            LoadcbBoxDanhMuc(cbDanhMuc2, loai);
            //Tạo mã Chi ban đầu
            txtMaChi.Text = TaoMaChiTuDong();
            //Clear dữ liệu
            txtTien.Clear();
            txtGhiChu.Clear();
            //lấy số dư ví hiện tại
            txtSoDu.Text = LaySoDu(taikhoan, mavi).ToString();
        }

        //Tạo mã Chi tự động
        string TaoMaChiTuDong()
        {
            DBConnect db = new DBConnect();
            string sqlquery = "";
            sqlquery = "select count(*) from Chi";
            int soDong = db.getScalar(sqlquery);
            string maChi;
            if (soDong < 9)
            {
                maChi = "Ma0" + (soDong + 1).ToString();
            }
            else
            {
                maChi = "Ma" + (soDong + 1).ToString();
            }
            return maChi;
        }
        bool XetTextBoxDeTrong()
        {
            return !this.Controls.OfType<TextBox>().Any(txt => txt.Text.Length == 0);
        }


        //Thống kê tiền hiển thị ở GridView
        float TinhTong(DataSet data)
        {
            DBConnect db = new DBConnect();
            float Tong = 0;
            int i = 0;
            while (i < data.Tables[0].Rows.Count)
            {
                float value = float.Parse(GridView_Chi.Rows[i].Cells[2].Value.ToString());
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
                string sqlQuery = "SELECT SoTien FROM SoDu WHERE TaiKhoan = @TaiKhoan AND MaVi = @MaVi";
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

        //Truy xuất tiền theo mã Chi
        public decimal SoTienHT_Chi(string maChi)
        {
            using (SqlConnection connection = new SqlConnection(DBConnect.chuoiketnoi))
            {
                connection.Open();
                string sqlquery = "select SoTien from Chi where MaChi='" + maChi + "'";
                SqlCommand cmd = new SqlCommand(sqlquery, connection);
                decimal SoTienChiHT = (decimal)cmd.ExecuteScalar(); //số tiền đơn đó
                return SoTienChiHT;
            }
        }


        //Xóa tiền Chi (tiền thêm vào ví)
        public void CongTienChiVaoVi(string taikhoan, string maVi, decimal soTienChi)
        {
            using (SqlConnection connection = new SqlConnection(DBConnect.chuoiketnoi))
            {
                connection.Open();

                // Truy xuất số dư ví hiện tại
                decimal soDuHienTai = LaySoDu(taikhoan, maVi);

                // Thực hiện phép cộng
                decimal soDuMoi = soDuHienTai + soTienChi;

                // Cập nhật số dư mới vào cơ sở dữ liệu
                CapNhatVi(taikhoan, maVi, soDuMoi);
            }
        }

        //Thêm tiền Chi (trừ tiền khỏi ví)
        public bool TruTienChiKhoiVi(string taikhoan, string maVi, decimal soTienChi)
        {
            using (SqlConnection connection = new SqlConnection(DBConnect.chuoiketnoi))
            {
                connection.Open();
                // Truy xuất số dư ví hiện tại
                decimal soDuHienTai = LaySoDu(taikhoan, maVi);
                // Thực hiện phép trừ
                decimal soDuMoi = soDuHienTai;
                if (soTienChi <= soDuHienTai)
                {
                    soDuMoi = soDuHienTai - soTienChi;
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

        //Sửa tiền Chi (thay đổi tiền ví)
        public bool SuaTienChiTrongVi(string taikhoan, string maVi, string maChi, decimal soTienChiMoi)
        {
            using (SqlConnection connection = new SqlConnection(DBConnect.chuoiketnoi))
            {
                connection.Open();
                // Truy xuất số dư ví hiện tại
                decimal soDuHienTai = LaySoDu(taikhoan, maVi);
                //Truy xuất số tiền hiện tại của mã Chi được chọn
                decimal SoTienChiHT = SoTienHT_Chi(maChi);
                decimal KhoanTienThayDoi;
                decimal soDuMoi = soDuHienTai;
                //So sánh tiền mới, tiền hiện tại
                bool Giam = false;
                if (soTienChiMoi <= SoTienChiHT)  // số tiền Chi mới bé hơn tiền Chi hiện tại => tiền ví bị tăng lên
                {
                    KhoanTienThayDoi = SoTienChiHT - soTienChiMoi;
                    soDuMoi = soDuHienTai + KhoanTienThayDoi;
                }
                else
                {
                    KhoanTienThayDoi = soTienChiMoi - SoTienChiHT;//số tiền Chi mới lớn hơn tiền Chi hiện tại => tiền giảm xuống
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
        private void Chi_FormClosing(object sender, FormClosingEventArgs e)
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
            string sqlquery = "select * from DanhMuc where substring(MaDanhMuc,1,1)='C'";
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
        DataSet GridView_DSChi()
        {
            DBConnect db = new DBConnect();
            string sqlquery = "";
            sqlquery = "select MaChi,Ngay,SoTien,GhiChu,TenDanhMuc,TenVi from Chi,DanhMuc,Vi where Chi.TaiKhoan='" + taikhoan + "' AND Chi.MaDanhMuc = DanhMuc.MaDanhMuc AND Chi.MaVi=Vi.MaVi AND Ngay='" + PickTime1.Value.ToString("yyyy-MM-dd") + "'";
            ds = db.getDataSet(sqlquery);
            GridView_Chi.DataSource = ds.Tables[0];
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
            sqlquery = "select MaChi,Ngay,SoTien,GhiChu,DanhMuc.TenDanhMuc,TenVi from Chi,DanhMuc,Vi where  Chi.TaiKhoan='" + taikhoan + "' AND Chi.MaDanhMuc = DanhMuc.MaDanhMuc AND Chi.MaVi=Vi.MaVi AND Ngay='" + PickTime2.Value.ToString("yyyy-MM-dd") + "'";
            dt = db.getDataSet(sqlquery);
            GridView_Chi.DataSource = dt.Tables[0];
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
                string sqlquery = "select MaChi,TenVi,SoTien,Ngay,DanhMuc.TenDanhMuc,GhiChu from Chi,DanhMuc,Vi where Chi.TaiKhoan='" + taikhoan + "' AND Chi.MaVi=Vi.MaVi AND DanhMuc.MaDanhMuc = Chi.MaDanhMuc AND  Ngay='" + PickTime2.Value.ToString("yyyy-MM-dd") + "'";
                dt = db.getDataSet(sqlquery);
            }
            else
            {
                string sqlquery = "select MaChi,TenVi,SoTien,Ngay,DanhMuc.TenDanhMuc,GhiChu from Chi,DanhMuc,Vi where Chi.TaiKhoan='" + taikhoan + "' AND Chi.MaVi=Vi.MaVi AND DanhMuc.MaDanhMuc = Chi.MaDanhMuc AND  Ngay='" + PickTime2.Value.ToString("yyyy-MM-dd") + "' AND Chi.MaDanhMuc='" + cbDanhMuc2.SelectedValue + "'";
                dt = db.getDataSet(sqlquery);

            }
            GridView_Chi.DataSource = dt.Tables[0];
            DataBindings(dt);
        }

        void DataBindings(DataSet ds)
        {
            txtMaChi.DataBindings.Clear();
            txtTien.DataBindings.Clear();
            PickTime1.DataBindings.Clear();
            cbDanhMuc.DataBindings.Clear();
            txtGhiChu.DataBindings.Clear();
            txtMaChi.DataBindings.Add("Text", ds.Tables[0], "MaChi");
            txtTien.DataBindings.Add("Text", ds.Tables[0], "SoTien");
            PickTime1.DataBindings.Add("Text", ds.Tables[0], "Ngay");
            cbDanhMuc.DataBindings.Add("Text", ds.Tables[0], "TenDanhMuc");
            txtGhiChu.DataBindings.Add("Text", ds.Tables[0], "GhiChu");
        }
        private void GridView_Chi_SelectionChanged(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
            bntXoa.Enabled = true;
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
            bool KetQua = TruTienChiKhoiVi(taikhoan, mavi, decimal.Parse(txtTien.Text));
            if (KetQua) //nếu ví hợp lệ 
            {
                string maChi = TaoMaChiTuDong();
                string chuoitruyvan = "insert into Chi values (N'" + maChi + "','" + decimal.Parse(txtTien.Text) + "', '" + PickTime1.Value.ToString("yyyy-MM-dd") + "', N'" + txtGhiChu.Text + "','" + cbDanhMuc.SelectedValue + "','" + mavi + "','" + taikhoan + "')";
                int kq = db.getNonQuery(chuoitruyvan);
                if (kq == 1)
                {
                    MessageBox.Show("Thêm dữ liệu thành công !!");
                    GridView_DSChi();
                }
            }
            else
            {
                MessageBox.Show("Thêm dữ liệu không thành công !!");
            }
        }

        //Xóa
        private void bntXoa_Click(object sender, EventArgs e)
        {
            DBConnect db = new DBConnect();
            string maChiXoa = txtMaChi.Text;
            CongTienChiVaoVi(taikhoan, mavi, decimal.Parse(txtTien.Text));
            string chuoitruyvan = "delete Chi where MaChi='" + txtMaChi.Text + "'";
            int tv = db.getNonQuery(chuoitruyvan);
            if (tv == 1)
            {
                int kq =  ThucHienDoiMaChi(maChiXoa);
                if (kq ==1 )
                {
                    MessageBox.Show("Xóa dữ liệu thành công !!");
                    GridView_DSChi();
                }    
            }
            else
            {
                MessageBox.Show("Xóa dữ liệu không thành công !!");
            }
     
        }

        int ThucHienDoiMaChi(string maChiXoa)
        {
            DBConnect db = new DBConnect();
            string sql1 = "select TOP 1 MaChi from Chi ORDER BY MaChi DESC";
            DataSet dt = db.getDataSet(sql1);
            string maChiCuoi = dt.Tables[0].Rows[0]["MaChi"].ToString();
            string sql2 = "update Chi set MaChi='" + maChiXoa + "' where MaChi='" + maChiCuoi + "'";
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
            bool KetQua = SuaTienChiTrongVi(taikhoan, mavi, txtMaChi.Text, decimal.Parse(txtTien.Text));
            if (KetQua) //nếu ví hợp lệ 
            {
                string chuoitruyvan = "update Chi set SoTien='" + float.Parse(txtTien.Text) + "', Ngay= '" + PickTime1.Value.ToString("yyyy-MM-dd") + "', MaDanhMuc='" + cbDanhMuc.SelectedValue + "' ,GhiChu= N'" + txtGhiChu.Text + "' where MaChi ='" + txtMaChi.Text + "'";
                int tv = db.getNonQuery(chuoitruyvan);
                if (tv == 1)
                {
                    MessageBox.Show("Sửa dữ liệu thành công !!");
                    GridView_DSChi();
                }
            }
            else
            {
                GridView_DSChi();
                MessageBox.Show("Sửa dữ liệu không thành công !!");
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thu form =new Thu(taikhoan);
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

        private void Chi_FormClosing_1(object sender, FormClosingEventArgs e)
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