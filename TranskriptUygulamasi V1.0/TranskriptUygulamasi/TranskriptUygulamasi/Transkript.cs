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
    public partial class Transkript : Form
    {
        public Transkript()
        {
            InitializeComponent();
        }

       public decimal kazanilanKrediHesapla(string harfNotu, decimal dersinKredisi)
        {

            decimal kazanilanKredi = 0;

            switch (harfNotu)
            {
                case "AA":

                    kazanilanKredi = 4 * dersinKredisi;
                    break;

                case "BA":

                    kazanilanKredi = 3.5M * dersinKredisi;
                    break;

                case "BB":

                    kazanilanKredi = 3 * dersinKredisi;
                    break;

                case "CB":

                    kazanilanKredi = 2.5M * dersinKredisi;
                    break;

                case "CC":

                    kazanilanKredi = 2 * dersinKredisi;
                    break;

                case "DC":

                    kazanilanKredi = 1.5M * dersinKredisi;
                    break;

                case "DD":

                    kazanilanKredi = 1 * dersinKredisi;
                    break;

                case "FD":

                    kazanilanKredi = 0.5M * dersinKredisi;
                    break;

                case "FF":

                    kazanilanKredi = 0 * dersinKredisi;
                    break;
            }

            return kazanilanKredi;
        }

        private void Transkript_Load(object sender, EventArgs e)
        {

            gridTranskript.AllowUserToAddRows = false;

            NpgsqlConnection connection = new NpgsqlConnection("server=localhost; port=5432; Database=dbDersler; user Id=postgres; password=12345");
            connection.Open();

            string sorgu = "SELECT * FROM DERS WHERE (DERS_DURUM = 'Gecti' OR DERS_DURUM = 'Kaldi' OR DERS_DURUM = 'Muaf') AND HARF_NOTU != '' ORDER BY DONEM;";
      
            NpgsqlCommand command = new NpgsqlCommand(sorgu, connection);
            NpgsqlDataReader reader = command.ExecuteReader();

            DataTable dataTable = new DataTable();

            dataTable.Load(reader);

            gridTranskript.DataSource = dataTable;

            decimal alinanToplamKredi = 0;
            decimal kazanilanToplamKredi = 0;

            for(int i = 0; i < gridTranskript.RowCount; i++)
            {
                alinanToplamKredi += Convert.ToDecimal(gridTranskript.Rows[i].Cells["Kredi"].Value);
                kazanilanToplamKredi += kazanilanKrediHesapla(gridTranskript.Rows[i].Cells["harf_notu"].Value.ToString(), Convert.ToDecimal(gridTranskript.Rows[i].Cells["Kredi"].Value));
            }

            float GANO;

            try
            {
                GANO = (float)(kazanilanToplamKredi / alinanToplamKredi);
            }
            catch (System.DivideByZeroException)
            {
                return;

            }

            GANO = (float)(kazanilanToplamKredi / alinanToplamKredi);
            txtGano.Text = System.Math.Round(GANO, 2).ToString();
        }

        private void btnIslemler_Click(object sender, EventArgs e)
        {
            Islemler islemler = new Islemler();
            this.Close();
            islemler.Show();
        }
    }
}
