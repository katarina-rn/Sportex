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

namespace Klijent
{
    public partial class IzmenaProizvoda : Form
    {
        Kontroler kki = new Kontroler();
        public IzmenaProizvoda()
        {
            InitializeComponent();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (kki.ZapamtiProizvod(txtNaziv, txtCena, cmbValuta, cmbStopa, cmbTip))
                this.Close();
        }

        private void IzmenaProizvoda_Load(object sender, EventArgs e)
        {
            logo.ImageLocation = @"img\logo.png";
            this.Text = kki.Welcome();
            kki.UcitajComboBox(cmbTip, cmbStopa);
            cmbValuta.DataSource = Enum.GetNames(typeof(Valuta));
            kki.PopuniPoljaZaProizvod(txtNaziv, txtCena, txtCenaPDV, cmbValuta, cmbTip, cmbStopa);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kki.ObrisiProizvod())
                this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
