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
            using (SqlConnection connection = new SqlConnection(myconnstrng))
            {
                connection.Open();
                using (var command = new SqlCommand(
                    "select class from dbo.Orders WHERE contact_user = @contact", connection))
                {
                    command.Parameters.AddWithValue("@contact", FormMainUser.conntact);
                    var sqlDependency = new SqlDependency(command);
                    sqlDependency.OnChange += new OnChangeEventHandler(OnDatabaseChange);
                    command.ExecuteReader();
                }
            }
        }
        private void OnDatabaseChange(object sender, SqlNotificationEventArgs args)
        {
            SqlNotificationInfo info = args.Info;
            if (SqlNotificationInfo.Insert.Equals(info) || SqlNotificationInfo.Update.Equals(info))
            {
                MessageBox.Show("You order is accepted waiting");
                pictureBox.Hide();
            }
            WatchingQuery();
        }

        private void WaitRoomUC_Load(object sender, EventArgs e)
        {
            StartWatching();
        }
    }
}
