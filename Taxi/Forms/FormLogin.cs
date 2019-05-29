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
using Taxi.BLL;
using Taxi.DLL;
using Taxi.Forms;

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

        LoginBLL l = new LoginBLL();
        LoginDAL l_dal = new LoginDAL();
        SignUpBLL s = new SignUpBLL();
        SignUpDAL s_dal = new SignUpDAL();

        public static string contact;
        public static string username;

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

        private void ButtonLogin_Click_1(object sender, EventArgs e)
        {
            l.contact = TextBoxUser.Text.Trim();
            l.password = TextBoxPass.Text.Trim();

            int success = l_dal.loginCheck(l);
            if(success == 1)
            {
                MessageBox.Show("Login success(user)");
                contact = TextBoxUser.Text;
                username = l.first_name;
                FormMainUser s = new FormMainUser();
                s.Show();
                this.Hide();
            }
            if (success == 2)
            {
                MessageBox.Show("Login success(taxi)");
                contact = TextBoxUser.Text;
                username = l_dal.login_user(l);
                FormMainTaxi s = new FormMainTaxi();
                s.Show();
                this.Hide();
            }
            if (success == 0)
            {
                MessageBox.Show("Login failed");
            }

        }

        private void FormLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
           if(e.KeyData == Keys.Enter)
            {
                l.contact = TextBoxUser.Text.Trim();
                l.password = TextBoxPass.Text.Trim();

                int success = l_dal.loginCheck(l);
                if (success == 1)
                {
                    MessageBox.Show("Login success(user)");
                    contact = TextBoxUser.Text;
                    username = l.first_name;
                    FormMainUser s = new FormMainUser();
                    s.Show();
                    this.Hide();
                }
                if (success == 2)
                {
                    MessageBox.Show("Login success(taxi)");
                    contact = TextBoxUser.Text;
                    username = l_dal.login_user(l);
                    FormMainTaxi s = new FormMainTaxi();
                    s.Show();
                    this.Hide();
                }
                if (success == 0)
                {
                    MessageBox.Show("Login failed");
                }

                e.Handled = true;
            }
        }

        private void ButtonSignUp_Click(object sender, EventArgs e)
        {
            if (TextBoxEmail.Text == "" || TextBoxFirstName.Text == "" || TextBoxLastName.Text == "" || TextBoxPassSign.Text == "")
            {
                MessageBox.Show("someone is empty");
            }
            else
            {


                //l.contact = TextBoxUser.Text.Trim();
                s.contact = TextBoxEmail.Text.Trim();
                s.first_name = TextBoxFirstName.Text.Trim();
                s.last_name = TextBoxLastName.Text.Trim();
                s.password = TextBoxPassSign.Text.Trim();

                bool success_check = s_dal.signup_check(s);
                if (success_check == true)
                {
                    bool success = s_dal.signup(s);
                    if (success == true)
                    {
                        MessageBox.Show("SignUp success");
                    }
                    else
                    {
                        MessageBox.Show("SignUp failed");
                    }

                }
                else
                {
                    MessageBox.Show("contact is al-ready register");
                }
            }
        }

        private void TextBoxPassSign_Click(object sender, EventArgs e)
        {
            TextBoxPassSign.Text = "";
            TextBoxPassSign.isPassword = true;
        }

        private void TextBoxReEnter_Click(object sender, EventArgs e)
        {
            TextBoxReEnter.Text = "";
            TextBoxReEnter.isPassword = true;
        }

        private void TextBoxFirstName_MouseClick(object sender, MouseEventArgs e)
        {
            TextBoxFirstName.Text = "";
        }
    }
}
