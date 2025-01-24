using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql;
using MySql.Data.MySqlClient;


namespace otelSistemi
{
    public partial class MüşteriBilgiForm : Form
    {
        public MüşteriBilgiForm()
        {
            InitializeComponent();

        MySqlConnection baglanti =
        new MySqlConnection("Server=172.21.54.253;Database=25_132330041;Username=25_132330041;Password=!nif.ogr41KO;");
        baglanti.Open();
        }
        






        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnOda101_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "101";
            MySqlConnection baglanti =
            new MySqlConnection("Server=172.21.54.253;Database=25_132330041;Username=25_132330041;Password=!nif.ogr41KO;");
            baglanti.Open();


            MySqlCommand komut = new MySqlCommand("SELECT *FROM odalar WHERE oda101");
            komut.Connection = baglanti;
            MySqlDataReader oku101 = komut.ExecuteReader();
            while (oku101.Read())
            {
                BtnOda101.Text = oku101.ToString();

            }
            baglanti.Close();

            if(TxtOdaNo.Text == "101")
            {
                BtnOda101.BackColor = Color.Red;
                BtnOda101.Enabled = false;
            }

        }

        private void BtnOda102_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "102";
            MySqlConnection baglanti =
            new MySqlConnection("Server=172.21.54.253;Database=25_132330041;Username=25_132330041;Password=!nif.ogr41KO;");
            baglanti.Open();


            MySqlCommand komut = new MySqlCommand("SELECT *FROM odalar WHERE oda102");
            komut.Connection = baglanti;
            MySqlDataReader oku102 = komut.ExecuteReader();
            while (oku102.Read())
            {
                BtnOda102.Text = oku102.ToString();

            }
            baglanti.Close();

            if (TxtOdaNo.Text == "102")
            {
                BtnOda102.BackColor = Color.Red;
                BtnOda102.Enabled = false;
            }
        }

        private void BtnOda103_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "103";
            MySqlConnection baglanti =
            new MySqlConnection("Server=172.21.54.253;Database=25_132330041;Username=25_132330041;Password=!nif.ogr41KO;");
            baglanti.Open();


            MySqlCommand komut = new MySqlCommand("SELECT *FROM odalar WHERE oda103");
            komut.Connection = baglanti;
            MySqlDataReader oku103 = komut.ExecuteReader();
            while (oku103.Read())
            {
                BtnOda103.Text = oku103.ToString();

            }
            baglanti.Close();

            if (TxtOdaNo.Text == "103")
            {
                BtnOda103.BackColor = Color.Red;
                BtnOda103.Enabled = false;
            }
        }

        private void BtnOda104_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "104";
            
            MySqlConnection baglanti =
            new MySqlConnection("Server=172.21.54.253;Database=25_132330041;Username=25_132330041;Password=!nif.ogr41KO;");
            baglanti.Open();


            MySqlCommand komut = new MySqlCommand("SELECT *FROM odalar WHERE oda104");
            komut.Connection = baglanti;
            MySqlDataReader oku104 = komut.ExecuteReader();
            while (oku104.Read())
            {
                BtnOda104.Text = oku104.ToString();

            }
            baglanti.Close();

            if (TxtOdaNo.Text == "104")
            {
                BtnOda104.BackColor = Color.Red;
                BtnOda104.Enabled = false;
            }
        }

        private void BtnOda201_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "201";

            MySqlConnection baglanti =
           new MySqlConnection("Server=172.21.54.253;Database=25_132330041;Username=25_132330041;Password=!nif.ogr41KO;");
            baglanti.Open();


            MySqlCommand komut = new MySqlCommand("SELECT *FROM odalar WHERE oda201");
            komut.Connection = baglanti;
            MySqlDataReader oku201 = komut.ExecuteReader();
            while (oku201.Read())
            {
                BtnOda201.Text = oku201.ToString();

            }
            baglanti.Close();

            if (TxtOdaNo.Text == "201")
            {
                BtnOda201.BackColor = Color.Red;
                BtnOda201.Enabled = false;
            }
        }

        private void BtnOda202_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "202";
            MySqlConnection baglanti =
           new MySqlConnection("Server=172.21.54.253;Database=25_132330041;Username=25_132330041;Password=!nif.ogr41KO;");
            baglanti.Open();


            MySqlCommand komut = new MySqlCommand("SELECT *FROM odalar WHERE oda202");
            komut.Connection = baglanti;
            MySqlDataReader oku202 = komut.ExecuteReader();
            while (oku202.Read())
            {
                BtnOda202.Text = oku202.ToString();

            }
            baglanti.Close();

            if (TxtOdaNo.Text == "202")
            {
                BtnOda202.BackColor = Color.Red;
                BtnOda202.Enabled = false;
            }
        }

        private void BtnOda203_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "203";
            MySqlConnection baglanti =
          new MySqlConnection("Server=172.21.54.253;Database=25_132330041;Username=25_132330041;Password=!nif.ogr41KO;");
            baglanti.Open();


            MySqlCommand komut = new MySqlCommand("SELECT *FROM odalar WHERE oda203");
            komut.Connection = baglanti;
            MySqlDataReader oku203 = komut.ExecuteReader();
            while (oku203.Read())
            {
                BtnOda203.Text = oku203.ToString();

            }
            baglanti.Close();

            if (TxtOdaNo.Text == "203")
            {
                BtnOda203.BackColor = Color.Red;
                BtnOda203.Enabled = false;
            }

        }

        private void BtnOda204_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "204";
            MySqlConnection baglanti =
          new MySqlConnection("Server=172.21.54.253;Database=25_132330041;Username=25_132330041;Password=!nif.ogr41KO;");
            baglanti.Open();


            MySqlCommand komut = new MySqlCommand("SELECT *FROM odalar WHERE oda204");
            komut.Connection = baglanti;
            MySqlDataReader oku204 = komut.ExecuteReader();
            while (oku204.Read())
            {
                BtnOda204.Text = oku204.ToString();

            }
            baglanti.Close();

            if (TxtOdaNo.Text == "204")
            {
                BtnOda204.BackColor = Color.Red;
                BtnOda204.Enabled = false;
            }
        }

        private void BtnOda301_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "301";
            MySqlConnection baglanti =
            new MySqlConnection("Server=172.21.54.253;Database=25_132330041;Username=25_132330041;Password=!nif.ogr41KO;");
            baglanti.Open();


            MySqlCommand komut = new MySqlCommand("SELECT *FROM odalar WHERE oda301");
            komut.Connection = baglanti;
            MySqlDataReader oku301 = komut.ExecuteReader();
            while (oku301.Read())
            {
                BtnOda301.Text = oku301.ToString();

            }
            baglanti.Close();

            if (TxtOdaNo.Text == "301")
            {
                BtnOda301.BackColor = Color.Red;
                BtnOda301.Enabled = false;  

            }
        }

        private void BtnOda302_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "302";
            MySqlConnection baglanti =
           new MySqlConnection("Server=172.21.54.253;Database=25_132330041;Username=25_132330041;Password=!nif.ogr41KO;");
            baglanti.Open();


            MySqlCommand komut = new MySqlCommand("SELECT *FROM odalar WHERE oda302");
            komut.Connection = baglanti;
            MySqlDataReader oku302 = komut.ExecuteReader();
            while (oku302.Read())
            {
                BtnOda302.Text = oku302.ToString();
                

            }
            baglanti.Close();

            if (TxtOdaNo.Text == "302")
            {
                BtnOda302.BackColor = Color.Red;
                BtnOda302.Enabled = false;  

            }
        }

        private void BtnOda303_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "303";
            MySqlConnection baglanti =
           new MySqlConnection("Server=172.21.54.253;Database=25_132330041;Username=25_132330041;Password=!nif.ogr41KO;");
            baglanti.Open();


            MySqlCommand komut = new MySqlCommand("SELECT *FROM odalar WHERE oda303");
            komut.Connection = baglanti;
            MySqlDataReader oku303 = komut.ExecuteReader();
            while (oku303.Read())
            {
                BtnOda303.Text = oku303.ToString();

            }
            baglanti.Close();

            if (TxtOdaNo.Text == "303")
            {
                BtnOda303.BackColor = Color.Red;
                BtnOda303.Enabled = false;  

            }
        }

        private void BtnOda304_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "304";
            MySqlConnection baglanti =
           new MySqlConnection("Server=172.21.54.253;Database=25_132330041;Username=25_132330041;Password=!nif.ogr41KO;");
            baglanti.Open();


            MySqlCommand komut = new MySqlCommand("SELECT *FROM odalar WHERE oda304");
            komut.Connection = baglanti;
            MySqlDataReader oku304 = komut.ExecuteReader();
            while (oku304.Read())
            {
                BtnOda304.Text = oku304.ToString();

            }
            baglanti.Close();

            if (TxtOdaNo.Text == "304")
            {
                BtnOda304.BackColor = Color.Red;
                BtnOda304.Enabled = false;

            }
        }

        private void BtnOda401_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "401";
            MySqlConnection baglanti =
           new MySqlConnection("Server=172.21.54.253;Database=25_132330041;Username=25_132330041;Password=!nif.ogr41KO;");
            baglanti.Open();


            MySqlCommand komut = new MySqlCommand("SELECT *FROM odalar WHERE oda401");
            komut.Connection = baglanti;
            MySqlDataReader oku401 = komut.ExecuteReader();
            while (oku401.Read())
            {
                BtnOda401.Text = oku401.ToString();

            }
            baglanti.Close();

            if (TxtOdaNo.Text == "401")
            {
                BtnOda401.BackColor = Color.Red;
                BtnOda401.Enabled = false;  

            }
        }

        private void BtnOda402_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "402";
            MySqlConnection baglanti =
           new MySqlConnection("Server=172.21.54.253;Database=25_132330041;Username=25_132330041;Password=!nif.ogr41KO;");
            baglanti.Open();


            MySqlCommand komut = new MySqlCommand("SELECT *FROM odalar WHERE oda402");
            komut.Connection = baglanti;
            MySqlDataReader oku402 = komut.ExecuteReader();
            while (oku402.Read())
            {
                BtnOda402.Text = oku402.ToString();

            }
            baglanti.Close();

            if (TxtOdaNo.Text == "402")
            {
                BtnOda402.BackColor = Color.Red;
                BtnOda402.Enabled = false;

            }
        }

        private void BtnOda403_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "403";
            MySqlConnection baglanti =
          new MySqlConnection("Server=172.21.54.253;Database=25_132330041;Username=25_132330041;Password=!nif.ogr41KO;");
            baglanti.Open();


            MySqlCommand komut = new MySqlCommand("SELECT *FROM odalar WHERE oda403");
            komut.Connection = baglanti;
            MySqlDataReader oku403 = komut.ExecuteReader();
            while (oku403.Read())
            {
                BtnOda403.Text = oku403.ToString();

            }
            baglanti.Close();

            if (TxtOdaNo.Text == "403")
            {
                BtnOda403.BackColor = Color.Red;
                BtnOda403.Enabled = false;

            }
        }

        private void BtnOda404_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "404";
            MySqlConnection baglanti =
          new MySqlConnection("Server=172.21.54.253;Database=25_132330041;Username=25_132330041;Password=!nif.ogr41KO;");
            baglanti.Open();


            MySqlCommand komut = new MySqlCommand("SELECT *FROM odalar WHERE oda404");
            komut.Connection = baglanti;
            MySqlDataReader oku404 = komut.ExecuteReader();
            while (oku404.Read())
            {
                BtnOda404.Text = oku404.ToString();

            }
            baglanti.Close();

            if (TxtOdaNo.Text == "404")
            {
                BtnOda404.BackColor = Color.Red;
                BtnOda404.Enabled = false;

            }
        }

        private void BtnOda501_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "501";
            MySqlConnection baglanti =
          new MySqlConnection("Server=172.21.54.253;Database=25_132330041;Username=25_132330041;Password=!nif.ogr41KO;");
            baglanti.Open();


            MySqlCommand komut = new MySqlCommand("SELECT *FROM odalar WHERE oda501");
            komut.Connection = baglanti;
            MySqlDataReader oku501 = komut.ExecuteReader();
            while (oku501.Read())
            {
                BtnOda501.Text = oku501.ToString();

            }
            baglanti.Close();

            if (TxtOdaNo.Text == "501")
            {
                BtnOda501.BackColor = Color.Red;
                BtnOda501.Enabled = false;

            }
        }

        private void BtnOda502_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "502";
            MySqlConnection baglanti =
          new MySqlConnection("Server=172.21.54.253;Database=25_132330041;Username=25_132330041;Password=!nif.ogr41KO;");
            baglanti.Open();


            MySqlCommand komut = new MySqlCommand("SELECT *FROM odalar WHERE oda502");
            komut.Connection = baglanti;
            MySqlDataReader oku502 = komut.ExecuteReader();
            while (oku502.Read())
            {
                BtnOda502.Text = oku502.ToString();

            }
            baglanti.Close();

            if (TxtOdaNo.Text == "502")
            {
                BtnOda502.BackColor = Color.Red;
                BtnOda502.Enabled = false;

            }
        }

        private void BtnOda503_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "503";
            MySqlConnection baglanti =
          new MySqlConnection("Server=172.21.54.253;Database=25_132330041;Username=25_132330041;Password=!nif.ogr41KO;");
            baglanti.Open();


            MySqlCommand komut = new MySqlCommand("SELECT *FROM odalar WHERE oda503");
            komut.Connection = baglanti;
            MySqlDataReader oku503 = komut.ExecuteReader();
            while (oku503.Read())
            {
                BtnOda503.Text = oku503.ToString();

            }
            baglanti.Close();

            if (TxtOdaNo.Text == "503")
            {
                BtnOda503.BackColor = Color.Red;
                BtnOda503.Enabled = false;

            }
        }

        private void BtnOda504_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "504";
            MySqlConnection baglanti =
          new MySqlConnection("Server=172.21.54.253;Database=25_132330041;Username=25_132330041;Password=!nif.ogr41KO;");
            baglanti.Open();


            MySqlCommand komut = new MySqlCommand("SELECT *FROM odalar WHERE oda504");
            komut.Connection = baglanti;
            MySqlDataReader oku504 = komut.ExecuteReader();
            while (oku504.Read())
            {
                BtnOda504.Text = oku504.ToString();

            }
            baglanti.Close();

            if (TxtOdaNo.Text == "501")
            {
                BtnOda504.BackColor = Color.Red;
                BtnOda504.Enabled = false;

            }
        }

        private void BtnAile1_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "Aile Odası 1";
            MySqlConnection baglanti =
          new MySqlConnection("Server=172.21.54.253;Database=25_132330041;Username=25_132330041;Password=!nif.ogr41KO;");
            baglanti.Open();


            MySqlCommand komut = new MySqlCommand("SELECT *FROM odalar WHERE aile1");
            komut.Connection = baglanti;
            MySqlDataReader okuAile1 = komut.ExecuteReader();
            while (okuAile1.Read())
            {
                BtnAile1.Text = okuAile1.ToString();

            }
            baglanti.Close();

            if (TxtOdaNo.Text == "Aile 1")
            {
                BtnAile1.BackColor = Color.Red;
                BtnAile1.Enabled = false;

            }
        }

        private void BtnAile2_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "Aile Odası 2";
            MySqlConnection baglanti =
         new MySqlConnection("Server=172.21.54.253;Database=25_132330041;Username=25_132330041;Password=!nif.ogr41KO;");
            baglanti.Open();


            MySqlCommand komut = new MySqlCommand("SELECT *FROM odalar WHERE aile2");
            komut.Connection = baglanti;
            MySqlDataReader okuAile2 = komut.ExecuteReader();
            while (okuAile2.Read())
            {
                BtnAile2.Text = okuAile2.ToString();

            }
            baglanti.Close();

            if (TxtOdaNo.Text == "Aile 2")
            {
                BtnAile2.BackColor = Color.Red;
                BtnAile2.Enabled = false;

            }
        }

        private void BtnAile3_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "Aile Odası 3";
            MySqlConnection baglanti =
         new MySqlConnection("Server=172.21.54.253;Database=25_132330041;Username=25_132330041;Password=!nif.ogr41KO;");
            baglanti.Open();


            MySqlCommand komut = new MySqlCommand("SELECT *FROM odalar WHERE aile3");
            komut.Connection = baglanti;
            MySqlDataReader okuAile3 = komut.ExecuteReader();
            while (okuAile3.Read())
            {
                BtnAile3.Text = okuAile3.ToString();

            }
            baglanti.Close();

            if (TxtOdaNo.Text == "Aile 3")
            {
                BtnAile3.BackColor = Color.Red;
                BtnAile3.Enabled = false;

            }
        }

        private void BtnOzel1_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = " Özel Oda 1";
            MySqlConnection baglanti =
            new MySqlConnection("Server=172.21.54.253;Database=25_132330041;Username=25_132330041;Password=!nif.ogr41KO;");
            baglanti.Open();


            MySqlCommand komut = new MySqlCommand("SELECT *FROM odalar WHERE ozel1");
            komut.Connection = baglanti;
            MySqlDataReader okuOzel1 = komut.ExecuteReader();
            while (okuOzel1.Read())
            {
                BtnOzel1.Text = okuOzel1.ToString();

            }
            baglanti.Close();

            if (TxtOdaNo.Text == "Özel 1")
            {
                BtnOzel1.BackColor = Color.Red;
                BtnOzel1.Enabled = false;

            }
        }

        private void BtnOzel2_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "Özel Oda 2";

            MySqlConnection baglanti =
            new MySqlConnection("Server=172.21.54.253;Database=25_132330041;Username=25_132330041;Password=!nif.ogr41KO;");
            baglanti.Open();


            MySqlCommand komut = new MySqlCommand("SELECT *FROM odalar WHERE ozel2");
            komut.Connection = baglanti;
            MySqlDataReader okuOzel2 = komut.ExecuteReader();
            while (okuOzel2.Read())
            {
                BtnOzel2.Text = okuOzel2.ToString();

            }
            baglanti.Close();

            if (TxtOdaNo.Text == "Özel 2")
            {
                BtnOzel2.BackColor = Color.Red;
                BtnOzel2.Enabled = false;

            }
        }

        private void btnSuitOda_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "Suit Oda";
            MySqlConnection baglanti =
            new MySqlConnection("Server=172.21.54.253;Database=25_132330041;Username=25_132330041;Password=!nif.ogr41KO;");
            baglanti.Open();


            MySqlCommand komut = new MySqlCommand("SELECT *FROM odalar WHERE odasuit");
            komut.Connection = baglanti;
            MySqlDataReader okuSuit = komut.ExecuteReader();
            while (okuSuit.Read())
            {
                btnSuitOda.Text = okuSuit.ToString();

            }
            baglanti.Close();

            if (TxtOdaNo.Text == "Suit Oda")
            {
                btnSuitOda.BackColor = Color.Red;
                btnSuitOda.Enabled = false;

            }

        }

        private void BtnDolu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı renkli butonlar dolu odaları göstermektedir.");
        }

        private void BtnBos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil renkli butonlar boş odaları göstermektedir.");
        }

        private void DtpCıkTrh_ValueChanged(object sender, EventArgs e)
        {
            DateTime kucukTarih = Convert.ToDateTime(DtpGirTrh.Text);
            DateTime buyukTarih = Convert.ToDateTime(DtpCıkTrh.Text);

            TimeSpan Sonuc;
            Sonuc = buyukTarih - kucukTarih;

            label11.Text = Sonuc.TotalDays.ToString();
            int gunSayisi = Convert.ToInt32(label11.Text);

            string odaTipi = TxtOdaNo.Text; // Oda tipi (numara ya da tipi)

            int ucret = 0;

            // Oda tipi seçimine göre ücret hesaplama
            if (odaTipi.Contains("Aile 1") || odaTipi.Contains("Aile 2") || odaTipi.Contains("Aile 3"))
            {
                ucret = gunSayisi * 900; // Aile odası için ücret
            }
            else if (odaTipi.Contains("Özel 1") || odaTipi.Contains("Özel 2"))
            {
                ucret = gunSayisi * 700; // Özel oda için ücret
            }
            else if (odaTipi.Contains("Suit Oda"))
            {
                ucret = gunSayisi * 1000; // Suit oda için ücret
            }
            else // Standart oda
            {
                ucret = gunSayisi * 800; // Standart oda için ücret
            }

            TxtUcret.Text = ucret.ToString(); // Ücreti TextBox'a yazdırıyoruz
        }




        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            MySqlConnection baglanti =
            new MySqlConnection("Server=172.21.54.253;Database=25_132330041;Username=25_132330041;Password=!nif.ogr41KO;");
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("INSERT INTO MusteriEkle (Adi,Soyadi,Telefon,Mail,TC,OdaNo,GirisTarihi,CikisTarihi,Ucret) values ('" + TxtAd.Text + "' ,'" + TxtSoyad.Text + "','" + MaskTxtTelefon.Text + "','" + TxtMail.Text + "','" + TxtKp.Text + "','" + TxtOdaNo.Text + "','" + DtpGirTrh.Value.ToString("yyyy-MM-dd") + "','" + DtpCıkTrh.Value.ToString("yyyy-MM-dd") + "','" + TxtUcret.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri kaydı yapıldı");

        }



        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection baglanti =
            new MySqlConnection("Server=172.21.54.253;Database=25_132330041;Username=25_132330041;Password=!nif.ogr41KO;");
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("UPDATE MusteriEkle SET Adi ='" + TxtAd.Text + "',Soyadi = '" + TxtSoyad.Text + "',Telefon ='" + MaskTxtTelefon.Text + "',Mail='" + TxtMail.Text + "' ,TC='" + TxtKp.Text + "',OdaNo='" + TxtOdaNo.Text + "',GirisTarihi='" + DtpGirTrh.Value.ToString("yyyy-MM-dd") + "',CikisTarihi='" + DtpCıkTrh.Value.ToString("yyyy-MM-dd") + "',Ucret='" + TxtUcret.Text + "' WHERE musteriid = " + musteriidTxt.Text + "" ,baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri kaydı başarıyla güncellendi");




        }



        private void ListSyfBtn_Click(object sender, EventArgs e)
        {

            MüşteriListe fr = new MüşteriListe();
            fr.Show();
        }



    }
    
}

