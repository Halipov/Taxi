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
    public delegate void NextHandlerPrice();
    public partial class SelectAutoUC : UserControl
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        public static string name;
        public static string _class;
        public static string contact;
        public int but = 0;
        public event NextHandlerPrice click;
        


        public SelectAutoUC()
        {
            InitializeComponent();
            ButtonNext.Enabled = false;
            


        }

        private void SelectAutoUC_Load(object sender, EventArgs e)
        {
        }


        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonA_Click(object sender, EventArgs e)
        {
            _class = "A";
            ButtonA.Enabled = false;
            ButtonNext.Enabled = true;
            ButtonB.Enabled = true;
            ButtonC.Enabled = true;
        }

        private void ButtonB_Click(object sender, EventArgs e)
        {
            _class = "B";
            ButtonB.Enabled = false;
            ButtonNext.Enabled = true;
            ButtonA.Enabled = true;
            ButtonC.Enabled = true;
        }

        private void ButtonC_Click(object sender, EventArgs e)
        {
            _class = "C";
            ButtonC.Enabled = false;
            ButtonNext.Enabled = true;
            ButtonA.Enabled = true;
            ButtonB.Enabled = true;
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            click.Invoke();
            
        }
    }
}
