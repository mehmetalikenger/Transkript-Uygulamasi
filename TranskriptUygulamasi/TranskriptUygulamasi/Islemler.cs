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
    public partial class Islemler : Form
    {
        public Islemler()
        {
            InitializeComponent();
        }

        private void Islemler_Load(object sender, EventArgs e) { }

        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            DersEkle dersEkle = new DersEkle();
            this.Hide();
            dersEkle.Show();
        }

        private void btnDersGuncelle_Click(object sender, EventArgs e)
        {
            DersGuncelleKod dersGuncelleKod = new DersGuncelleKod();
            this.Hide();
            dersGuncelleKod.Show();
        }

        private void btnDersSil_Click(object sender, EventArgs e)
        {
            DersSilKod dersSilKod = new DersSilKod();
            this.Hide();
            dersSilKod.Show();
        }

        private void btnTranskript_Click(object sender, EventArgs e)
        {
            Transkript transkript = new Transkript();
            this.Hide();
            transkript.Show();
        }
    }
}
