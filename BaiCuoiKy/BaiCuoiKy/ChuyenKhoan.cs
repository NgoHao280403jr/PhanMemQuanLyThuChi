using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiCuoiKyDB
{
    public partial class ChuyenKhoan : Form
    {
        string taikhoan = "";
        //public ChuyenKhoan()
        //{
        //    InitializeComponent();
        //}

        public ChuyenKhoan(string taikhoan)
        {
            InitializeComponent();
            this.taikhoan = taikhoan;
        }

        DataSet dt;
        DataSet dscb;
        DataSet ds;
        private void ChuyenKhoan_Load(object sender, EventArgs e)
        {
            LoadcbBoxVi(cbViChuyen);
            LoadcbBoxVi(cbViNhan);
            PickTime1.Value = DateTime.Now;
            txtSoDuHT.Enabled = false;
            txtGhiChu.Enabled = false;
            txtSoDuHT.Text = "0";
        }
        void LoadcbBoxVi(ComboBox cb)
        {
            DBConnect db = new DBConnect();
            string sqlquery = "select * from Vi inner join SoDu on Vi.MaVi=SoDu.MaVi where SoDu.TaiKhoan= '"+taikhoan+"'";
            dscb = db.getDataSet(sqlquery);
            cb.DataSource = dscb.Tables[0];
            cb.DisplayMember = "TenVi";
            cb.ValueMember = "MaVi";
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
        //Xem/Lấy số dư hiện tại
        public decimal LaySoDu(string taikhoan, string maVi)
        {
            using (SqlConnection connection = new SqlConnection(DBConnect.chuoiketnoi))
            {
                connection.Open();
                string sqlQuery = "SELECT SoTien FROM SoDu WHERE TaiKhoan = @TaiKhoan and MaVi =@MaVi ";
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
                    MessageBox.Show("Số dư Ví không đủ để chuyển");
                    return false;
                }
                //Cập nhật số dư ví 
                CapNhatVi(taikhoan, maVi, soDuMoi);
                return true;
            }
        }
        bool XetTextBoxDeTrong()
        {
            return !this.Controls.OfType<TextBox>().Any(txt => txt.Text.Length == 0);
        }

        private void ChuyenTienHaiVi(string taikhoan)
        {
            if (!XetTextBoxDeTrong())
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu");
                return;
            }
            DBConnect db = new DBConnect();
            string danhmucthu = "T_K";
            string danhmucchi = "C_K";
            string mathu = TaoMaThuTuDong();
            string maChi = TaoMaChiTuDong();
            if(cbViChuyen.SelectedValue.ToString() != cbViNhan.SelectedValue.ToString())
            {
                bool KetQua = TruTienThuKhoiVi(taikhoan, cbViChuyen.SelectedValue.ToString(), decimal.Parse(txtSoTienChuyen.Text));
                if (KetQua)
                {
                    CongTienThuVaoVi(taikhoan, cbViNhan.SelectedValue.ToString(), decimal.Parse(txtSoTienChuyen.Text));
                    string chuoitruyvan1 = "insert into Thu values (N'" + mathu + "','" + decimal.Parse(txtSoTienChuyen.Text) + "', '" + PickTime1.Value.ToString("yyyy-MM-dd") + "', N'" + txtGhiChu.Text + "','" + danhmucthu + "','" + cbViNhan.SelectedValue + "','" + taikhoan + "')";
                    int kq1 = db.getNonQuery(chuoitruyvan1);
                    string chuoitruyvan2 = "insert into Chi values (N'" + maChi + "','" + decimal.Parse(txtSoTienChuyen.Text) + "', '" + PickTime1.Value.ToString("yyyy-MM-dd") + "', N'" + txtGhiChu.Text + "','" + danhmucchi + "','" + cbViChuyen.SelectedValue + "','" + taikhoan + "')";
                    int kq2 = db.getNonQuery(chuoitruyvan2);
                    if (kq1 == 1 && kq2 == 1)
                    {
                        txtSoDuHT.Text = LaySoDu(taikhoan, cbViChuyen.SelectedValue.ToString()).ToString();
                        MessageBox.Show("Chuyển khoản thành công !!");
                        txtSoTienChuyen.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Chuyển khoản không thành công !!");
                }
            }
            else
            {
                MessageBox.Show("Trùng ví không thể chuyển khoản");
            }    
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ChuyenTienHaiVi(taikhoan);
        }

        private void cbViChuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSoDuHT.Text = LaySoDu(taikhoan, cbViChuyen.SelectedValue.ToString()).ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyVi form = new QuanLyVi(taikhoan);
            form.ShowDialog();
        }

        private void txtSoTienChuyen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                string message = "Chỉ được nhập số";
                string title = "Thông báo";
                MessageBox.Show(message, title);
            }
        }

        private void ChuyenKhoan_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            { e.Cancel = true; }
        }
    }
}