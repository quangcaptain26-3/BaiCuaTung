using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenBaTung98880
{
    internal class Database
    {
        private static string connect =
            @"Data Source=LAPTOP-SMSO4FMT\SQLEXPRESS;Initial Catalog=NguyenBaTung_98880_3;Integrated Security=True;";
        public static DataTable Query(string sql)
        {
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            adapter.Fill(dt);
            con.Close();
            return dt;
        }
        public static DataTable Query(string sql, Dictionary<string, object> dic)
        {
            SqlConnection con = new SqlConnection(connect);

            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            foreach (string key in dic.Keys)
            {
                adapter.SelectCommand.Parameters.AddWithValue(key, dic[key]);
            }
            adapter.Fill(dt);
            con.Close();
            return dt;
        }
        public static void Execute(string sql)
        {
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
        }
        public static void Execute(string sql, Dictionary<string, object> dic)
        {
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            foreach (string key in dic.Keys)
            {
                cmd.Parameters.AddWithValue(key, dic[key]);
            }
            cmd.ExecuteNonQuery();
        }
    }
}
