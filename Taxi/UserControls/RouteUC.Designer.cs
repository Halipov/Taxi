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
            this.PanelStatus = new System.Windows.Forms.Panel();
            this.TextBoxTo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextBoxFrom = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panelmap = new System.Windows.Forms.Panel();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.PanelStatus.SuspendLayout();
            this.panelmap.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelStatus
            // 
            this.PanelStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.PanelStatus.Controls.Add(this.TextBoxTo);
            this.PanelStatus.Controls.Add(this.TextBoxFrom);
            this.PanelStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelStatus.Location = new System.Drawing.Point(0, 0);
            this.PanelStatus.Name = "PanelStatus";
            this.PanelStatus.Size = new System.Drawing.Size(975, 74);
            this.PanelStatus.TabIndex = 3;
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
            // 
            // panelmap
            // 
            this.panelmap.Controls.Add(this.map);
            this.panelmap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelmap.Location = new System.Drawing.Point(0, 74);
            this.panelmap.Name = "panelmap";
            this.panelmap.Size = new System.Drawing.Size(975, 699);
            this.panelmap.TabIndex = 4;
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
            this.map.Size = new System.Drawing.Size(975, 699);
            this.map.TabIndex = 3;
            this.map.Zoom = 0D;
            this.map.Load += new System.EventHandler(this.map_Load_1);
            // 
            // RouteUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelmap);
            this.Controls.Add(this.PanelStatus);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RouteUC";
            this.Size = new System.Drawing.Size(975, 773);
            this.Load += new System.EventHandler(this.Route_Load);
            this.PanelStatus.ResumeLayout(false);
            this.panelmap.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelStatus;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBoxTo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBoxFrom;
        private System.Windows.Forms.Panel panelmap;
        private GMap.NET.WindowsForms.GMapControl map;
    }
}
