namespace HarmonyHotel
{
    partial class CustomerRegistration
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.mskdTel = new System.Windows.Forms.MaskedTextBox();
            this.RadioKadin = new System.Windows.Forms.RadioButton();
            this.RadioErkek = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOda = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.musidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musCinsiyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musTcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musOdaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musUcretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musGirisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musCikisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblMusteriKayitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.harmonyHotelDataSet = new HarmonyHotel.HarmonyHotelDataSet();
            this.tblMusteriKayitTableAdapter = new HarmonyHotel.HarmonyHotelDataSetTableAdapters.tblMusteriKayitTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMusteriKayitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.harmonyHotelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(217, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 53);
            this.button1.TabIndex = 11;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(165, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txtTc);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.mskdTel);
            this.groupBox1.Controls.Add(this.RadioKadin);
            this.groupBox1.Controls.Add(this.RadioErkek);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtOda);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtUcret);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 580);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(470, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 25);
            this.label10.TabIndex = 12;
            this.label10.Text = "  ";
            this.label10.Visible = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(217, 446);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(299, 30);
            this.dateTimePicker2.TabIndex = 10;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(217, 397);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(299, 30);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // txtTc
            // 
            this.txtTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTc.Location = new System.Drawing.Point(217, 245);
            this.txtTc.MaxLength = 11;
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(197, 30);
            this.txtTc.TabIndex = 6;
            // 
            // mskdTel
            // 
            this.mskdTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskdTel.Location = new System.Drawing.Point(217, 195);
            this.mskdTel.Mask = "(999) 000-0000";
            this.mskdTel.Name = "mskdTel";
            this.mskdTel.Size = new System.Drawing.Size(197, 30);
            this.mskdTel.TabIndex = 5;
            // 
            // RadioKadin
            // 
            this.RadioKadin.AutoSize = true;
            this.RadioKadin.Location = new System.Drawing.Point(325, 143);
            this.RadioKadin.Name = "RadioKadin";
            this.RadioKadin.Size = new System.Drawing.Size(89, 29);
            this.RadioKadin.TabIndex = 4;
            this.RadioKadin.TabStop = true;
            this.RadioKadin.Text = "Kadın";
            this.RadioKadin.UseVisualStyleBackColor = true;
            // 
            // RadioErkek
            // 
            this.RadioErkek.AutoSize = true;
            this.RadioErkek.Location = new System.Drawing.Point(217, 143);
            this.RadioErkek.Name = "RadioErkek";
            this.RadioErkek.Size = new System.Drawing.Size(88, 29);
            this.RadioErkek.TabIndex = 3;
            this.RadioErkek.TabStop = true;
            this.RadioErkek.Text = "Erkek";
            this.RadioErkek.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(83, 446);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Çıkış Tarihi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(140, 346);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 25);
            this.label9.TabIndex = 11;
            this.label9.Text = "Ücret:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(114, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cinsiyet:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(87, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Giriş Tarihi:";
            // 
            // txtOda
            // 
            this.txtOda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOda.Location = new System.Drawing.Point(217, 294);
            this.txtOda.Name = "txtOda";
            this.txtOda.Size = new System.Drawing.Size(197, 30);
            this.txtOda.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(151, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "Oda:";
            // 
            // txtUcret
            // 
            this.txtUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUcret.Location = new System.Drawing.Point(217, 343);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(197, 30);
            this.txtUcret.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(130, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Soyad:";
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(217, 41);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(197, 30);
            this.txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(217, 91);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(197, 30);
            this.txtSoyad.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(162, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "TC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(119, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefon:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(592, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(643, 407);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Odalar";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 598);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1250, 197);
            this.panel1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musidDataGridViewTextBoxColumn,
            this.musAdDataGridViewTextBoxColumn,
            this.musSoyadDataGridViewTextBoxColumn,
            this.musCinsiyetDataGridViewTextBoxColumn,
            this.musTelefonDataGridViewTextBoxColumn,
            this.musTcDataGridViewTextBoxColumn,
            this.musOdaDataGridViewTextBoxColumn,
            this.musUcretDataGridViewTextBoxColumn,
            this.musGirisDataGridViewTextBoxColumn,
            this.musCikisDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblMusteriKayitBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1250, 197);
            this.dataGridView1.TabIndex = 0;
            // 
            // musidDataGridViewTextBoxColumn
            // 
            this.musidDataGridViewTextBoxColumn.DataPropertyName = "Musid";
            this.musidDataGridViewTextBoxColumn.HeaderText = "Musid";
            this.musidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musidDataGridViewTextBoxColumn.Name = "musidDataGridViewTextBoxColumn";
            this.musidDataGridViewTextBoxColumn.ReadOnly = true;
            this.musidDataGridViewTextBoxColumn.Width = 125;
            // 
            // musAdDataGridViewTextBoxColumn
            // 
            this.musAdDataGridViewTextBoxColumn.DataPropertyName = "MusAd";
            this.musAdDataGridViewTextBoxColumn.HeaderText = "MusAd";
            this.musAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musAdDataGridViewTextBoxColumn.Name = "musAdDataGridViewTextBoxColumn";
            this.musAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // musSoyadDataGridViewTextBoxColumn
            // 
            this.musSoyadDataGridViewTextBoxColumn.DataPropertyName = "MusSoyad";
            this.musSoyadDataGridViewTextBoxColumn.HeaderText = "MusSoyad";
            this.musSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musSoyadDataGridViewTextBoxColumn.Name = "musSoyadDataGridViewTextBoxColumn";
            this.musSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // musCinsiyetDataGridViewTextBoxColumn
            // 
            this.musCinsiyetDataGridViewTextBoxColumn.DataPropertyName = "MusCinsiyet";
            this.musCinsiyetDataGridViewTextBoxColumn.HeaderText = "MusCinsiyet";
            this.musCinsiyetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musCinsiyetDataGridViewTextBoxColumn.Name = "musCinsiyetDataGridViewTextBoxColumn";
            this.musCinsiyetDataGridViewTextBoxColumn.Width = 125;
            // 
            // musTelefonDataGridViewTextBoxColumn
            // 
            this.musTelefonDataGridViewTextBoxColumn.DataPropertyName = "MusTelefon";
            this.musTelefonDataGridViewTextBoxColumn.HeaderText = "MusTelefon";
            this.musTelefonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musTelefonDataGridViewTextBoxColumn.Name = "musTelefonDataGridViewTextBoxColumn";
            this.musTelefonDataGridViewTextBoxColumn.Width = 125;
            // 
            // musTcDataGridViewTextBoxColumn
            // 
            this.musTcDataGridViewTextBoxColumn.DataPropertyName = "MusTc";
            this.musTcDataGridViewTextBoxColumn.HeaderText = "MusTc";
            this.musTcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musTcDataGridViewTextBoxColumn.Name = "musTcDataGridViewTextBoxColumn";
            this.musTcDataGridViewTextBoxColumn.Width = 125;
            // 
            // musOdaDataGridViewTextBoxColumn
            // 
            this.musOdaDataGridViewTextBoxColumn.DataPropertyName = "MusOda";
            this.musOdaDataGridViewTextBoxColumn.HeaderText = "MusOda";
            this.musOdaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musOdaDataGridViewTextBoxColumn.Name = "musOdaDataGridViewTextBoxColumn";
            this.musOdaDataGridViewTextBoxColumn.Width = 125;
            // 
            // musUcretDataGridViewTextBoxColumn
            // 
            this.musUcretDataGridViewTextBoxColumn.DataPropertyName = "MusUcret";
            this.musUcretDataGridViewTextBoxColumn.HeaderText = "MusUcret";
            this.musUcretDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musUcretDataGridViewTextBoxColumn.Name = "musUcretDataGridViewTextBoxColumn";
            this.musUcretDataGridViewTextBoxColumn.Width = 125;
            // 
            // musGirisDataGridViewTextBoxColumn
            // 
            this.musGirisDataGridViewTextBoxColumn.DataPropertyName = "MusGiris";
            this.musGirisDataGridViewTextBoxColumn.HeaderText = "MusGiris";
            this.musGirisDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musGirisDataGridViewTextBoxColumn.Name = "musGirisDataGridViewTextBoxColumn";
            this.musGirisDataGridViewTextBoxColumn.Width = 125;
            // 
            // musCikisDataGridViewTextBoxColumn
            // 
            this.musCikisDataGridViewTextBoxColumn.DataPropertyName = "MusCikis";
            this.musCikisDataGridViewTextBoxColumn.HeaderText = "MusCikis";
            this.musCikisDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musCikisDataGridViewTextBoxColumn.Name = "musCikisDataGridViewTextBoxColumn";
            this.musCikisDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblMusteriKayitBindingSource
            // 
            this.tblMusteriKayitBindingSource.DataMember = "tblMusteriKayit";
            this.tblMusteriKayitBindingSource.DataSource = this.harmonyHotelDataSet;
            // 
            // harmonyHotelDataSet
            // 
            this.harmonyHotelDataSet.DataSetName = "HarmonyHotelDataSet";
            this.harmonyHotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblMusteriKayitTableAdapter
            // 
            this.tblMusteriKayitTableAdapter.ClearBeforeFill = true;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 0;
            // 
            // CustomerRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1274, 807);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "CustomerRegistration";
            this.Text = "Müşteri Kayıt";
            this.Load += new System.EventHandler(this.CustomerRegistration_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMusteriKayitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.harmonyHotelDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtOda;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.MaskedTextBox mskdTel;
        private System.Windows.Forms.RadioButton RadioKadin;
        private System.Windows.Forms.RadioButton RadioErkek;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private HarmonyHotelDataSet harmonyHotelDataSet;
        private System.Windows.Forms.BindingSource tblMusteriKayitBindingSource;
        private HarmonyHotelDataSetTableAdapters.tblMusteriKayitTableAdapter tblMusteriKayitTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn musidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musCinsiyetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musTcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musOdaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musUcretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musGirisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musCikisDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}