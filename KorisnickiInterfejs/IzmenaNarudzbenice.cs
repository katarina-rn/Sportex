using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domen;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Klijent
{
    public partial class IzmenaNarudzbenice : Form
    {
        Kontroler kki = new Kontroler();
        public IzmenaNarudzbenice()
        {
            InitializeComponent();
        }

        private void IzmenaNarudzbenice_Load(object sender, EventArgs e)
        {
            logo.ImageLocation = @"img\logo.png";
            this.Text = kki.Welcome();
            if (!kki.ProveriKorisnika())
            {
                cmbPlacanje.Enabled = false;
                cmbStatus.Enabled = false;
            }
            else
            {
                btnDodaj.Visible = false;
                btnObrisi.Visible = false;
                btnSacuvaj.Location = new Point(btnSacuvaj.Location.X, (btnSacuvaj.Location.Y-40));
            }
            cmbPlacanje.Items.Clear();
            foreach (StatusPlacanja status in Enum.GetValues(typeof(StatusPlacanja)))
            {
                cmbPlacanje.Items.Add(status.ToString());
            }

            cmbStatus.Items.Clear();
            foreach (StatusNarudzbine status in Enum.GetValues(typeof(StatusNarudzbine)))
            {
                cmbStatus.Items.Add(status.ToString());
            }

            kki.PopuniPoljaZaNarudzbenicu(txtDatum, txtVrednost, txtVrednostPDV, cmbPlacanje, cmbStatus, txtNarucilac, dataGridView1, panelOtpremnica);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if(kki.ZapamtiNarudzbenicu(txtDatum, txtVrednost, txtVrednostPDV, cmbPlacanje, cmbStatus, dataGridView1, txtNarucilac))
            {
                if (kki.ProveriKorisnika())
                {
                    panelOtpremnica.Visible = true;
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            panelStavke.Visible = true;
            kki.PretraziProizvode(txtProizvod, dataGridView2, btnPretrazi);
            dataGridView2.Columns[1].Width = 60;
            dataGridView2.Columns[2].Width = 60;
            dataGridView2.Columns[3].Width = 60;
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (kki.ObrisiStavku(dataGridView1))
            {
                dataGridView1.Refresh();
            }
        }

        private void btnStavka_Click(object sender, EventArgs e)
        {
            kki.DodajStavku(txtKolicina, dataGridView2);
            dataGridView1.Refresh();
            panelStavke.Visible = false;
        }

        private void btnIzvestaj_Click(object sender, EventArgs e)
        {
            if(kki.KreirajRacun(dataGridView1))
            {
                this.Close();
            }
        }
    }
}
