namespace TreeGeneric.UI
{
    partial class FrmTreeTypes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddTreeType = new System.Windows.Forms.Button();
            this.btnEditTreeType = new System.Windows.Forms.Button();
            this.btnDeleteTreeType = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDeleteTreeType);
            this.panel1.Controls.Add(this.btnEditTreeType);
            this.panel1.Controls.Add(this.btnAddTreeType);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 77);
            this.panel1.TabIndex = 0;
            // 
            // btnAddTreeType
            // 
            this.btnAddTreeType.Location = new System.Drawing.Point(52, 32);
            this.btnAddTreeType.Name = "btnAddTreeType";
            this.btnAddTreeType.Size = new System.Drawing.Size(122, 23);
            this.btnAddTreeType.TabIndex = 0;
            this.btnAddTreeType.Text = "Fidan Tipi Ekle";
            this.btnAddTreeType.UseVisualStyleBackColor = true;
            this.btnAddTreeType.Click += new System.EventHandler(this.btnAddTreeType_Click);
            // 
            // btnEditTreeType
            // 
            this.btnEditTreeType.Location = new System.Drawing.Point(233, 32);
            this.btnEditTreeType.Name = "btnEditTreeType";
            this.btnEditTreeType.Size = new System.Drawing.Size(151, 23);
            this.btnEditTreeType.TabIndex = 1;
            this.btnEditTreeType.Text = "Fidan Tipi Güncelle";
            this.btnEditTreeType.UseVisualStyleBackColor = true;
            this.btnEditTreeType.Click += new System.EventHandler(this.btnEditTreeType_Click);
            // 
            // btnDeleteTreeType
            // 
            this.btnDeleteTreeType.Location = new System.Drawing.Point(439, 32);
            this.btnDeleteTreeType.Name = "btnDeleteTreeType";
            this.btnDeleteTreeType.Size = new System.Drawing.Size(129, 23);
            this.btnDeleteTreeType.TabIndex = 2;
            this.btnDeleteTreeType.Text = "Fidan Tipi Sil";
            this.btnDeleteTreeType.UseVisualStyleBackColor = true;
            this.btnDeleteTreeType.Click += new System.EventHandler(this.btnDeleteTreeType_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(635, 298);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Fidan Adı";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TreePrice";
            this.Column3.HeaderText = "Fidan Fiyatı";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "UnitPrice";
            this.Column4.HeaderText = "Fidan Dikim Fiyatı";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "RegionId";
            this.Column5.HeaderText = "Fidan Dikim Bölgesi";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // FrmTreeTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 375);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "FrmTreeTypes";
            this.Text = "Fidan Tipleri";
            this.Load += new System.EventHandler(this.FrmTreeTypes_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDeleteTreeType;
        private System.Windows.Forms.Button btnEditTreeType;
        private System.Windows.Forms.Button btnAddTreeType;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}