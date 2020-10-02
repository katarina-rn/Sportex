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
    public partial class Profil : Form
    {
        Kontroler kki = new Kontroler();
        public Profil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtLozinka.UseSystemPasswordChar)
            {
                button1.Image = Image.FromFile(@"Pass\1.png");
                txtLozinka.UseSystemPasswordChar = false;
            }
            else
            {
                button1.Image = Image.FromFile(@"Pass\2.png");
                txtLozinka.UseSystemPasswordChar = true;
            }
        }

        private void Profil_Load(object sender, EventArgs e)
        {
            logo.ImageLocation = @"img\logo.png";
            kki.PopuniPoljaZaNarucioca(txtKI, txtLozinka, txtNazivN, txtEmail, txtAdresa, txtTelefon, txtPib);
            if (kki.ProveriKorisnika())
            {
                txtKI.Visible = false;
                txtLozinka.Visible = false;
                button1.Visible = false;
                lblKI.Visible = false;
                lblLozinka.Visible = false;
                txtNazivN.Location = new Point(txtNazivN.Location.X, 59);
                lblNaziv.Location = new Point(lblNaziv.Location.X, 59);
                txtEmail.Location = new Point(txtEmail.Location.X, 90);
                lblEmail.Location = new Point(lblEmail.Location.X, 90);
                txtAdresa.Location = new Point(txtAdresa.Location.X, 121);
                lblAdresa.Location = new Point(lblAdresa.Location.X, 121);
                txtTelefon.Location = new Point(txtTelefon.Location.X, 152);
                lblTelefon.Location = new Point(lblTelefon.Location.X, 152);
                txtPib.Location = new Point(txtPib.Location.X, 188);
                lblPib.Location = new Point(lblPib.Location.X, 188);
                btnIzmeni.Visible = false;
                btnObrisi.Visible = false;
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (kki.ZapamtiNarucioca(txtKI, txtLozinka, txtNazivN, txtEmail, txtAdresa, txtTelefon, txtPib))
            {
                this.Close(); 
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (kki.ObrisiNarucioca())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
