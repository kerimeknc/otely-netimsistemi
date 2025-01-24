using MySql.Data.MySqlClient;
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

namespace otelSistemi
{
    public partial class MüşteriListe : Form
    {
        public MüşteriListe()
        {
            InitializeComponent();
            MySqlConnection baglanti =
            new MySqlConnection("Server=172.21.54.253;Database=25_132330041;Username=25_132330041;Password=!nif.ogr41KO;");
            baglanti.Open();
        }

        private void VerileriListele()
        {
            MySqlConnection baglanti =
            new MySqlConnection("Server=172.21.54.253;Database=25_132330041;Username=25_132330041;Password=!nif.ogr41KO;");
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("SELECT *FROM MusteriEkle");
            komut.Connection = baglanti;
            MySqlDataReader okunanlar = komut.ExecuteReader();
            while (okunanlar.Read())
            { 
                ListViewItem ekle = new ListViewItem(); 
                ekle.Text = okunanlar["musteriid"].ToString();
                ekle.SubItems.Add(okunanlar["Adi"].ToString());
                ekle.SubItems.Add(okunanlar["Soyadi"].ToString());
                ekle.SubItems.Add(okunanlar["Telefon"].ToString());
                ekle.SubItems.Add(okunanlar["Mail"].ToString());
                ekle.SubItems.Add(okunanlar["TC"].ToString());
                ekle.SubItems.Add(okunanlar["OdaNo"].ToString());
                ekle.SubItems.Add(okunanlar["GirisTarihi"].ToString());
                ekle.SubItems.Add(okunanlar["CikisTarihi"].ToString());
                ekle.SubItems.Add(okunanlar["Ucret"].ToString());


                listView1.Items.Add(ekle);  
            }
            baglanti.Close();
        }

        private void listeleBtn_Click(object sender, EventArgs e)
        {
            VerileriListele();
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection baglanti =
            new MySqlConnection("Server=172.21.54.253;Database=25_132330041;Username=25_132330041;Password=!nif.ogr41KO;");
            baglanti.Open();


            MySqlCommand komut = new MySqlCommand("DELETE  FROM MusteriEkle WHERE musteriid = " +musteriidTxt.Text + "" ,baglanti);
            komut.Connection = baglanti;
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show(" Müşteri kaydı başarı ile silindi");
            VerileriListele();



        }

        private void araBtn_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            MySqlConnection baglanti =
            new MySqlConnection("Server=172.21.54.253;Database=25_132330041;Username=25_132330041;Password=!nif.ogr41KO;");
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("SELECT *FROM MusteriEkle WHERE Adi like '%" + araTextBox.Text + "%'" ,baglanti);
            komut.Connection = baglanti;
            MySqlDataReader okunanlar = komut.ExecuteReader();
            while (okunanlar.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = okunanlar["musteriid"].ToString();
                ekle.SubItems.Add(okunanlar["Adi"].ToString());
                ekle.SubItems.Add(okunanlar["Soyadi"].ToString());
                ekle.SubItems.Add(okunanlar["Telefon"].ToString());
                ekle.SubItems.Add(okunanlar["Mail"].ToString());
                ekle.SubItems.Add(okunanlar["TC"].ToString());
                ekle.SubItems.Add(okunanlar["OdaNo"].ToString());
                ekle.SubItems.Add(okunanlar["GirisTarihi"].ToString());
                ekle.SubItems.Add(okunanlar["CikisTarihi"].ToString());
                ekle.SubItems.Add(okunanlar["Ucret"].ToString());


                listView1.Items.Add(ekle);
            }
            baglanti.Close();





        }
    }
}
