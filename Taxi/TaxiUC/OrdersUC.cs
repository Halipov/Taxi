﻿using System;
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
    public delegate void NextHandlerGL();
    public partial class OrdersUC : UserControl
    {
        public event NextHandlerGL click;
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
            labelClass.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            labelContact.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
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
            }
            WatchingQuery();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ButtonPick_Click(object sender, EventArgs e)
        {
            string cont = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            SqlConnection conn = new SqlConnection(myconnstrng);

            
            orders.taxi_name = FormLogin.username;
            orders.taxi_contact = FormLogin.contact;
            orders.taxi_number = LoginDAL.car_number;
            orders._class = LoginDAL.car_class;

            orders.user_name = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            orders.user_lastname= dataGridView1.CurrentRow.Cells[1].Value.ToString();
            orders.from = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            orders.to = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            orders.user_contact = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            orders.distance = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            orders.cost = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            bool success = ordersdal.AddOrder(orders);
            if (success)
            {
                MessageBox.Show("Success");

                //click.Invoke();
            }
            else
            {
                MessageBox.Show("Error");
            }
            try
            {
                string sql = "UPDATE Users SET status = 0  WHERE contact = @contact";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@contact", cont);
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("status change");
                }
                else
                {
                    MessageBox.Show("status no change");
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
            click.Invoke();

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label_class_Click(object sender, EventArgs e)
        {

        }

        private void label_name_Click(object sender, EventArgs e)
        {

        }

        private void labelContact_Click(object sender, EventArgs e)
        {

        }

        private void labelClass_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelM_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}