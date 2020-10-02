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
    public partial class UnosNarucioca : Form
    {
        Kontroler kki = new Kontroler();
        public UnosNarucioca()
        {
            InitializeComponent();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (kki.ZapamtiNarucioca(txtKI, txtLozinka, txtNaziv, txtEmail, txtAdresa, txtTelefon, txtPib))
            {
                this.Close();
            }
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            kki.KreirajNarucioca(txtID);
            panel3.Enabled = true;
        }

        private void UnosNarucioca_Load(object sender, EventArgs e)
        {
            logo.ImageLocation = @"img\logo.png";
            this.Text = kki.Welcome();
        }

    }
}
