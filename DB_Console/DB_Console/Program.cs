using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DB_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string conString = @"Server=WINDOWS-EKS4LMU\SQLEXPRESS;Database=Demo;User Id=sa; Password=Talha1998;";
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            /*string query = "insert into Info values ('Talha','1121','Admin')";
            SqlCommand cmd = new SqlCommand(query,con);
            int row_affected = cmd.ExecuteNonQuery();
            if(row_affected>0)
            {
                Console.WriteLine("Successfully added");
            }
            else
            {
                Console.WriteLine("Not added");
            }
            con.Close();
            */
            string query = "select * from Info";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            Console.WriteLine("Id\tName\t\tType");
            while(reader.Read())
            {
                //long id = reader.GetInt64(0);
                string uname = reader.GetString(1);
                string type = reader.GetString(3);
                Console.WriteLine("{0}\t{1}", uname, type);
            }
               con.Close();

        }
    }
}
