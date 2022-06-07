using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class UserSignin
    {
        public static bool Login(string password, string username)
        {
            string sPassword = "";
            string hashpassword = HashPassword.HashTo(password);

            SqlConnection sql = new SqlConnection("Data Source=up954795\\mssqlser;Initial Catalog=User;Integrated Security=True;Pooling=False");
            sql.Open();

            SqlCommand cm = new SqlCommand("select Password from UserP where UserName=@username", sql);
            cm.Parameters.AddWithValue("@username", username);

            SqlDataReader read;
            read = cm.ExecuteReader();
            if (!read.HasRows)
            {
                return false;
            }
            else
            if (read.Read())
            {
                sPassword = read["Password"].ToString().Replace(" ", "");
                if (hashpassword == sPassword)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

       
        }
    }
}
