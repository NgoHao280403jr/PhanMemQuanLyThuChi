using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace BaiCuoiKyDB
{
    public partial class SuaSoDuVi : Form
    {

        string taikhoan = "pp";
        string mavi = "Vi_TD";
        //public SuaSoDuVi()
        //{
        //    InitializeComponent();
        //}
        public SuaSoDuVi(string taikhoan, string mavi)
        {
            InitializeComponent();
            this.taikhoan = taikhoan;
            this.mavi = mavi;
        }

        private void SuaSoDuVi_Load(object sender, EventArgs e)
        {
            PickTime1.Value = DateTime.Now;
            txtSoDuHT.Text = LaySoDu(taikhoan, mavi).ToString();
        }

        DataSet dt;
        DataSet dscb;
        DataSet ds;
        //Load ComboBox
        void LoadcbBoxDanhMuc(ComboBox cb, char text)
        {
            DBConnect db = new DBConnect();
            string sqlquery = "select * from DanhMuc where substring(MaDanhMuc,1,1)='" + text + "'";
            dscb = db.getDataSet(sqlquery);
            cb.DataSource = dscb.Tables[0];
            cb.DisplayMember = "TenDanhMuc";
            cb.ValueMember = "MaDanhMuc";
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
            return 0m;
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

        decimal ChenhLech = 0;
        bool Thu = true;
        private void txtSoDuMoi_TextChanged(object sender, EventArgs e)
        {
            decimal SoDuMoi = 0, SoDuHT = 0;
            if (decimal.TryParse(txtSoDuMoi.Text, out SoDuMoi))
            {
                SoDuHT = LaySoDu(taikhoan, mavi);

                if (SoDuMoi >= SoDuHT)
                {
                    LoadcbBoxDanhMuc(cbDanhMuc, 'T');
                    ChenhLech = SoDuMoi - SoDuHT;
                    txtChenhLech.Text = ChenhLech.ToString();
                    Thu = true;
                }
                else
                {
                    LoadcbBoxDanhMuc(cbDanhMuc, 'C');
                    ChenhLech = SoDuHT - SoDuMoi;
                    txtChenhLech.Text = "-" + ChenhLech.ToString();
                    Thu = false;
                }
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
                //Cập nhật số dư ví 
                CapNhatVi(taikhoan, maVi, soDuMoi);
                return true;
            }
        }

        //Tạo mã Thu tự động
        string TaoMaThuTuDong()
        {
            DBConnect db = new DBConnect();
            string sqlquery = "";
            sqlquery = "select count(*) from Thu";
            int soDong = db.getScalar(sqlquery);
            string mathu;
            if (soDong < 10)
            {
                mathu = "Ma0" + (soDong + 1).ToString();
            }
            else
            {
                mathu = "Ma" + (soDong + 1).ToString();
            }
            return mathu;
        }
        //Tạo mã Chi tự động
        string TaoMaChiTuDong()
        {
            DBConnect db = new DBConnect();
            string sqlquery = "";
            sqlquery = "select count(*) from Chi";
            int soDong = db.getScalar(sqlquery);
            string maChi;
            if (soDong < 10)
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

        //Lưu số dư mới
        private void bntLuu_Click(object sender, EventArgs e)
        {
            if (!XetTextBoxDeTrong())
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu");
                return;
            }
            DBConnect db = new DBConnect();
            string chuoitruyvan = "";
            int kq = 0;
            if (Thu)
            {
                string mathu = TaoMaThuTuDong();
                CongTienThuVaoVi(taikhoan, mavi, ChenhLech);
                chuoitruyvan = "insert into Thu values (N'" + mathu + "','" + ChenhLech + "', '" + PickTime1.Value.ToString("yyyy-MM-dd") + "', N'" + txtGhiChu.Text + "','" + cbDanhMuc.SelectedValue + "','" + mavi + "','" + taikhoan + "')";
                kq = db.getNonQuery(chuoitruyvan);
            }
            else
            {

                string maChi = TaoMaChiTuDong();
                TruTienThuKhoiVi(taikhoan, mavi, ChenhLech);
                chuoitruyvan = "insert into Chi values (N'" + maChi + "','" + ChenhLech + "', '" + PickTime1.Value.ToString("yyyy-MM-dd") + "', N'" + txtGhiChu.Text + "','" + cbDanhMuc.SelectedValue + "','" + mavi + "','" + taikhoan + "')";
                kq = db.getNonQuery(chuoitruyvan);
            }
            txtSoDuHT.Text = LaySoDu(taikhoan, mavi).ToString();
            if (kq == 1)
            {
                MessageBox.Show("Lưu dữ liệu thành công !!");
                txtSoDuMoi.Clear();

            }
            else
            {
                MessageBox.Show("Lưu dữ liệu không thành công !!");
                txtSoDuMoi.Clear();
            }
        }
        private void SuaSoDuVi_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            { e.Cancel = true; }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyVi form = new QuanLyVi(taikhoan);
            form.ShowDialog();
        }

        private void txtSoDuMoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                string message = "Chỉ được nhập số";
                string title = "Thông báo";
                MessageBox.Show(message, title);
            }
        }

    }
}
