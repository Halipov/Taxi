namespace Taxi
{
    partial class FormLogin
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.panelInfo = new System.Windows.Forms.Panel();
            this.labelinfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TextBoxUser = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ButtonRussia = new Bunifu.Framework.UI.BunifuImageButton();
            this.ButtonUSA = new Bunifu.Framework.UI.BunifuImageButton();
            this.ButtonLogin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LabelSignUp = new System.Windows.Forms.Label();
            this.LabelForgetPass = new System.Windows.Forms.Label();
            this.TextBoxPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ButtonExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonSignUp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.TextBoxReEnter = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.TextBoxPassSign = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.TextBoxEmail = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.TextBoxLastName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.TextBoxFirstName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonRussia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonUSA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonExit)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(151)))), ((int)(((byte)(4)))));
            this.panelInfo.Controls.Add(this.labelinfo);
            this.panelInfo.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.panelInfo, "panelInfo");
            this.panelInfo.Name = "panelInfo";
            // 
            // labelinfo
            // 
            resources.ApplyResources(this.labelinfo, "labelinfo");
            this.labelinfo.Name = "labelinfo";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::Taxi.Properties.Resources.IconTaxi;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // TextBoxUser
            // 
            this.TextBoxUser.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.TextBoxUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.TextBoxUser, "TextBoxUser");
            this.TextBoxUser.ForeColor = System.Drawing.Color.White;
            this.TextBoxUser.HintForeColor = System.Drawing.Color.Empty;
            this.TextBoxUser.HintText = "";
            this.TextBoxUser.isPassword = false;
            this.TextBoxUser.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(80)))), ((int)(((byte)(4)))));
            this.TextBoxUser.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(151)))), ((int)(((byte)(4)))));
            this.TextBoxUser.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(80)))), ((int)(((byte)(4)))));
            this.TextBoxUser.LineThickness = 3;
            this.TextBoxUser.Name = "TextBoxUser";
            this.TextBoxUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ButtonRussia
            // 
            this.ButtonRussia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.ButtonRussia.Image = global::Taxi.Properties.Resources.Russia;
            this.ButtonRussia.ImageActive = null;
            resources.ApplyResources(this.ButtonRussia, "ButtonRussia");
            this.ButtonRussia.Name = "ButtonRussia";
            this.ButtonRussia.TabStop = false;
            this.ButtonRussia.Zoom = 10;
            // 
            // ButtonUSA
            // 
            this.ButtonUSA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.ButtonUSA.Image = global::Taxi.Properties.Resources.UnitedStates;
            this.ButtonUSA.ImageActive = null;
            resources.ApplyResources(this.ButtonUSA, "ButtonUSA");
            this.ButtonUSA.Name = "ButtonUSA";
            this.ButtonUSA.TabStop = false;
            this.ButtonUSA.Zoom = 10;
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(80)))), ((int)(((byte)(4)))));
            this.ButtonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(151)))), ((int)(((byte)(4)))));
            resources.ApplyResources(this.ButtonLogin, "ButtonLogin");
            this.ButtonLogin.BorderRadius = 4;
            this.ButtonLogin.ButtonText = "LogIn";
            this.ButtonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonLogin.DisabledColor = System.Drawing.Color.Gray;
            this.ButtonLogin.Iconcolor = System.Drawing.Color.Transparent;
            this.ButtonLogin.Iconimage = null;
            this.ButtonLogin.Iconimage_right = null;
            this.ButtonLogin.Iconimage_right_Selected = null;
            this.ButtonLogin.Iconimage_Selected = null;
            this.ButtonLogin.IconMarginLeft = 0;
            this.ButtonLogin.IconMarginRight = 0;
            this.ButtonLogin.IconRightVisible = true;
            this.ButtonLogin.IconRightZoom = 0D;
            this.ButtonLogin.IconVisible = true;
            this.ButtonLogin.IconZoom = 90D;
            this.ButtonLogin.IsTab = false;
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(151)))), ((int)(((byte)(4)))));
            this.ButtonLogin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(80)))), ((int)(((byte)(4)))));
            this.ButtonLogin.OnHoverTextColor = System.Drawing.Color.White;
            this.ButtonLogin.selected = false;
            this.ButtonLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonLogin.Textcolor = System.Drawing.Color.White;
            this.ButtonLogin.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // LabelSignUp
            // 
            resources.ApplyResources(this.LabelSignUp, "LabelSignUp");
            this.LabelSignUp.ForeColor = System.Drawing.Color.White;
            this.LabelSignUp.Name = "LabelSignUp";
            // 
            // LabelForgetPass
            // 
            resources.ApplyResources(this.LabelForgetPass, "LabelForgetPass");
            this.LabelForgetPass.ForeColor = System.Drawing.Color.White;
            this.LabelForgetPass.Name = "LabelForgetPass";
            // 
            // TextBoxPass
            // 
            this.TextBoxPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.TextBoxPass, "TextBoxPass");
            this.TextBoxPass.ForeColor = System.Drawing.Color.White;
            this.TextBoxPass.HintForeColor = System.Drawing.Color.Empty;
            this.TextBoxPass.HintText = "";
            this.TextBoxPass.isPassword = true;
            this.TextBoxPass.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(80)))), ((int)(((byte)(4)))));
            this.TextBoxPass.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(151)))), ((int)(((byte)(4)))));
            this.TextBoxPass.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(80)))), ((int)(((byte)(4)))));
            this.TextBoxPass.LineThickness = 3;
            this.TextBoxPass.Name = "TextBoxPass";
            this.TextBoxPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ButtonExit
            // 
            this.ButtonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            resources.ApplyResources(this.ButtonExit, "ButtonExit");
            this.ButtonExit.ImageActive = null;
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.TabStop = false;
            this.ButtonExit.Zoom = 10;
            this.ButtonExit.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ButtonSignUp);
            this.panel1.Controls.Add(this.bunifuImageButton2);
            this.panel1.Controls.Add(this.LabelLogin);
            this.panel1.Controls.Add(this.TextBoxReEnter);
            this.panel1.Controls.Add(this.TextBoxPassSign);
            this.panel1.Controls.Add(this.TextBoxEmail);
            this.panel1.Controls.Add(this.TextBoxLastName);
            this.panel1.Controls.Add(this.TextBoxFirstName);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // ButtonSignUp
            // 
            this.ButtonSignUp.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(100)))), ((int)(((byte)(4)))));
            this.ButtonSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(151)))), ((int)(((byte)(4)))));
            resources.ApplyResources(this.ButtonSignUp, "ButtonSignUp");
            this.ButtonSignUp.BorderRadius = 6;
            this.ButtonSignUp.ButtonText = "SignUp";
            this.ButtonSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSignUp.DisabledColor = System.Drawing.Color.Gray;
            this.ButtonSignUp.Iconcolor = System.Drawing.Color.Transparent;
            this.ButtonSignUp.Iconimage = null;
            this.ButtonSignUp.Iconimage_right = null;
            this.ButtonSignUp.Iconimage_right_Selected = null;
            this.ButtonSignUp.Iconimage_Selected = null;
            this.ButtonSignUp.IconMarginLeft = 0;
            this.ButtonSignUp.IconMarginRight = 0;
            this.ButtonSignUp.IconRightVisible = true;
            this.ButtonSignUp.IconRightZoom = 0D;
            this.ButtonSignUp.IconVisible = true;
            this.ButtonSignUp.IconZoom = 90D;
            this.ButtonSignUp.IsTab = false;
            this.ButtonSignUp.Name = "ButtonSignUp";
            this.ButtonSignUp.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(151)))), ((int)(((byte)(4)))));
            this.ButtonSignUp.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(80)))), ((int)(((byte)(4)))));
            this.ButtonSignUp.OnHoverTextColor = System.Drawing.Color.White;
            this.ButtonSignUp.selected = false;
            this.ButtonSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonSignUp.Textcolor = System.Drawing.Color.White;
            this.ButtonSignUp.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            resources.ApplyResources(this.bunifuImageButton2, "bunifuImageButton2");
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // LabelLogin
            // 
            resources.ApplyResources(this.LabelLogin, "LabelLogin");
            this.LabelLogin.ForeColor = System.Drawing.Color.White;
            this.LabelLogin.Name = "LabelLogin";
            // 
            // TextBoxReEnter
            // 
            this.TextBoxReEnter.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(100)))), ((int)(((byte)(4)))));
            this.TextBoxReEnter.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(151)))), ((int)(((byte)(4)))));
            this.TextBoxReEnter.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(100)))), ((int)(((byte)(4)))));
            this.TextBoxReEnter.BorderThickness = 3;
            this.TextBoxReEnter.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.TextBoxReEnter, "TextBoxReEnter");
            this.TextBoxReEnter.ForeColor = System.Drawing.Color.White;
            this.TextBoxReEnter.isPassword = false;
            this.TextBoxReEnter.Name = "TextBoxReEnter";
            this.TextBoxReEnter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TextBoxPassSign
            // 
            this.TextBoxPassSign.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(100)))), ((int)(((byte)(4)))));
            this.TextBoxPassSign.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(151)))), ((int)(((byte)(4)))));
            this.TextBoxPassSign.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(100)))), ((int)(((byte)(4)))));
            this.TextBoxPassSign.BorderThickness = 3;
            this.TextBoxPassSign.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.TextBoxPassSign, "TextBoxPassSign");
            this.TextBoxPassSign.ForeColor = System.Drawing.Color.White;
            this.TextBoxPassSign.isPassword = false;
            this.TextBoxPassSign.Name = "TextBoxPassSign";
            this.TextBoxPassSign.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(100)))), ((int)(((byte)(4)))));
            this.TextBoxEmail.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(151)))), ((int)(((byte)(4)))));
            this.TextBoxEmail.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(100)))), ((int)(((byte)(4)))));
            this.TextBoxEmail.BorderThickness = 3;
            this.TextBoxEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.TextBoxEmail, "TextBoxEmail");
            this.TextBoxEmail.ForeColor = System.Drawing.Color.White;
            this.TextBoxEmail.isPassword = false;
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TextBoxLastName
            // 
            this.TextBoxLastName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(100)))), ((int)(((byte)(4)))));
            this.TextBoxLastName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(151)))), ((int)(((byte)(4)))));
            this.TextBoxLastName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(100)))), ((int)(((byte)(4)))));
            this.TextBoxLastName.BorderThickness = 3;
            this.TextBoxLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.TextBoxLastName, "TextBoxLastName");
            this.TextBoxLastName.ForeColor = System.Drawing.Color.White;
            this.TextBoxLastName.isPassword = false;
            this.TextBoxLastName.Name = "TextBoxLastName";
            this.TextBoxLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TextBoxFirstName
            // 
            this.TextBoxFirstName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(100)))), ((int)(((byte)(4)))));
            this.TextBoxFirstName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(151)))), ((int)(((byte)(4)))));
            this.TextBoxFirstName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(100)))), ((int)(((byte)(4)))));
            this.TextBoxFirstName.BorderThickness = 3;
            this.TextBoxFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.TextBoxFirstName, "TextBoxFirstName");
            this.TextBoxFirstName.ForeColor = System.Drawing.Color.White;
            this.TextBoxFirstName.isPassword = false;
            this.TextBoxFirstName.Name = "TextBoxFirstName";
            this.TextBoxFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // FormLogin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.ButtonRussia);
            this.Controls.Add(this.ButtonUSA);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonLogin);
            this.Controls.Add(this.LabelSignUp);
            this.Controls.Add(this.LabelForgetPass);
            this.Controls.Add(this.TextBoxPass);
            this.Controls.Add(this.TextBoxUser);
            this.Controls.Add(this.panelInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonRussia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonUSA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonExit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelinfo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBoxUser;
        private Bunifu.Framework.UI.BunifuImageButton ButtonRussia;
        private Bunifu.Framework.UI.BunifuImageButton ButtonUSA;
        private Bunifu.Framework.UI.BunifuFlatButton ButtonLogin;
        private System.Windows.Forms.Label LabelSignUp;
        private System.Windows.Forms.Label LabelForgetPass;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBoxPass;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton ButtonSignUp;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.Label LabelLogin;
        private Bunifu.Framework.UI.BunifuMetroTextbox TextBoxReEnter;
        private Bunifu.Framework.UI.BunifuMetroTextbox TextBoxPassSign;
        private Bunifu.Framework.UI.BunifuMetroTextbox TextBoxEmail;
        private Bunifu.Framework.UI.BunifuMetroTextbox TextBoxLastName;
        private Bunifu.Framework.UI.BunifuMetroTextbox TextBoxFirstName;
        private Bunifu.Framework.UI.BunifuImageButton ButtonExit;
    }
}

