using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace TriggerForm
{
    public static class Commons
    {
        public static string WORKINGPATH = $"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName}\\";
        public static string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + WORKINGPATH + @"Driver.mdf;Integrated Security=True";
        public static void Query(string sql)
        {
            var con = new SqlConnection(CONNECTION_STRING);
            con.Open();

            var cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();

            con.Close();
        }

        public static object isNull(this TextBox control)
        {
            if(string.IsNullOrEmpty(control.Text) || string.IsNullOrWhiteSpace(control.Text))
            {
                return "NULL";
            }
            else
            {
                return $"'{control.Text}'";
            }
        }
    }
}
