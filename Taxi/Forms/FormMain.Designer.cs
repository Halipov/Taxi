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
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.PanelSlide = new System.Windows.Forms.Panel();
            this.PanelBar = new System.Windows.Forms.Panel();
            this.PanelStatus = new System.Windows.Forms.Panel();
            this.LabelRole = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.LabelTime = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.ButtonClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.PictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.ButtonPrice = new System.Windows.Forms.Button();
            this.ButtonAuto = new System.Windows.Forms.Button();
            this.ButtonRoute = new System.Windows.Forms.Button();
            this.ButtonLoc = new System.Windows.Forms.Button();
            this.ButtonHomeLoc = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelMenu.SuspendLayout();
            this.PanelBar.SuspendLayout();
            this.PanelStatus.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.PanelMenu.Controls.Add(this.ButtonPrice);
            this.PanelMenu.Controls.Add(this.ButtonAuto);
            this.PanelMenu.Controls.Add(this.ButtonRoute);
            this.PanelMenu.Controls.Add(this.ButtonLoc);
            this.PanelMenu.Controls.Add(this.ButtonHomeLoc);
            this.PanelMenu.Controls.Add(this.panel1);
            this.PanelMenu.Controls.Add(this.PanelSlide);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(225, 609);
            this.PanelMenu.TabIndex = 0;
            // 
            // PanelSlide
            // 
            this.PanelSlide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(151)))), ((int)(((byte)(4)))));
            this.PanelSlide.Location = new System.Drawing.Point(0, 150);
            this.PanelSlide.Name = "PanelSlide";
            this.PanelSlide.Size = new System.Drawing.Size(8, 60);
            this.PanelSlide.TabIndex = 3;
            // 
            // PanelBar
            // 
            this.PanelBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(151)))), ((int)(((byte)(4)))));
            this.PanelBar.Controls.Add(this.ButtonClose);
            this.PanelBar.Controls.Add(this.PictureBoxIcon);
            this.PanelBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBar.Location = new System.Drawing.Point(225, 0);
            this.PanelBar.Name = "PanelBar";
            this.PanelBar.Size = new System.Drawing.Size(857, 36);
            this.PanelBar.TabIndex = 1;
            // 
            // PanelStatus
            // 
            this.PanelStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.PanelStatus.Controls.Add(this.LabelTime);
            this.PanelStatus.Controls.Add(this.LabelRole);
            this.PanelStatus.Controls.Add(this.label3);
            this.PanelStatus.Controls.Add(this.LabelUser);
            this.PanelStatus.Controls.Add(this.label1);
            this.PanelStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelStatus.Location = new System.Drawing.Point(225, 36);
            this.PanelStatus.Name = "PanelStatus";
            this.PanelStatus.Size = new System.Drawing.Size(857, 64);
            this.PanelStatus.TabIndex = 2;
            // 
            // LabelRole
            // 
            this.LabelRole.AutoSize = true;
            this.LabelRole.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelRole.ForeColor = System.Drawing.Color.White;
            this.LabelRole.Location = new System.Drawing.Point(174, 37);
            this.LabelRole.Name = "LabelRole";
            this.LabelRole.Size = new System.Drawing.Size(40, 19);
            this.LabelRole.TabIndex = 3;
            this.LabelRole.Text = "User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(122, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Role:";
            // 
            // LabelUser
            // 
            this.LabelUser.AutoSize = true;
            this.LabelUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelUser.ForeColor = System.Drawing.Color.White;
            this.LabelUser.Location = new System.Drawing.Point(174, 9);
            this.LabelUser.Name = "LabelUser";
            this.LabelUser.Size = new System.Drawing.Size(40, 19);
            this.LabelUser.TabIndex = 1;
            this.LabelUser.Text = "User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(81, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome:";
            // 
            // timer
            // 
            this.timer.Interval = 5;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(225, 100);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Location = new System.Drawing.Point(180, 36);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(45, 64);
            this.panel4.TabIndex = 2;
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
            // LabelTime
            // 
            this.LabelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelTime.AutoSize = true;
            this.LabelTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelTime.ForeColor = System.Drawing.Color.White;
            this.LabelTime.Location = new System.Drawing.Point(736, 21);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(83, 19);
            this.LabelTime.TabIndex = 4;
            this.LabelTime.Text = "HH:MM:SS";
            // 
            // time
            // 
            this.time.Tick += new System.EventHandler(this.time_Tick);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(151)))), ((int)(((byte)(4)))));
            this.ButtonClose.Image = global::Taxi.Properties.Resources.close2;
            this.ButtonClose.ImageActive = null;
            this.ButtonClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ButtonClose.Location = new System.Drawing.Point(823, 3);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(29, 30);
            this.ButtonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonClose.TabIndex = 23;
            this.ButtonClose.TabStop = false;
            this.ButtonClose.Zoom = 10;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // PictureBoxIcon
            // 
            this.PictureBoxIcon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PictureBoxIcon.Image = global::Taxi.Properties.Resources.IconTaxi;
            this.PictureBoxIcon.Location = new System.Drawing.Point(363, -16);
            this.PictureBoxIcon.Name = "PictureBoxIcon";
            this.PictureBoxIcon.Size = new System.Drawing.Size(84, 65);
            this.PictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxIcon.TabIndex = 0;
            this.PictureBoxIcon.TabStop = false;
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
            this.ButtonPrice.Location = new System.Drawing.Point(7, 390);
            this.ButtonPrice.Name = "ButtonPrice";
            this.ButtonPrice.Size = new System.Drawing.Size(252, 60);
            this.ButtonPrice.TabIndex = 7;
            this.ButtonPrice.Text = "Price";
            this.ButtonPrice.UseVisualStyleBackColor = true;
            this.ButtonPrice.Click += new System.EventHandler(this.ButtonPrice_Click);
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
            this.ButtonAuto.Location = new System.Drawing.Point(6, 330);
            this.ButtonAuto.Name = "ButtonAuto";
            this.ButtonAuto.Size = new System.Drawing.Size(252, 60);
            this.ButtonAuto.TabIndex = 6;
            this.ButtonAuto.Text = "Select auto";
            this.ButtonAuto.UseVisualStyleBackColor = true;
            this.ButtonAuto.Click += new System.EventHandler(this.ButtonAuto_Click);
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
            this.ButtonRoute.Location = new System.Drawing.Point(6, 270);
            this.ButtonRoute.Name = "ButtonRoute";
            this.ButtonRoute.Size = new System.Drawing.Size(252, 60);
            this.ButtonRoute.TabIndex = 5;
            this.ButtonRoute.Text = "Route";
            this.ButtonRoute.UseVisualStyleBackColor = true;
            this.ButtonRoute.Click += new System.EventHandler(this.ButtonRoute_Click);
            // 
            // ButtonLoc
            // 
            this.ButtonLoc.FlatAppearance.BorderSize = 0;
            this.ButtonLoc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.ButtonLoc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(50)))));
            this.ButtonLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLoc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonLoc.ForeColor = System.Drawing.Color.White;
            this.ButtonLoc.Image = global::Taxi.Properties.Resources.place;
            this.ButtonLoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonLoc.Location = new System.Drawing.Point(6, 210);
            this.ButtonLoc.Name = "ButtonLoc";
            this.ButtonLoc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonLoc.Size = new System.Drawing.Size(252, 60);
            this.ButtonLoc.TabIndex = 4;
            this.ButtonLoc.Text = "Where to finish?";
            this.ButtonLoc.UseVisualStyleBackColor = true;
            this.ButtonLoc.Click += new System.EventHandler(this.ButtonLoc_Click);
            // 
            // ButtonHomeLoc
            // 
            this.ButtonHomeLoc.FlatAppearance.BorderSize = 0;
            this.ButtonHomeLoc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.ButtonHomeLoc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(50)))));
            this.ButtonHomeLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonHomeLoc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonHomeLoc.ForeColor = System.Drawing.Color.White;
            this.ButtonHomeLoc.Image = global::Taxi.Properties.Resources.home;
            this.ButtonHomeLoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonHomeLoc.Location = new System.Drawing.Point(6, 150);
            this.ButtonHomeLoc.Name = "ButtonHomeLoc";
            this.ButtonHomeLoc.Size = new System.Drawing.Size(252, 60);
            this.ButtonHomeLoc.TabIndex = 1;
            this.ButtonHomeLoc.Text = "Where are you?";
            this.ButtonHomeLoc.UseVisualStyleBackColor = true;
            this.ButtonHomeLoc.Click += new System.EventHandler(this.ButtonHomeLoc_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(50)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = global::Taxi.Properties.Resources.menu;
            this.button6.Location = new System.Drawing.Point(180, 1);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(42, 33);
            this.button6.TabIndex = 1;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
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
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1082, 609);
            this.Controls.Add(this.PanelStatus);
            this.Controls.Add(this.PanelBar);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taxi";
            this.PanelMenu.ResumeLayout(false);
            this.PanelBar.ResumeLayout(false);
            this.PanelStatus.ResumeLayout(false);
            this.PanelStatus.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel PanelBar;
        private System.Windows.Forms.Panel PanelStatus;
        private System.Windows.Forms.Button ButtonHomeLoc;
        private System.Windows.Forms.Button ButtonPrice;
        private System.Windows.Forms.Button ButtonAuto;
        private System.Windows.Forms.Button ButtonRoute;
        private System.Windows.Forms.Button ButtonLoc;
        private System.Windows.Forms.Panel PanelSlide;
        private System.Windows.Forms.PictureBox PictureBoxIcon;
        private System.Windows.Forms.Label LabelRole;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelUser;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton ButtonClose;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label LabelTime;
        private System.Windows.Forms.Timer time;
    }
}