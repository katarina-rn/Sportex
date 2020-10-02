using Domen;
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
    public partial class UnosNarudzbenice : Form
    {
        Kontroler kki = new Kontroler();
        public UnosNarudzbenice()
        {
            InitializeComponent();
        }

        private void UnosNarudzbenice_Load(object sender, EventArgs e)
        {
            logo.ImageLocation = @"img\logo.png";
            this.Text = kki.Welcome();
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            kki.KreirajNarudzbenicu(txtID, dataGridView1);
            btnDodaj.Enabled = true;
            btnObrisi.Enabled = true;
            btnSacuvaj.Enabled = true;
            btnPregled.Enabled = true;
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            btnPretrazi.Enabled = false;
            kki.PretraziProizvode(txtProizvod, dataGridView2, btnPretrazi);
            btnPretrazi.Enabled = true;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            //new DodajStavku().ShowDialog();
            kki.PretraziProizvode(txtProizvod, dataGridView2, btnPretrazi);
            btnPretrazi.Enabled = true;
            dataGridView2.Columns[1].Width = 60;
            dataGridView2.Columns[2].Width = 60;
            dataGridView2.Columns[3].Width = 60;
            dataGridView1.Refresh();
        }

        private void btnPregled_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            panel3.Visible = true;
            panel5.Visible = false;
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (kki.ObrisiStavku(dataGridView1))
            {
                dataGridView1.Refresh();
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (kki.ZapamtiNarudzbenicu(txtDatum, txtVrednost, txtVrednostPDV, cmbPlacanje, cmbStatus, dataGridView1, txtNarucilac))
            {
                panel4.Visible = true;
            }
        }

        private void btnStavka_Click(object sender, EventArgs e)
        {
            kki.DodajStavku(txtKolicina, dataGridView2);
        }
    }
}
