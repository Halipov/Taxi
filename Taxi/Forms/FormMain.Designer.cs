﻿namespace Taxi
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
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.LogoAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.PanelSlide = new System.Windows.Forms.Panel();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.ButtonPrice = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.ButtonAuto = new System.Windows.Forms.Button();
            this.ButtonRoute = new System.Windows.Forms.Button();
            this.PanelUC = new System.Windows.Forms.Panel();
            this.PanelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.PanelAnimator2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
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
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // LogoAnimator
            // 
            this.LogoAnimator.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.LogoAnimator.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(30);
            animation3.RotateCoeff = 0.5F;
            animation3.RotateLimit = 0.2F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.LogoAnimator.DefaultAnimation = animation3;
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
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.PanelMenu.Controls.Add(this.buttonMenu);
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
            this.PanelMenu.TabIndex = 5;
            // 
            // buttonMenu
            // 
            this.buttonMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelAnimator2.SetDecoration(this.buttonMenu, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.buttonMenu, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.buttonMenu, BunifuAnimatorNS.DecorationType.None);
            this.buttonMenu.FlatAppearance.BorderSize = 0;
            this.buttonMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.buttonMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(50)))));
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenu.Image = global::Taxi.Properties.Resources.menu;
            this.buttonMenu.Location = new System.Drawing.Point(188, 1);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(29, 24);
            this.buttonMenu.TabIndex = 8;
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
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
            // 
            // Logo
            // 
            this.PanelAnimator2.SetDecoration(this.Logo, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.Logo, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.Logo, BunifuAnimatorNS.DecorationType.None);
            this.Logo.Image = global::Taxi.Properties.Resources.IconTaxiOrange;
            this.Logo.Location = new System.Drawing.Point(37, 3);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(136, 97);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 2;
            this.Logo.TabStop = false;
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
            this.ButtonAuto.Click += new System.EventHandler(this.ButtonAuto_Click_1);
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
            this.ButtonRoute.Click += new System.EventHandler(this.ButtonRoute_Click_1);
            // 
            // PanelUC
            // 
            this.LogoAnimator.SetDecoration(this.PanelUC, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.PanelUC, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator2.SetDecoration(this.PanelUC, BunifuAnimatorNS.DecorationType.None);
            this.PanelUC.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelUC.Location = new System.Drawing.Point(57, 0);
            this.PanelUC.Name = "PanelUC";
            this.PanelUC.Size = new System.Drawing.Size(1143, 800);
            this.PanelUC.TabIndex = 6;
            this.PanelUC.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelUC_Paint_1);
            // 
            // PanelAnimator
            // 
            this.PanelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind;
            this.PanelAnimator.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.PanelAnimator.DefaultAnimation = animation2;
            // 
            // PanelAnimator2
            // 
            this.PanelAnimator2.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.PanelAnimator2.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.PanelAnimator2.DefaultAnimation = animation1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.PanelUC);
            this.PanelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taxi";
            this.PanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private BunifuAnimatorNS.BunifuTransition PanelAnimator;
        private BunifuAnimatorNS.BunifuTransition LogoAnimator;
        private BunifuAnimatorNS.BunifuTransition PanelAnimator2;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Button ButtonPrice;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button ButtonRoute;
        private System.Windows.Forms.Panel PanelSlide;
        private System.Windows.Forms.Panel PanelUC;
        private System.Windows.Forms.Button ButtonAuto;
    }
}