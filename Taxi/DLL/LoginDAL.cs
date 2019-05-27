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
        
        public int loginCheck(LoginBLL l)
        {
            int isSuccess = 0;
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
    }
}
