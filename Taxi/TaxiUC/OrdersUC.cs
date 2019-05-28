using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Taxi.BLL;
using Taxi.DLL;

namespace Taxi.TaxiUC
{
    public partial class OrdersUC : UserControl
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        OrdersBLL orders = new OrdersBLL();
        OrdersDAL ordersdal = new OrdersDAL();
        public OrdersUC()
        {
            InitializeComponent();
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(5, 23, 31);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.BackgroundColor = Color.FromArgb(5, 23, 31);

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(254, 151, 4);
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(5, 23, 31);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            StartWatching();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoadData()
        {

            //dataGridView.ColumnHeadersDefaultCellStyle.BackColor = 

            SqlConnection conn = new SqlConnection(myconnstrng);
            conn.Open();
            string query = "SELECT * FROM Users where status = 1";
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            
            while (reader.Read())
            {
                data.Add(new string[7]);
                data[data.Count - 1][0] = reader[1].ToString();
                data[data.Count - 1][1] = reader[2].ToString();
                data[data.Count - 1][2] = reader[8].ToString();
                data[data.Count - 1][3] = reader[9].ToString();
                data[data.Count - 1][4] = reader[3].ToString();
                data[data.Count - 1][5] = reader[7].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
            }
            reader.Close();
            conn.Close();

           
            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }

        }

        private void OrdersUC_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            labelName.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            labelClass.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            labelContact.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
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
                    "SELECT status FROM dbo.Users WHERE status = 1", connection))
                {
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
                dataGridView1.Rows.Clear();
                LoadData();
                MessageBox.Show("New Order");
            }
            WatchingQuery();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ButtonPick_Click(object sender, EventArgs e)
        {
            labelName.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            labelClass.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            labelContact.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }
    }

}