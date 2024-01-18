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

namespace DoAn
{
    public partial class Home : Form
    {
       
        public Home()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        
        private void Home_Load(object sender, EventArgs e)
        {
            button_XoaUser.Enabled = false;
            LoadUserData();
        }
        private void LoadUserData()
        {
            using (SqlConnection connection = new SqlConnection(Connection.strConnection))
            {
                string query = "SELECT * From TaiKhoan where VaiTro='user'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name != "MatKhau")
            {
                // Display an error message
                MessageBox.Show("Chỉ có thể sửa mật khẩu user!");

                // Optionally, you can cancel the edit or set the focus back to the "TenSV" column
                // Uncomment the following line to cancel the edit:
                dataGridView1.CancelEdit();

                // Uncomment the following line to set the focus back to the "TenSV" column:
                dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells["MatKhau"];
                return;
            }

            // The rest of your code for updating the "TenSV" column
            DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
            string Tk = Convert.ToString(selectedRow.Cells["TaiKhoan"].Value);
            string Mk = Convert.ToString(selectedRow.Cells["MatKhau"].Value);
            string Gm = Convert.ToString(selectedRow.Cells["Gmail"].Value);
            string Vt = Convert.ToString(selectedRow.Cells["VaiTro"].Value);

            using (SqlConnection connection = new SqlConnection(Connection.strConnection))
            {
                try
                {
                    connection.Open();

                    // Update only the "TenSV" column in the database
                    string query = "UPDATE TaiKhoan SET MatKhau = @Matkhau WHERE TaiKhoan = @Taikhoan";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Taikhoan", Tk);
                    command.Parameters.AddWithValue("@Matkhau", Mk);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật thông tin user thành công!");
                        // Optionally, you can reload the data from the database and refresh the DataGridView
                        LoadUserData();
                    }
                    else
                    {
                        MessageBox.Show("Không thể cập nhật thông tin user!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật mật khẩu user: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button_XoaUser.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_XoaUser_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa user này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    string Tk = Convert.ToString(selectedRow.Cells["TaiKhoan"].Value);

                    using (SqlConnection connection = new SqlConnection(Connection.strConnection))
                    {
                        try
                        {
                            connection.Open();

                            string query = "DELETE FROM TaiKhoan WHERE TaiKhoan = @TKhoan";

                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@TKhoan", Tk);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Xóa user thành công!");
                                LoadUserData();
                            }
                            else
                            {
                                MessageBox.Show("Không thể xóa user!");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khi xóa user: " + ex.Message);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một user để xóa!");
            }
        }

        private void button_SuaPass_Click(object sender, EventArgs e)
        {

        }
    }
}
