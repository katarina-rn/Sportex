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
    public partial class PregledProizvoda : Form
    {
        Kontroler kki = new Kontroler();
        public PregledProizvoda()
        {
            InitializeComponent();
        }

        private void PregledProizvoda_Load(object sender, EventArgs e)
        {
            logo.ImageLocation = @"img\logo.png";
            this.Text = kki.Welcome();
            kki.PretraziProizvode(txtNaziv, dataGridView2, btnPretrazi);
            btnPretrazi.Enabled = true;
            dataGridView2.Columns[1].Width = 60;
            dataGridView2.Columns[2].Width = 60;
            dataGridView2.Columns[3].Width = 60;
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            if (kki.PrikaziProizvod(dataGridView2))
            {
                txtNaziv.Clear();
                new IzmenaProizvoda().ShowDialog();
            }  
            PregledProizvoda_Load(sender, e);
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            btnPretrazi.Enabled = false;
            kki.PretraziProizvode(txtNaziv, dataGridView2, btnPretrazi);
            btnPretrazi.Enabled = true;
        }

    }
}
