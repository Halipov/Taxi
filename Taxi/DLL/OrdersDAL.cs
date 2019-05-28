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
    class OrdersDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        public bool AddOrder(OrdersBLL u)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "INSERT INTO Orders (taxi_contact, taxi_name, taxi_number, user_contact, user_name, add_from, add_to, class, distance, cost) VALUES(@taxi_contact, @taxi_name, @taxi_number, @user_contact, @user_name, @add_from, @add_to, @class, @distance, @cost) ";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@taxi_contact", u.taxi_contact);
                cmd.Parameters.AddWithValue("@taxi_name", u.taxi_name);
                cmd.Parameters.AddWithValue("@taxi_number", u.taxi_number); 
                cmd.Parameters.AddWithValue("@user_name", u.user_name);
                cmd.Parameters.AddWithValue("@user_contact", u.user_contact);
                cmd.Parameters.AddWithValue("@add_from", u.from);
                cmd.Parameters.AddWithValue("@add_to", u.to);
                cmd.Parameters.AddWithValue("@class", u._class);
                cmd.Parameters.AddWithValue("@distance", u.distance);
                cmd.Parameters.AddWithValue("@cost", u.cost);


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
