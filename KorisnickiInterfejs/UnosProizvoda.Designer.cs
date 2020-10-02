namespace Klijent
{
    partial class UnosProizvoda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnosProizvoda));
            this.cmbValuta = new System.Windows.Forms.ComboBox();
            this.cmbStopa = new System.Windows.Forms.ComboBox();
            this.cmbTip = new System.Windows.Forms.ComboBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbValuta
            // 
            this.cmbValuta.Font = new System.Drawing.Font("Century", 12F);
            this.cmbValuta.ForeColor = System.Drawing.Color.Teal;
            this.cmbValuta.FormattingEnabled = true;
            this.cmbValuta.Location = new System.Drawing.Point(262, 170);
            this.cmbValuta.Name = "cmbValuta";
            this.cmbValuta.Size = new System.Drawing.Size(256, 28);
            this.cmbValuta.TabIndex = 23;
            // 
            // cmbStopa
            // 
            this.cmbStopa.Font = new System.Drawing.Font("Century", 12F);
            this.cmbStopa.ForeColor = System.Drawing.Color.Teal;
            this.cmbStopa.FormattingEnabled = true;
            this.cmbStopa.Location = new System.Drawing.Point(321, 241);
            this.cmbStopa.Name = "cmbStopa";
            this.cmbStopa.Size = new System.Drawing.Size(197, 28);
            this.cmbStopa.TabIndex = 22;
            // 
            // cmbTip
            // 
            this.cmbTip.Font = new System.Drawing.Font("Century", 12F);
            this.cmbTip.ForeColor = System.Drawing.Color.Teal;
            this.cmbTip.FormattingEnabled = true;
            this.cmbTip.Location = new System.Drawing.Point(321, 209);
            this.cmbTip.Name = "cmbTip";
            this.cmbTip.Size = new System.Drawing.Size(197, 28);
            this.cmbTip.TabIndex = 21;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.Teal;
            this.btnSacuvaj.Font = new System.Drawing.Font("Century", 12F);
            this.btnSacuvaj.ForeColor = System.Drawing.Color.White;
            this.btnSacuvaj.Location = new System.Drawing.Point(204, 286);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(307, 47);
            this.btnSacuvaj.TabIndex = 20;
            this.btnSacuvaj.Text = "Sacuvaj proizvod";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // txtCena
            // 
            this.txtCena.Font = new System.Drawing.Font("Century", 12F);
            this.txtCena.ForeColor = System.Drawing.Color.Teal;
            this.txtCena.Location = new System.Drawing.Point(269, 134);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(249, 27);
            this.txtCena.TabIndex = 17;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Font = new System.Drawing.Font("Century", 12F);
            this.txtNaziv.ForeColor = System.Drawing.Color.Teal;
            this.txtNaziv.Location = new System.Drawing.Point(271, 95);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(247, 27);
            this.txtNaziv.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 12F);
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(201, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Poreska stopa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 12F);
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(201, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tip proizvoda:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F);
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(200, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Valuta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F);
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(201, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cena:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(201, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Naziv:";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.Font = new System.Drawing.Font("Century", 12F);
            this.txtID.ForeColor = System.Drawing.Color.Teal;
            this.txtID.Location = new System.Drawing.Point(12, 207);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(115, 27);
            this.txtID.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 12F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "ProizvodID:";
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.BackColor = System.Drawing.Color.White;
            this.btnKreiraj.Font = new System.Drawing.Font("Century", 10F);
            this.btnKreiraj.ForeColor = System.Drawing.Color.Teal;
            this.btnKreiraj.Location = new System.Drawing.Point(0, 120);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(174, 35);
            this.btnKreiraj.TabIndex = 24;
            this.btnKreiraj.Text = "Kreiraj proizvod";
            this.btnKreiraj.UseVisualStyleBackColor = false;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.logo);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.btnKreiraj);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 364);
            this.panel1.TabIndex = 33;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.White;
            this.logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(174, 66);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.Coral;
            this.panel2.Location = new System.Drawing.Point(174, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 66);
            this.panel2.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century", 12F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(619, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 20);
            this.label10.TabIndex = 30;
            this.label10.Text = "x";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 14F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(28, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 23);
            this.label7.TabIndex = 28;
            this.label7.Text = "Unos novog proizvoda";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.cmbValuta);
            this.panel3.Controls.Add(this.txtNaziv);
            this.panel3.Controls.Add(this.cmbStopa);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cmbTip);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnSacuvaj);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtCena);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Enabled = false;
            this.panel3.ForeColor = System.Drawing.Color.Teal;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(548, 364);
            this.panel3.TabIndex = 35;
            // 
            // UnosProizvoda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 364);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.ForeColor = System.Drawing.Color.Teal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "UnosProizvoda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UnosProizvoda";
            this.Load += new System.EventHandler(this.UnosProizvoda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbStopa;
        private System.Windows.Forms.ComboBox cmbTip;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbValuta;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
    }
}