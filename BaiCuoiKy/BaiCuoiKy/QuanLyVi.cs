using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiCuoiKyDB
{
    public partial class QuanLyVi : Form
    {
        string taikhoan = "";
        string maVi = ""; //dùng GridView chọn maVi
        //public QuanLyVi()
        //{
        //    InitializeComponent();
        //}
        public QuanLyVi(string taikhoan)
        {
            InitializeComponent();
            this.taikhoan = taikhoan;
        }
        DataSet dt;
        DataSet ds;
        private void btn_SuaSoDu_Click(object sender, EventArgs e)
        {
            SuaSoDuVi form1 = new SuaSoDuVi(taikhoan, maVi);
            this.Hide();
            form1.ShowDialog();
        }
        private void btn_ChuyenKhoan_Click(object sender, EventArgs e)
        {
            ChuyenKhoan form2 = new ChuyenKhoan(taikhoan);
            this.Hide();
            form2.ShowDialog();
        }
        public void CapNhatVi(string taikhoan)
        {
            DBConnect db = new DBConnect();
            string sqlquery = "select * from SoDu WHERE TaiKhoan ='"+taikhoan+"'";
            db.getNonQuery(sqlquery);
        }
        DataSet GridView_DSVi()
        {
            DBConnect db = new DBConnect();
            string sqlquery = "";
            sqlquery = "select * from SoDu where TaiKhoan='" + taikhoan + "'";
            ds = db.getDataSet(sqlquery);
            GridView_Vi.DataSource = ds.Tables[0];
            return ds;
        }
        private void GridView_Vi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = GridView_Vi.Rows[e.RowIndex];
            object maViDuocChon = selectedRow.Cells["clMaVi"].Value;
            maVi = maViDuocChon.ToString();
            btn_SuaSoDu.Enabled = true;
        }

        private void QuanLyVi_Load(object sender, EventArgs e)
        {
            GridView_DSVi();
            btn_SuaSoDu.Enabled = false;
        }

        private void QuanLyVi_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            { 
                e.Cancel = true; 
            }
            else
            {
                this.Hide();
            }
        }
    }
}