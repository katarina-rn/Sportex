using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    
    public partial class FormaServer : Form
    {
        Server s;
        public FormaServer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Serverski program";
            lblStatus.Text = "Server nije pokrenut!";
            lblStatus.ForeColor = Color.Red;
            btnPokreni.Enabled = true;
            btnZaustavi.Enabled = false;
        }

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            s = new Server();
            if (s.PokreniServer())
            {
                lblStatus.Text = "Status: Server je pokrenut!";
                lblStatus.ForeColor = Color.Green;
                btnPokreni.Enabled = false;
                btnZaustavi.Enabled = true;
                //this.WindowState = FormWindowState.Minimized;
            }
        }

        private void btnZaustavi_Click(object sender, EventArgs e)
        {
            if (Server.listaTokova.Count > 0)
            {
                MessageBox.Show("Ima jos ulogovanih klijenata!");
                return;
            }
            if (s.ZaustaviServer())
            {
                lblStatus.Text = "Status: Server nije pokrenut!";
                lblStatus.ForeColor = Color.Red;
                btnPokreni.Enabled = true;
                btnZaustavi.Enabled = false;
            }
        }
    }
}
