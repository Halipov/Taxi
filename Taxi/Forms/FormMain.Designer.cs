namespace Taxi
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            this.PanelBar = new System.Windows.Forms.Panel();
            this.ButtonClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.PanelUC = new System.Windows.Forms.Panel();
            this.PanelSlide = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.ButtonPrice = new System.Windows.Forms.Button();
            this.ButtonAuto = new System.Windows.Forms.Button();
            this.ButtonRoute = new System.Windows.Forms.Button();
            this.LogoAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.PanelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.PanelAnimator2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.PanelBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.PanelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelBar
            // 
            this.PanelBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(151)))), ((int)(((byte)(4)))));
            this.PanelBar.Controls.Add(this.ButtonClose);
            this.LogoAnimator.SetDecoration(this.PanelBar, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.PanelBar, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator2.SetDecoration(this.PanelBar, BunifuAnimatorNS.DecorationType.None);
            this.PanelBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBar.Location = new System.Drawing.Point(225, 0);
            this.PanelBar.Name = "PanelBar";
            this.PanelBar.Size = new System.Drawing.Size(975, 26);
            this.PanelBar.TabIndex = 1;
            // 
            // ButtonClose
            // 
            this.ButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(151)))), ((int)(((byte)(4)))));
            this.LogoAnimator.SetDecoration(this.ButtonClose, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.ButtonClose, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator2.SetDecoration(this.ButtonClose, BunifuAnimatorNS.DecorationType.None);
            this.ButtonClose.Image = global::Taxi.Properties.Resources.close2;
            this.ButtonClose.ImageActive = null;
            this.ButtonClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ButtonClose.Location = new System.Drawing.Point(942, 3);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(34, 21);
            this.ButtonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonClose.TabIndex = 23;
            this.ButtonClose.TabStop = false;
            this.ButtonClose.Zoom = 10;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // timer
            // 
            this.timer.Interval = 2;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.PanelBar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // PanelUC
            // 
            this.LogoAnimator.SetDecoration(this.PanelUC, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.PanelUC, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator2.SetDecoration(this.PanelUC, BunifuAnimatorNS.DecorationType.None);
            this.PanelUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelUC.Location = new System.Drawing.Point(225, 26);
            this.PanelUC.Name = "PanelUC";
            this.PanelUC.Size = new System.Drawing.Size(975, 774);
            this.PanelUC.TabIndex = 4;
            // 
            // PanelSlide
            // 
            this.PanelSlide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(151)))), ((int)(((byte)(4)))));
            this.LogoAnimator.SetDecoration(this.PanelSlide, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.PanelSlide, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator2.SetDecoration(this.PanelSlide, BunifuAnimatorNS.DecorationType.None);
            this.PanelSlide.Location = new System.Drawing.Point(0, 150);
            this.PanelSlide.Name = "PanelSlide";
            this.PanelSlide.Size = new System.Drawing.Size(8, 60);
            this.PanelSlide.TabIndex = 3;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelAnimator2.SetDecoration(this.button6, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.button6, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.button6, BunifuAnimatorNS.DecorationType.None);
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(50)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = global::Taxi.Properties.Resources.menu;
            this.button6.Location = new System.Drawing.Point(193, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(29, 24);
            this.button6.TabIndex = 1;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Logo
            // 
            this.PanelAnimator2.SetDecoration(this.Logo, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.Logo, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.Logo, BunifuAnimatorNS.DecorationType.None);
            this.Logo.Image = global::Taxi.Properties.Resources.IconTaxiOrange;
            this.Logo.Location = new System.Drawing.Point(41, 3);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(136, 97);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.PanelMenu.Controls.Add(this.button6);
            this.PanelMenu.Controls.Add(this.ButtonPrice);
            this.PanelMenu.Controls.Add(this.Logo);
            this.PanelMenu.Controls.Add(this.ButtonAuto);
            this.PanelMenu.Controls.Add(this.ButtonRoute);
            this.PanelMenu.Controls.Add(this.PanelSlide);
            this.LogoAnimator.SetDecoration(this.PanelMenu, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.PanelMenu, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator2.SetDecoration(this.PanelMenu, BunifuAnimatorNS.DecorationType.None);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(225, 800);
            this.PanelMenu.TabIndex = 0;
            this.PanelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelMenu_Paint);
            // 
            // ButtonPrice
            // 
            this.PanelAnimator2.SetDecoration(this.ButtonPrice, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.ButtonPrice, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.ButtonPrice, BunifuAnimatorNS.DecorationType.None);
            this.ButtonPrice.FlatAppearance.BorderSize = 0;
            this.ButtonPrice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.ButtonPrice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(50)))));
            this.ButtonPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonPrice.ForeColor = System.Drawing.Color.White;
            this.ButtonPrice.Image = global::Taxi.Properties.Resources.money;
            this.ButtonPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonPrice.Location = new System.Drawing.Point(7, 282);
            this.ButtonPrice.Name = "ButtonPrice";
            this.ButtonPrice.Size = new System.Drawing.Size(241, 60);
            this.ButtonPrice.TabIndex = 7;
            this.ButtonPrice.Text = "Price";
            this.ButtonPrice.UseVisualStyleBackColor = true;
            this.ButtonPrice.Click += new System.EventHandler(this.ButtonPrice_Click);
            // 
            // ButtonAuto
            // 
            this.PanelAnimator2.SetDecoration(this.ButtonAuto, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.ButtonAuto, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.ButtonAuto, BunifuAnimatorNS.DecorationType.None);
            this.ButtonAuto.FlatAppearance.BorderSize = 0;
            this.ButtonAuto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.ButtonAuto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(50)))));
            this.ButtonAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAuto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAuto.ForeColor = System.Drawing.Color.White;
            this.ButtonAuto.Image = global::Taxi.Properties.Resources.car2;
            this.ButtonAuto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonAuto.Location = new System.Drawing.Point(7, 216);
            this.ButtonAuto.Name = "ButtonAuto";
            this.ButtonAuto.Size = new System.Drawing.Size(241, 60);
            this.ButtonAuto.TabIndex = 6;
            this.ButtonAuto.Text = "Select auto";
            this.ButtonAuto.UseVisualStyleBackColor = true;
            this.ButtonAuto.Click += new System.EventHandler(this.ButtonAuto_Click);
            // 
            // ButtonRoute
            // 
            this.PanelAnimator2.SetDecoration(this.ButtonRoute, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.ButtonRoute, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.ButtonRoute, BunifuAnimatorNS.DecorationType.None);
            this.ButtonRoute.FlatAppearance.BorderSize = 0;
            this.ButtonRoute.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.ButtonRoute.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(50)))));
            this.ButtonRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRoute.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonRoute.ForeColor = System.Drawing.Color.White;
            this.ButtonRoute.Image = global::Taxi.Properties.Resources.route;
            this.ButtonRoute.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonRoute.Location = new System.Drawing.Point(7, 150);
            this.ButtonRoute.Name = "ButtonRoute";
            this.ButtonRoute.Size = new System.Drawing.Size(241, 60);
            this.ButtonRoute.TabIndex = 5;
            this.ButtonRoute.Text = "Route";
            this.ButtonRoute.UseVisualStyleBackColor = true;
            this.ButtonRoute.Click += new System.EventHandler(this.ButtonRoute_Click);
            // 
            // LogoAnimator
            // 
            this.LogoAnimator.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.LogoAnimator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(30);
            animation1.RotateCoeff = 0.5F;
            animation1.RotateLimit = 0.2F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.LogoAnimator.DefaultAnimation = animation1;
            // 
            // PanelAnimator
            // 
            this.PanelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.PanelAnimator.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 1;
            animation2.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 2F;
            animation2.TransparencyCoeff = 0F;
            this.PanelAnimator.DefaultAnimation = animation2;
            // 
            // PanelAnimator2
            // 
            this.PanelAnimator2.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind;
            this.PanelAnimator2.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.PanelAnimator2.DefaultAnimation = animation3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.LogoAnimator.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator2.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(225, 100);
            this.panel3.TabIndex = 3;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.PanelUC);
            this.Controls.Add(this.PanelBar);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.panel3);
            this.PanelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taxi";
            this.PanelBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.PanelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelBar;
        private Bunifu.Framework.UI.BunifuImageButton ButtonClose;
        private System.Windows.Forms.Timer timer;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel PanelUC;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Button ButtonAuto;
        private System.Windows.Forms.Button ButtonPrice;
        private System.Windows.Forms.Button ButtonRoute;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel PanelSlide;
        private BunifuAnimatorNS.BunifuTransition PanelAnimator;
        private BunifuAnimatorNS.BunifuTransition LogoAnimator;
        private BunifuAnimatorNS.BunifuTransition PanelAnimator2;
        private System.Windows.Forms.Panel panel3;
    }
}