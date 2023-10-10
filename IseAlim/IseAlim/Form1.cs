namespace IseAlim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string ad = "", soyad = "", telefon = "", adres = "", aciklama = "", egitimSeviyesi = "", tc = "";
            int tarih;
            int bugun = int.Parse(DateTime.Now.Year.ToString());
            ad = txtAd.Text;
            soyad = txtSoyad.Text;
            telefon = txtTelefon.Text;





            if (ad != "" & soyad != "" & telefon != "" & txtTC.Text != "")
            {
                tarih = int.Parse(dtpTarih.Value.Year.ToString());
                egitimSeviyesi = cbEgitim.SelectedItem.ToString();
                adres = txtAdres.Text;
                aciklama = txtAciklama.Text;
                tc = txtTC.Text;
                if (bugun - tarih >= 20 & bugun - tarih <= 40)
                {
                    if (rbErkek.Checked)
                    {
                        if (rbYapildi.Checked || rbTecilli.Checked)
                        {
                            if (((chkAlmanca.Checked) || (chkIngilizce.Checked && chkFransizca.Checked)) && ((chkVeriTabani.Checked && chkYazilim.Checked) || chkSistem.Checked) && (egitimSeviyesi == "Doktora" || egitimSeviyesi == "Lisans"))
                            {
                                MessageBox.Show("Yeterli düzeydesiniz iþe alýndýnýz");
                            }
                            else
                            {
                                MessageBox.Show("Yeterli düzeyde deðilsiniz iþe alýnmadýnýz");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Askerlik yapýlmýþ olmasý þarttýr");
                        }
                    }
                    else if (rbKadin.Checked)
                    {
                        if (((chkArapca.Checked) || (chkRusca.Checked && chkFransizca.Checked)) && ((chkOffice.Checked && chkSistem.Checked) || chkWebTasarim.Checked) && (egitimSeviyesi == "Lise" || egitimSeviyesi != "Doktora"))
                        {
                            MessageBox.Show("Yeterli düzeydesiniz iþe alýndýnýz");
                        }
                        else
                        {
                            MessageBox.Show("Yeterli düzeyde deðilsiniz iþe alýnmadýnýz");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bir Cinsiyet Seçiniz");
                    }
                }
                else
                {
                    MessageBox.Show("Yaþ kriterleri uygun deðil");
                }
            }
            else
            {
                MessageBox.Show("Alanlarý Boþ Geçmeyin");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gbAskerlik.Visible = false;
        }

        private void rbKadin_CheckedChanged(object sender, EventArgs e)
        {
            gbAskerlik.Visible = false;
        }

        private void rbErkek_CheckedChanged(object sender, EventArgs e)
        {
            gbAskerlik.Visible = true;
        }
    }
}