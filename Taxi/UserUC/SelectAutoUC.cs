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

namespace Taxi.UserControls
{
    public partial class SelectAutoUC : UserControl
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        public static string name;
        public static string _class;
        public static string contact;

        public SelectAutoUC()
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
            //dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void SelectAutoUC_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            //dataGridView.ColumnHeadersDefaultCellStyle.BackColor = 
            SqlConnection conn = new SqlConnection(myconnstrng);
            conn.Open();
            string query = "SELECT * FROM TAXI";
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>(); 
            while (reader.Read())
            {
                data.Add(new string[4]);
                data[data.Count - 1][0] = reader[1].ToString();
                data[data.Count - 1][1] = reader[2].ToString();
                data[data.Count - 1][2] = reader[3].ToString();
                data[data.Count - 1][3] = reader[4].ToString();
            }
            reader.Close();
            conn.Close();

            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            labelName.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            labelClass.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            labelContact.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            name = labelName.Text;
            _class = labelClass.Text;
            contact = labelContact.Text;
        }
        
    }
}
