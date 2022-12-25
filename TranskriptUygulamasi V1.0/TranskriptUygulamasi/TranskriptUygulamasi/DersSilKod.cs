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
using static System.Net.Mime.MediaTypeNames;

namespace TranskriptUygulamasi
{
    public partial class DersSilKod : Form
    {

        private static string dersKod;
        private static string dersAd;

        public string DersKod
        {
            get
            {
                return dersKod;
            }
        }

        public string DersAd
        {
            get
            {
                return dersAd;
            }
        }

        public DersSilKod()
        {
            InitializeComponent();
        }

        private void btnDevam_Click(object sender, EventArgs e)
        {
            dersKod = txtDersKod.Text.ToUpper();

            NpgsqlConnection connection = new NpgsqlConnection("server=localHost; port=5432; Database=dbDersler; user Id=postgres; password=12345");
            connection.Open();

            string sorgu = "SELECT * FROM ders WHERE ders_kodu = @ders_kodu";

            NpgsqlCommand command = new NpgsqlCommand(sorgu, connection);

            command.Parameters.AddWithValue("@ders_kodu", DersKod);

           NpgsqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if(DersKod == reader.GetString(0)){

                    dersAd = reader.GetString(1);

                    DersSil dersSil = new DersSil();
                    dersSil.Show();
                    this.Close();
                    return;
                }
            }

            MessageBox.Show(DersKod + " kodlu ders bulunamadi.");
        }
    }
}
