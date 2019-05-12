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
            this.PanelBar = new System.Windows.Forms.Panel();
            this.PanelStatus = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.time = new System.Windows.Forms.Timer(this.components);
            this.PanelUC = new System.Windows.Forms.Panel();
            this.ButtonClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.TextBoxTo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextBoxFrom = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PanelSlide = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.ButtonRoute = new System.Windows.Forms.Button();
            this.ButtonAuto = new System.Windows.Forms.Button();
            this.ButtonPrice = new System.Windows.Forms.Button();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.PanelBar.SuspendLayout();
            this.PanelStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClose)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelBar
            // 
            this.PanelBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(151)))), ((int)(((byte)(4)))));
            this.PanelBar.Controls.Add(this.ButtonClose);
            this.PanelBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBar.Location = new System.Drawing.Point(225, 0);
            this.PanelBar.Name = "PanelBar";
            this.PanelBar.Size = new System.Drawing.Size(975, 27);
            this.PanelBar.TabIndex = 1;
            // 
            // PanelStatus
            // 
            this.PanelStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.PanelStatus.Controls.Add(this.TextBoxTo);
            this.PanelStatus.Controls.Add(this.TextBoxFrom);
            this.PanelStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelStatus.Location = new System.Drawing.Point(225, 27);
            this.PanelStatus.Name = "PanelStatus";
            this.PanelStatus.Size = new System.Drawing.Size(975, 73);
            this.PanelStatus.TabIndex = 2;
            // 
            // timer
            // 
            this.timer.Interval = 2;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(225, 100);
            this.panel3.TabIndex = 3;
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
            // time
            // 
            this.time.Tick += new System.EventHandler(this.time_Tick);
            // 
            // PanelUC
            // 
            this.PanelUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelUC.Location = new System.Drawing.Point(225, 100);
            this.PanelUC.Name = "PanelUC";
            this.PanelUC.Size = new System.Drawing.Size(975, 700);
            this.PanelUC.TabIndex = 4;
            // 
            // ButtonClose
            // 
            this.ButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(151)))), ((int)(((byte)(4)))));
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
            // TextBoxTo
            // 
            this.TextBoxTo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxTo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextBoxTo.ForeColor = System.Drawing.Color.White;
            this.TextBoxTo.HintForeColor = System.Drawing.Color.Empty;
            this.TextBoxTo.HintText = "";
            this.TextBoxTo.isPassword = false;
            this.TextBoxTo.LineFocusedColor = System.Drawing.Color.Blue;
            this.TextBoxTo.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(151)))), ((int)(((byte)(4)))));
            this.TextBoxTo.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TextBoxTo.LineThickness = 3;
            this.TextBoxTo.Location = new System.Drawing.Point(413, 9);
            this.TextBoxTo.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxTo.Name = "TextBoxTo";
            this.TextBoxTo.Size = new System.Drawing.Size(334, 44);
            this.TextBoxTo.TabIndex = 4;
            this.TextBoxTo.Text = "To";
            this.TextBoxTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TextBoxFrom
            // 
            this.TextBoxFrom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxFrom.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextBoxFrom.ForeColor = System.Drawing.Color.White;
            this.TextBoxFrom.HintForeColor = System.Drawing.Color.Empty;
            this.TextBoxFrom.HintText = "";
            this.TextBoxFrom.isPassword = false;
            this.TextBoxFrom.LineFocusedColor = System.Drawing.Color.Blue;
            this.TextBoxFrom.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(151)))), ((int)(((byte)(4)))));
            this.TextBoxFrom.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TextBoxFrom.LineThickness = 3;
            this.TextBoxFrom.Location = new System.Drawing.Point(55, 9);
            this.TextBoxFrom.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxFrom.Name = "TextBoxFrom";
            this.TextBoxFrom.Size = new System.Drawing.Size(334, 44);
            this.TextBoxFrom.TabIndex = 3;
            this.TextBoxFrom.Text = "From";
            this.TextBoxFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBoxFrom.OnValueChanged += new System.EventHandler(this.TextBoxFrom_OnValueChanged);
            // 
            // PanelSlide
            // 
            this.PanelSlide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(151)))), ((int)(((byte)(4)))));
            this.PanelSlide.Location = new System.Drawing.Point(0, 150);
            this.PanelSlide.Name = "PanelSlide";
            this.PanelSlide.Size = new System.Drawing.Size(8, 60);
            this.PanelSlide.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 100);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Taxi.Properties.Resources.IconTaxiOrange;
            this.pictureBox1.Location = new System.Drawing.Point(40, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(50)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = global::Taxi.Properties.Resources.menu;
            this.button6.Location = new System.Drawing.Point(193, 1);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(29, 24);
            this.button6.TabIndex = 1;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // ButtonRoute
            // 
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
            // ButtonAuto
            // 
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
            // ButtonPrice
            // 
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
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.PanelMenu.Controls.Add(this.ButtonPrice);
            this.PanelMenu.Controls.Add(this.ButtonAuto);
            this.PanelMenu.Controls.Add(this.ButtonRoute);
            this.PanelMenu.Controls.Add(this.panel1);
            this.PanelMenu.Controls.Add(this.PanelSlide);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(225, 800);
            this.PanelMenu.TabIndex = 0;
            this.PanelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelMenu_Paint);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.PanelUC);
            this.Controls.Add(this.PanelStatus);
            this.Controls.Add(this.PanelBar);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taxi";
            this.PanelBar.ResumeLayout(false);
            this.PanelStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClose)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelBar;
        private System.Windows.Forms.Panel PanelStatus;
        private Bunifu.Framework.UI.BunifuImageButton ButtonClose;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Timer time;
        private System.Windows.Forms.Panel PanelUC;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBoxTo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBoxFrom;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Button ButtonAuto;
        private System.Windows.Forms.Button ButtonPrice;
        private System.Windows.Forms.Button ButtonRoute;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PanelSlide;
    }
}