namespace KlinikOtomasyonu
{
    partial class FormHastaIslemleri
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
            this.dateTimePickerSevkTarihi = new System.Windows.Forms.DateTimePicker();
            this.button7 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDosyaNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSeciliSil = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonYazdir = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.buttonYeniKayit = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.buttonTaburcuEt = new System.Windows.Forms.Button();
            this.btnDosynaNobul = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxOncekiIslemler = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxHastaAdi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxHastaSoyadi = new System.Windows.Forms.TextBox();
            this.textBoxKurumAdi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonOncekiIslemler = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.numericUpDownMiktar = new System.Windows.Forms.NumericUpDown();
            this.comboBoxDoktorKodu = new System.Windows.Forms.ComboBox();
            this.comboBoxYapilanIslem = new System.Windows.Forms.ComboBox();
            this.comboBoxPoliklinik = new System.Windows.Forms.ComboBox();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.sOHATSDataSet = new KlinikOtomasyonu.SOHATSDataSet();
            this.tBLHASTAISLEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBL_HASTAISLEMTableAdapter = new KlinikOtomasyonu.SOHATSDataSetTableAdapters.TBL_HASTAISLEMTableAdapter();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HASTA_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POLIKLINIK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SIRA_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SAAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YAPILAN_ISLEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DR_KODU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MIKTAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BIRIM_FIYATI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMiktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOHATSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLHASTAISLEMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerSevkTarihi
            // 
            this.dateTimePickerSevkTarihi.Location = new System.Drawing.Point(124, 39);
            this.dateTimePickerSevkTarihi.Name = "dateTimePickerSevkTarihi";
            this.dateTimePickerSevkTarihi.Size = new System.Drawing.Size(169, 20);
            this.dateTimePickerSevkTarihi.TabIndex = 31;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(596, 39);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(164, 36);
            this.button7.TabIndex = 15;
            this.button7.Text = "Hasta Bilgileri";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Dosya No";
            // 
            // textBoxDosyaNo
            // 
            this.textBoxDosyaNo.Location = new System.Drawing.Point(124, 7);
            this.textBoxDosyaNo.Name = "textBoxDosyaNo";
            this.textBoxDosyaNo.Size = new System.Drawing.Size(100, 20);
            this.textBoxDosyaNo.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sevk Tarihi";
            // 
            // buttonSeciliSil
            // 
            this.buttonSeciliSil.Location = new System.Drawing.Point(112, 6);
            this.buttonSeciliSil.Name = "buttonSeciliSil";
            this.buttonSeciliSil.Size = new System.Drawing.Size(84, 41);
            this.buttonSeciliSil.TabIndex = 32;
            this.buttonSeciliSil.Text = "Seç Sil";
            this.buttonSeciliSil.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonYazdir);
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.buttonYeniKayit);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.buttonSeciliSil);
            this.panel1.Controls.Add(this.buttonTaburcuEt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 511);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 51);
            this.panel1.TabIndex = 44;
            // 
            // buttonYazdir
            // 
            this.buttonYazdir.Location = new System.Drawing.Point(292, 7);
            this.buttonYazdir.Name = "buttonYazdir";
            this.buttonYazdir.Size = new System.Drawing.Size(75, 40);
            this.buttonYazdir.TabIndex = 36;
            this.buttonYazdir.Text = "Yazdır";
            this.buttonYazdir.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(855, 7);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(84, 36);
            this.button13.TabIndex = 35;
            this.button13.Text = "Çıkış";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // buttonYeniKayit
            // 
            this.buttonYeniKayit.Location = new System.Drawing.Point(22, 7);
            this.buttonYeniKayit.Name = "buttonYeniKayit";
            this.buttonYeniKayit.Size = new System.Drawing.Size(84, 40);
            this.buttonYeniKayit.TabIndex = 31;
            this.buttonYeniKayit.Text = "Yeni";
            this.buttonYeniKayit.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(372, 6);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(84, 40);
            this.button12.TabIndex = 34;
            this.button12.Text = "Baskı Önzileme";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // buttonTaburcuEt
            // 
            this.buttonTaburcuEt.Location = new System.Drawing.Point(202, 7);
            this.buttonTaburcuEt.Name = "buttonTaburcuEt";
            this.buttonTaburcuEt.Size = new System.Drawing.Size(84, 40);
            this.buttonTaburcuEt.TabIndex = 33;
            this.buttonTaburcuEt.Text = "Taburcu";
            this.buttonTaburcuEt.UseVisualStyleBackColor = true;
            // 
            // btnDosynaNobul
            // 
            this.btnDosynaNobul.Location = new System.Drawing.Point(230, 3);
            this.btnDosynaNobul.Name = "btnDosynaNobul";
            this.btnDosynaNobul.Size = new System.Drawing.Size(63, 27);
            this.btnDosynaNobul.TabIndex = 2;
            this.btnDosynaNobul.Text = "Bul";
            this.btnDosynaNobul.UseVisualStyleBackColor = true;
            this.btnDosynaNobul.Click += new System.EventHandler(this.btnDosynaNobul_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 620);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(776, 39);
            this.flowLayoutPanel1.TabIndex = 43;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(0, 157);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(776, 318);
            this.panel3.TabIndex = 46;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.HASTA_ID,
            this.POLIKLINIK,
            this.SIRA_NO,
            this.SAAT,
            this.YAPILAN_ISLEM,
            this.DR_KODU,
            this.MIKTAR,
            this.BIRIM_FIYATI});
            this.dataGridView1.DataSource = this.tBLHASTAISLEMBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 318);
            this.dataGridView1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Önceki İşlemler";
            // 
            // textBoxOncekiIslemler
            // 
            this.textBoxOncekiIslemler.Location = new System.Drawing.Point(124, 65);
            this.textBoxOncekiIslemler.Name = "textBoxOncekiIslemler";
            this.textBoxOncekiIslemler.Size = new System.Drawing.Size(100, 20);
            this.textBoxOncekiIslemler.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(360, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Hasta Adı";
            // 
            // textBoxHastaAdi
            // 
            this.textBoxHastaAdi.Location = new System.Drawing.Point(419, 7);
            this.textBoxHastaAdi.Name = "textBoxHastaAdi";
            this.textBoxHastaAdi.Size = new System.Drawing.Size(169, 20);
            this.textBoxHastaAdi.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(360, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Soyadı";
            // 
            // textBoxHastaSoyadi
            // 
            this.textBoxHastaSoyadi.Location = new System.Drawing.Point(419, 36);
            this.textBoxHastaSoyadi.Name = "textBoxHastaSoyadi";
            this.textBoxHastaSoyadi.Size = new System.Drawing.Size(169, 20);
            this.textBoxHastaSoyadi.TabIndex = 11;
            // 
            // textBoxKurumAdi
            // 
            this.textBoxKurumAdi.Location = new System.Drawing.Point(419, 65);
            this.textBoxKurumAdi.Name = "textBoxKurumAdi";
            this.textBoxKurumAdi.Size = new System.Drawing.Size(169, 20);
            this.textBoxKurumAdi.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(596, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Sağlık Ocağı Hasta Takip Sistemi";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dateTimePickerSevkTarihi);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBoxDosyaNo);
            this.panel2.Controls.Add(this.btnDosynaNobul);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.buttonOncekiIslemler);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBoxOncekiIslemler);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textBoxHastaAdi);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textBoxHastaSoyadi);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textBoxKurumAdi);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 97);
            this.panel2.TabIndex = 45;
            // 
            // buttonOncekiIslemler
            // 
            this.buttonOncekiIslemler.Location = new System.Drawing.Point(230, 61);
            this.buttonOncekiIslemler.Name = "buttonOncekiIslemler";
            this.buttonOncekiIslemler.Size = new System.Drawing.Size(63, 27);
            this.buttonOncekiIslemler.TabIndex = 36;
            this.buttonOncekiIslemler.Text = "Git";
            this.buttonOncekiIslemler.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Kurum Adı";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.numericUpDownMiktar);
            this.panel4.Controls.Add(this.comboBoxDoktorKodu);
            this.panel4.Controls.Add(this.comboBoxYapilanIslem);
            this.panel4.Controls.Add(this.comboBoxPoliklinik);
            this.panel4.Controls.Add(this.button8);
            this.panel4.Controls.Add(this.textBox13);
            this.panel4.Controls.Add(this.textBox8);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Location = new System.Drawing.Point(0, 95);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(776, 63);
            this.panel4.TabIndex = 32;
            // 
            // numericUpDownMiktar
            // 
            this.numericUpDownMiktar.Location = new System.Drawing.Point(467, 29);
            this.numericUpDownMiktar.Name = "numericUpDownMiktar";
            this.numericUpDownMiktar.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMiktar.TabIndex = 49;
            // 
            // comboBoxDoktorKodu
            // 
            this.comboBoxDoktorKodu.FormattingEnabled = true;
            this.comboBoxDoktorKodu.Location = new System.Drawing.Point(344, 29);
            this.comboBoxDoktorKodu.Name = "comboBoxDoktorKodu";
            this.comboBoxDoktorKodu.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDoktorKodu.TabIndex = 48;
            // 
            // comboBoxYapilanIslem
            // 
            this.comboBoxYapilanIslem.FormattingEnabled = true;
            this.comboBoxYapilanIslem.Location = new System.Drawing.Point(222, 29);
            this.comboBoxYapilanIslem.Name = "comboBoxYapilanIslem";
            this.comboBoxYapilanIslem.Size = new System.Drawing.Size(121, 21);
            this.comboBoxYapilanIslem.TabIndex = 47;
            // 
            // comboBoxPoliklinik
            // 
            this.comboBoxPoliklinik.FormattingEnabled = true;
            this.comboBoxPoliklinik.Location = new System.Drawing.Point(7, 28);
            this.comboBoxPoliklinik.Name = "comboBoxPoliklinik";
            this.comboBoxPoliklinik.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPoliklinik.TabIndex = 46;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(679, 28);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(78, 20);
            this.button8.TabIndex = 45;
            this.button8.Text = "Ekle";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(590, 29);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(87, 20);
            this.textBox13.TabIndex = 44;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(129, 29);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(93, 20);
            this.textBox8.TabIndex = 43;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(587, 13);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 13);
            this.label16.TabIndex = 42;
            this.label16.Text = "Birim Fiyat";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(471, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 13);
            this.label15.TabIndex = 41;
            this.label15.Text = "Miktar";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(343, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 40;
            this.label14.Text = "Dr Kodu";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(225, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 39;
            this.label13.Text = "Yapılan İşlem";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(129, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Sıra No";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 10);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Poliklinik";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sOHATSDataSet
            // 
            this.sOHATSDataSet.DataSetName = "SOHATSDataSet";
            this.sOHATSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLHASTAISLEMBindingSource
            // 
            this.tBLHASTAISLEMBindingSource.DataMember = "TBL_HASTAISLEM";
            this.tBLHASTAISLEMBindingSource.DataSource = this.sOHATSDataSet;
            // 
            // tBL_HASTAISLEMTableAdapter
            // 
            this.tBL_HASTAISLEMTableAdapter.ClearBeforeFill = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // HASTA_ID
            // 
            this.HASTA_ID.DataPropertyName = "HASTA_ID";
            this.HASTA_ID.HeaderText = "HASTA_ID";
            this.HASTA_ID.Name = "HASTA_ID";
            this.HASTA_ID.Visible = false;
            // 
            // POLIKLINIK
            // 
            this.POLIKLINIK.DataPropertyName = "POLIKLINIK";
            this.POLIKLINIK.HeaderText = "POLİKLİNİK";
            this.POLIKLINIK.Name = "POLIKLINIK";
            // 
            // SIRA_NO
            // 
            this.SIRA_NO.DataPropertyName = "SIRA_NO";
            this.SIRA_NO.HeaderText = "SIRA NO";
            this.SIRA_NO.Name = "SIRA_NO";
            // 
            // SAAT
            // 
            this.SAAT.HeaderText = "SAAT";
            this.SAAT.Name = "SAAT";
            // 
            // YAPILAN_ISLEM
            // 
            this.YAPILAN_ISLEM.DataPropertyName = "YAPILAN_ISLEM";
            this.YAPILAN_ISLEM.HeaderText = "YAPILAN İŞLEM";
            this.YAPILAN_ISLEM.Name = "YAPILAN_ISLEM";
            // 
            // DR_KODU
            // 
            this.DR_KODU.DataPropertyName = "DOKTOR_KODU";
            this.DR_KODU.HeaderText = "DR. KODU";
            this.DR_KODU.Name = "DR_KODU";
            // 
            // MIKTAR
            // 
            this.MIKTAR.DataPropertyName = "MIKTAR";
            this.MIKTAR.HeaderText = "MİKTAR";
            this.MIKTAR.Name = "MIKTAR";
            // 
            // BIRIM_FIYATI
            // 
            this.BIRIM_FIYATI.DataPropertyName = "BIRIM_FIYAT";
            this.BIRIM_FIYATI.HeaderText = "BİRİM FİYATI";
            this.BIRIM_FIYATI.Name = "BIRIM_FIYATI";
            // 
            // FormHastaIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 562);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "FormHastaIslemleri";
            this.Text = "Hasta İşlemleri";
            this.Load += new System.EventHandler(this.FormHastaIslemleri_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMiktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOHATSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLHASTAISLEMBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerSevkTarihi;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDosyaNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSeciliSil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonYazdir;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button buttonYeniKayit;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button buttonTaburcuEt;
        private System.Windows.Forms.Button btnDosynaNobul;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxOncekiIslemler;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxHastaAdi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxHastaSoyadi;
        private System.Windows.Forms.TextBox textBoxKurumAdi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonOncekiIslemler;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown numericUpDownMiktar;
        private System.Windows.Forms.ComboBox comboBoxDoktorKodu;
        private System.Windows.Forms.ComboBox comboBoxYapilanIslem;
        private System.Windows.Forms.ComboBox comboBoxPoliklinik;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private SOHATSDataSet sOHATSDataSet;
        private System.Windows.Forms.BindingSource tBLHASTAISLEMBindingSource;
        private SOHATSDataSetTableAdapters.TBL_HASTAISLEMTableAdapter tBL_HASTAISLEMTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HASTA_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn POLIKLINIK;
        private System.Windows.Forms.DataGridViewTextBoxColumn SIRA_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SAAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn YAPILAN_ISLEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn DR_KODU;
        private System.Windows.Forms.DataGridViewTextBoxColumn MIKTAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn BIRIM_FIYATI;
    }
}

