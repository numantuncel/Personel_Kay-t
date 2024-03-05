namespace Personel_Kayıt
{
    partial class FrmAnaForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radiobekar = new System.Windows.Forms.RadioButton();
            this.radioevli = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.combosehir = new System.Windows.Forms.ComboBox();
            this.maskedmaas = new System.Windows.Forms.MaskedTextBox();
            this.textmeslek = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textpersonelsoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textpersonelad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textpersonelid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttongrafikler = new System.Windows.Forms.Button();
            this.buttonistatistik = new System.Windows.Forms.Button();
            this.buttontemizle = new System.Windows.Forms.Button();
            this.buttongüncelle = new System.Windows.Forms.Button();
            this.buttonsil = new System.Windows.Forms.Button();
            this.buttonkaydet = new System.Windows.Forms.Button();
            this.buttonlistele = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.perIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSOYADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSEHİRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMAASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perDURUMDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.perMESLEKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelVeriTabaniDataSet = new Personel_Kayıt.PersonelVeriTabaniDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbl_PersonelTableAdapter = new Personel_Kayıt.PersonelVeriTabaniDataSetTableAdapters.Tbl_PersonelTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.radiobekar);
            this.groupBox1.Controls.Add(this.radioevli);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.combosehir);
            this.groupBox1.Controls.Add(this.maskedmaas);
            this.groupBox1.Controls.Add(this.textmeslek);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textpersonelsoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textpersonelad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textpersonelid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 387);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Kayıt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Meslek:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Durum:";
            // 
            // radiobekar
            // 
            this.radiobekar.AutoSize = true;
            this.radiobekar.Location = new System.Drawing.Point(222, 259);
            this.radiobekar.Name = "radiobekar";
            this.radiobekar.Size = new System.Drawing.Size(79, 29);
            this.radiobekar.TabIndex = 17;
            this.radiobekar.TabStop = true;
            this.radiobekar.Text = "Bekar";
            this.radiobekar.UseVisualStyleBackColor = true;
            // 
            // radioevli
            // 
            this.radioevli.AutoSize = true;
            this.radioevli.Location = new System.Drawing.Point(155, 259);
            this.radioevli.Name = "radioevli";
            this.radioevli.Size = new System.Drawing.Size(61, 29);
            this.radioevli.TabIndex = 16;
            this.radioevli.TabStop = true;
            this.radioevli.Text = "Evli";
            this.radioevli.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Şehir:";
            // 
            // combosehir
            // 
            this.combosehir.FormattingEnabled = true;
            this.combosehir.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Amasya",
            "Ankara",
            "Antalya",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bartın",
            "Batman",
            "Bayburt",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Düzce",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkâri",
            "Hatay",
            "Iğdır",
            "Isparta",
            "İstanbul",
            "İzmir",
            "Kahramanmaraş",
            "Karabük",
            "Karaman",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kilis",
            "Kırıkkale",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Mardin",
            "Mersin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Osmaniye",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Şanlıurfa",
            "Şırnak",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Uşak",
            "Van",
            "Yalova",
            "Yozgat",
            "Zonguldak"});
            this.combosehir.Location = new System.Drawing.Point(155, 183);
            this.combosehir.Name = "combosehir";
            this.combosehir.Size = new System.Drawing.Size(146, 33);
            this.combosehir.TabIndex = 4;
            // 
            // maskedmaas
            // 
            this.maskedmaas.Location = new System.Drawing.Point(155, 222);
            this.maskedmaas.Mask = "0000";
            this.maskedmaas.Name = "maskedmaas";
            this.maskedmaas.Size = new System.Drawing.Size(146, 31);
            this.maskedmaas.TabIndex = 5;
            this.maskedmaas.ValidatingType = typeof(int);
            // 
            // textmeslek
            // 
            this.textmeslek.Location = new System.Drawing.Point(155, 294);
            this.textmeslek.Name = "textmeslek";
            this.textmeslek.Size = new System.Drawing.Size(146, 31);
            this.textmeslek.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Maaş:";
            // 
            // textpersonelsoyad
            // 
            this.textpersonelsoyad.Location = new System.Drawing.Point(155, 146);
            this.textpersonelsoyad.Name = "textpersonelsoyad";
            this.textpersonelsoyad.Size = new System.Drawing.Size(146, 31);
            this.textpersonelsoyad.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Soyad:";
            // 
            // textpersonelad
            // 
            this.textpersonelad.Location = new System.Drawing.Point(155, 109);
            this.textpersonelad.Name = "textpersonelad";
            this.textpersonelad.Size = new System.Drawing.Size(146, 31);
            this.textpersonelad.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad:";
            // 
            // textpersonelid
            // 
            this.textpersonelid.Location = new System.Drawing.Point(155, 72);
            this.textpersonelid.Name = "textpersonelid";
            this.textpersonelid.Size = new System.Drawing.Size(146, 31);
            this.textpersonelid.TabIndex = 1;
            this.textpersonelid.TextChanged += new System.EventHandler(this.textpersonelid_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.buttongrafikler);
            this.groupBox2.Controls.Add(this.buttonistatistik);
            this.groupBox2.Controls.Add(this.buttontemizle);
            this.groupBox2.Controls.Add(this.buttongüncelle);
            this.groupBox2.Controls.Add(this.buttonsil);
            this.groupBox2.Controls.Add(this.buttonkaydet);
            this.groupBox2.Controls.Add(this.buttonlistele);
            this.groupBox2.Location = new System.Drawing.Point(438, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 387);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // buttongrafikler
            // 
            this.buttongrafikler.Location = new System.Drawing.Point(58, 297);
            this.buttongrafikler.Name = "buttongrafikler";
            this.buttongrafikler.Size = new System.Drawing.Size(159, 40);
            this.buttongrafikler.TabIndex = 8;
            this.buttongrafikler.Text = "Grafikler";
            this.buttongrafikler.UseVisualStyleBackColor = true;
            this.buttongrafikler.Click += new System.EventHandler(this.buttongrafikler_Click);
            // 
            // buttonistatistik
            // 
            this.buttonistatistik.Location = new System.Drawing.Point(58, 251);
            this.buttonistatistik.Name = "buttonistatistik";
            this.buttonistatistik.Size = new System.Drawing.Size(159, 40);
            this.buttonistatistik.TabIndex = 7;
            this.buttonistatistik.Text = "İstatistik";
            this.buttonistatistik.UseVisualStyleBackColor = true;
            this.buttonistatistik.Click += new System.EventHandler(this.buttonistatistik_Click);
            // 
            // buttontemizle
            // 
            this.buttontemizle.Location = new System.Drawing.Point(58, 205);
            this.buttontemizle.Name = "buttontemizle";
            this.buttontemizle.Size = new System.Drawing.Size(159, 40);
            this.buttontemizle.TabIndex = 6;
            this.buttontemizle.Text = "Temizleme";
            this.buttontemizle.UseVisualStyleBackColor = true;
            this.buttontemizle.Click += new System.EventHandler(this.buttontemizle_Click);
            // 
            // buttongüncelle
            // 
            this.buttongüncelle.Location = new System.Drawing.Point(58, 159);
            this.buttongüncelle.Name = "buttongüncelle";
            this.buttongüncelle.Size = new System.Drawing.Size(159, 40);
            this.buttongüncelle.TabIndex = 5;
            this.buttongüncelle.Text = "Güncelle";
            this.buttongüncelle.UseVisualStyleBackColor = true;
            this.buttongüncelle.Click += new System.EventHandler(this.buttongüncelle_Click);
            // 
            // buttonsil
            // 
            this.buttonsil.Location = new System.Drawing.Point(58, 113);
            this.buttonsil.Name = "buttonsil";
            this.buttonsil.Size = new System.Drawing.Size(159, 40);
            this.buttonsil.TabIndex = 4;
            this.buttonsil.Text = "Sil";
            this.buttonsil.UseVisualStyleBackColor = true;
            this.buttonsil.Click += new System.EventHandler(this.buttonsil_Click);
            // 
            // buttonkaydet
            // 
            this.buttonkaydet.Location = new System.Drawing.Point(58, 67);
            this.buttonkaydet.Name = "buttonkaydet";
            this.buttonkaydet.Size = new System.Drawing.Size(159, 40);
            this.buttonkaydet.TabIndex = 3;
            this.buttonkaydet.Text = "Ekle/Kaydet";
            this.buttonkaydet.UseVisualStyleBackColor = true;
            this.buttonkaydet.Click += new System.EventHandler(this.buttonkaydet_Click);
            // 
            // buttonlistele
            // 
            this.buttonlistele.Location = new System.Drawing.Point(58, 21);
            this.buttonlistele.Name = "buttonlistele";
            this.buttonlistele.Size = new System.Drawing.Size(159, 40);
            this.buttonlistele.TabIndex = 2;
            this.buttonlistele.Text = "Listele";
            this.buttonlistele.UseVisualStyleBackColor = true;
            this.buttonlistele.Click += new System.EventHandler(this.buttonlistele_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 405);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(932, 222);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.perIDDataGridViewTextBoxColumn,
            this.perADDataGridViewTextBoxColumn,
            this.perSOYADDataGridViewTextBoxColumn,
            this.perSEHİRDataGridViewTextBoxColumn,
            this.perMAASDataGridViewTextBoxColumn,
            this.perDURUMDataGridViewCheckBoxColumn,
            this.perMESLEKDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPersonelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(926, 192);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // perIDDataGridViewTextBoxColumn
            // 
            this.perIDDataGridViewTextBoxColumn.DataPropertyName = "per_ID";
            this.perIDDataGridViewTextBoxColumn.HeaderText = "per_ID";
            this.perIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perIDDataGridViewTextBoxColumn.Name = "perIDDataGridViewTextBoxColumn";
            this.perIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.perIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // perADDataGridViewTextBoxColumn
            // 
            this.perADDataGridViewTextBoxColumn.DataPropertyName = "per_AD";
            this.perADDataGridViewTextBoxColumn.HeaderText = "per_AD";
            this.perADDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perADDataGridViewTextBoxColumn.Name = "perADDataGridViewTextBoxColumn";
            this.perADDataGridViewTextBoxColumn.Width = 125;
            // 
            // perSOYADDataGridViewTextBoxColumn
            // 
            this.perSOYADDataGridViewTextBoxColumn.DataPropertyName = "per_SOYAD";
            this.perSOYADDataGridViewTextBoxColumn.HeaderText = "per_SOYAD";
            this.perSOYADDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perSOYADDataGridViewTextBoxColumn.Name = "perSOYADDataGridViewTextBoxColumn";
            this.perSOYADDataGridViewTextBoxColumn.Width = 125;
            // 
            // perSEHİRDataGridViewTextBoxColumn
            // 
            this.perSEHİRDataGridViewTextBoxColumn.DataPropertyName = "per_SEHİR";
            this.perSEHİRDataGridViewTextBoxColumn.HeaderText = "per_SEHİR";
            this.perSEHİRDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perSEHİRDataGridViewTextBoxColumn.Name = "perSEHİRDataGridViewTextBoxColumn";
            this.perSEHİRDataGridViewTextBoxColumn.Width = 125;
            // 
            // perMAASDataGridViewTextBoxColumn
            // 
            this.perMAASDataGridViewTextBoxColumn.DataPropertyName = "per_MAAS";
            this.perMAASDataGridViewTextBoxColumn.HeaderText = "per_MAAS";
            this.perMAASDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perMAASDataGridViewTextBoxColumn.Name = "perMAASDataGridViewTextBoxColumn";
            this.perMAASDataGridViewTextBoxColumn.Width = 125;
            // 
            // perDURUMDataGridViewCheckBoxColumn
            // 
            this.perDURUMDataGridViewCheckBoxColumn.DataPropertyName = "per_DURUM";
            this.perDURUMDataGridViewCheckBoxColumn.HeaderText = "per_DURUM";
            this.perDURUMDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.perDURUMDataGridViewCheckBoxColumn.Name = "perDURUMDataGridViewCheckBoxColumn";
            this.perDURUMDataGridViewCheckBoxColumn.Width = 125;
            // 
            // perMESLEKDataGridViewTextBoxColumn
            // 
            this.perMESLEKDataGridViewTextBoxColumn.DataPropertyName = "per_MESLEK";
            this.perMESLEKDataGridViewTextBoxColumn.HeaderText = "per_MESLEK";
            this.perMESLEKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.perMESLEKDataGridViewTextBoxColumn.Name = "perMESLEKDataGridViewTextBoxColumn";
            this.perMESLEKDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblPersonelBindingSource
            // 
            this.tblPersonelBindingSource.DataMember = "Tbl_Personel";
            this.tblPersonelBindingSource.DataSource = this.personelVeriTabaniDataSet;
            // 
            // personelVeriTabaniDataSet
            // 
            this.personelVeriTabaniDataSet.DataSetName = "PersonelVeriTabaniDataSet";
            this.personelVeriTabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(729, 217);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(729, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(215, 199);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // tbl_PersonelTableAdapter
            // 
            this.tbl_PersonelTableAdapter.ClearBeforeFill = true;
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(954, 639);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAnaForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textmeslek;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textpersonelsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textpersonelad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textpersonelid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combosehir;
        private System.Windows.Forms.MaskedTextBox maskedmaas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radiobekar;
        private System.Windows.Forms.RadioButton radioevli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonistatistik;
        private System.Windows.Forms.Button buttontemizle;
        private System.Windows.Forms.Button buttongüncelle;
        private System.Windows.Forms.Button buttonsil;
        private System.Windows.Forms.Button buttonkaydet;
        private System.Windows.Forms.Button buttonlistele;
        private System.Windows.Forms.Button buttongrafikler;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private PersonelVeriTabaniDataSet personelVeriTabaniDataSet;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource;
        private PersonelVeriTabaniDataSetTableAdapters.Tbl_PersonelTableAdapter tbl_PersonelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn perIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSOYADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSEHİRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMAASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perDURUMDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMESLEKDataGridViewTextBoxColumn;
    }
}

