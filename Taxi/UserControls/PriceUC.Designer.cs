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
            this.PanelBar = new System.Windows.Forms.Panel();
            this.ButtonClose = new Bunifu.Framework.UI.BunifuImageButton();
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
            this.PanelBar.Size = new System.Drawing.Size(1200, 26);
            this.PanelBar.TabIndex = 8;
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
            // 
            // PanelM
            // 
            this.PanelM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.PanelM.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelM.Location = new System.Drawing.Point(0, 26);
            this.PanelM.Name = "PanelM";
            this.PanelM.Size = new System.Drawing.Size(167, 774);
            this.PanelM.TabIndex = 10;
            // 
            // label_Price
            // 
            this.label_Price.AutoSize = true;
            this.label_Price.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Price.ForeColor = System.Drawing.Color.White;
            this.label_Price.Location = new System.Drawing.Point(614, 43);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(140, 56);
            this.label_Price.TabIndex = 21;
            this.label_Price.Text = "Price";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFrom.ForeColor = System.Drawing.Color.White;
            this.labelFrom.Location = new System.Drawing.Point(208, 142);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(77, 28);
            this.labelFrom.TabIndex = 22;
            this.labelFrom.Text = "From:";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTo.ForeColor = System.Drawing.Color.White;
            this.labelTo.Location = new System.Drawing.Point(208, 198);
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
            this.labelDistance.Location = new System.Drawing.Point(208, 256);
            this.labelDistance.Name = "labelDistance";
            this.labelDistance.Size = new System.Drawing.Size(120, 28);
            this.labelDistance.TabIndex = 24;
            this.labelDistance.Text = "Distance:";
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClass.ForeColor = System.Drawing.Color.White;
            this.labelClass.Location = new System.Drawing.Point(208, 315);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(82, 28);
            this.labelClass.TabIndex = 25;
            this.labelClass.Text = "Class:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(208, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 28);
            this.label1.TabIndex = 26;
            this.label1.Text = "In total:";
            // 
            // label_From
            // 
            this.label_From.AutoSize = true;
            this.label_From.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_From.ForeColor = System.Drawing.Color.White;
            this.label_From.Location = new System.Drawing.Point(334, 140);
            this.label_From.Name = "label_From";
            this.label_From.Size = new System.Drawing.Size(152, 30);
            this.label_From.TabIndex = 27;
            this.label_From.Text = "LabelName";
            // 
            // label_To
            // 
            this.label_To.AutoSize = true;
            this.label_To.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_To.ForeColor = System.Drawing.Color.White;
            this.label_To.Location = new System.Drawing.Point(334, 196);
            this.label_To.Name = "label_To";
            this.label_To.Size = new System.Drawing.Size(152, 30);
            this.label_To.TabIndex = 28;
            this.label_To.Text = "LabelName";
            // 
            // label_Distance
            // 
            this.label_Distance.AutoSize = true;
            this.label_Distance.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Distance.ForeColor = System.Drawing.Color.White;
            this.label_Distance.Location = new System.Drawing.Point(334, 254);
            this.label_Distance.Name = "label_Distance";
            this.label_Distance.Size = new System.Drawing.Size(152, 30);
            this.label_Distance.TabIndex = 29;
            this.label_Distance.Text = "LabelName";
            // 
            // label_Class
            // 
            this.label_Class.AutoSize = true;
            this.label_Class.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Class.ForeColor = System.Drawing.Color.White;
            this.label_Class.Location = new System.Drawing.Point(334, 313);
            this.label_Class.Name = "label_Class";
            this.label_Class.Size = new System.Drawing.Size(152, 30);
            this.label_Class.TabIndex = 30;
            this.label_Class.Text = "LabelName";
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalPrice.ForeColor = System.Drawing.Color.White;
            this.labelTotalPrice.Location = new System.Drawing.Point(334, 409);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(152, 30);
            this.labelTotalPrice.TabIndex = 31;
            this.labelTotalPrice.Text = "LabelName";
            // 
            // PriceUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
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
            this.Size = new System.Drawing.Size(1200, 800);
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
    }
}
