using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;

namespace FormHtml.Models
{
    public class ResponseData
    {
        string connection = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;

        public void Insert(string TEXT)
        {
            string sql = "EXEC Insert_Html N'" + TEXT + "'";
            SqlConnection conn = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }

    }
}