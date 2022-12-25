using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranskriptUygulamasi
{
    public partial class DersGuncelle : Form
    {
        public DersGuncelle()
        {
            InitializeComponent();
        }

        NpgsqlConnection connection = new NpgsqlConnection("server=localHost; port=5432; Database=dbDersler; user Id=postgres; password=12345");
        DersGuncelleKod kod = new DersGuncelleKod();

        Islemler islemler = new Islemler();

        private void DersGuncelle_Load(object sender, EventArgs e)
        {

            string dersKodu = kod.DersKodu();
            string sorgu = "select * from ders where ders_kodu = '" + dersKodu + "'";

            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand(sorgu, connection);
            NpgsqlDataReader reader = command.ExecuteReader();

            reader.Read();

            txtDersKod.Text = reader["ders_kodu"].ToString().ToUpper();
            txtDersAd.Text = reader["ders_adi"].ToString();
            txtKredi.Text = reader["kredi"].ToString();
            txtAKTS.Text = reader["akts"].ToString();
            txtOgrUyesi.Text = reader["ogretim_uyesi"].ToString();
            txtDonem.Text = reader["donem"].ToString();
            txtHarfNotu.Text = reader["harf_notu"].ToString();
            cbDersDurum.SelectedItem = reader["ders_durum"].ToString();

            connection.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            string sorgu = "UPDATE ders SET ders_kodu = @ders_kodu, ders_adi = @ders_adi, kredi = @kredi, akts = @akts, ogretim_uyesi = @ogrUyesi, donem = @donem, harf_notu = @harfNotu, ders_durum = @dersDurum WHERE ders_kodu = '" + kod.DersKodu() + "'";
        
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand(sorgu, connection);

            command.Parameters.AddWithValue("@ders_kodu", txtDersKod.Text.ToUpper());
            command.Parameters.AddWithValue("@ders_adi", txtDersAd.Text);
            command.Parameters.AddWithValue("@kredi", Convert.ToDecimal(txtKredi.Text));
            command.Parameters.AddWithValue("@akts", Convert.ToDecimal(txtAKTS.Text));
            command.Parameters.AddWithValue("@ogrUyesi", txtOgrUyesi.Text);
            command.Parameters.AddWithValue("@donem", txtDonem.Text);
            command.Parameters.AddWithValue("@harfNotu", txtHarfNotu.Text.ToUpper());
            command.Parameters.AddWithValue("@dersDurum", cbDersDurum.SelectedItem);

            command.ExecuteNonQuery();

            connection.Close();

            MessageBox.Show("Guncelleme Basarili");

            this.Close();           
            islemler.Show();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
            islemler.Show();
        }
    }
}
