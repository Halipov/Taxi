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

namespace Taxi.UserUC
{
    public partial class HistoryUC : UserControl
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        public HistoryUC()
        {
            InitializeComponent();dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(5, 23, 31);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.BackgroundColor = Color.FromArgb(5, 23, 31);

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(254, 151, 4);
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(5, 23, 31);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void PanelM_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LoadData()
        {

            //dataGridView.ColumnHeadersDefaultCellStyle.BackColor = 

            SqlConnection conn = new SqlConnection(myconnstrng);
            conn.Open();
            string query = "SELECT * FROM Orders where contact_user = @contact";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@contact", FormMainUser.conntact);
            
            SqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[6]);
                data[data.Count - 1][0] = reader[6].ToString();
                data[data.Count - 1][1] = reader[7].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[9].ToString();
                data[data.Count - 1][5] = reader[10].ToString();
            }
            reader.Close();
            conn.Close();


            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }

        }

        private void HistoryUC_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
