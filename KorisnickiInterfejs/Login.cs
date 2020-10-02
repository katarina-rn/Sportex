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
    public partial class Login : Form
    {
        Kontroler kki = new Kontroler();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            logo.ImageLocation = @"img\logo.png";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //kki.Kraj();
            this.Close();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            Kontroler.PoveziSeNaServer();
            if (kki.NadjiKorisnika(txtKI, txtLozinka))
            {
                this.Hide();
                if (kki.ProveriKorisnika())
                {
                    new MeniForma().ShowDialog();
                }
                else
                {
                    new MeniNarucilac().ShowDialog();
                }
                this.Show();
            }
        }

        private void txtLozinka_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
