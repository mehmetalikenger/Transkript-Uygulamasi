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
    public partial class DersGuncelleKod : Form
    {

        private static string DersKod;

        public string DersKodu()
        {
            return DersKod;
        }

        public DersGuncelleKod()
        {
            InitializeComponent();
        }

        private void btnDevam_Click(object sender, EventArgs e)
        {

            DersKod = txtDersKod.Text.ToUpper();

            string sorgu = "select ders_kodu from ders";

            NpgsqlConnection connection = new NpgsqlConnection("server=localHost; port=5432; Database=dbDersler; user Id=postgres; password=12345");
            connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(sorgu, connection);
            NpgsqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (DersKod == reader.GetString(0))
                {
                    connection.Close();
                                      
                    DersGuncelle guncelle = new DersGuncelle();
                    guncelle.Show();
                    this.Close();
                    return;
                }
            }

            MessageBox.Show(txtDersKod.Text + " kodlu ders bulunamadi");
            connection.Close();
            return;
        }

        private void label1_Click(object sender, EventArgs e) { }
    }
}
