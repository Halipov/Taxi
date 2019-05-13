namespace Taxi.UserControls
{
    partial class RouteUC
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RouteUC));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.PanelStatus = new System.Windows.Forms.Panel();
            this.TextBoxTo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextBoxFrom = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.PanelBar = new System.Windows.Forms.Panel();
            this.ButtonClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.PanelStatus.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PanelBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClose)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.PanelBar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // PanelStatus
            // 
            this.PanelStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.PanelStatus.Controls.Add(this.bunifuThinButton21);
            this.PanelStatus.Controls.Add(this.TextBoxTo);
            this.PanelStatus.Controls.Add(this.TextBoxFrom);
            this.PanelStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelStatus.Location = new System.Drawing.Point(0, 26);
            this.PanelStatus.Name = "PanelStatus";
            this.PanelStatus.Size = new System.Drawing.Size(1200, 74);
            this.PanelStatus.TabIndex = 8;
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
            this.TextBoxTo.Location = new System.Drawing.Point(635, 16);
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
            this.TextBoxFrom.Location = new System.Drawing.Point(277, 16);
            this.TextBoxFrom.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxFrom.Name = "TextBoxFrom";
            this.TextBoxFrom.Size = new System.Drawing.Size(334, 44);
            this.TextBoxFrom.TabIndex = 3;
            this.TextBoxFrom.Text = "From";
            this.TextBoxFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.map);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 700);
            this.panel1.TabIndex = 9;
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemmory = 5;
            this.map.Location = new System.Drawing.Point(0, 0);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(1200, 700);
            this.map.TabIndex = 0;
            this.map.Zoom = 0D;
            this.map.Load += new System.EventHandler(this.map_Load);
            // 
            // PanelBar
            // 
            this.PanelBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(151)))), ((int)(((byte)(4)))));
            this.PanelBar.Controls.Add(this.ButtonClose);
            this.PanelBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBar.Location = new System.Drawing.Point(0, 0);
            this.PanelBar.Name = "PanelBar";
            this.PanelBar.Size = new System.Drawing.Size(1200, 26);
            this.PanelBar.TabIndex = 7;
            // 
            // ButtonClose
            // 
            this.ButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(151)))), ((int)(((byte)(4)))));
            this.ButtonClose.Image = global::Taxi.Properties.Resources.close2;
            this.ButtonClose.ImageActive = null;
            this.ButtonClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ButtonClose.Location = new System.Drawing.Point(1167, 3);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(34, 21);
            this.ButtonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonClose.TabIndex = 23;
            this.ButtonClose.TabStop = false;
            this.ButtonClose.Zoom = 10;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click_1);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(80)))), ((int)(((byte)(4)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(80)))), ((int)(((byte)(4)))));
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Route";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(151)))), ((int)(((byte)(4)))));
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(80)))), ((int)(((byte)(4)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(1011, 19);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(117, 41);
            this.bunifuThinButton21.TabIndex = 5;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RouteUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelStatus);
            this.Controls.Add(this.PanelBar);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RouteUC";
            this.Size = new System.Drawing.Size(1200, 800);
            this.Load += new System.EventHandler(this.Route_Load);
            this.PanelStatus.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.PanelBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel PanelStatus;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBoxTo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBoxFrom;
        private System.Windows.Forms.Panel panel1;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Panel PanelBar;
        private Bunifu.Framework.UI.BunifuImageButton ButtonClose;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
    }
}
