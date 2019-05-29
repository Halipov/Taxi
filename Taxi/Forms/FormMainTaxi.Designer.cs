namespace Taxi.Forms
{
    partial class FormMainTaxi
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
            BunifuAnimatorNS.Animation animation7 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainTaxi));
            BunifuAnimatorNS.Animation animation9 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation8 = new BunifuAnimatorNS.Animation();
            this.PanelAnimator2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.ButtonHistory = new System.Windows.Forms.Button();
            this.LabelContact = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.ButtonOrders = new System.Windows.Forms.Button();
            this.PanelSlide = new System.Windows.Forms.Panel();
            this.PanelBar = new System.Windows.Forms.Panel();
            this.ButtonClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.PanelUC = new System.Windows.Forms.Panel();
            this.PanelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.LogoAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.PanelBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClose)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelAnimator2
            // 
            this.PanelAnimator2.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.PanelAnimator2.Cursor = null;
            animation7.AnimateOnlyDifferences = true;
            animation7.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.BlindCoeff")));
            animation7.LeafCoeff = 0F;
            animation7.MaxTime = 1F;
            animation7.MinTime = 0F;
            animation7.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.MosaicCoeff")));
            animation7.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation7.MosaicShift")));
            animation7.MosaicSize = 0;
            animation7.Padding = new System.Windows.Forms.Padding(0);
            animation7.RotateCoeff = 0F;
            animation7.RotateLimit = 0F;
            animation7.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.ScaleCoeff")));
            animation7.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.SlideCoeff")));
            animation7.TimeCoeff = 0F;
            animation7.TransparencyCoeff = 0F;
            this.PanelAnimator2.DefaultAnimation = animation7;
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.PanelMenu.Controls.Add(this.ButtonHistory);
            this.PanelMenu.Controls.Add(this.LabelContact);
            this.PanelMenu.Controls.Add(this.pictureBox1);
            this.PanelMenu.Controls.Add(this.Logo);
            this.PanelMenu.Controls.Add(this.ButtonOrders);
            this.PanelMenu.Controls.Add(this.PanelSlide);
            this.PanelAnimator2.SetDecoration(this.PanelMenu, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.PanelMenu, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.PanelMenu, BunifuAnimatorNS.DecorationType.None);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 27);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(225, 773);
            this.PanelMenu.TabIndex = 7;
            // 
            // ButtonHistory
            // 
            this.LogoAnimator.SetDecoration(this.ButtonHistory, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.ButtonHistory, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator2.SetDecoration(this.ButtonHistory, BunifuAnimatorNS.DecorationType.None);
            this.ButtonHistory.FlatAppearance.BorderSize = 0;
            this.ButtonHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.ButtonHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(50)))));
            this.ButtonHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonHistory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonHistory.ForeColor = System.Drawing.Color.White;
            this.ButtonHistory.Image = global::Taxi.Properties.Resources.History;
            this.ButtonHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonHistory.Location = new System.Drawing.Point(7, 226);
            this.ButtonHistory.Name = "ButtonHistory";
            this.ButtonHistory.Size = new System.Drawing.Size(241, 60);
            this.ButtonHistory.TabIndex = 11;
            this.ButtonHistory.Text = "History";
            this.ButtonHistory.UseVisualStyleBackColor = true;
            this.ButtonHistory.Click += new System.EventHandler(this.ButtonHistory_Click);
            // 
            // LabelContact
            // 
            this.LabelContact.AutoSize = true;
            this.LogoAnimator.SetDecoration(this.LabelContact, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.LabelContact, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator2.SetDecoration(this.LabelContact, BunifuAnimatorNS.DecorationType.None);
            this.LabelContact.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelContact.ForeColor = System.Drawing.Color.White;
            this.LabelContact.Location = new System.Drawing.Point(56, 709);
            this.LabelContact.Name = "LabelContact";
            this.LabelContact.Size = new System.Drawing.Size(97, 42);
            this.LabelContact.TabIndex = 10;
            this.LabelContact.Text = "First_name \r\nLast_name";
            this.LabelContact.Click += new System.EventHandler(this.LabelContact_Click);
            // 
            // pictureBox1
            // 
            this.LogoAnimator.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator2.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::Taxi.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(75, 634);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Logo
            // 
            this.LogoAnimator.SetDecoration(this.Logo, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.Logo, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator2.SetDecoration(this.Logo, BunifuAnimatorNS.DecorationType.None);
            this.Logo.Image = global::Taxi.Properties.Resources.IconTaxiOrange;
            this.Logo.Location = new System.Drawing.Point(37, 3);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(136, 97);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 2;
            this.Logo.TabStop = false;
            // 
            // ButtonOrders
            // 
            this.LogoAnimator.SetDecoration(this.ButtonOrders, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.ButtonOrders, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator2.SetDecoration(this.ButtonOrders, BunifuAnimatorNS.DecorationType.None);
            this.ButtonOrders.FlatAppearance.BorderSize = 0;
            this.ButtonOrders.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.ButtonOrders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(50)))));
            this.ButtonOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOrders.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonOrders.ForeColor = System.Drawing.Color.White;
            this.ButtonOrders.Image = global::Taxi.Properties.Resources.orders;
            this.ButtonOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonOrders.Location = new System.Drawing.Point(7, 150);
            this.ButtonOrders.Name = "ButtonOrders";
            this.ButtonOrders.Size = new System.Drawing.Size(241, 60);
            this.ButtonOrders.TabIndex = 5;
            this.ButtonOrders.Text = "Orders";
            this.ButtonOrders.UseVisualStyleBackColor = true;
            this.ButtonOrders.Click += new System.EventHandler(this.ButtonOrders_Click);
            // 
            // PanelSlide
            // 
            this.PanelSlide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(151)))), ((int)(((byte)(4)))));
            this.PanelAnimator2.SetDecoration(this.PanelSlide, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.PanelSlide, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.PanelSlide, BunifuAnimatorNS.DecorationType.None);
            this.PanelSlide.Location = new System.Drawing.Point(0, 150);
            this.PanelSlide.Name = "PanelSlide";
            this.PanelSlide.Size = new System.Drawing.Size(8, 60);
            this.PanelSlide.TabIndex = 3;
            // 
            // PanelBar
            // 
            this.PanelBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(151)))), ((int)(((byte)(4)))));
            this.PanelBar.Controls.Add(this.ButtonClose);
            this.PanelAnimator2.SetDecoration(this.PanelBar, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.PanelBar, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.PanelBar, BunifuAnimatorNS.DecorationType.None);
            this.PanelBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBar.Location = new System.Drawing.Point(0, 0);
            this.PanelBar.Name = "PanelBar";
            this.PanelBar.Size = new System.Drawing.Size(1357, 27);
            this.PanelBar.TabIndex = 17;
            // 
            // ButtonClose
            // 
            this.ButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(151)))), ((int)(((byte)(4)))));
            this.PanelAnimator2.SetDecoration(this.ButtonClose, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.ButtonClose, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.ButtonClose, BunifuAnimatorNS.DecorationType.None);
            this.ButtonClose.Image = global::Taxi.Properties.Resources.close2;
            this.ButtonClose.ImageActive = null;
            this.ButtonClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ButtonClose.Location = new System.Drawing.Point(1324, 3);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(34, 22);
            this.ButtonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonClose.TabIndex = 23;
            this.ButtonClose.TabStop = false;
            this.ButtonClose.Zoom = 10;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // PanelUC
            // 
            this.PanelAnimator2.SetDecoration(this.PanelUC, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.PanelUC, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.PanelUC, BunifuAnimatorNS.DecorationType.None);
            this.PanelUC.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelUC.Location = new System.Drawing.Point(57, 27);
            this.PanelUC.Name = "PanelUC";
            this.PanelUC.Size = new System.Drawing.Size(1300, 773);
            this.PanelUC.TabIndex = 18;
            // 
            // PanelAnimator
            // 
            this.PanelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind;
            this.PanelAnimator.Cursor = null;
            animation9.AnimateOnlyDifferences = true;
            animation9.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.BlindCoeff")));
            animation9.LeafCoeff = 0F;
            animation9.MaxTime = 1F;
            animation9.MinTime = 0F;
            animation9.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.MosaicCoeff")));
            animation9.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation9.MosaicShift")));
            animation9.MosaicSize = 0;
            animation9.Padding = new System.Windows.Forms.Padding(0);
            animation9.RotateCoeff = 0F;
            animation9.RotateLimit = 0F;
            animation9.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.ScaleCoeff")));
            animation9.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.SlideCoeff")));
            animation9.TimeCoeff = 0F;
            animation9.TransparencyCoeff = 0F;
            this.PanelAnimator.DefaultAnimation = animation9;
            // 
            // LogoAnimator
            // 
            this.LogoAnimator.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.LogoAnimator.Cursor = null;
            animation8.AnimateOnlyDifferences = true;
            animation8.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.BlindCoeff")));
            animation8.LeafCoeff = 0F;
            animation8.MaxTime = 1F;
            animation8.MinTime = 0F;
            animation8.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.MosaicCoeff")));
            animation8.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation8.MosaicShift")));
            animation8.MosaicSize = 0;
            animation8.Padding = new System.Windows.Forms.Padding(30);
            animation8.RotateCoeff = 0.5F;
            animation8.RotateLimit = 0.2F;
            animation8.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.ScaleCoeff")));
            animation8.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.SlideCoeff")));
            animation8.TimeCoeff = 0F;
            animation8.TransparencyCoeff = 0F;
            this.LogoAnimator.DefaultAnimation = animation8;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.PanelBar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // timer
            // 
            this.timer.Interval = 2;
            // 
            // FormMainTaxi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1357, 800);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.PanelUC);
            this.Controls.Add(this.PanelBar);
            this.PanelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormMainTaxi";
            this.Text = "Form1";
            this.PanelMenu.ResumeLayout(false);
            this.PanelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.PanelBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BunifuAnimatorNS.BunifuTransition PanelAnimator2;
        private BunifuAnimatorNS.BunifuTransition LogoAnimator;
        private BunifuAnimatorNS.BunifuTransition PanelAnimator;
        private System.Windows.Forms.Button ButtonHistory;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Label LabelContact;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button ButtonOrders;
        private System.Windows.Forms.Panel PanelSlide;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel PanelUC;
        private System.Windows.Forms.Panel PanelBar;
        private Bunifu.Framework.UI.BunifuImageButton ButtonClose;
    }
}