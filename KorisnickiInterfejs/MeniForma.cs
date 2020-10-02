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
    public partial class MeniForma : Form
    {
        Kontroler kki = new Kontroler();
        public MeniForma()
        {
            InitializeComponent();
        }

        private void MeniForma_Load(object sender, EventArgs e)
        {
            logo.ImageLocation = @"img\logo.png";
            img.ImageLocation = @"img\naslovna.jpg";
            this.Text = kki.Welcome();
        }

        private void unosNovogNaruciocaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UnosNarucioca().ShowDialog();
        }

        private void unosNovogProizvodaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UnosProizvoda().ShowDialog();
        }

        private void pregledProizvodaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PregledProizvoda().ShowDialog();
        }

        private void izmenaPodatakaONaruciocuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PregledNarucioca().ShowDialog();
        }


        private void pregledNarudzbenicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PregledNarudzbenica().ShowDialog();
        }

        private void MeniForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            kki.Kraj();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
