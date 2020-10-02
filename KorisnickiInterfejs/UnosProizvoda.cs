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
    public partial class UnosProizvoda : Form
    {
        Kontroler kki = new Kontroler();
        public UnosProizvoda()
        {
            InitializeComponent();
        }

        private void UnosProizvoda_Load(object sender, EventArgs e)
        {
            logo.ImageLocation = @"img\logo.png";
            this.Text = kki.Welcome();
            kki.UcitajComboBox(cmbTip, cmbStopa);
            cmbValuta.Items.Clear();
            foreach (Valuta status in Enum.GetValues(typeof(Valuta)))
            {
                cmbValuta.Items.Add(status.ToString());
            }
            cmbValuta.Text = "Izaberite valutu";
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (kki.ZapamtiProizvod(txtNaziv, txtCena, cmbValuta, cmbStopa, cmbTip))
            {
                this.Close();
            }
                
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            kki.KreirajProizvod(txtID);
            panel3.Enabled = true;
        }
    }
}
