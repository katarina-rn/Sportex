namespace Klijent
{
    partial class MeniNarucilac
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeniNarucilac));
            this.panel1 = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.logOut = new System.Windows.Forms.Button();
            this.btnPregled = new System.Windows.Forms.Button();
            this.btnProfil = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.slidePic = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slidePic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.logo);
            this.panel1.Controls.Add(this.btnKreiraj);
            this.panel1.Controls.Add(this.logOut);
            this.panel1.Controls.Add(this.btnPregled);
            this.panel1.Controls.Add(this.btnProfil);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Teal;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 83);
            this.panel1.TabIndex = 0;
            // 
            // logo
            // 
            this.logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.logo.ErrorImage = null;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(219, 81);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 5;
            this.logo.TabStop = false;
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKreiraj.BackColor = System.Drawing.Color.White;
            this.btnKreiraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKreiraj.ForeColor = System.Drawing.Color.Teal;
            this.btnKreiraj.Image = ((System.Drawing.Image)(resources.GetObject("btnKreiraj.Image")));
            this.btnKreiraj.Location = new System.Drawing.Point(310, 7);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(168, 68);
            this.btnKreiraj.TabIndex = 4;
            this.btnKreiraj.Text = "Nova narudzbenica";
            this.btnKreiraj.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKreiraj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKreiraj.UseVisualStyleBackColor = false;
            this.btnKreiraj.Click += new System.EventHandler(this.button1_Click);
            // 
            // logOut
            // 
            this.logOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logOut.BackColor = System.Drawing.Color.White;
            this.logOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOut.Font = new System.Drawing.Font("Century", 12F);
            this.logOut.ForeColor = System.Drawing.Color.Teal;
            this.logOut.Image = ((System.Drawing.Image)(resources.GetObject("logOut.Image")));
            this.logOut.Location = new System.Drawing.Point(801, 7);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(124, 68);
            this.logOut.TabIndex = 3;
            this.logOut.Text = "Log out";
            this.logOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.logOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.logOut.UseVisualStyleBackColor = false;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // btnPregled
            // 
            this.btnPregled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPregled.BackColor = System.Drawing.Color.White;
            this.btnPregled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPregled.ForeColor = System.Drawing.Color.Teal;
            this.btnPregled.Image = ((System.Drawing.Image)(resources.GetObject("btnPregled.Image")));
            this.btnPregled.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPregled.Location = new System.Drawing.Point(484, 8);
            this.btnPregled.Name = "btnPregled";
            this.btnPregled.Size = new System.Drawing.Size(181, 68);
            this.btnPregled.TabIndex = 2;
            this.btnPregled.Text = "Pregled narudzbenica";
            this.btnPregled.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPregled.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPregled.UseVisualStyleBackColor = false;
            this.btnPregled.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnProfil
            // 
            this.btnProfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProfil.BackColor = System.Drawing.Color.White;
            this.btnProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfil.ForeColor = System.Drawing.Color.Teal;
            this.btnProfil.Image = ((System.Drawing.Image)(resources.GetObject("btnProfil.Image")));
            this.btnProfil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProfil.Location = new System.Drawing.Point(671, 7);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(124, 69);
            this.btnProfil.TabIndex = 1;
            this.btnProfil.Text = "Profil";
            this.btnProfil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProfil.UseVisualStyleBackColor = false;
            this.btnProfil.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.slidePic);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.Color.Teal;
            this.panel2.Location = new System.Drawing.Point(0, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(939, 435);
            this.panel2.TabIndex = 1;
            // 
            // slidePic
            // 
            this.slidePic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slidePic.Image = ((System.Drawing.Image)(resources.GetObject("slidePic.Image")));
            this.slidePic.ImageLocation = "";
            this.slidePic.Location = new System.Drawing.Point(0, 0);
            this.slidePic.Name = "slidePic";
            this.slidePic.Size = new System.Drawing.Size(937, 433);
            this.slidePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slidePic.TabIndex = 0;
            this.slidePic.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MeniNarucilac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 518);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MeniNarucilac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MeniNarucilac";
            this.Load += new System.EventHandler(this.MeniNarucilac_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slidePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.Button btnPregled;
        private System.Windows.Forms.Button btnProfil;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox slidePic;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox logo;
    }
}