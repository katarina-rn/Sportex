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
    public partial class PregledNarudzbenica : Form
    {
        Kontroler kki = new Kontroler();
        public PregledNarudzbenica()
        {
            InitializeComponent();
        }

        private void PregledNarudzbenica_Load(object sender, EventArgs e)
        {
            logo.ImageLocation = @"img\logo.png";
            cmbMesec.Text = "Izaberite mesec";
            this.Text = kki.Welcome();
            panelRadnik.Enabled = true;
            cmbStatus.Items.Clear();
            foreach (StatusNarudzbine status in Enum.GetValues(typeof(StatusNarudzbine)))
            {
                cmbStatus.Items.Add(status.ToString());
            }
            cmbStatus.Text = "Izaberite status narudzbine";
            if (!kki.ProveriKorisnika())
            {
                btnIzvestaj.Visible = false;
                lblMesec.Visible = false;
                cmbMesec.Visible = false;
                btnPrikazi.Location = new Point(18, btnPrikazi.Location.Y);
                btnPrikazi.Width = 658;
            }
            kki.PretraziNarudzbenice(txtNaziv, dataGridView1, panelRadnik);
            dataGridView1.Columns[1].Width = 60;
            dataGridView1.Columns[6].Width = 60;
            
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            panelRadnik.Enabled = false;
            kki.PretraziNarudzbenice(txtNaziv, dataGridView1, panelRadnik);
            panelRadnik.Enabled = true;
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            if (kki.PrikaziNarudzbenicu(dataGridView1))
            {
                txtNaziv.Clear();
                new IzmenaNarudzbenice().ShowDialog();
            } 
            PregledNarudzbenica_Load(sender, e);
        }

        private void btnIzvestaj_Click(object sender, EventArgs e)
        {
            kki.KreirajIzvestaj(cmbMesec);
        }

        private void btnPretrazi2_Click(object sender, EventArgs e)
        {
            panelRadnik.Enabled = false;
            kki.PretraziNarudzbenice2(cmbStatus, dataGridView1, panelRadnik);
            panelRadnik.Enabled = true;
        }
    }
}
