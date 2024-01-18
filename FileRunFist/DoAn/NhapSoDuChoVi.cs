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
    public partial class NhapSoDuChoVi : Form
    {
        private string TenUser;
        public NhapSoDuChoVi()
        {
            InitializeComponent();
        }
        public NhapSoDuChoVi(string user)
        {
            InitializeComponent();
            this.TenUser = user;
        }
        Modify modify = new Modify();
        private void button1_Click(object sender, EventArgs e)
        {
            if(decimal.Parse(textBox1.Text)>=0&&decimal.Parse(textBox2.Text)>=0)
            {
                string MaVi_TD = "Vi_TD";
                string MaVi_TK = "Vi_TK";
                string query = "Insert into SoDu values('" + MaVi_TD + "','" + TenUser + "','" + textBox1.Text + "')";
                string query1 = "Insert into SoDu values('" + MaVi_TK + "','" + TenUser + "','" + textBox2.Text + "')";
                modify.Command(query);
                modify.Command(query1);
                this.Close();
                Giao_DiệnXML.Form form = new Giao_DiệnXML.Form(TenUser);
                DialogResult selectButton = form.ShowDialog();
            }    
           else
            {
                MessageBox.Show("Tiền đưa vào ví không được âm!");
            }    

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                string message = "Chỉ được nhập số";
                string title = "Thông báo";
                MessageBox.Show(message, title);
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
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
