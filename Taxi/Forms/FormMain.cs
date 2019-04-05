using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taxi
{
    public partial class FormMain : Form
    {
        int PanelWidth;
        bool isCollapsed;
        public FormMain()
        {
            InitializeComponent();
            time.Start();
            PanelWidth = PanelMenu.Width;
            isCollapsed = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
            LabelTime.Text = dt.ToString("HH:MM:ss");
        }

        private void ButtonHomeLoc_Click(object sender, EventArgs e)
        {
            moveSidePanel(ButtonHomeLoc);
        }

        private void ButtonLoc_Click(object sender, EventArgs e)
        {
            moveSidePanel(ButtonLoc);
        }

        private void ButtonRoute_Click(object sender, EventArgs e)
        {
            moveSidePanel(ButtonRoute);
        }

        private void ButtonAuto_Click(object sender, EventArgs e)
        {
            moveSidePanel(ButtonAuto);
        }

        private void ButtonPrice_Click(object sender, EventArgs e)
        {
            moveSidePanel(ButtonPrice);
        }
    }
}
