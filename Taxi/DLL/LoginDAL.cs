using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taxi.BLL;

namespace Taxi.DLL
{
    class LoginDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        public int isSuccess = 0;
        public static string car_number;
        public static string car_class;
        public int loginCheck(LoginBLL l)
        {
            
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "SELECT * FROM users WHERE contact=@contact AND password=@password";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@contact", l.contact);
                cmd.Parameters.AddWithValue("@password", l.password);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                conn.Open();
                adapter.Fill(dt);   

                if(dt.Rows.Count>0)
                {
                    isSuccess = 1;
                }
                else

                {
                    string sql2 = "SELECT * FROM Taxi WHERE contact=@contact2 AND password=@password2";
                    SqlCommand cmd2 = new SqlCommand(sql2, conn);

                    cmd2.Parameters.AddWithValue("@contact2", l.contact);
                    cmd2.Parameters.AddWithValue("@password2", l.password);

                    SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);

                    DataTable dt2 = new DataTable();
                    adapter2.Fill(dt2);
                    if (dt2.Rows.Count > 0)
                    {
                        isSuccess = 2;
                    }
                    else
                    {
                        isSuccess = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            
            return isSuccess;
        }
        public string login_user(LoginBLL l)
        {
            string user_name = "";
            SqlConnection conn = new SqlConnection(myconnstrng);
            conn.Open();
           
           if (isSuccess == 1)
           {
                string query = "SELECT * FROM Users WHERE contact = @contact";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@contact", l.contact);
                SqlDataReader reader = command.ExecuteReader();
                user_name = reader["first_Name"].ToString();
           }
                
            if (isSuccess == 2)
            {
                string query = "SELECT * FROM Taxi WHERE contact = @contact";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@contact", l.contact);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    user_name = reader["name"].ToString();
                    car_number = reader["car_number"].ToString();
                    car_class = reader["class"].ToString();
                }
            }
            return user_name;
        }
    }
}
