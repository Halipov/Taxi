using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;

namespace Taxi
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            PanelSignUp.Visible = false;
            panelForgetPass.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LabelSignUp_Click(object sender, EventArgs e)
        {
            PanelSignUp.Visible = true;
        }

        private void LabelLogin_Click(object sender, EventArgs e)
        {
            PanelSignUp.Visible = false;
        }

        private void LabelForgetPass_Click(object sender, EventArgs e)
        {
            panelForgetPass.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            panelForgetPass.Visible = false;
        }
    }
}
