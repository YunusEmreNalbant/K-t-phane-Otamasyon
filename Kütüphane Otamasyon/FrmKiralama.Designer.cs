﻿namespace Kütüphane_Otamasyon
{
    partial class FrmKiralama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKiralama));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblOkurlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kütüphaneOtomasyonDataSet6 = new Kütüphane_Otamasyon.KütüphaneOtomasyonDataSet6();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.kitapAdıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblKitapBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kütüphaneOtomasyonDataSet7 = new Kütüphane_Otamasyon.KütüphaneOtomasyonDataSet7();
            this.tbl_OkurlarTableAdapter = new Kütüphane_Otamasyon.KütüphaneOtomasyonDataSet6TableAdapters.Tbl_OkurlarTableAdapter();
            this.tbl_KitapBilgiTableAdapter = new Kütüphane_Otamasyon.KütüphaneOtomasyonDataSet7TableAdapters.Tbl_KitapBilgiTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtKiralananOkurAd = new System.Windows.Forms.TextBox();
            this.TxtKiralananKitap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tarih1 = new System.Windows.Forms.DateTimePicker();
            this.tarih2 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxtKiralananOkurSoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOkurlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneOtomasyonDataSet6)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKitapBilgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneOtomasyonDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 274);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiralanacak Kişi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adıDataGridViewTextBoxColumn,
            this.soyadıDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblOkurlarBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(459, 248);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // adıDataGridViewTextBoxColumn
            // 
            this.adıDataGridViewTextBoxColumn.DataPropertyName = "Adı";
            this.adıDataGridViewTextBoxColumn.HeaderText = "Adı";
            this.adıDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.adıDataGridViewTextBoxColumn.Name = "adıDataGridViewTextBoxColumn";
            this.adıDataGridViewTextBoxColumn.ReadOnly = true;
            this.adıDataGridViewTextBoxColumn.Width = 200;
            // 
            // soyadıDataGridViewTextBoxColumn
            // 
            this.soyadıDataGridViewTextBoxColumn.DataPropertyName = "Soyadı";
            this.soyadıDataGridViewTextBoxColumn.HeaderText = "Soyadı";
            this.soyadıDataGridViewTextBoxColumn.MinimumWidth = 215;
            this.soyadıDataGridViewTextBoxColumn.Name = "soyadıDataGridViewTextBoxColumn";
            this.soyadıDataGridViewTextBoxColumn.ReadOnly = true;
            this.soyadıDataGridViewTextBoxColumn.Width = 215;
            // 
            // tblOkurlarBindingSource
            // 
            this.tblOkurlarBindingSource.DataMember = "Tbl_Okurlar";
            this.tblOkurlarBindingSource.DataSource = this.kütüphaneOtomasyonDataSet6;
            // 
            // kütüphaneOtomasyonDataSet6
            // 
            this.kütüphaneOtomasyonDataSet6.DataSetName = "KütüphaneOtomasyonDataSet6";
            this.kütüphaneOtomasyonDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 339);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(468, 274);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kiralanacak Kitap";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kitapAdıDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tblKitapBilgiBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 23);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(462, 248);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // kitapAdıDataGridViewTextBoxColumn
            // 
            this.kitapAdıDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kitapAdıDataGridViewTextBoxColumn.DataPropertyName = "Kitap Adı";
            this.kitapAdıDataGridViewTextBoxColumn.HeaderText = "Kitap Adı";
            this.kitapAdıDataGridViewTextBoxColumn.MinimumWidth = 160;
            this.kitapAdıDataGridViewTextBoxColumn.Name = "kitapAdıDataGridViewTextBoxColumn";
            this.kitapAdıDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblKitapBilgiBindingSource
            // 
            this.tblKitapBilgiBindingSource.DataMember = "Tbl_KitapBilgi";
            this.tblKitapBilgiBindingSource.DataSource = this.kütüphaneOtomasyonDataSet7;
            // 
            // kütüphaneOtomasyonDataSet7
            // 
            this.kütüphaneOtomasyonDataSet7.DataSetName = "KütüphaneOtomasyonDataSet7";
            this.kütüphaneOtomasyonDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_OkurlarTableAdapter
            // 
            this.tbl_OkurlarTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_KitapBilgiTableAdapter
            // 
            this.tbl_KitapBilgiTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(37, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kiralanan Okur Ad:";
            // 
            // TxtKiralananOkurAd
            // 
            this.TxtKiralananOkurAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKiralananOkurAd.Location = new System.Drawing.Point(182, 50);
            this.TxtKiralananOkurAd.Name = "TxtKiralananOkurAd";
            this.TxtKiralananOkurAd.Size = new System.Drawing.Size(178, 24);
            this.TxtKiralananOkurAd.TabIndex = 3;
            // 
            // TxtKiralananKitap
            // 
            this.TxtKiralananKitap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKiralananKitap.Location = new System.Drawing.Point(182, 130);
            this.TxtKiralananKitap.Name = "TxtKiralananKitap";
            this.TxtKiralananKitap.Size = new System.Drawing.Size(178, 24);
            this.TxtKiralananKitap.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(54, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kiralanan Kitap:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(88, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Alım Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(76, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Teslim Tarihi:";
            // 
            // tarih1
            // 
            this.tarih1.Location = new System.Drawing.Point(182, 185);
            this.tarih1.Name = "tarih1";
            this.tarih1.Size = new System.Drawing.Size(200, 27);
            this.tarih1.TabIndex = 8;
            // 
            // tarih2
            // 
            this.tarih2.Location = new System.Drawing.Point(182, 227);
            this.tarih2.Name = "tarih2";
            this.tarih2.Size = new System.Drawing.Size(200, 27);
            this.tarih2.TabIndex = 9;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(208, 285);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(108, 65);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(93, 285);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TxtKiralananOkurSoyad);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tarih2);
            this.groupBox3.Controls.Add(this.pictureBox3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.TxtKiralananOkurAd);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.TxtKiralananKitap);
            this.groupBox3.Controls.Add(this.tarih1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(507, 146);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(595, 397);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bilgiler";
            // 
            // TxtKiralananOkurSoyad
            // 
            this.TxtKiralananOkurSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKiralananOkurSoyad.Location = new System.Drawing.Point(182, 91);
            this.TxtKiralananOkurSoyad.Name = "TxtKiralananOkurSoyad";
            this.TxtKiralananOkurSoyad.Size = new System.Drawing.Size(178, 24);
            this.TxtKiralananOkurSoyad.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(13, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 19);
            this.label5.TabIndex = 24;
            this.label5.Text = "Kiralanan Okur Soyad:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // FrmKiralama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 653);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmKiralama";
            this.Text = "FrmKiralama";
            this.Load += new System.EventHandler(this.FrmKiralama_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOkurlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneOtomasyonDataSet6)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKitapBilgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kütüphaneOtomasyonDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private KütüphaneOtomasyonDataSet6 kütüphaneOtomasyonDataSet6;
        private System.Windows.Forms.BindingSource tblOkurlarBindingSource;
        private KütüphaneOtomasyonDataSet6TableAdapters.Tbl_OkurlarTableAdapter tbl_OkurlarTableAdapter;
        private KütüphaneOtomasyonDataSet7 kütüphaneOtomasyonDataSet7;
        private System.Windows.Forms.BindingSource tblKitapBilgiBindingSource;
        private KütüphaneOtomasyonDataSet7TableAdapters.Tbl_KitapBilgiTableAdapter tbl_KitapBilgiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn adıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadıDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtKiralananOkurAd;
        private System.Windows.Forms.TextBox TxtKiralananKitap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker tarih1;
        private System.Windows.Forms.DateTimePicker tarih2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox TxtKiralananOkurSoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}