﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DBHelper
    {
        public static DataTable GetDt(string cmd)
        {
            string strConn = "data source = .; initial catalog = test; uid = sa; pwd = 31412580";
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            return dt;
        }
        public static void SetDt(string cmd)
        {
            string strConn = "data source = .; initial catalog = test; uid = sa; pwd = 31412580";
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();

            SqlCommand sc = new SqlCommand(cmd, conn);
            sc.ExecuteNonQuery();
            conn.Close();
        }
    }
}
