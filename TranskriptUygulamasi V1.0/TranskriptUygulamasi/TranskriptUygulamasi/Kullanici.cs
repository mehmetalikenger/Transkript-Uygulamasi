using Npgsql;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranskriptUygulamasi
{
    internal class Kullanici
    {
        public bool SifreKontrol(string sifre)
        {
            string sorgu = "select sifre from kullanici";

            NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=dbDersler; user Id=postgres; password=12345");
            baglanti.Open(); 
            NpgsqlCommand command = new NpgsqlCommand(sorgu, baglanti);
            NpgsqlDataReader reader = command.ExecuteReader();

            reader.Read();

            if (sifre == reader.GetValue(0).ToString())
            {
                baglanti.Close();             
                return true;
            }
            else
            {   
                baglanti.Close();     
                return false;
            }         
        }
    }
}
