using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace DoAn
{
    public partial class DangKi : Form
    {
        public DangKi()
        {
            InitializeComponent();
        }
        public bool checkAccount(string ac)
        {
            return Regex.IsMatch(ac,"^[a-zA-z0-9]{6,24}$");
        }
        public bool checkEmail(string em)
        {
            return Regex.IsMatch(em,@"^[a-zA-z0-9_.]{3,20}@gmail.com(.vn|)$");
        }
        Modify modify = new Modify();
       

        
        private void Button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            DangNhap dangNhap = new DangNhap();
            dangNhap.Show();


        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            
        }

        private void button_DangNhap_Click_1(object sender, EventArgs e)
        {
            string tenTK = textBox1.Text;
            string matKhau = textBox2.Text;
            string xnMatKhau = textBox3.Text;
            string email = textBox4.Text;
            string vaiTro = "user";
            
            if (!checkAccount(tenTK))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản dài từ 6 đến 24 kí tự,với kí tụ chữ hoa chữ thường và số");
                return;
            }
            if (!checkAccount(matKhau))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu dài từ 6 đến 24 kí tự,với kí tụ chữ hoa chữ thường và số");
                return;
            }
            if (matKhau != xnMatKhau)
            {
                MessageBox.Show("Vui lòng xác nhận mật khẩu chính xác");
                return;
            }
            if (!checkEmail(email))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng Email");
                return;
            }
            if (modify.TaiKhoans("Select*from TaiKhoan where Gmail='" + email + "'").Count != 0)
            {
                MessageBox.Show("Email này đã được đăng kí");
                return;
            }
            string query;
            try
            {
                
                
                query = "Insert into TaiKhoan values('" + tenTK + "','" + matKhau + "','" + email + "','" + vaiTro + "')";
                
                modify.Command(query);
                if (MessageBox.Show("Đăng kí thành công! Bạn có muốn đăng nhập không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Close();
                    DangNhap dangNhap = new DangNhap();
                    dangNhap.ShowDialog();
                }
            }
            catch
            {
                MessageBox.Show("Tên tài khoản này đã được đăng kí");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            DangNhap dangNhap = new DangNhap();
            dangNhap.Show();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox3.Focus();
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox4.Focus();
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled=true;
                string tenTK = textBox1.Text;
                
                string matKhau = textBox2.Text;
                string xnMatKhau = textBox3.Text;
                string email = textBox4.Text;
                string vaiTro = "user";
                
                if (!checkAccount(tenTK))
                {
                    MessageBox.Show("Vui lòng nhập tên tài khoản dài từ 6 đến 24 kí tự,với kí tụ chữ hoa chữ thường và số");
                    return;
                }
                if (!checkAccount(matKhau))
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu dài từ 6 đến 24 kí tự,với kí tụ chữ hoa chữ thường và số");
                    return;
                }
                if (matKhau != xnMatKhau)
                {
                    MessageBox.Show("Vui lòng xác nhận mật khẩu chính xác");
                    return;
                }
                if (!checkEmail(email))
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng Email");
                    return;
                }
                if (modify.TaiKhoans("Select*from TaiKhoan where Gmail='" + email + "'").Count != 0)
                {
                    MessageBox.Show("Email này đã được đăng kí");
                    return;
                }
                string query;
                try
                {
                    

                    query = "Insert into TaiKhoan values('" + tenTK + "','" + matKhau + "','" + email + "'," + vaiTro + ")";
                    
                    modify.Command(query);
                    if (MessageBox.Show("Đăng kí thành công! Bạn có muốn đăng nhập không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        this.Close();
                        DangNhap dangNhap = new DangNhap();
                        dangNhap.ShowDialog();
                    }
                }
                catch
                {
                    MessageBox.Show("Tên tài khoản này đã được đăng kí");
                }

            }    
        }
    }
}
