using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BaiCuoiKyDB
{
    public class DBConnect
    {
        public static string chuoiketnoi = "Data Source =DESKTOP-1SP23K9; Initial Catalog = QLThuChi;  Integrated Security = true";

        public SqlConnection conn = new SqlConnection();
        public SqlDataAdapter da;

        public DBConnect()
        {
            conn = new SqlConnection(chuoiketnoi);
        }
        public void Open()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void Close()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public int getNonQuery(string sqlquery)
        {
            Open();
            SqlCommand cmd = new SqlCommand(sqlquery, conn);
            int kq = cmd.ExecuteNonQuery();
            Close();
            return kq;
        }

        public DataSet getDataSet(string sqlquery)
        {
            DataSet ds = new DataSet();
            da = new SqlDataAdapter(sqlquery, conn);
            da.Fill(ds);
            return ds;
        }

        public DataTable getDataTable(string sqlquyery)
        {
            DataSet ds = new DataSet();

            da = new SqlDataAdapter(sqlquyery, conn);
            da.Fill(ds);
            return ds.Tables[0];
        }

        public int getScalar(string sqlquery)
        {
            Open();
            SqlCommand cmd = new SqlCommand(sqlquery, conn);
            int kq = (int)cmd.ExecuteScalar();
            Close();
            return kq;
        }
        public float getScalar1(string sqlquery)
        {
            Open();
            SqlCommand cmd = new SqlCommand(sqlquery, conn);
            float kq = (float)cmd.ExecuteScalar();
            Close();
            return kq;
        }
    }
}
