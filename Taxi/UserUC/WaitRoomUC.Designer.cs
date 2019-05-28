namespace Taxi.UserUC
{
    partial class WaitRoomUC
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
            this.ButtonClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.PanelM = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelOrder = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelCon = new System.Windows.Forms.Panel();
            this.labelContact = new System.Windows.Forms.Label();
            this.labelCar = new System.Windows.Forms.Label();
            this.labelCarNum = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCon = new System.Windows.Forms.Label();
            this.PanelBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panelCon.SuspendLayout();
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
            this.PanelBar.TabIndex = 36;
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
            // PanelM
            // 
            this.PanelM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.PanelM.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelM.Location = new System.Drawing.Point(0, 26);
            this.PanelM.Name = "PanelM";
            this.PanelM.Size = new System.Drawing.Size(167, 774);
            this.PanelM.TabIndex = 37;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(151)))), ((int)(((byte)(4)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(167, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 774);
            this.panel1.TabIndex = 50;
            // 
            // labelOrder
            // 
            this.labelOrder.AutoSize = true;
            this.labelOrder.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOrder.ForeColor = System.Drawing.Color.White;
            this.labelOrder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelOrder.Location = new System.Drawing.Point(451, 96);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(465, 88);
            this.labelOrder.TabIndex = 51;
            this.labelOrder.Text = "You order is created\r\nPlease waiting a free car\r\n";
            this.labelOrder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::Taxi.Properties.Resources.load;
            this.pictureBox.Location = new System.Drawing.Point(664, 197);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(43, 46);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 52;
            this.pictureBox.TabStop = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.PanelBar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panelCon
            // 
            this.panelCon.Controls.Add(this.labelContact);
            this.panelCon.Controls.Add(this.labelCar);
            this.panelCon.Controls.Add(this.labelCarNum);
            this.panelCon.Controls.Add(this.labelName);
            this.panelCon.Controls.Add(this.label3);
            this.panelCon.Controls.Add(this.label2);
            this.panelCon.Controls.Add(this.label1);
            this.panelCon.Controls.Add(this.labelCon);
            this.panelCon.Location = new System.Drawing.Point(469, 259);
            this.panelCon.Name = "panelCon";
            this.panelCon.Size = new System.Drawing.Size(459, 264);
            this.panelCon.TabIndex = 61;
            this.panelCon.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCon_Paint);
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelContact.ForeColor = System.Drawing.Color.White;
            this.labelContact.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelContact.Location = new System.Drawing.Point(232, 93);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(104, 33);
            this.labelContact.TabIndex = 68;
            this.labelContact.Text = "Name:";
            this.labelContact.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelCar
            // 
            this.labelCar.AutoSize = true;
            this.labelCar.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCar.ForeColor = System.Drawing.Color.White;
            this.labelCar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelCar.Location = new System.Drawing.Point(232, 138);
            this.labelCar.Name = "labelCar";
            this.labelCar.Size = new System.Drawing.Size(172, 33);
            this.labelCar.TabIndex = 67;
            this.labelCar.Text = "Reno Logan";
            this.labelCar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelCarNum
            // 
            this.labelCarNum.AutoSize = true;
            this.labelCarNum.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCarNum.ForeColor = System.Drawing.Color.White;
            this.labelCarNum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelCarNum.Location = new System.Drawing.Point(232, 189);
            this.labelCarNum.Name = "labelCarNum";
            this.labelCarNum.Size = new System.Drawing.Size(104, 33);
            this.labelCarNum.TabIndex = 66;
            this.labelCarNum.Text = "Name:";
            this.labelCarNum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelName.Location = new System.Drawing.Point(232, 42);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(104, 33);
            this.labelName.TabIndex = 65;
            this.labelName.Text = "Name:";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(41, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 32);
            this.label3.TabIndex = 64;
            this.label3.Text = "Car number:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(41, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 32);
            this.label2.TabIndex = 63;
            this.label2.Text = "Car:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(41, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 32);
            this.label1.TabIndex = 62;
            this.label1.Text = "Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelCon
            // 
            this.labelCon.AutoSize = true;
            this.labelCon.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCon.ForeColor = System.Drawing.Color.White;
            this.labelCon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelCon.Location = new System.Drawing.Point(41, 93);
            this.labelCon.Name = "labelCon";
            this.labelCon.Size = new System.Drawing.Size(128, 32);
            this.labelCon.TabIndex = 61;
            this.labelCon.Text = "Contact:";
            this.labelCon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // WaitRoomUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.panelCon);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.labelOrder);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelM);
            this.Controls.Add(this.PanelBar);
            this.Name = "WaitRoomUC";
            this.Size = new System.Drawing.Size(1143, 800);
            this.Load += new System.EventHandler(this.WaitRoomUC_Load);
            this.PanelBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panelCon.ResumeLayout(false);
            this.panelCon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton ButtonClose;
        private System.Windows.Forms.Panel PanelBar;
        private System.Windows.Forms.Panel PanelM;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelOrder;
        private System.Windows.Forms.PictureBox pictureBox;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panelCon;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.Label labelCar;
        private System.Windows.Forms.Label labelCarNum;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCon;
    }
}
