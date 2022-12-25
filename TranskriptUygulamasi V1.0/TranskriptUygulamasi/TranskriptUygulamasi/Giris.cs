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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici();

            if (!kullanici.SifreKontrol(txtSifre.Text)){

                MessageBox.Show("Sifre hatali");
            }
            else
            {
                Islemler islemler = new Islemler();
                islemler.Show();
            }
        }
        private void Giris_Load(object sender, EventArgs e)
        {
            txtSifre.Focus();
        }
    }
}

