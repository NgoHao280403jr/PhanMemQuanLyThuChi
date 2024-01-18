using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Giao_DiệnXML
{
    public partial class Form : System.Windows.Forms.Form
    {
        private string userName;
        SqlConnection connsql = new SqlConnection("Data Source = DESKTOP-1SP23K9; Initial Catalog = QLThuChi; Integrated Security = True");
        public Form()
        {
            InitializeComponent();
            loadData();
        }
        public Form(string user)
        {
            InitializeComponent();
            this.userName = user;
            loadData();
        }
        //private void button_trangchu_Click(object sender, EventArgs e)
        //{
        //    tabControl.SelectedTab = tabPage_home;
        //}

        private void button_thu_Click(object sender, EventArgs e)
        {
            BaiCuoiKyDB.Thu thu = new BaiCuoiKyDB.Thu(userName);
            DialogResult selectButton = thu.ShowDialog();

        }

        private void button_chi_Click(object sender, EventArgs e)
        {
            BaiCuoiKyDB.Chi chi = new BaiCuoiKyDB.Chi(userName);
            DialogResult selectButton = chi.ShowDialog();
        }

        private void button_detailThuChi_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPage_showThuChi;
            dataGridView_thu.DataSource = Thu_reports().Tables[0];
            dataGridView_chi.DataSource = Chi_reports().Tables[0];
        }

        DataSet Thu_reports()
        {
            if (connsql.State == ConnectionState.Closed)
            {
                connsql.Open();
            }
            
            DataSet data = new DataSet();
            string sql_dataGridView = "SELECT DanhMuc.TenDanhMuc, Thu.SoTien, Thu.Ngay, Vi.TenVi, Thu.GhiChu FROM Thu "+
                "INNER JOIN DanhMuc ON Thu.MaDanhMuc = DanhMuc.MaDanhMuc " +
                "INNER JOIN Vi ON Thu.MaVi = Vi.MaVi " +
                "WHERE Thu.TaiKhoan = '" + userName + "' ORDER BY Thu.Ngay DESC";
            using (SqlCommand cmd_DataGridView = new SqlCommand(sql_dataGridView, connsql))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd_DataGridView);
                adapter.Fill(data);
            }
            return data;
        }

        DataSet Chi_reports()
        {
            if (connsql.State == ConnectionState.Closed)
            {
                connsql.Open();
            }

            DataSet data = new DataSet();
            string sql_dataGridView = "SELECT DanhMuc.TenDanhMuc, Chi.SoTien, Chi.Ngay, Vi.TenVi, Chi.GhiChu FROM Chi " +
                "INNER JOIN DanhMuc ON Chi.MaDanhMuc = DanhMuc.MaDanhMuc " +
                "INNER JOIN Vi ON Chi.MaVi = Vi.MaVi " +
                "WHERE Chi.TaiKhoan = '" + userName + "' ORDER BY Chi.Ngay DESC";
            using (SqlCommand cmd_DataGridView = new SqlCommand(sql_dataGridView, connsql))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd_DataGridView);
                adapter.Fill(data);
            }
            return data;
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đóng cửa sổ không?", "Xác nhận đóng form", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //if (result == DialogResult.No)
            //{
            //    e.Cancel = true;
            //}
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void loadData()
        {
            {
                connsql.Open();

                String sql_thu = "SELECT SUM(SoTien) AS TongThu, " +
                    "MAX(SoTien) AS MaxMoney_thu," +
                    "MIN(SoTien) AS MinMoney_thu," +
                    "MAX(Ngay) AS RecentDay_thu," +
                    "COUNT(*) AS SLgd_thu " +
                    "FROM Thu WHERE TaiKhoan = '" + userName + "' group by TaiKhoan";

                String sql_chi = "SELECT SUM(SoTien) AS TongChi, " +
                    "MAX(SoTien) AS MaxMoney_chi," +
                    "MIN(SoTien) AS MinMoney_chi," +
                    "MAX(Ngay) AS RecentDay_chi," +
                    "COUNT(*) AS SLgd_chi " +
                    "FROM Chi WHERE TaiKhoan = '" + userName + "' group by TaiKhoan";

                String sql_avg_money = "SELECT((SELECT SUM(SoTien) FROM Thu WHERE TaiKhoan = '" + userName + "') " +
                    "- (SELECT SUM(SoTien) FROM Chi WHERE TaiKhoan = '" + userName + "'))AS avg_money";

                using (SqlCommand cmd_thu = new SqlCommand(sql_thu, connsql))
                {
                    using (SqlDataReader reader = cmd_thu.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            label_tien_tongthu.Text = reader["TongThu"].ToString();
                            label_gdthu.Text = reader["SLgd_thu"].ToString();
                            label_maxThu.Text = reader["MaxMoney_thu"].ToString();
                            label_minThu.Text = reader["MinMoney_thu"].ToString();
                            label_lastThu.Text = reader["RecentDay_thu"].ToString();
                        }
                    }
                }

                using (SqlCommand cmd_chi = new SqlCommand(sql_chi, connsql))
                {
                    using (SqlDataReader reader = cmd_chi.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            label_tien_tongchi.Text = reader["TongChi"].ToString();
                            label_gdchi.Text = reader["SLgd_chi"].ToString();
                            label_maxChi.Text = reader["MaxMoney_chi"].ToString();
                            label_minChi.Text = reader["MinMoney_chi"].ToString();
                            label_lastChi.Text = reader["RecentDay_chi"].ToString();
                        }
                    }
                }

                using (SqlCommand cmd_avg_money = new SqlCommand(sql_avg_money, connsql))
                {
                    using (SqlDataReader reader = cmd_avg_money.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            label_trungbinh.Text = reader["avg_money"].ToString();
                        }    
                    }
                }
            }

        }

        private void Form_Load(object sender, EventArgs e)
        {
            label_account.Text = userName;
        }

        private void button_QuanLyVi_Click(object sender, EventArgs e)
        {
            BaiCuoiKyDB.QuanLyVi quanLyVi = new BaiCuoiKyDB.QuanLyVi(userName);
            DialogResult selectButton = quanLyVi.ShowDialog();
        }

        private void button_trangchu_Click(object sender, EventArgs e)
        {
            this.Close();
            Form form = new Form(userName);
            form.ShowDialog();
        }
    }
        
}
