namespace IseAlim
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtTC = new TextBox();
            txtTelefon = new MaskedTextBox();
            label5 = new Label();
            txtAdres = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtAciklama = new TextBox();
            label8 = new Label();
            dtpTarih = new DateTimePicker();
            cbEgitim = new ComboBox();
            gbDil = new GroupBox();
            chkRusca = new CheckBox();
            chkArapca = new CheckBox();
            chkIngilizce = new CheckBox();
            chkFransizca = new CheckBox();
            chkAlmanca = new CheckBox();
            gbBilgisayar = new GroupBox();
            chkVeriTabani = new CheckBox();
            chkWebTasarim = new CheckBox();
            chkOffice = new CheckBox();
            chkSistem = new CheckBox();
            chkYazilim = new CheckBox();
            gbCinsiyet = new GroupBox();
            rbErkek = new RadioButton();
            rbKadin = new RadioButton();
            gbAskerlik = new GroupBox();
            rbTecilli = new RadioButton();
            rbYapilmadi = new RadioButton();
            rbYapildi = new RadioButton();
            btnKaydet = new Button();
            label9 = new Label();
            gbDil.SuspendLayout();
            gbBilgisayar.SuspendLayout();
            gbCinsiyet.SuspendLayout();
            gbAskerlik.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(164, 95);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(147, 124);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 0;
            label2.Text = "Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(167, 153);
            label3.Name = "label3";
            label3.Size = new Size(19, 15);
            label3.TabIndex = 0;
            label3.Text = "Tc";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(140, 182);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 0;
            label4.Text = "Telefon";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(201, 92);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(200, 23);
            txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(201, 121);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(200, 23);
            txtSoyad.TabIndex = 1;
            // 
            // txtTC
            // 
            txtTC.Location = new Point(201, 150);
            txtTC.Name = "txtTC";
            txtTC.Size = new Size(200, 23);
            txtTC.TabIndex = 1;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(201, 179);
            txtTelefon.Mask = "(999) 000-0000";
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(200, 23);
            txtTelefon.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(149, 211);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 0;
            label5.Text = "Adres";
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(201, 208);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(200, 43);
            txtAdres.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(139, 263);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 0;
            label6.Text = "D.Tarihi";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(101, 289);
            label7.Name = "label7";
            label7.Size = new Size(85, 15);
            label7.TabIndex = 0;
            label7.Text = "Eğitim Seviyesi";
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(201, 315);
            txtAciklama.Multiline = true;
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(200, 54);
            txtAciklama.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(67, 318);
            label8.Name = "label8";
            label8.Size = new Size(119, 15);
            label8.TabIndex = 3;
            label8.Text = "Eklemek İstedikleriniz";
            // 
            // dtpTarih
            // 
            dtpTarih.Location = new Point(201, 257);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(200, 23);
            dtpTarih.TabIndex = 5;
            // 
            // cbEgitim
            // 
            cbEgitim.FormattingEnabled = true;
            cbEgitim.Items.AddRange(new object[] { "Doktora", "Lisans", "Önlisans", "Lise", "İlkokul" });
            cbEgitim.Location = new Point(201, 286);
            cbEgitim.Name = "cbEgitim";
            cbEgitim.Size = new Size(200, 23);
            cbEgitim.TabIndex = 6;
            // 
            // gbDil
            // 
            gbDil.BackColor = Color.IndianRed;
            gbDil.Controls.Add(chkRusca);
            gbDil.Controls.Add(chkArapca);
            gbDil.Controls.Add(chkIngilizce);
            gbDil.Controls.Add(chkFransizca);
            gbDil.Controls.Add(chkAlmanca);
            gbDil.Location = new Point(436, 93);
            gbDil.Name = "gbDil";
            gbDil.Size = new Size(200, 134);
            gbDil.TabIndex = 7;
            gbDil.TabStop = false;
            gbDil.Text = "Yabancı Dil";
            // 
            // chkRusca
            // 
            chkRusca.AutoSize = true;
            chkRusca.Location = new Point(15, 81);
            chkRusca.Name = "chkRusca";
            chkRusca.Size = new Size(57, 19);
            chkRusca.TabIndex = 0;
            chkRusca.Text = "Rusça";
            chkRusca.UseVisualStyleBackColor = true;
            // 
            // chkArapca
            // 
            chkArapca.AutoSize = true;
            chkArapca.Location = new Point(103, 56);
            chkArapca.Name = "chkArapca";
            chkArapca.Size = new Size(63, 19);
            chkArapca.TabIndex = 0;
            chkArapca.Text = "Arapça";
            chkArapca.UseVisualStyleBackColor = true;
            // 
            // chkIngilizce
            // 
            chkIngilizce.AutoSize = true;
            chkIngilizce.Location = new Point(15, 56);
            chkIngilizce.Name = "chkIngilizce";
            chkIngilizce.Size = new Size(69, 19);
            chkIngilizce.TabIndex = 0;
            chkIngilizce.Text = "İngilizce";
            chkIngilizce.UseVisualStyleBackColor = true;
            // 
            // chkFransizca
            // 
            chkFransizca.AutoSize = true;
            chkFransizca.Location = new Point(103, 31);
            chkFransizca.Name = "chkFransizca";
            chkFransizca.Size = new Size(74, 19);
            chkFransizca.TabIndex = 0;
            chkFransizca.Text = "Fransızca";
            chkFransizca.UseVisualStyleBackColor = true;
            // 
            // chkAlmanca
            // 
            chkAlmanca.AutoSize = true;
            chkAlmanca.Location = new Point(15, 31);
            chkAlmanca.Name = "chkAlmanca";
            chkAlmanca.Size = new Size(73, 19);
            chkAlmanca.TabIndex = 0;
            chkAlmanca.Text = "Almanca";
            chkAlmanca.UseVisualStyleBackColor = true;
            // 
            // gbBilgisayar
            // 
            gbBilgisayar.BackColor = Color.RosyBrown;
            gbBilgisayar.Controls.Add(chkVeriTabani);
            gbBilgisayar.Controls.Add(chkWebTasarim);
            gbBilgisayar.Controls.Add(chkOffice);
            gbBilgisayar.Controls.Add(chkSistem);
            gbBilgisayar.Controls.Add(chkYazilim);
            gbBilgisayar.Location = new Point(436, 235);
            gbBilgisayar.Name = "gbBilgisayar";
            gbBilgisayar.Size = new Size(200, 134);
            gbBilgisayar.TabIndex = 7;
            gbBilgisayar.TabStop = false;
            gbBilgisayar.Text = "Bilgisayar Bilgisi";
            // 
            // chkVeriTabani
            // 
            chkVeriTabani.AutoSize = true;
            chkVeriTabani.Location = new Point(12, 78);
            chkVeriTabani.Name = "chkVeriTabani";
            chkVeriTabani.Size = new Size(83, 19);
            chkVeriTabani.TabIndex = 1;
            chkVeriTabani.Text = "Veri Tabanı";
            chkVeriTabani.UseVisualStyleBackColor = true;
            // 
            // chkWebTasarim
            // 
            chkWebTasarim.AutoSize = true;
            chkWebTasarim.Location = new Point(100, 53);
            chkWebTasarim.Name = "chkWebTasarim";
            chkWebTasarim.Size = new Size(94, 19);
            chkWebTasarim.TabIndex = 2;
            chkWebTasarim.Text = "Web Tasarım";
            chkWebTasarim.UseVisualStyleBackColor = true;
            // 
            // chkOffice
            // 
            chkOffice.AutoSize = true;
            chkOffice.Location = new Point(12, 53);
            chkOffice.Name = "chkOffice";
            chkOffice.Size = new Size(80, 19);
            chkOffice.TabIndex = 3;
            chkOffice.Text = "MS-Office";
            chkOffice.UseVisualStyleBackColor = true;
            // 
            // chkSistem
            // 
            chkSistem.AutoSize = true;
            chkSistem.Location = new Point(100, 28);
            chkSistem.Name = "chkSistem";
            chkSistem.Size = new Size(61, 19);
            chkSistem.TabIndex = 4;
            chkSistem.Text = "Sistem";
            chkSistem.UseVisualStyleBackColor = true;
            // 
            // chkYazilim
            // 
            chkYazilim.AutoSize = true;
            chkYazilim.Location = new Point(12, 28);
            chkYazilim.Name = "chkYazilim";
            chkYazilim.Size = new Size(63, 19);
            chkYazilim.TabIndex = 5;
            chkYazilim.Text = "Yazılım";
            chkYazilim.UseVisualStyleBackColor = true;
            // 
            // gbCinsiyet
            // 
            gbCinsiyet.BackColor = Color.MistyRose;
            gbCinsiyet.Controls.Add(rbErkek);
            gbCinsiyet.Controls.Add(rbKadin);
            gbCinsiyet.Location = new Point(659, 92);
            gbCinsiyet.Name = "gbCinsiyet";
            gbCinsiyet.Size = new Size(130, 134);
            gbCinsiyet.TabIndex = 7;
            gbCinsiyet.TabStop = false;
            gbCinsiyet.Text = "Cinsiyet";
            // 
            // rbErkek
            // 
            rbErkek.AutoSize = true;
            rbErkek.Location = new Point(23, 71);
            rbErkek.Name = "rbErkek";
            rbErkek.Size = new Size(53, 19);
            rbErkek.TabIndex = 0;
            rbErkek.TabStop = true;
            rbErkek.Text = "Erkek";
            rbErkek.UseVisualStyleBackColor = true;
            rbErkek.CheckedChanged += rbErkek_CheckedChanged;
            // 
            // rbKadin
            // 
            rbKadin.AutoSize = true;
            rbKadin.Location = new Point(23, 46);
            rbKadin.Name = "rbKadin";
            rbKadin.Size = new Size(55, 19);
            rbKadin.TabIndex = 0;
            rbKadin.TabStop = true;
            rbKadin.Text = "Kadın";
            rbKadin.UseVisualStyleBackColor = true;
            rbKadin.CheckedChanged += rbKadin_CheckedChanged;
            // 
            // gbAskerlik
            // 
            gbAskerlik.BackColor = Color.Salmon;
            gbAskerlik.Controls.Add(rbTecilli);
            gbAskerlik.Controls.Add(rbYapilmadi);
            gbAskerlik.Controls.Add(rbYapildi);
            gbAskerlik.Location = new Point(659, 235);
            gbAskerlik.Name = "gbAskerlik";
            gbAskerlik.Size = new Size(130, 134);
            gbAskerlik.TabIndex = 7;
            gbAskerlik.TabStop = false;
            gbAskerlik.Text = "Askerlik Durumu";
            // 
            // rbTecilli
            // 
            rbTecilli.AutoSize = true;
            rbTecilli.Location = new Point(23, 88);
            rbTecilli.Name = "rbTecilli";
            rbTecilli.Size = new Size(55, 19);
            rbTecilli.TabIndex = 1;
            rbTecilli.TabStop = true;
            rbTecilli.Text = "Tecilli";
            rbTecilli.UseVisualStyleBackColor = true;
            // 
            // rbYapilmadi
            // 
            rbYapilmadi.AutoSize = true;
            rbYapilmadi.Location = new Point(23, 66);
            rbYapilmadi.Name = "rbYapilmadi";
            rbYapilmadi.Size = new Size(77, 19);
            rbYapilmadi.TabIndex = 1;
            rbYapilmadi.TabStop = true;
            rbYapilmadi.Text = "Yapılmadı";
            rbYapilmadi.UseVisualStyleBackColor = true;
            // 
            // rbYapildi
            // 
            rbYapildi.AutoSize = true;
            rbYapildi.Location = new Point(23, 41);
            rbYapildi.Name = "rbYapildi";
            rbYapildi.Size = new Size(60, 19);
            rbYapildi.TabIndex = 2;
            rbYapildi.TabStop = true;
            rbYapildi.Text = "Yapıldı";
            rbYapildi.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(385, 400);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(75, 23);
            btnKaydet.TabIndex = 8;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(327, 30);
            label9.Name = "label9";
            label9.Size = new Size(214, 28);
            label9.TabIndex = 0;
            label9.Text = "İşe Giriş Başvuru Formu";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 462);
            Controls.Add(btnKaydet);
            Controls.Add(gbAskerlik);
            Controls.Add(gbCinsiyet);
            Controls.Add(gbBilgisayar);
            Controls.Add(gbDil);
            Controls.Add(cbEgitim);
            Controls.Add(dtpTarih);
            Controls.Add(txtAciklama);
            Controls.Add(label8);
            Controls.Add(txtTelefon);
            Controls.Add(txtAdres);
            Controls.Add(txtTC);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label9);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gbDil.ResumeLayout(false);
            gbDil.PerformLayout();
            gbBilgisayar.ResumeLayout(false);
            gbBilgisayar.PerformLayout();
            gbCinsiyet.ResumeLayout(false);
            gbCinsiyet.PerformLayout();
            gbAskerlik.ResumeLayout(false);
            gbAskerlik.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtTC;
        private MaskedTextBox txtTelefon;
        private Label label5;
        private TextBox txtAdres;
        private Label label6;
        private Label label7;
        private TextBox txtAciklama;
        private Label label8;
        private DateTimePicker dtpTarih;
        private ComboBox cbEgitim;
        private GroupBox gbDil;
        private CheckBox chkRusca;
        private CheckBox chkArapca;
        private CheckBox chkIngilizce;
        private CheckBox chkFransizca;
        private CheckBox chkAlmanca;
        private GroupBox gbBilgisayar;
        private GroupBox gbCinsiyet;
        private GroupBox gbAskerlik;
        private CheckBox chkVeriTabani;
        private CheckBox chkWebTasarim;
        private CheckBox chkOffice;
        private CheckBox chkSistem;
        private CheckBox chkYazilim;
        private RadioButton rbErkek;
        private RadioButton rbKadin;
        private RadioButton rbTecilli;
        private RadioButton rbYapilmadi;
        private RadioButton rbYapildi;
        private Button btnKaydet;
        private Label label9;
    }
}