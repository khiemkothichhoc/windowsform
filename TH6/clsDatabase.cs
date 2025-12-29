using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thuchanh6
{
    public class clsDatabase
    {
        string chuoikn = @"Data Source=khiemmini\\SQLEXPRESS;Initial Catalog=CongNgheNET;User ID=sa;Password=123";
        public SqlConnection conn;
        public SqlDataAdapter da;
        public DataTable dt;
        public void KetNoi()
        {
            conn = new SqlConnection();
            conn.ConnectionString = chuoikn;
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void NgatKetNoi()
        {
            conn = new SqlConnection(chuoikn);
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        public DataTable table(string query)
        {
            da = new SqlDataAdapter(query, conn);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}
