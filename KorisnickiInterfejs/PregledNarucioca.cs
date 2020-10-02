using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent
{
    public partial class PregledNarucioca : Form
    {
        Kontroler kki = new Kontroler();
        public PregledNarucioca()
        {
            InitializeComponent();
        }

        private void IzmenaNarucioca_Load(object sender, EventArgs e)
        {
            logo.ImageLocation = @"img\logo.png";
            this.Text = kki.Welcome();
            kki.PretraziNarucioce(txtNaziv, dataGridView1, btnPretrazi);
            btnPretrazi.Enabled = true;
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            if (kki.PrikaziNarucioca(dataGridView1))
            {
                new Profil().ShowDialog();
                txtNaziv.Clear();
            }
            IzmenaNarucioca_Load(sender, e);
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            btnPretrazi.Enabled = false;
            kki.PretraziNarucioce(txtNaziv, dataGridView1, btnPretrazi);
            btnPretrazi.Enabled = true;
        }

    }
}
