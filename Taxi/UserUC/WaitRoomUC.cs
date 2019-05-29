using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Taxi.UserUC
{
    public partial class WaitRoomUC : UserControl
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        SqlConnection conn = new SqlConnection(myconnstrng);

        public WaitRoomUC()
        {
            InitializeComponent();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void StartWatching()
        {
            SqlDependency.Stop(myconnstrng);
            SqlDependency.Start(myconnstrng);
            WatchingQuery();
        }

        private void WatchingQuery()
        {
                conn.Open();
                using (var command = new SqlCommand(
                    "select class from dbo.Orders WHERE contact_user = @contact", conn))
                {
                    command.Parameters.AddWithValue("@contact", FormMainUser.conntact);
                    var sqlDependency = new SqlDependency(command);
                    sqlDependency.OnChange += new OnChangeEventHandler(OnDatabaseChange);
                    command.ExecuteReader();
                }
        }
        private void OnDatabaseChange(object sender, SqlNotificationEventArgs args)
        {
            SqlNotificationInfo info = args.Info;
            if (SqlNotificationInfo.Insert.Equals(info))
            {
                pictureBox.Hide();
                labelOrder.Text = "You order is accepted";

                SqlCommand myCommand = new SqlCommand("SELECT TOP 1 * FROM Orders ORDER BY order_id DESC", conn);
                SqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    labelName.Text = (myReader["taxi_name"].ToString());
                    labelContact.Text = (myReader["taxi_contact"].ToString());
                    labelCarNum.Text = (myReader["taxi_number"].ToString());
                }
                            
               
            }
            WatchingQuery();
        }
        public void Label()
        {
           
        }
        private void WaitRoomUC_Load(object sender, EventArgs e)
        {
            StartWatching();
        }

        private void panelCon_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
