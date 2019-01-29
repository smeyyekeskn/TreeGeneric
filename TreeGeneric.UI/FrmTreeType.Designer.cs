namespace TreeGeneric.UI
{
    partial class FrmTreeType
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPassive = new System.Windows.Forms.RadioButton();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPlantingPrice = new System.Windows.Forms.TextBox();
            this.txtTreePrice = new System.Windows.Forms.TextBox();
            this.txtPhoto = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbTreeRegion = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPassive);
            this.groupBox1.Controls.Add(this.rbActive);
            this.groupBox1.Location = new System.Drawing.Point(466, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 49);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // rbPassive
            // 
            this.rbPassive.AutoSize = true;
            this.rbPassive.Location = new System.Drawing.Point(124, 19);
            this.rbPassive.Name = "rbPassive";
            this.rbPassive.Size = new System.Drawing.Size(50, 18);
            this.rbPassive.TabIndex = 1;
            this.rbPassive.TabStop = true;
            this.rbPassive.Text = "Pasif";
            this.rbPassive.UseVisualStyleBackColor = true;
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.Location = new System.Drawing.Point(7, 20);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(50, 18);
            this.rbActive.TabIndex = 0;
            this.rbActive.TabStop = true;
            this.rbActive.Text = "Aktif";
            this.rbActive.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(257, 242);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(178, 35);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "KAYDET";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPlantingPrice
            // 
            this.txtPlantingPrice.Location = new System.Drawing.Point(466, 68);
            this.txtPlantingPrice.Name = "txtPlantingPrice";
            this.txtPlantingPrice.Size = new System.Drawing.Size(187, 22);
            this.txtPlantingPrice.TabIndex = 29;
            // 
            // txtTreePrice
            // 
            this.txtTreePrice.Location = new System.Drawing.Point(466, 28);
            this.txtTreePrice.Name = "txtTreePrice";
            this.txtTreePrice.Size = new System.Drawing.Size(187, 22);
            this.txtTreePrice.TabIndex = 28;
            // 
            // txtPhoto
            // 
            this.txtPhoto.Location = new System.Drawing.Point(102, 144);
            this.txtPhoto.Name = "txtPhoto";
            this.txtPhoto.Size = new System.Drawing.Size(187, 22);
            this.txtPhoto.TabIndex = 27;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(102, 73);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(187, 56);
            this.txtDescription.TabIndex = 26;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(102, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(187, 22);
            this.txtName.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(374, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 14);
            this.label7.TabIndex = 24;
            this.label7.Text = "Aktif mi ? :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 14);
            this.label5.TabIndex = 22;
            this.label5.Text = "Dikim Fiyatı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 14);
            this.label4.TabIndex = 21;
            this.label4.Text = "Fidan Fiyatı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 14);
            this.label3.TabIndex = 20;
            this.label3.Text = "Fotoğraf :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 14);
            this.label2.TabIndex = 19;
            this.label2.Text = "Açıklama :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 14);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ad :";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(466, 104);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(187, 22);
            this.txtStock.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(329, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 14);
            this.label6.TabIndex = 23;
            this.label6.Text = "Stokta Kalan Adet :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 14);
            this.label8.TabIndex = 33;
            this.label8.Text = "Bölge :";
            // 
            // cbTreeRegion
            // 
            this.cbTreeRegion.FormattingEnabled = true;
            this.cbTreeRegion.Location = new System.Drawing.Point(103, 191);
            this.cbTreeRegion.Name = "cbTreeRegion";
            this.cbTreeRegion.Size = new System.Drawing.Size(186, 22);
            this.cbTreeRegion.TabIndex = 34;
            // 
            // FrmTreeType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 315);
            this.Controls.Add(this.cbTreeRegion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtPlantingPrice);
            this.Controls.Add(this.txtTreePrice);
            this.Controls.Add(this.txtPhoto);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "FrmTreeType";
            this.Text = "FrmTreeType";
            this.Load += new System.EventHandler(this.FrmTreeType_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPassive;
        private System.Windows.Forms.RadioButton rbActive;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPlantingPrice;
        private System.Windows.Forms.TextBox txtTreePrice;
        private System.Windows.Forms.TextBox txtPhoto;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbTreeRegion;
    }
}