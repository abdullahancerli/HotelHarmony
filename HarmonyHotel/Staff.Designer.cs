namespace HarmonyHotel
{
    partial class Staff
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
            this.peridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perCinsiyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perTcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perGorevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perDurumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.harmonyHotelDataSet5 = new HarmonyHotel.HarmonyHotelDataSet5();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnIstatislik = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRaporluPersonel = new System.Windows.Forms.Label();
            this.lblGörev = new System.Windows.Forms.Label();
            this.lblPersonelSayi = new System.Windows.Forms.Label();
            this.lblErkekSayi = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAktifPersonel = new System.Windows.Forms.Label();
            this.lblIzinliPersonel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKadinSayi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tblPersonelTableAdapter = new HarmonyHotel.HarmonyHotelDataSet5TableAdapters.tblPersonelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.harmonyHotelDataSet5)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.peridDataGridViewTextBoxColumn,
            this.perAdDataGridViewTextBoxColumn,
            this.perSoyadDataGridViewTextBoxColumn,
            this.perCinsiyetDataGridViewTextBoxColumn,
            this.perTcDataGridViewTextBoxColumn,
            this.perTelefonDataGridViewTextBoxColumn,
            this.perGorevDataGridViewTextBoxColumn,
            this.perDurumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPersonelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1000, 444);
            this.dataGridView1.TabIndex = 0;
            // 
            // peridDataGridViewTextBoxColumn
            // 
            this.peridDataGridViewTextBoxColumn.DataPropertyName = "Perid";
            this.peridDataGridViewTextBoxColumn.HeaderText = "Perid";
            this.peridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.peridDataGridViewTextBoxColumn.Name = "peridDataGridViewTextBoxColumn";
            this.peridDataGridViewTextBoxColumn.ReadOnly = true;
            this.peridDataGridViewTextBoxColumn.Width = 125;
            // 
            // perAdDataGridViewTextBoxColumn
            // 
            this.perAdDataGridViewTextBoxColumn.DataPropertyName = "PerAd";
            this.perAdDataGridViewTextBoxColumn.HeaderText = "PerAd";
            this.perAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perAdDataGridViewTextBoxColumn.Name = "perAdDataGridViewTextBoxColumn";
            this.perAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // perSoyadDataGridViewTextBoxColumn
            // 
            this.perSoyadDataGridViewTextBoxColumn.DataPropertyName = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.HeaderText = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perSoyadDataGridViewTextBoxColumn.Name = "perSoyadDataGridViewTextBoxColumn";
            this.perSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // perCinsiyetDataGridViewTextBoxColumn
            // 
            this.perCinsiyetDataGridViewTextBoxColumn.DataPropertyName = "PerCinsiyet";
            this.perCinsiyetDataGridViewTextBoxColumn.HeaderText = "PerCinsiyet";
            this.perCinsiyetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perCinsiyetDataGridViewTextBoxColumn.Name = "perCinsiyetDataGridViewTextBoxColumn";
            this.perCinsiyetDataGridViewTextBoxColumn.Width = 125;
            // 
            // perTcDataGridViewTextBoxColumn
            // 
            this.perTcDataGridViewTextBoxColumn.DataPropertyName = "PerTc";
            this.perTcDataGridViewTextBoxColumn.HeaderText = "PerTc";
            this.perTcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perTcDataGridViewTextBoxColumn.Name = "perTcDataGridViewTextBoxColumn";
            this.perTcDataGridViewTextBoxColumn.Width = 125;
            // 
            // perTelefonDataGridViewTextBoxColumn
            // 
            this.perTelefonDataGridViewTextBoxColumn.DataPropertyName = "PerTelefon";
            this.perTelefonDataGridViewTextBoxColumn.HeaderText = "PerTelefon";
            this.perTelefonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perTelefonDataGridViewTextBoxColumn.Name = "perTelefonDataGridViewTextBoxColumn";
            this.perTelefonDataGridViewTextBoxColumn.Width = 125;
            // 
            // perGorevDataGridViewTextBoxColumn
            // 
            this.perGorevDataGridViewTextBoxColumn.DataPropertyName = "PerGorev";
            this.perGorevDataGridViewTextBoxColumn.HeaderText = "PerGorev";
            this.perGorevDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perGorevDataGridViewTextBoxColumn.Name = "perGorevDataGridViewTextBoxColumn";
            this.perGorevDataGridViewTextBoxColumn.Width = 125;
            // 
            // perDurumDataGridViewTextBoxColumn
            // 
            this.perDurumDataGridViewTextBoxColumn.DataPropertyName = "PerDurum";
            this.perDurumDataGridViewTextBoxColumn.HeaderText = "PerDurum";
            this.perDurumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perDurumDataGridViewTextBoxColumn.Name = "perDurumDataGridViewTextBoxColumn";
            this.perDurumDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblPersonelBindingSource
            // 
            this.tblPersonelBindingSource.DataMember = "tblPersonel";
            this.tblPersonelBindingSource.DataSource = this.harmonyHotelDataSet5;
            // 
            // harmonyHotelDataSet5
            // 
            this.harmonyHotelDataSet5.DataSetName = "HarmonyHotelDataSet5";
            this.harmonyHotelDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(4, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 444);
            this.panel1.TabIndex = 1;
            // 
            // btnIstatislik
            // 
            this.btnIstatislik.Location = new System.Drawing.Point(1011, 12);
            this.btnIstatislik.Name = "btnIstatislik";
            this.btnIstatislik.Size = new System.Drawing.Size(101, 42);
            this.btnIstatislik.TabIndex = 2;
            this.btnIstatislik.Text = "İstatislik";
            this.btnIstatislik.UseVisualStyleBackColor = true;
            this.btnIstatislik.Click += new System.EventHandler(this.btnIstatislik_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblRaporluPersonel);
            this.groupBox1.Controls.Add(this.lblGörev);
            this.groupBox1.Controls.Add(this.lblPersonelSayi);
            this.groupBox1.Controls.Add(this.lblErkekSayi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblAktifPersonel);
            this.groupBox1.Controls.Add(this.lblIzinliPersonel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblKadinSayi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(1011, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 373);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İstatislikler";
            this.groupBox1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 327);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Departman Sayısı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Toplam Personel Sayısı:";
            // 
            // lblRaporluPersonel
            // 
            this.lblRaporluPersonel.AutoSize = true;
            this.lblRaporluPersonel.Location = new System.Drawing.Point(284, 232);
            this.lblRaporluPersonel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblRaporluPersonel.Name = "lblRaporluPersonel";
            this.lblRaporluPersonel.Size = new System.Drawing.Size(19, 20);
            this.lblRaporluPersonel.TabIndex = 27;
            this.lblRaporluPersonel.Text = "0";
            // 
            // lblGörev
            // 
            this.lblGörev.AutoSize = true;
            this.lblGörev.Location = new System.Drawing.Point(284, 327);
            this.lblGörev.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblGörev.Name = "lblGörev";
            this.lblGörev.Size = new System.Drawing.Size(19, 20);
            this.lblGörev.TabIndex = 21;
            this.lblGörev.Text = "0";
            // 
            // lblPersonelSayi
            // 
            this.lblPersonelSayi.AutoSize = true;
            this.lblPersonelSayi.Location = new System.Drawing.Point(285, 35);
            this.lblPersonelSayi.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPersonelSayi.Name = "lblPersonelSayi";
            this.lblPersonelSayi.Size = new System.Drawing.Size(19, 20);
            this.lblPersonelSayi.TabIndex = 16;
            this.lblPersonelSayi.Text = "0";
            // 
            // lblErkekSayi
            // 
            this.lblErkekSayi.AutoSize = true;
            this.lblErkekSayi.Location = new System.Drawing.Point(284, 134);
            this.lblErkekSayi.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblErkekSayi.Name = "lblErkekSayi";
            this.lblErkekSayi.Size = new System.Drawing.Size(19, 20);
            this.lblErkekSayi.TabIndex = 20;
            this.lblErkekSayi.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 232);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Raporlu Personel:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(120, 281);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "İzinli Personel:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 134);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Erkek Personel Sayısı:";
            // 
            // lblAktifPersonel
            // 
            this.lblAktifPersonel.AutoSize = true;
            this.lblAktifPersonel.Location = new System.Drawing.Point(284, 180);
            this.lblAktifPersonel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAktifPersonel.Name = "lblAktifPersonel";
            this.lblAktifPersonel.Size = new System.Drawing.Size(19, 20);
            this.lblAktifPersonel.TabIndex = 25;
            this.lblAktifPersonel.Text = "0";
            // 
            // lblIzinliPersonel
            // 
            this.lblIzinliPersonel.AutoSize = true;
            this.lblIzinliPersonel.Location = new System.Drawing.Point(284, 281);
            this.lblIzinliPersonel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblIzinliPersonel.Name = "lblIzinliPersonel";
            this.lblIzinliPersonel.Size = new System.Drawing.Size(19, 20);
            this.lblIzinliPersonel.TabIndex = 23;
            this.lblIzinliPersonel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Kadın Personel Sayısı:";
            // 
            // lblKadinSayi
            // 
            this.lblKadinSayi.AutoSize = true;
            this.lblKadinSayi.Location = new System.Drawing.Point(285, 82);
            this.lblKadinSayi.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblKadinSayi.Name = "lblKadinSayi";
            this.lblKadinSayi.Size = new System.Drawing.Size(19, 20);
            this.lblKadinSayi.TabIndex = 18;
            this.lblKadinSayi.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Aktif Personel:";
            // 
            // tblPersonelTableAdapter
            // 
            this.tblPersonelTableAdapter.ClearBeforeFill = true;
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1434, 455);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnIstatislik);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personeller";
            this.Load += new System.EventHandler(this.Staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.harmonyHotelDataSet5)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnIstatislik;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRaporluPersonel;
        private System.Windows.Forms.Label lblGörev;
        private System.Windows.Forms.Label lblPersonelSayi;
        private System.Windows.Forms.Label lblErkekSayi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAktifPersonel;
        private System.Windows.Forms.Label lblIzinliPersonel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKadinSayi;
        private System.Windows.Forms.Label label4;
        private HarmonyHotelDataSet5 harmonyHotelDataSet5;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource;
        private HarmonyHotelDataSet5TableAdapters.tblPersonelTableAdapter tblPersonelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn peridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perCinsiyetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perTcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perGorevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perDurumDataGridViewTextBoxColumn;
    }
}