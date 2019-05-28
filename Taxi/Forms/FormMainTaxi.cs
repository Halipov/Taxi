using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taxi.UserControls;
using System.Data.SqlClient;
using Taxi.BLL;
using Taxi.TaxiUC;

namespace Taxi.Forms
{
    public partial class FormMainTaxi : Form
    {

        int PanelWidth;
        bool isCollapsed;
        bool flag = false;

        OrdersUC ouc = new OrdersUC();

        public FormMainTaxi()
        {
            InitializeComponent();
            PanelWidth = PanelMenu.Width;
            isCollapsed = false;
            AddControlsToPanel(ouc);
            ButtonPrice.Enabled = false;
            LabelContact.Text = FormLogin.contact;
        }
        private void moveSidePanel(Control btn)
        {
            PanelSlide.Top = btn.Top;
            PanelSlide.Width = btn.Width;
        }
        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            PanelUC.Controls.Clear();
            PanelUC.Controls.Add(c);
        }

        private void LabelContact_Click(object sender, EventArgs e)
        {

        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
