﻿
namespace CafeDemo.Formlar
{
    partial class FrmAyarlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAyarlar));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.Kategorisi = new System.Windows.Forms.Label();
            this.cmbKategorisi = new System.Windows.Forms.ComboBox();
            this.pbUrun = new System.Windows.Forms.PictureBox();
            this.cbUrunAktifMi = new System.Windows.Forms.CheckBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUrunGuncelle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnUrunSil = new System.Windows.Forms.Button();
            this.btnUrunResim = new System.Windows.Forms.Button();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.listUrun = new System.Windows.Forms.ListView();
            this.clmnUrunAdi = new System.Windows.Forms.ColumnHeader();
            this.clmnKategorisi = new System.Windows.Forms.ColumnHeader();
            this.clmnFiyati = new System.Windows.Forms.ColumnHeader();
            this.clmnAktifMi = new System.Windows.Forms.ColumnHeader();
            this.btnResim = new System.Windows.Forms.TabPage();
            this.pbKategori = new System.Windows.Forms.PictureBox();
            this.cbKategoriAktifMi = new System.Windows.Forms.CheckBox();
            this.txtKategoriAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKategoriGuncelle = new System.Windows.Forms.Button();
            this.btnKategoriSil = new System.Windows.Forms.Button();
            this.btnKategoriResim = new System.Windows.Forms.Button();
            this.btnKategoriEkle = new System.Windows.Forms.Button();
            this.listKategori = new System.Windows.Forms.ListView();
            this.KategoriAdi = new System.Windows.Forms.ColumnHeader();
            this.AktifMi = new System.Windows.Forms.ColumnHeader();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gbRestoranDuzen = new System.Windows.Forms.GroupBox();
            this.btnKaydetDuzen = new System.Windows.Forms.Button();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKaydetIletisim = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRestoranAdi = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUrun)).BeginInit();
            this.btnResim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbKategori)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.gbRestoranDuzen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.btnResim);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1244, 535);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Beige;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.Kategorisi);
            this.tabPage1.Controls.Add(this.cmbKategorisi);
            this.tabPage1.Controls.Add(this.pbUrun);
            this.tabPage1.Controls.Add(this.cbUrunAktifMi);
            this.tabPage1.Controls.Add(this.txtUrunAdi);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnUrunGuncelle);
            this.tabPage1.Controls.Add(this.btnUrunSil);
            this.tabPage1.Controls.Add(this.btnUrunResim);
            this.tabPage1.Controls.Add(this.btnUrunEkle);
            this.tabPage1.Controls.Add(this.listUrun);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.Location = new System.Drawing.Point(4, 46);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage1.Size = new System.Drawing.Size(1236, 485);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "     Ürün Ekle    ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(209, 139);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(229, 43);
            this.numericUpDown1.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 37);
            this.label6.TabIndex = 17;
            this.label6.Text = "Fiyatı";
            // 
            // Kategorisi
            // 
            this.Kategorisi.AutoSize = true;
            this.Kategorisi.Location = new System.Drawing.Point(8, 87);
            this.Kategorisi.Name = "Kategorisi";
            this.Kategorisi.Size = new System.Drawing.Size(136, 37);
            this.Kategorisi.TabIndex = 17;
            this.Kategorisi.Text = "Kategorisi";
            // 
            // cmbKategorisi
            // 
            this.cmbKategorisi.FormattingEnabled = true;
            this.cmbKategorisi.Location = new System.Drawing.Point(209, 79);
            this.cmbKategorisi.Name = "cmbKategorisi";
            this.cmbKategorisi.Size = new System.Drawing.Size(229, 45);
            this.cmbKategorisi.TabIndex = 16;
            // 
            // pbUrun
            // 
            this.pbUrun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbUrun.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbUrun.Location = new System.Drawing.Point(209, 197);
            this.pbUrun.Name = "pbUrun";
            this.pbUrun.Size = new System.Drawing.Size(229, 151);
            this.pbUrun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUrun.TabIndex = 14;
            this.pbUrun.TabStop = false;
            // 
            // cbUrunAktifMi
            // 
            this.cbUrunAktifMi.AutoSize = true;
            this.cbUrunAktifMi.Location = new System.Drawing.Point(220, 354);
            this.cbUrunAktifMi.Name = "cbUrunAktifMi";
            this.cbUrunAktifMi.Size = new System.Drawing.Size(120, 41);
            this.cbUrunAktifMi.TabIndex = 13;
            this.cbUrunAktifMi.Text = "Aktif Et";
            this.cbUrunAktifMi.UseVisualStyleBackColor = true;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(209, 30);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(229, 43);
            this.txtUrunAdi.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 37);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ürün Adi";
            // 
            // btnUrunGuncelle
            // 
            this.btnUrunGuncelle.BackColor = System.Drawing.Color.White;
            this.btnUrunGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrunGuncelle.ImageKey = "güncelle.png";
            this.btnUrunGuncelle.ImageList = this.ımageList1;
            this.btnUrunGuncelle.Location = new System.Drawing.Point(318, 396);
            this.btnUrunGuncelle.Name = "btnUrunGuncelle";
            this.btnUrunGuncelle.Size = new System.Drawing.Size(185, 67);
            this.btnUrunGuncelle.TabIndex = 8;
            this.btnUrunGuncelle.Text = "Güncelle";
            this.btnUrunGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUrunGuncelle.UseVisualStyleBackColor = false;
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "resimsec.png");
            this.ımageList1.Images.SetKeyName(1, "ekle.png");
            this.ımageList1.Images.SetKeyName(2, "ghfgh.png");
            this.ımageList1.Images.SetKeyName(3, "gfnfgn.jpg");
            this.ımageList1.Images.SetKeyName(4, "güncelle.png");
            this.ımageList1.Images.SetKeyName(5, "resimsec.png");
            this.ımageList1.Images.SetKeyName(6, "xcvxc.jpg");
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.BackColor = System.Drawing.Color.White;
            this.btnUrunSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrunSil.ImageKey = "ghfgh.png";
            this.btnUrunSil.ImageList = this.ımageList1;
            this.btnUrunSil.Location = new System.Drawing.Point(168, 396);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(102, 67);
            this.btnUrunSil.TabIndex = 9;
            this.btnUrunSil.Text = "Sil";
            this.btnUrunSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUrunSil.UseVisualStyleBackColor = false;
            // 
            // btnUrunResim
            // 
            this.btnUrunResim.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUrunResim.ForeColor = System.Drawing.Color.Black;
            this.btnUrunResim.ImageKey = "resimsec.png";
            this.btnUrunResim.ImageList = this.ımageList1;
            this.btnUrunResim.Location = new System.Drawing.Point(19, 230);
            this.btnUrunResim.Name = "btnUrunResim";
            this.btnUrunResim.Size = new System.Drawing.Size(170, 69);
            this.btnUrunResim.TabIndex = 10;
            this.btnUrunResim.Text = "RESİM";
            this.btnUrunResim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUrunResim.UseVisualStyleBackColor = false;
            this.btnUrunResim.Click += new System.EventHandler(this.btnUrunResim_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.BackColor = System.Drawing.Color.White;
            this.btnUrunEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrunEkle.ImageKey = "gfnfgn.jpg";
            this.btnUrunEkle.ImageList = this.ımageList1;
            this.btnUrunEkle.Location = new System.Drawing.Point(19, 396);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(125, 67);
            this.btnUrunEkle.TabIndex = 10;
            this.btnUrunEkle.Text = "Ekle";
            this.btnUrunEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUrunEkle.UseVisualStyleBackColor = false;
            // 
            // listUrun
            // 
            this.listUrun.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmnUrunAdi,
            this.clmnKategorisi,
            this.clmnFiyati,
            this.clmnAktifMi});
            this.listUrun.HideSelection = false;
            this.listUrun.Location = new System.Drawing.Point(463, 30);
            this.listUrun.Name = "listUrun";
            this.listUrun.Size = new System.Drawing.Size(513, 299);
            this.listUrun.TabIndex = 0;
            this.listUrun.UseCompatibleStateImageBehavior = false;
            this.listUrun.View = System.Windows.Forms.View.Details;
            // 
            // clmnUrunAdi
            // 
            this.clmnUrunAdi.Text = "Ürün Adı";
            this.clmnUrunAdi.Width = 150;
            // 
            // clmnKategorisi
            // 
            this.clmnKategorisi.Text = "Kategorisi";
            this.clmnKategorisi.Width = 150;
            // 
            // clmnFiyati
            // 
            this.clmnFiyati.Text = "Fiyatı";
            this.clmnFiyati.Width = 100;
            // 
            // clmnAktifMi
            // 
            this.clmnAktifMi.Text = "Durum";
            this.clmnAktifMi.Width = 100;
            // 
            // btnResim
            // 
            this.btnResim.Controls.Add(this.pbKategori);
            this.btnResim.Controls.Add(this.cbKategoriAktifMi);
            this.btnResim.Controls.Add(this.txtKategoriAdi);
            this.btnResim.Controls.Add(this.label1);
            this.btnResim.Controls.Add(this.btnKategoriGuncelle);
            this.btnResim.Controls.Add(this.btnKategoriSil);
            this.btnResim.Controls.Add(this.btnKategoriResim);
            this.btnResim.Controls.Add(this.btnKategoriEkle);
            this.btnResim.Controls.Add(this.listKategori);
            this.btnResim.Location = new System.Drawing.Point(4, 46);
            this.btnResim.Name = "btnResim";
            this.btnResim.Padding = new System.Windows.Forms.Padding(3);
            this.btnResim.Size = new System.Drawing.Size(1236, 485);
            this.btnResim.TabIndex = 1;
            this.btnResim.Text = "    Kategori Ekle    ";
            this.btnResim.UseVisualStyleBackColor = true;
            // 
            // pbKategori
            // 
            this.pbKategori.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbKategori.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbKategori.Location = new System.Drawing.Point(209, 138);
            this.pbKategori.Name = "pbKategori";
            this.pbKategori.Size = new System.Drawing.Size(229, 151);
            this.pbKategori.TabIndex = 6;
            this.pbKategori.TabStop = false;
            // 
            // cbKategoriAktifMi
            // 
            this.cbKategoriAktifMi.AutoSize = true;
            this.cbKategoriAktifMi.Location = new System.Drawing.Point(209, 295);
            this.cbKategoriAktifMi.Name = "cbKategoriAktifMi";
            this.cbKategoriAktifMi.Size = new System.Drawing.Size(120, 41);
            this.cbKategoriAktifMi.TabIndex = 5;
            this.cbKategoriAktifMi.Text = "Aktif Et";
            this.cbKategoriAktifMi.UseVisualStyleBackColor = true;
            // 
            // txtKategoriAdi
            // 
            this.txtKategoriAdi.Location = new System.Drawing.Point(209, 78);
            this.txtKategoriAdi.Name = "txtKategoriAdi";
            this.txtKategoriAdi.Size = new System.Drawing.Size(229, 43);
            this.txtKategoriAdi.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kategori Adı";
            // 
            // btnKategoriGuncelle
            // 
            this.btnKategoriGuncelle.BackColor = System.Drawing.Color.White;
            this.btnKategoriGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKategoriGuncelle.ImageKey = "güncelle.png";
            this.btnKategoriGuncelle.ImageList = this.ımageList1;
            this.btnKategoriGuncelle.Location = new System.Drawing.Point(307, 352);
            this.btnKategoriGuncelle.Name = "btnKategoriGuncelle";
            this.btnKategoriGuncelle.Size = new System.Drawing.Size(175, 73);
            this.btnKategoriGuncelle.TabIndex = 2;
            this.btnKategoriGuncelle.Text = "Güncelle";
            this.btnKategoriGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKategoriGuncelle.UseVisualStyleBackColor = false;
            // 
            // btnKategoriSil
            // 
            this.btnKategoriSil.BackColor = System.Drawing.Color.White;
            this.btnKategoriSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKategoriSil.ImageKey = "ghfgh.png";
            this.btnKategoriSil.ImageList = this.ımageList1;
            this.btnKategoriSil.Location = new System.Drawing.Point(167, 352);
            this.btnKategoriSil.Name = "btnKategoriSil";
            this.btnKategoriSil.Size = new System.Drawing.Size(109, 73);
            this.btnKategoriSil.TabIndex = 2;
            this.btnKategoriSil.Text = "Sil";
            this.btnKategoriSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKategoriSil.UseVisualStyleBackColor = false;
            // 
            // btnKategoriResim
            // 
            this.btnKategoriResim.BackColor = System.Drawing.Color.White;
            this.btnKategoriResim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKategoriResim.ImageKey = "resimsec.png";
            this.btnKategoriResim.ImageList = this.ımageList1;
            this.btnKategoriResim.Location = new System.Drawing.Point(20, 174);
            this.btnKategoriResim.Name = "btnKategoriResim";
            this.btnKategoriResim.Size = new System.Drawing.Size(153, 69);
            this.btnKategoriResim.TabIndex = 2;
            this.btnKategoriResim.Text = "Resim";
            this.btnKategoriResim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKategoriResim.UseVisualStyleBackColor = false;
            this.btnKategoriResim.Click += new System.EventHandler(this.btnKategoriResim_Click);
            // 
            // btnKategoriEkle
            // 
            this.btnKategoriEkle.BackColor = System.Drawing.Color.White;
            this.btnKategoriEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKategoriEkle.ImageKey = "gfnfgn.jpg";
            this.btnKategoriEkle.ImageList = this.ımageList1;
            this.btnKategoriEkle.Location = new System.Drawing.Point(8, 352);
            this.btnKategoriEkle.Name = "btnKategoriEkle";
            this.btnKategoriEkle.Size = new System.Drawing.Size(131, 73);
            this.btnKategoriEkle.TabIndex = 2;
            this.btnKategoriEkle.Text = "Ekle";
            this.btnKategoriEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKategoriEkle.UseVisualStyleBackColor = false;
            // 
            // listKategori
            // 
            this.listKategori.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.KategoriAdi,
            this.AktifMi});
            this.listKategori.HideSelection = false;
            this.listKategori.Location = new System.Drawing.Point(496, 78);
            this.listKategori.Name = "listKategori";
            this.listKategori.Size = new System.Drawing.Size(496, 258);
            this.listKategori.TabIndex = 1;
            this.listKategori.UseCompatibleStateImageBehavior = false;
            this.listKategori.View = System.Windows.Forms.View.Details;
            // 
            // KategoriAdi
            // 
            this.KategoriAdi.Text = "Kategori Adı";
            this.KategoriAdi.Width = 200;
            // 
            // AktifMi
            // 
            this.AktifMi.Text = "Aktiflik Durumu";
            this.AktifMi.Width = 200;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gbRestoranDuzen);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 46);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1236, 485);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "    Restoran Bilgileri    ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // gbRestoranDuzen
            // 
            this.gbRestoranDuzen.Controls.Add(this.btnKaydetDuzen);
            this.gbRestoranDuzen.Controls.Add(this.numericUpDown7);
            this.gbRestoranDuzen.Controls.Add(this.numericUpDown4);
            this.gbRestoranDuzen.Controls.Add(this.numericUpDown6);
            this.gbRestoranDuzen.Controls.Add(this.numericUpDown3);
            this.gbRestoranDuzen.Controls.Add(this.numericUpDown5);
            this.gbRestoranDuzen.Controls.Add(this.numericUpDown2);
            this.gbRestoranDuzen.Controls.Add(this.checkBox2);
            this.gbRestoranDuzen.Controls.Add(this.checkBox6);
            this.gbRestoranDuzen.Controls.Add(this.checkBox5);
            this.gbRestoranDuzen.Controls.Add(this.checkBox4);
            this.gbRestoranDuzen.Controls.Add(this.checkBox3);
            this.gbRestoranDuzen.Controls.Add(this.checkBox1);
            this.gbRestoranDuzen.Location = new System.Drawing.Point(591, 18);
            this.gbRestoranDuzen.Name = "gbRestoranDuzen";
            this.gbRestoranDuzen.Size = new System.Drawing.Size(607, 442);
            this.gbRestoranDuzen.TabIndex = 7;
            this.gbRestoranDuzen.TabStop = false;
            this.gbRestoranDuzen.Text = "Restoran Düzeni";
            // 
            // btnKaydetDuzen
            // 
            this.btnKaydetDuzen.BackColor = System.Drawing.Color.White;
            this.btnKaydetDuzen.ImageKey = "xcvxc.jpg";
            this.btnKaydetDuzen.ImageList = this.ımageList1;
            this.btnKaydetDuzen.Location = new System.Drawing.Point(220, 343);
            this.btnKaydetDuzen.Name = "btnKaydetDuzen";
            this.btnKaydetDuzen.Size = new System.Drawing.Size(171, 75);
            this.btnKaydetDuzen.TabIndex = 6;
            this.btnKaydetDuzen.Text = "Kaydet";
            this.btnKaydetDuzen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKaydetDuzen.UseVisualStyleBackColor = false;
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.Enabled = false;
            this.numericUpDown7.Location = new System.Drawing.Point(516, 231);
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(76, 43);
            this.numericUpDown7.TabIndex = 1;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Enabled = false;
            this.numericUpDown4.Location = new System.Drawing.Point(224, 231);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(76, 43);
            this.numericUpDown4.TabIndex = 1;
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Enabled = false;
            this.numericUpDown6.Location = new System.Drawing.Point(516, 159);
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(76, 43);
            this.numericUpDown6.TabIndex = 1;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Enabled = false;
            this.numericUpDown3.Location = new System.Drawing.Point(224, 159);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(76, 43);
            this.numericUpDown3.TabIndex = 1;
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Enabled = false;
            this.numericUpDown5.Location = new System.Drawing.Point(516, 87);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(76, 43);
            this.numericUpDown5.TabIndex = 1;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Enabled = false;
            this.numericUpDown2.Location = new System.Drawing.Point(224, 87);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(76, 43);
            this.numericUpDown2.TabIndex = 1;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(23, 161);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(95, 41);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "Teras";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(347, 233);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(103, 41);
            this.checkBox6.TabIndex = 0;
            this.checkBox6.Text = "3. Kat";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(347, 159);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(103, 41);
            this.checkBox5.TabIndex = 0;
            this.checkBox5.Text = "2. Kat";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(347, 89);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(96, 41);
            this.checkBox4.TabIndex = 0;
            this.checkBox4.Text = "1.Kat";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(23, 231);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(156, 41);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Text = "Zemin Kat";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(23, 89);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(106, 41);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Bahçe";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKaydetIletisim);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAdres);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtRestoranAdi);
            this.groupBox1.Location = new System.Drawing.Point(19, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 442);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Restoran İletişim";
            // 
            // btnKaydetIletisim
            // 
            this.btnKaydetIletisim.BackColor = System.Drawing.Color.White;
            this.btnKaydetIletisim.ImageKey = "xcvxc.jpg";
            this.btnKaydetIletisim.ImageList = this.ımageList1;
            this.btnKaydetIletisim.Location = new System.Drawing.Point(137, 343);
            this.btnKaydetIletisim.Name = "btnKaydetIletisim";
            this.btnKaydetIletisim.Size = new System.Drawing.Size(171, 75);
            this.btnKaydetIletisim.TabIndex = 6;
            this.btnKaydetIletisim.Text = "Kaydet";
            this.btnKaydetIletisim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKaydetIletisim.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Restoran Adı";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(291, 217);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(201, 80);
            this.txtAdres.TabIndex = 5;
            this.txtAdres.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 37);
            this.label7.TabIndex = 2;
            this.label7.Text = "Telefon Numarası";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(291, 153);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(201, 43);
            this.txtTelefon.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 37);
            this.label5.TabIndex = 2;
            this.label5.Text = "Adres";
            // 
            // txtRestoranAdi
            // 
            this.txtRestoranAdi.Location = new System.Drawing.Point(291, 89);
            this.txtRestoranAdi.Name = "txtRestoranAdi";
            this.txtRestoranAdi.Size = new System.Drawing.Size(201, 43);
            this.txtRestoranAdi.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmAyarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1244, 535);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAyarlar";
            this.Text = "FrmAyarlar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUrun)).EndInit();
            this.btnResim.ResumeLayout(false);
            this.btnResim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbKategori)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.gbRestoranDuzen.ResumeLayout(false);
            this.gbRestoranDuzen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage btnResim;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView listKategori;
        private System.Windows.Forms.ColumnHeader KategoriAdi;
        private System.Windows.Forms.ColumnHeader AktifMi;
        private System.Windows.Forms.TextBox txtKategoriAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKategoriGuncelle;
        private System.Windows.Forms.Button btnKategoriSil;
        private System.Windows.Forms.Button btnKategoriEkle;
        private System.Windows.Forms.PictureBox pbKategori;
        private System.Windows.Forms.CheckBox cbKategoriAktifMi;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pbUrun;
        private System.Windows.Forms.CheckBox cbUrunAktifMi;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUrunGuncelle;
        private System.Windows.Forms.Button btnUrunSil;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.ListView listUrun;
        private System.Windows.Forms.ColumnHeader clmnUrunAdi;
        private System.Windows.Forms.ColumnHeader clmnKategorisi;
        private System.Windows.Forms.ColumnHeader clmnFiyati;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Kategorisi;
        private System.Windows.Forms.ComboBox cmbKategorisi;
        private System.Windows.Forms.Button btnUrunResim;
        private System.Windows.Forms.ColumnHeader clmnAktifMi;
        private System.Windows.Forms.Button btnKategoriResim;
        private System.Windows.Forms.RichTextBox txtAdres;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private System.Windows.Forms.TextBox txtRestoranAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKaydetIletisim;
        private System.Windows.Forms.GroupBox gbRestoranDuzen;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnKaydetDuzen;
        private System.Windows.Forms.NumericUpDown numericUpDown7;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ImageList ımageList1;
    }
}