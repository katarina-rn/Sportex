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
    public partial class MeniNarucilac : Form
    {
        Kontroler kki = new Kontroler();
        public MeniNarucilac()
        {
            InitializeComponent();
        }

        private void MeniNarucilac_Load(object sender, EventArgs e)
        {
            slidePic.ImageLocation = @"Images\10.jpg";
            logo.ImageLocation = @"img\logo.png";
            this.Text = kki.Welcome();
            slidePic.ImageLocation = @"Images\10.jpg";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var profil = new Profil();
            var res = profil.ShowDialog();
            if(res == DialogResult.OK)
            {
                kki.Kraj();
                this.Close();
            }
            //new Profil().ShowDialog();
        }

        private int imgNumber = 1;

        private void LoadNextImg()
        {
            if(imgNumber > 10)
            {
                imgNumber = 1;
            }
            slidePic.ImageLocation = string.Format(@"Images\{0}.jpg", imgNumber);
            imgNumber++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImg();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            kki.Kraj();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new PregledNarudzbenica().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new UnosNarudzbenice().ShowDialog();
        }
    }
}
