namespace HarmonyHotel
{
    partial class Stock
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.harmonyHotelDataSet6 = new HarmonyHotel.HarmonyHotelDataSet6();
            this.tblStokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblStokTableAdapter = new HarmonyHotel.HarmonyHotelDataSet6TableAdapters.tblStokTableAdapter();
            this.stokidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunKodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunFiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minStokMiktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.harmonyHotelDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStokBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stokidDataGridViewTextBoxColumn,
            this.urunKodDataGridViewTextBoxColumn,
            this.urunAdDataGridViewTextBoxColumn,
            this.urunAdetDataGridViewTextBoxColumn,
            this.urunFiyatDataGridViewTextBoxColumn,
            this.minStokMiktarDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblStokBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1020, 352);
            this.dataGridView1.TabIndex = 0;
            // 
            // harmonyHotelDataSet6
            // 
            this.harmonyHotelDataSet6.DataSetName = "HarmonyHotelDataSet6";
            this.harmonyHotelDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblStokBindingSource
            // 
            this.tblStokBindingSource.DataMember = "tblStok";
            this.tblStokBindingSource.DataSource = this.harmonyHotelDataSet6;
            // 
            // tblStokTableAdapter
            // 
            this.tblStokTableAdapter.ClearBeforeFill = true;
            // 
            // stokidDataGridViewTextBoxColumn
            // 
            this.stokidDataGridViewTextBoxColumn.DataPropertyName = "Stokid";
            this.stokidDataGridViewTextBoxColumn.HeaderText = "Stokid";
            this.stokidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stokidDataGridViewTextBoxColumn.Name = "stokidDataGridViewTextBoxColumn";
            this.stokidDataGridViewTextBoxColumn.ReadOnly = true;
            this.stokidDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunKodDataGridViewTextBoxColumn
            // 
            this.urunKodDataGridViewTextBoxColumn.DataPropertyName = "UrunKod";
            this.urunKodDataGridViewTextBoxColumn.HeaderText = "UrunKod";
            this.urunKodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunKodDataGridViewTextBoxColumn.Name = "urunKodDataGridViewTextBoxColumn";
            this.urunKodDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunAdDataGridViewTextBoxColumn
            // 
            this.urunAdDataGridViewTextBoxColumn.DataPropertyName = "UrunAd";
            this.urunAdDataGridViewTextBoxColumn.HeaderText = "UrunAd";
            this.urunAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunAdDataGridViewTextBoxColumn.Name = "urunAdDataGridViewTextBoxColumn";
            this.urunAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunAdetDataGridViewTextBoxColumn
            // 
            this.urunAdetDataGridViewTextBoxColumn.DataPropertyName = "UrunAdet";
            this.urunAdetDataGridViewTextBoxColumn.HeaderText = "UrunAdet";
            this.urunAdetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunAdetDataGridViewTextBoxColumn.Name = "urunAdetDataGridViewTextBoxColumn";
            this.urunAdetDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunFiyatDataGridViewTextBoxColumn
            // 
            this.urunFiyatDataGridViewTextBoxColumn.DataPropertyName = "UrunFiyat";
            this.urunFiyatDataGridViewTextBoxColumn.HeaderText = "UrunFiyat";
            this.urunFiyatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunFiyatDataGridViewTextBoxColumn.Name = "urunFiyatDataGridViewTextBoxColumn";
            this.urunFiyatDataGridViewTextBoxColumn.Width = 125;
            // 
            // minStokMiktarDataGridViewTextBoxColumn
            // 
            this.minStokMiktarDataGridViewTextBoxColumn.DataPropertyName = "MinStokMiktar";
            this.minStokMiktarDataGridViewTextBoxColumn.HeaderText = "MinStokMiktar";
            this.minStokMiktarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.minStokMiktarDataGridViewTextBoxColumn.Name = "minStokMiktarDataGridViewTextBoxColumn";
            this.minStokMiktarDataGridViewTextBoxColumn.Width = 125;
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 376);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Stock";
            this.Text = "Stok";
            this.Load += new System.EventHandler(this.Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.harmonyHotelDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStokBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private HarmonyHotelDataSet6 harmonyHotelDataSet6;
        private System.Windows.Forms.BindingSource tblStokBindingSource;
        private HarmonyHotelDataSet6TableAdapters.tblStokTableAdapter tblStokTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunKodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunFiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minStokMiktarDataGridViewTextBoxColumn;
    }
}