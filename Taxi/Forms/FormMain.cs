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

namespace Taxi
{
    public partial class FormMain : Form
    {
        int PanelWidth;
        bool isCollapsed;
        RouteUC ruc = new RouteUC();
        public FormMain()
        {
            InitializeComponent();
            time.Start();
            PanelWidth = PanelMenu.Width;
            isCollapsed = false;
            AddControlsToPanel(ruc);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                PanelMenu.Width = PanelMenu.Width + 10;
                if(PanelMenu.Width >= PanelWidth)
                {
                    timer.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                PanelMenu.Width = PanelMenu.Width - 10;
                if (PanelMenu.Width <= 57)
                {
                    timer.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void moveSidePanel(Control btn)
        {
            PanelSlide.Top = btn.Top;
            PanelSlide.Width = btn.Width;
        }

        private void time_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            //LabelTime.Text = dt.ToString("HH:MM:ss");
        }


        private void ButtonRoute_Click(object sender, EventArgs e)
        {
            moveSidePanel(ButtonRoute);
            
            AddControlsToPanel(ruc);
        }

        private void ButtonAuto_Click(object sender, EventArgs e)
        {
            moveSidePanel(ButtonAuto);
        }

        private void ButtonPrice_Click(object sender, EventArgs e)
        {
            moveSidePanel(ButtonPrice);
        }

        private void PanelMenu_Paint(object sender, PaintEventArgs e)
        {

        }
         
        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            PanelUC.Controls.Clear();
            PanelUC.Controls.Add(c);
        }

        private void TextBoxFrom_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
