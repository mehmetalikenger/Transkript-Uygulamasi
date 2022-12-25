using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranskriptUygulamasi
{
    public partial class DersEkle : Form
    {
        public DersEkle()
        {
            InitializeComponent();
        }

        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            
            NpgsqlConnection connection = new NpgsqlConnection("server=localHost; port=5432; Database=dbDersler; user Id=postgres; password=12345");

            connection.Open();

            string sorgu = "INSERT INTO ders VALUES (@ders_kodu, @ders_adi, @kredi, @akts, @ogrUyesi, @donem, @harfNotu, @dersDurum);";

            NpgsqlCommand command = new NpgsqlCommand(sorgu, connection);

            command.Parameters.AddWithValue("@ders_kodu", txtDersKod.Text.ToUpper());
            command.Parameters.AddWithValue("@ders_adi", txtDersAd.Text);
            command.Parameters.AddWithValue("@kredi", Convert.ToDecimal(txtKredi.Text));
            command.Parameters.AddWithValue("@akts", Convert.ToDecimal(txtAKTS.Text));
            command.Parameters.AddWithValue("@ogrUyesi", txtOgrUyesi.Text);
            command.Parameters.AddWithValue("@donem", txtDonem.Text);
            command.Parameters.AddWithValue("@harfNotu", txtHarfNotu.Text.ToUpper());
            command.Parameters.AddWithValue("@dersDurum", cbDersDurum.SelectedItem);

            try{

                command.ExecuteNonQuery();
            }
            catch(Npgsql.PostgresException ex)
            {

                if(ex.SqlState == "23505")
                {
                    MessageBox.Show(txtDersKod.Text + " ders koduna sahip bir ders zaten var.");
                    return;

                }
                else
                {
                    throw;
                }
            }

            MessageBox.Show("Ders Ekleme Basarili");

            connection.Close();         
        }

        private void btnIslemler_Click(object sender, EventArgs e)
        {
            this.Close();
            Islemler islemler = new Islemler();
            islemler.Show();
        }
    }
}
