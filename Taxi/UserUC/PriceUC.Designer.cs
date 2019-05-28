namespace Taxi.UserControls
{
    partial class PriceUC
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
            this.PanelBar = new System.Windows.Forms.Panel();
            this.PanelM = new System.Windows.Forms.Panel();
            this.label_Price = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.labelDistance = new System.Windows.Forms.Label();
            this.labelClass = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_From = new System.Windows.Forms.Label();
            this.label_To = new System.Windows.Forms.Label();
            this.label_Distance = new System.Windows.Forms.Label();
            this.label_Class = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonCreateOrder = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ButtonClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.PanelBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClose)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelBar
            // 
            this.PanelBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(151)))), ((int)(((byte)(4)))));
            this.PanelBar.Controls.Add(this.ButtonClose);
            this.PanelBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBar.Location = new System.Drawing.Point(0, 0);
            this.PanelBar.Name = "PanelBar";
            this.PanelBar.Size = new System.Drawing.Size(1143, 26);
            this.PanelBar.TabIndex = 8;
            this.PanelBar.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelBar_Paint);
            // 
            // PanelM
            // 
            this.PanelM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.PanelM.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelM.Location = new System.Drawing.Point(0, 26);
            this.PanelM.Name = "PanelM";
            this.PanelM.Size = new System.Drawing.Size(167, 774);
            this.PanelM.TabIndex = 10;
            this.PanelM.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelM_Paint);
            // 
            // label_Price
            // 
            this.label_Price.AutoSize = true;
            this.label_Price.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Price.ForeColor = System.Drawing.Color.White;
            this.label_Price.Location = new System.Drawing.Point(273, 67);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(140, 56);
            this.label_Price.TabIndex = 21;
            this.label_Price.Text = "Price";
            this.label_Price.Click += new System.EventHandler(this.label_Price_Click);
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFrom.ForeColor = System.Drawing.Color.White;
            this.labelFrom.Location = new System.Drawing.Point(208, 230);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(77, 28);
            this.labelFrom.TabIndex = 22;
            this.labelFrom.Text = "From:";
            this.labelFrom.Click += new System.EventHandler(this.labelFrom_Click);
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTo.ForeColor = System.Drawing.Color.White;
            this.labelTo.Location = new System.Drawing.Point(208, 292);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(44, 28);
            this.labelTo.TabIndex = 23;
            this.labelTo.Text = "To:";
            this.labelTo.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelDistance
            // 
            this.labelDistance.AutoSize = true;
            this.labelDistance.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDistance.ForeColor = System.Drawing.Color.White;
            this.labelDistance.Location = new System.Drawing.Point(208, 355);
            this.labelDistance.Name = "labelDistance";
            this.labelDistance.Size = new System.Drawing.Size(120, 28);
            this.labelDistance.TabIndex = 24;
            this.labelDistance.Text = "Distance:";
            this.labelDistance.Click += new System.EventHandler(this.labelDistance_Click);
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClass.ForeColor = System.Drawing.Color.White;
            this.labelClass.Location = new System.Drawing.Point(208, 420);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(82, 28);
            this.labelClass.TabIndex = 25;
            this.labelClass.Text = "Class:";
            this.labelClass.Click += new System.EventHandler(this.labelClass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(151)))), ((int)(((byte)(4)))));
            this.label1.Location = new System.Drawing.Point(208, 571);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 28);
            this.label1.TabIndex = 26;
            this.label1.Text = "In total:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label_From
            // 
            this.label_From.AutoSize = true;
            this.label_From.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_From.ForeColor = System.Drawing.Color.White;
            this.label_From.Location = new System.Drawing.Point(334, 228);
            this.label_From.Name = "label_From";
            this.label_From.Size = new System.Drawing.Size(152, 30);
            this.label_From.TabIndex = 27;
            this.label_From.Text = "LabelName";
            this.label_From.Click += new System.EventHandler(this.label_From_Click);
            // 
            // label_To
            // 
            this.label_To.AutoSize = true;
            this.label_To.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_To.ForeColor = System.Drawing.Color.White;
            this.label_To.Location = new System.Drawing.Point(334, 290);
            this.label_To.Name = "label_To";
            this.label_To.Size = new System.Drawing.Size(152, 30);
            this.label_To.TabIndex = 28;
            this.label_To.Text = "LabelName";
            this.label_To.Click += new System.EventHandler(this.label_To_Click);
            // 
            // label_Distance
            // 
            this.label_Distance.AutoSize = true;
            this.label_Distance.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Distance.ForeColor = System.Drawing.Color.White;
            this.label_Distance.Location = new System.Drawing.Point(334, 353);
            this.label_Distance.Name = "label_Distance";
            this.label_Distance.Size = new System.Drawing.Size(152, 30);
            this.label_Distance.TabIndex = 29;
            this.label_Distance.Text = "LabelName";
            this.label_Distance.Click += new System.EventHandler(this.label_Distance_Click);
            // 
            // label_Class
            // 
            this.label_Class.AutoSize = true;
            this.label_Class.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Class.ForeColor = System.Drawing.Color.White;
            this.label_Class.Location = new System.Drawing.Point(334, 418);
            this.label_Class.Name = "label_Class";
            this.label_Class.Size = new System.Drawing.Size(152, 30);
            this.label_Class.TabIndex = 30;
            this.label_Class.Text = "LabelName";
            this.label_Class.Click += new System.EventHandler(this.label_Class_Click);
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalPrice.ForeColor = System.Drawing.Color.White;
            this.labelTotalPrice.Location = new System.Drawing.Point(334, 569);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(152, 30);
            this.labelTotalPrice.TabIndex = 31;
            this.labelTotalPrice.Text = "LabelName";
            this.labelTotalPrice.Click += new System.EventHandler(this.labelTotalPrice_Click);
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemmory = 5;
            this.map.Location = new System.Drawing.Point(664, 140);
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
            this.map.Size = new System.Drawing.Size(459, 459);
            this.map.TabIndex = 32;
            this.map.Zoom = 0D;
            this.map.Load += new System.EventHandler(this.map_Load);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(151)))), ((int)(((byte)(4)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(167, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 774);
            this.panel1.TabIndex = 33;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(812, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 56);
            this.label2.TabIndex = 34;
            this.label2.Text = "Route";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ButtonCreateOrder
            // 
            this.ButtonCreateOrder.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(80)))), ((int)(((byte)(4)))));
            this.ButtonCreateOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(151)))), ((int)(((byte)(4)))));
            this.ButtonCreateOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonCreateOrder.BorderRadius = 4;
            this.ButtonCreateOrder.ButtonText = "Create order";
            this.ButtonCreateOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCreateOrder.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(80)))), ((int)(((byte)(4)))));
            this.ButtonCreateOrder.Iconcolor = System.Drawing.Color.Transparent;
            this.ButtonCreateOrder.Iconimage = null;
            this.ButtonCreateOrder.Iconimage_right = null;
            this.ButtonCreateOrder.Iconimage_right_Selected = null;
            this.ButtonCreateOrder.Iconimage_Selected = null;
            this.ButtonCreateOrder.IconMarginLeft = 0;
            this.ButtonCreateOrder.IconMarginRight = 0;
            this.ButtonCreateOrder.IconRightVisible = true;
            this.ButtonCreateOrder.IconRightZoom = 0D;
            this.ButtonCreateOrder.IconVisible = true;
            this.ButtonCreateOrder.IconZoom = 90D;
            this.ButtonCreateOrder.IsTab = false;
            this.ButtonCreateOrder.Location = new System.Drawing.Point(554, 685);
            this.ButtonCreateOrder.Name = "ButtonCreateOrder";
            this.ButtonCreateOrder.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(151)))), ((int)(((byte)(4)))));
            this.ButtonCreateOrder.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(80)))), ((int)(((byte)(4)))));
            this.ButtonCreateOrder.OnHoverTextColor = System.Drawing.Color.White;
            this.ButtonCreateOrder.selected = false;
            this.ButtonCreateOrder.Size = new System.Drawing.Size(214, 48);
            this.ButtonCreateOrder.TabIndex = 35;
            this.ButtonCreateOrder.Text = "Create order";
            this.ButtonCreateOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonCreateOrder.Textcolor = System.Drawing.Color.White;
            this.ButtonCreateOrder.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCreateOrder.Click += new System.EventHandler(this.ButtonCreateOrder_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(151)))), ((int)(((byte)(4)))));
            this.ButtonClose.Image = global::Taxi.Properties.Resources.close2;
            this.ButtonClose.ImageActive = null;
            this.ButtonClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ButtonClose.Location = new System.Drawing.Point(1110, 3);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(34, 21);
            this.ButtonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonClose.TabIndex = 23;
            this.ButtonClose.TabStop = false;
            this.ButtonClose.Zoom = 10;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.PanelBar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // PriceUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.ButtonCreateOrder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.map);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.label_Class);
            this.Controls.Add(this.label_Distance);
            this.Controls.Add(this.label_To);
            this.Controls.Add(this.label_From);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.labelDistance);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.label_Price);
            this.Controls.Add(this.PanelM);
            this.Controls.Add(this.PanelBar);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "PriceUC";
            this.Size = new System.Drawing.Size(1143, 800);
            this.Load += new System.EventHandler(this.Price_Load);
            this.PanelBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelBar;
        private Bunifu.Framework.UI.BunifuImageButton ButtonClose;
        private System.Windows.Forms.Panel PanelM;
        private System.Windows.Forms.Label label_Price;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Label labelDistance;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_From;
        private System.Windows.Forms.Label label_To;
        private System.Windows.Forms.Label label_Distance;
        private System.Windows.Forms.Label label_Class;
        private System.Windows.Forms.Label labelTotalPrice;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton ButtonCreateOrder;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}
