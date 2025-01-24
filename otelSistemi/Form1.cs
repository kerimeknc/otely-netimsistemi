using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using MySql;


namespace otelSistemi
{

    public partial class Form1 : Form
    {

        public Form1() => InitializeComponent();

        private void baglantibtn_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection baglanti =
                new MySqlConnection("Server=172.21.54.253;Database=25_132330041;Username=25_132330041;Password=!nif.ogr41KO;");
                baglanti.Open();
                MessageBox.Show("Bağlantı Başarılı");


            }
            catch (Exception)
            {
                MessageBox.Show("Bağlantıda hata var");

                throw;
            }



           

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void girisbtn_Click(object sender, EventArgs e)
        {
            if (kullaniciAditxt.Text == "admin" && sifretxt.Text == "adm123") 
            {
                MüşteriBilgiForm fr = new MüşteriBilgiForm();
             fr.Show();
             this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı!");
            }





        }
    }
}









