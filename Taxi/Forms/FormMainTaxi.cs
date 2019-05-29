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
        public static string conntact;
        
        int PanelWidth;
        OrdersUC ouc = new OrdersUC();
        Good_Luck gluc = new Good_Luck();
        HistoryTaxi huc = new HistoryTaxi();
        public FormMainTaxi()
        {
            InitializeComponent();
            //buttonGL.Enabled = false;
            ouc.click += () => { buttonGL.Enabled = true; GL(); };
            PanelWidth = PanelMenu.Width;
            AddControlsToPanel(ouc);
            LabelContact.Text = FormLogin.contact;
            conntact = LabelContact.Text;

        }
        private void moveSidePanel(Control btn)
        {
            PanelSlide.Top = btn.Top;
            PanelSlide.Width = btn.Width;
        }
        private void AddControlsToPanel(Control c)
        {
            
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

        private void ButtonHistory_Click(object sender, EventArgs e)
        {
            moveSidePanel(ButtonHistory);
            AddControlsToPanel(huc);
        }

        private void ButtonOrders_Click(object sender, EventArgs e)
        {
            moveSidePanel(ButtonOrders);
            AddControlsToPanel(ouc);
        }

        private void buttonGL_Click(object sender, EventArgs e)
        {
            PanelWidth = PanelMenu.Width;
            moveSidePanel(buttonGL);
            AddControlsToPanel(gluc);
        }
        public void GL()
        {
            moveSidePanel(buttonGL);
            AddControlsToPanel(gluc);
        }
    }
}
