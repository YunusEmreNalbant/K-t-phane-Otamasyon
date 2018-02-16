namespace Kütüphane_Otamasyon
{
    partial class FrmOkuyucuEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOkuyucuEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtOkuyucuSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtOkuyucuAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtOkuyucuMail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MskOkuyucuTC = new System.Windows.Forms.MaskedTextBox();
            this.MskOkuyucuTelefon = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.üyeTCNumarasıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doğumTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonNumarasıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblOkurlarBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.kütüphaneOtomasyonDataSet5 = new Kütüphane_Otamasyon.KütüphaneOtomasyonDataSet5();
            this.tblOkurlarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kütüphaneOtomasyonDataSet4 = new Kütüphane_Otamasyon.KütüphaneOtomasyonDataSet4();
            this.kütüphaneOtomasyonDataSet3 = new Kütüphane_Otamasyon.KütüphaneOtomasyonDataSet3();
            this.tblOkurlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_OkurlarTableAdapter = new Kütüphane_Otamasyon.KütüphaneOtomasyonDataSet3TableAdapters.Tbl_OkurlarTableAdapter();
            this.tbl_OkurlarTableAdapter1 = new Kütüphane_Otamasyon.KütüphaneOtomasyonDataSet4TableAdapters.Tbl_OkurlarTableAdapter();
            this.tbl_OkurlarTableAdapter2 = new Kütüphane_Otamasyon.KütüphaneOtomasyonDataSet5TableAdapters.Tbl_OkurlarTableAdapter();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOkurlarBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneOtomasyonDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOkurlarBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneOtomasyonDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneOtomasyonDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOkurlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(20, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik Numarası:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(37, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefon Numarası:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(69, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Doğum Tarihi:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TxtOkuyucuSoyad
            // 
            this.TxtOkuyucuSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOkuyucuSoyad.Location = new System.Drawing.Point(198, 151);
            this.TxtOkuyucuSoyad.Name = "TxtOkuyucuSoyad";
            this.TxtOkuyucuSoyad.Size = new System.Drawing.Size(226, 24);
            this.TxtOkuyucuSoyad.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(122, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Soyadı:";
            // 
            // TxtOkuyucuAd
            // 
            this.TxtOkuyucuAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOkuyucuAd.Location = new System.Drawing.Point(198, 100);
            this.TxtOkuyucuAd.Name = "TxtOkuyucuAd";
            this.TxtOkuyucuAd.Size = new System.Drawing.Size(226, 24);
            this.TxtOkuyucuAd.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(148, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Adı:";
            // 
            // TxtOkuyucuMail
            // 
            this.TxtOkuyucuMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOkuyucuMail.Location = new System.Drawing.Point(194, 315);
            this.TxtOkuyucuMail.Name = "TxtOkuyucuMail";
            this.TxtOkuyucuMail.Size = new System.Drawing.Size(230, 24);
            this.TxtOkuyucuMail.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(141, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mail:";
            // 
            // MskOkuyucuTC
            // 
            this.MskOkuyucuTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskOkuyucuTC.Location = new System.Drawing.Point(198, 46);
            this.MskOkuyucuTC.Mask = "00000000000";
            this.MskOkuyucuTC.Name = "MskOkuyucuTC";
            this.MskOkuyucuTC.Size = new System.Drawing.Size(230, 24);
            this.MskOkuyucuTC.TabIndex = 1;
            // 
            // MskOkuyucuTelefon
            // 
            this.MskOkuyucuTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskOkuyucuTelefon.Location = new System.Drawing.Point(194, 265);
            this.MskOkuyucuTelefon.Mask = "(999) 000-0000";
            this.MskOkuyucuTelefon.Name = "MskOkuyucuTelefon";
            this.MskOkuyucuTelefon.Size = new System.Drawing.Size(230, 24);
            this.MskOkuyucuTelefon.TabIndex = 5;
            this.MskOkuyucuTelefon.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(198, 402);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(146, 96);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(364, 402);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(146, 96);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 402);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.MskOkuyucuTC);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.MskOkuyucuTelefon);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtOkuyucuSoyad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtOkuyucuMail);
            this.groupBox1.Controls.Add(this.TxtOkuyucuAd);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 524);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Okuyucu Kayıt";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(196, 214);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(239, 22);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.üyeTCNumarasıDataGridViewTextBoxColumn,
            this.adıDataGridViewTextBoxColumn,
            this.soyadıDataGridViewTextBoxColumn,
            this.doğumTarihiDataGridViewTextBoxColumn,
            this.telefonNumarasıDataGridViewTextBoxColumn,
            this.eMailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblOkurlarBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(579, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(842, 512);
            this.dataGridView1.TabIndex = 22;
            // 
            // üyeTCNumarasıDataGridViewTextBoxColumn
            // 
            this.üyeTCNumarasıDataGridViewTextBoxColumn.DataPropertyName = "Üye T_C_ Numarası";
            this.üyeTCNumarasıDataGridViewTextBoxColumn.HeaderText = "Üye T_C_ Numarası";
            this.üyeTCNumarasıDataGridViewTextBoxColumn.Name = "üyeTCNumarasıDataGridViewTextBoxColumn";
            // 
            // adıDataGridViewTextBoxColumn
            // 
            this.adıDataGridViewTextBoxColumn.DataPropertyName = "Adı";
            this.adıDataGridViewTextBoxColumn.HeaderText = "Adı";
            this.adıDataGridViewTextBoxColumn.MinimumWidth = 155;
            this.adıDataGridViewTextBoxColumn.Name = "adıDataGridViewTextBoxColumn";
            this.adıDataGridViewTextBoxColumn.Width = 155;
            // 
            // soyadıDataGridViewTextBoxColumn
            // 
            this.soyadıDataGridViewTextBoxColumn.DataPropertyName = "Soyadı";
            this.soyadıDataGridViewTextBoxColumn.HeaderText = "Soyadı";
            this.soyadıDataGridViewTextBoxColumn.MinimumWidth = 155;
            this.soyadıDataGridViewTextBoxColumn.Name = "soyadıDataGridViewTextBoxColumn";
            this.soyadıDataGridViewTextBoxColumn.Width = 155;
            // 
            // doğumTarihiDataGridViewTextBoxColumn
            // 
            this.doğumTarihiDataGridViewTextBoxColumn.DataPropertyName = "Doğum Tarihi";
            this.doğumTarihiDataGridViewTextBoxColumn.HeaderText = "Doğum Tarihi";
            this.doğumTarihiDataGridViewTextBoxColumn.Name = "doğumTarihiDataGridViewTextBoxColumn";
            // 
            // telefonNumarasıDataGridViewTextBoxColumn
            // 
            this.telefonNumarasıDataGridViewTextBoxColumn.DataPropertyName = "Telefon Numarası";
            this.telefonNumarasıDataGridViewTextBoxColumn.HeaderText = "Telefon Numarası";
            this.telefonNumarasıDataGridViewTextBoxColumn.Name = "telefonNumarasıDataGridViewTextBoxColumn";
            // 
            // eMailDataGridViewTextBoxColumn
            // 
            this.eMailDataGridViewTextBoxColumn.DataPropertyName = "E-Mail";
            this.eMailDataGridViewTextBoxColumn.HeaderText = "E-Mail";
            this.eMailDataGridViewTextBoxColumn.MinimumWidth = 188;
            this.eMailDataGridViewTextBoxColumn.Name = "eMailDataGridViewTextBoxColumn";
            this.eMailDataGridViewTextBoxColumn.Width = 188;
            // 
            // tblOkurlarBindingSource2
            // 
            this.tblOkurlarBindingSource2.DataMember = "Tbl_Okurlar";
            this.tblOkurlarBindingSource2.DataSource = this.kütüphaneOtomasyonDataSet5;
            // 
            // kütüphaneOtomasyonDataSet5
            // 
            this.kütüphaneOtomasyonDataSet5.DataSetName = "KütüphaneOtomasyonDataSet5";
            this.kütüphaneOtomasyonDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblOkurlarBindingSource1
            // 
            this.tblOkurlarBindingSource1.DataMember = "Tbl_Okurlar";
            this.tblOkurlarBindingSource1.DataSource = this.kütüphaneOtomasyonDataSet4;
            // 
            // kütüphaneOtomasyonDataSet4
            // 
            this.kütüphaneOtomasyonDataSet4.DataSetName = "KütüphaneOtomasyonDataSet4";
            this.kütüphaneOtomasyonDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kütüphaneOtomasyonDataSet3
            // 
            this.kütüphaneOtomasyonDataSet3.DataSetName = "KütüphaneOtomasyonDataSet3";
            this.kütüphaneOtomasyonDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblOkurlarBindingSource
            // 
            this.tblOkurlarBindingSource.DataMember = "Tbl_Okurlar";
            this.tblOkurlarBindingSource.DataSource = this.kütüphaneOtomasyonDataSet3;
            // 
            // tbl_OkurlarTableAdapter
            // 
            this.tbl_OkurlarTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_OkurlarTableAdapter1
            // 
            this.tbl_OkurlarTableAdapter1.ClearBeforeFill = true;
            // 
            // tbl_OkurlarTableAdapter2
            // 
            this.tbl_OkurlarTableAdapter2.ClearBeforeFill = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 38);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // FrmOkuyucuEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1622, 608);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "FrmOkuyucuEkle";
            this.Text = "FrmOkuyucuEkle";
            this.Load += new System.EventHandler(this.FrmOkuyucuEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOkurlarBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneOtomasyonDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOkurlarBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneOtomasyonDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneOtomasyonDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOkurlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtOkuyucuSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtOkuyucuAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtOkuyucuMail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox MskOkuyucuTC;
        private System.Windows.Forms.MaskedTextBox MskOkuyucuTelefon;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private KütüphaneOtomasyonDataSet3 kütüphaneOtomasyonDataSet3;
        private System.Windows.Forms.BindingSource tblOkurlarBindingSource;
        private KütüphaneOtomasyonDataSet3TableAdapters.Tbl_OkurlarTableAdapter tbl_OkurlarTableAdapter;
        private KütüphaneOtomasyonDataSet4 kütüphaneOtomasyonDataSet4;
        private System.Windows.Forms.BindingSource tblOkurlarBindingSource1;
        private KütüphaneOtomasyonDataSet4TableAdapters.Tbl_OkurlarTableAdapter tbl_OkurlarTableAdapter1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private KütüphaneOtomasyonDataSet5 kütüphaneOtomasyonDataSet5;
        private System.Windows.Forms.BindingSource tblOkurlarBindingSource2;
        private KütüphaneOtomasyonDataSet5TableAdapters.Tbl_OkurlarTableAdapter tbl_OkurlarTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn üyeTCNumarasıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doğumTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonNumarasıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}