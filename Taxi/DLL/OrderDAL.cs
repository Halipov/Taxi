using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taxi.BLL;

namespace Taxi.DLL
{
    class OrderDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        public bool StatusChange(OrderBLL u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "UPDATE Users SET status = @status, cost = @cost, distance = @distance, add_from = @from, add_to = @to WHERE contact = @contact";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@contact", u.contact);
                cmd.Parameters.AddWithValue("@status", u.status);
                cmd.Parameters.AddWithValue("@cost", u.cost);
                cmd.Parameters.AddWithValue("@distance", u.distance);
                cmd.Parameters.AddWithValue("@from", u.from);
                cmd.Parameters.AddWithValue("@to", u.to);
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
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
