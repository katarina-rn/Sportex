namespace Klijent
{
    partial class PregledNarudzbenica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PregledNarudzbenica));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelRadnik = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.btnPretrazi2 = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMesec = new System.Windows.Forms.Label();
            this.cmbMesec = new System.Windows.Forms.ComboBox();
            this.btnIzvestaj = new System.Windows.Forms.Button();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelRadnik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 47);
            this.panel1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century", 16F);
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(162, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pregled narudzbenica";
            // 
            // logo
            // 
            this.logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(138, 45);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panelRadnik);
            this.panel2.Controls.Add(this.btnPretrazi2);
            this.panel2.Controls.Add(this.cmbStatus);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblMesec);
            this.panel2.Controls.Add(this.cmbMesec);
            this.panel2.Controls.Add(this.btnIzvestaj);
            this.panel2.Controls.Add(this.btnPrikazi);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(703, 317);
            this.panel2.TabIndex = 20;
            // 
            // panelRadnik
            // 
            this.panelRadnik.BackColor = System.Drawing.Color.White;
            this.panelRadnik.Controls.Add(this.label1);
            this.panelRadnik.Controls.Add(this.txtNaziv);
            this.panelRadnik.Controls.Add(this.btnPretrazi);
            this.panelRadnik.Location = new System.Drawing.Point(21, -1);
            this.panelRadnik.Name = "panelRadnik";
            this.panelRadnik.Size = new System.Drawing.Size(409, 45);
            this.panelRadnik.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 10F);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(7, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Naziv narucioca:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Font = new System.Drawing.Font("Century", 10F);
            this.txtNaziv.ForeColor = System.Drawing.Color.Teal;
            this.txtNaziv.Location = new System.Drawing.Point(130, 11);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(153, 24);
            this.txtNaziv.TabIndex = 14;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.BackColor = System.Drawing.Color.Teal;
            this.btnPretrazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPretrazi.Font = new System.Drawing.Font("Century", 10F);
            this.btnPretrazi.ForeColor = System.Drawing.Color.White;
            this.btnPretrazi.Location = new System.Drawing.Point(300, 9);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(100, 29);
            this.btnPretrazi.TabIndex = 15;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPretrazi.UseVisualStyleBackColor = false;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // btnPretrazi2
            // 
            this.btnPretrazi2.BackColor = System.Drawing.Color.Teal;
            this.btnPretrazi2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPretrazi2.Font = new System.Drawing.Font("Century", 10F);
            this.btnPretrazi2.ForeColor = System.Drawing.Color.White;
            this.btnPretrazi2.Location = new System.Drawing.Point(321, 8);
            this.btnPretrazi2.Name = "btnPretrazi2";
            this.btnPretrazi2.Size = new System.Drawing.Size(100, 29);
            this.btnPretrazi2.TabIndex = 27;
            this.btnPretrazi2.Text = "Pretrazi";
            this.btnPretrazi2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPretrazi2.UseVisualStyleBackColor = false;
            this.btnPretrazi2.Click += new System.EventHandler(this.btnPretrazi2_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(160, 12);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(155, 21);
            this.cmbStatus.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 10F);
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(21, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Status narudzbine:";
            // 
            // lblMesec
            // 
            this.lblMesec.AutoSize = true;
            this.lblMesec.Font = new System.Drawing.Font("Century", 10F);
            this.lblMesec.ForeColor = System.Drawing.Color.Teal;
            this.lblMesec.Location = new System.Drawing.Point(18, 273);
            this.lblMesec.Name = "lblMesec";
            this.lblMesec.Size = new System.Drawing.Size(51, 17);
            this.lblMesec.TabIndex = 24;
            this.lblMesec.Text = "Mesec:";
            // 
            // cmbMesec
            // 
            this.cmbMesec.FormattingEnabled = true;
            this.cmbMesec.Items.AddRange(new object[] {
            "Januar",
            "Februar",
            "Mart",
            "April",
            "Maj",
            "Jun",
            "Jul",
            "Avgust",
            "Septembar",
            "Oktobar",
            "Novembar",
            "Decembar"});
            this.cmbMesec.Location = new System.Drawing.Point(77, 273);
            this.cmbMesec.Name = "cmbMesec";
            this.cmbMesec.Size = new System.Drawing.Size(121, 21);
            this.cmbMesec.TabIndex = 23;
            // 
            // btnIzvestaj
            // 
            this.btnIzvestaj.BackColor = System.Drawing.Color.Teal;
            this.btnIzvestaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzvestaj.Font = new System.Drawing.Font("Century", 10F);
            this.btnIzvestaj.ForeColor = System.Drawing.Color.White;
            this.btnIzvestaj.Location = new System.Drawing.Point(215, 260);
            this.btnIzvestaj.Name = "btnIzvestaj";
            this.btnIzvestaj.Size = new System.Drawing.Size(229, 44);
            this.btnIzvestaj.TabIndex = 22;
            this.btnIzvestaj.Text = "Izvestaj o prodatim proizvodima";
            this.btnIzvestaj.UseVisualStyleBackColor = false;
            this.btnIzvestaj.Click += new System.EventHandler(this.btnIzvestaj_Click);
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.BackColor = System.Drawing.Color.Teal;
            this.btnPrikazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrikazi.Font = new System.Drawing.Font("Century", 10F);
            this.btnPrikazi.ForeColor = System.Drawing.Color.White;
            this.btnPrikazi.Location = new System.Drawing.Point(452, 260);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(227, 44);
            this.btnPrikazi.TabIndex = 20;
            this.btnPrikazi.Text = "Prikazi podatke o narudzbenici";
            this.btnPrikazi.UseVisualStyleBackColor = false;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(658, 210);
            this.dataGridView1.TabIndex = 19;
            // 
            // PregledNarudzbenica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(703, 364);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Teal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PregledNarudzbenica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PregledNarudzbenica";
            this.Load += new System.EventHandler(this.PregledNarudzbenica_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelRadnik.ResumeLayout(false);
            this.panelRadnik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelRadnik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnIzvestaj;
        private System.Windows.Forms.ComboBox cmbMesec;
        private System.Windows.Forms.Label lblMesec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnPretrazi2;
    }
}