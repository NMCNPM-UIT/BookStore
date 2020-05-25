using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class DatabaseHelper
    {
        private static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Database.mdf;Integrated Security=True";
        SqlConnection Cnt;
        public DatabaseHelper()
        {
            Cnt = new SqlConnection(connectionString);
        }
        public void Insert(string ID, string Pass)
        {
            Cnt.Open();
            string sqlInsert = "INSERT INTO dbo.[Table](ID, PASSWORD) VALUES (@ID, @PASSWORD)";
            SqlCommand cmd = new SqlCommand(sqlInsert, Cnt);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@PASSWORD", Pass);
            cmd.ExecuteNonQuery();
            Cnt.Close();
        }
        public bool CheckID(String ID)
        {
            Cnt.Open();
            string sqlSelect = "Select * from  dbo.[Table];";
            SqlDataAdapter cmd = new SqlDataAdapter(sqlSelect, Cnt);
            System.Data.DataTable temp = new System.Data.DataTable();
            cmd.Fill(temp);
            for (int i = 0; i < temp.Rows.Count; i++)
                if (temp.Rows[i][0].ToString() == ID)
                {
                    Cnt.Close();
                    return true;
                }
            Cnt.Close();
            return false;
        }
        public System.Data.DataTable GetDatabase(string Sql)
        {
            Cnt.Open();
            string sqlSelect = Sql;
            SqlDataAdapter cmd = new SqlDataAdapter(sqlSelect, Cnt);
            System.Data.DataTable temp = new System.Data.DataTable();
            cmd.Fill(temp);
            Cnt.Close();
            return temp;
        }
    }
}
