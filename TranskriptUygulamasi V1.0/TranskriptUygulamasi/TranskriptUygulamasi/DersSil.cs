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
    public partial class DersSil : Form
    {
        public DersSil()
        {
            InitializeComponent();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM ders WHERE ders_kodu = @ders_kodu";

            NpgsqlConnection connection = new NpgsqlConnection("server=localhost; port=5432; Database=dbDersler; user Id=postgres; password=12345");
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand(sorgu, connection);
         
            command.Parameters.AddWithValue("@ders_kodu", txtDersKod.Text.ToUpper());

            command.ExecuteNonQuery();

            connection.Close();

            MessageBox.Show("Silme islemi basarili");

            this.Close();
            Islemler islem = new Islemler();
            islem.Show();
        }

        private void DersSil_Load(object sender, EventArgs e)
        {
            DersSilKod kod = new DersSilKod();
            txtDersKod.Text = kod.DersKod;
            txtDersAd.Text = kod.DersAd;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
            Islemler islemler = new Islemler();
            islemler.Show();
        }
    }
}
