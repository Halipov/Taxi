using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

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
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
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


        private void ChangeLanguage(string lang)
        {
            var rm = new ComponentResourceManager(this.GetType());
            var culture = CultureInfo.CreateSpecificCulture(lang);
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
            foreach (Control c in this.AllControls())
            {
                if (c is ToolStrip)
                {
                    var items = ((ToolStrip)c).AllItems().ToList();
                    foreach (var item in items)
                        rm.ApplyResources(item, item.Name);
                }
                rm.ApplyResources(c, c.Name);
            }
        }
        private void ButtonRussia_Click(object sender, EventArgs e)
        {
            ChangeLanguage("ru");
            ButtonLogin.Text = "Войти";
            ButtonSignUp.Text = "Регистрация";
            ButtonFPSend.Text = "Отправить";
        }

        private void ButtonUSA_Click(object sender, EventArgs e)
        {
            ChangeLanguage("en");
            ButtonLogin.Text = "LogIn";
            ButtonSignUp.Text = "SignUp";
            ButtonFPSend.Text = "Send";
        }

        private void panelForgetPass_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelSignUp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonLogin_Click_1(object sender, EventArgs e)
        {
            FormMain s = new FormMain();
            s.Show();
            this.Hide();
        }
    }
}
