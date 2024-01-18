using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class LayLaiMatKhau : Form
    {
        public LayLaiMatKhau()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        private void button_DangNhap_Click(object sender, EventArgs e)
        {
            string Gmail = textBox1.Text;
            string taiKhoan = textBox2.Text;
            string matKhau = textBox3.Text;
            string xnMatKhau = textBox4.Text;
            if (matKhau != xnMatKhau)
            {
                MessageBox.Show("Vui lòng xác nhận mật khẩu chính xác");
                return;
            }
            if (Gmail.Trim() == "" || taiKhoan.Trim() == "")
            {
                MessageBox.Show("Gmail và tài khoản không được để trống");
            }
            else
            {
                string query = "select * from TaiKhoan where Gmail='" + Gmail + "'and TaiKhoan='" + taiKhoan + "'";
                string query1 = "update TaiKhoan set MatKhau='" + matKhau + "'where Gmail='" + Gmail + "'and TaiKhoan='" + taiKhoan + "'";
                if (modify.TaiKhoans(query).Count != 0)
                {
                    modify.Command(query1);
                    if (MessageBox.Show("Đổi mật khẩu thành công! Bạn có muốn đăng nhập không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        this.Close();
                        DangNhap dangNhap = new DangNhap();
                        dangNhap.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Gmail hoặc tài khoản này chưa được đăng kí");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            DangNhap dangNhap = new DangNhap();
            dangNhap.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
