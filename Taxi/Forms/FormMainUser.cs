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
using Taxi.UserUC;
using System.Data.SqlClient;
using Taxi.BLL;

namespace Taxi
{
    public partial class FormMainUser : Form
    {

        int PanelWidth;
        bool isCollapsed;
        bool flag = false;
        public static string conntact;
        RouteUC ruc = new RouteUC();
        SelectAutoUC sauc = new SelectAutoUC();
        

    public FormMainUser()
        {
            InitializeComponent();

            sauc.click += () => { ButtonPrice.Enabled = true; ButtonPriceMethod(); };
            ruc.click += () => { ButtonAuto.Enabled = true; };
        
            PanelWidth = PanelMenu.Width;
            isCollapsed = false;
            AddControlsToPanel(ruc);
            ButtonPrice.Enabled = false;
            buttonWR.Enabled = false;
            ButtonAuto.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //timer.Start();
            if (PanelMenu.Width == 57)
            {
                PanelMenu.Visible = false;
                PanelMenu.Width = 225;
                PanelAnimator2.ShowSync(PanelMenu);
                LogoAnimator.ShowSync(Logo);
            }
            else
            {
                LogoAnimator.HideSync(Logo);
                PanelMenu.Visible = false;
                PanelMenu.Width = 57;
                PanelAnimator.ShowSync(PanelMenu);

            }
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
                if (isCollapsed == false && flag == false)
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
           // DateTime dt = DateTime.Now;
            //LabelTime.Text = dt.ToString("HH:MM:ss");
        }


        private void ButtonRoute_Click(object sender, EventArgs e)
        {
            moveSidePanel(ButtonRoute);
            AddControlsToPanel(ruc);
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

        private void Logo_Click(object sender, EventArgs e)
        {

        }

        private void PanelUC_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            flag = false;
            timer.Start();

            //if (PanelMenu.Width == 57)
            //{
            //    PanelMenu.Visible = false;
            //    PanelMenu.Width = 225;
            //    PanelAnimator2.ShowSync(PanelMenu);
            //    LogoAnimator.ShowSync(Logo);
            //}
            //else
            //{
            //    LogoAnimator.HideSync(Logo);
            //    PanelMenu.Visible = false;
            //    PanelMenu.Width = 57;
            //    PanelAnimator.ShowSync(PanelMenu); 
            // moveSidePanel(ButtonAuto);
            //AddControlsToPanel(sauc);

            //}
        }

        private void ButtonRoute_Click_1(object sender, EventArgs e)
        {
            ButtonNext.Visible = true;
            ButtonNext.ButtonText = "Select auto";
            moveSidePanel(ButtonRoute);
            AddControlsToPanel(ruc);
            buttonMenu.Visible = true;
            
        }

        private void ButtonAuto_Click_1(object sender, EventArgs e)
        {
            ButtonNext.Visible = true;
            ButtonNext.ButtonText = "Price";
            moveSidePanel(ButtonAuto);
            AddControlsToPanel(sauc);
            flag = true;
            timer.Start();
            buttonMenu.Visible = false;
        }

        private void PanelUC_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LabelContact.Text = FormLogin.contact;
            conntact = LabelContact.Text;
        }

        private void LabelContact_Click(object sender, EventArgs e)
        {

        }

        
        public void ButtonPriceMethod()
        {
           
            ButtonNext.Visible = false;
            PriceUC pruc = new PriceUC();
            pruc.click += () => { buttonWR.Enabled = true; ButtonWRMethod(); };
            moveSidePanel(ButtonPrice);
            AddControlsToPanel(pruc);
            flag = true;
            timer.Start();
            buttonMenu.Visible = false;
        }

        public void ButtonWRMethod()
        {

            ButtonNext.Visible = false;
            
            moveSidePanel(buttonWR);
            WaitRoomUC wruc = new WaitRoomUC();
            AddControlsToPanel(wruc);
            flag = true;
            timer.Start();
            buttonMenu.Visible = false;
        }

        public void ButtonPrice_Click_1(object sender, EventArgs e)
        {
            ButtonPriceMethod();
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            moveSidePanel(ButtonAuto);
            AddControlsToPanel(sauc);
            flag = true;
            timer.Start();
            buttonMenu.Visible = false;
            ButtonNext.ButtonText = "Price";
            ButtonNext.Visible = false;
        }

        private void PanelSlide_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelMenu_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void ButtonHistory_Click(object sender, EventArgs e)
        {
            moveSidePanel(ButtonHistory);
            HistoryUC huc = new HistoryUC();
            AddControlsToPanel(huc);
            flag = true;
            timer.Start();
            buttonMenu.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Logo_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonWR_Click(object sender, EventArgs e)
        {
            ButtonWRMethod();
        }
    }
}
