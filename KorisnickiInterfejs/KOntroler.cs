using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Drawing;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using iTextSharp.text.pdf.draw;
using System.ComponentModel.DataAnnotations;
using Domen;

namespace Klijent
{
    public class Kontroler
    {
        public static Komunikacija kom;
        public static Radnik radnik;
        public static Narucilac narucilac;
        public static Proizvod proizvod;
        public static Narudzbenica narudzbenica;
        public static Korisnik ulogovan;

        public static bool PoveziSeNaServer()
        {
            kom = new Komunikacija();
            return kom.PoveziSeNaServer();
        }
        public bool IsValidEmail(string adress)
        {
            return new EmailAddressAttribute().IsValid(adress);
        }
        public bool NadjiKorisnika(TextBox txtKI, TextBox txtLozinka)
        {
            ulogovan = new Korisnik();
            ulogovan.KorisnickoIme = txtKI.Text;
            ulogovan.Lozinka = txtLozinka.Text;
            try
            {
                ulogovan = kom.NadjiKorisnika(ulogovan);
            }
            catch (Exception)
            {
                MessageBox.Show("Nije ostvarena konekcija sa serverom!");
                return false;
            }

            if (ulogovan == null)
            {
                MessageBox.Show("Sistem ne moze da pronadje korisnika sa unetim podacima");
                txtKI.Clear();
                txtLozinka.Clear();
                txtKI.Focus();
                Kraj();
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je pronasao korisnika");
                if (ProveriKorisnika())
                {
                    radnik = (Radnik)ulogovan;
                }
                else
                {
                    narucilac = (Narucilac)ulogovan;
                }
                return true;
            }
        }
        public bool ProveriKorisnika()
        {
            if (ulogovan.GetType() == typeof(Radnik))
                return true;
            else
                return false;
        }
        public void Kraj()
        {
            kom.Kraj();
        }
        public string Welcome()
        {
            if (ProveriKorisnika())
            {
                return "Ulogovani radnik: " + radnik.ToString();
            }
            else
            {
                return "Ulogovani Narucilac: " + narucilac.ToString();
            }
        }

        #region Izvestaji

        public bool KreirajRacun(DataGridView dataGridView1)
        {
            try
            {
                ExportToPdf(dataGridView1, narudzbenica);
                System.Diagnostics.Process.Start(@"PDF\" + narudzbenica.BrojNarudzbenice.ToString() + ".pdf");
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne moze da kreira otpremnicu");
                return false;
            }
        }

        public bool KreirajIzvestaj(ComboBox cmbMesec)
        {
            try
            {
                List<Narudzbenica> lista = kom.VratiSveNarudzbenice();
                if (cmbMesec.SelectedItem == null)
                {
                    MessageBox.Show("Niste odabrali mesec");
                    return false;
                }
                ProizvodIzvestaj pi = new ProizvodIzvestaj();
                pi.Mesec = cmbMesec.SelectedIndex + 1;
                Izvestaj(lista, pi);
                System.Diagnostics.Process.Start(@"PDF\Izvestaj\Izvestaj-" + pi.Mesec.ToString() + ".pdf");
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne moze da kreira izvestaj");
                return false;
            }
        }

        private void Izvestaj(List<Narudzbenica> lista, ProizvodIzvestaj pi)
        {

            string pdfFilePath = @"PDF\Izvestaj\";
            string imeFajla = pdfFilePath + "Izvestaj-" + pi.Mesec.ToString();
            if (File.Exists(imeFajla + ".pdf"))
            {
                MessageBox.Show("Postoji izvestaj za taj mesec");
                return;
            }

            FileStream fs = new FileStream(@"PDF\Izvestaj\Izvestaj-" + pi.Mesec.ToString() + ".pdf",
                FileMode.Create, FileAccess.Write, FileShare.None);
            Document doc = new Document();
            doc.SetPageSize(iTextSharp.text.PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(doc, fs);
            doc.Open();

            //Header
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            iTextSharp.text.Font fHeader = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 16, 1, iTextSharp.text.BaseColor.BLACK);
            Paragraph pHeader = new Paragraph();
            pHeader.Alignment = Element.ALIGN_LEFT;
            pHeader.Add(new Chunk("Izveštaj o prodatim proizvodima", fHeader));
            doc.Add(pHeader);

            Paragraph pRadnik = new Paragraph();
            iTextSharp.text.Font fRadnik = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 8, 2, iTextSharp.text.BaseColor.GRAY);
            pRadnik.Alignment = Element.ALIGN_RIGHT;
            pRadnik.Add(new Chunk("Radnik: " + radnik.ToString() + "", fRadnik));
            pRadnik.Add(new Chunk("\nDatum: " + DateTime.Now.ToShortDateString() + "", fRadnik));
            doc.Add(pRadnik);

            //Line
            Paragraph line = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, iTextSharp.text.BaseColor.BLACK, Element.ALIGN_LEFT, 0)));
            doc.Add(line);

            doc.Add(new Chunk("\n", fHeader));

            //Firma
            iTextSharp.text.Font fPDF = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, 1, iTextSharp.text.BaseColor.BLACK);
            doc.Add(new Chunk("\n", fHeader));
            Paragraph pFirma = new Paragraph();
            pFirma.Alignment = Element.ALIGN_LEFT;
            pFirma.Add(new Chunk(" Sportex d.o.o", fPDF));
            pFirma.Add(new Chunk("\n Adresa: Bogdana Teofilovića 20", fPDF));
            pFirma.Add(new Chunk("\n Email: sportex@sportex.com", fPDF));
            pFirma.Add(new Chunk("\n Telefon: 123456", fPDF));
            pFirma.Add(new Chunk("\n PIB: 43215", fPDF));
            doc.Add(pFirma);

            doc.Add(new Chunk("\n", fHeader));

            //Tabela
            PdfPTable tabela = new PdfPTable(3);
            iTextSharp.text.Font fTH = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 10, 1, iTextSharp.text.BaseColor.BLACK);


            PdfPCell cell1 = new PdfPCell(new Phrase("Naziv proizvoda", fTH));
            cell1.BackgroundColor = iTextSharp.text.BaseColor.WHITE;
            tabela.AddCell(cell1);
            PdfPCell cell2 = new PdfPCell(new Phrase("Količina", fTH));
            cell2.BackgroundColor = iTextSharp.text.BaseColor.WHITE;
            tabela.AddCell(cell2);
            PdfPCell cell3 = new PdfPCell(new Phrase("Vrednost", fTH));
            cell3.BackgroundColor = iTextSharp.text.BaseColor.WHITE;
            tabela.AddCell(cell3);

            iTextSharp.text.Font fTC = new iTextSharp.text.Font(bf, 10, 1, iTextSharp.text.BaseColor.BLACK);

            int UK = 0;
            double UV = 0;
            List<ProizvodIzvestaj> proizvodi = new List<ProizvodIzvestaj>();
            try
            {
                proizvodi = kom.KreirajIzvestaj(pi);
            }
            catch (Exception)
            {
                if (File.Exists(imeFajla + ".pdf"))
                {
                    File.Delete(imeFajla + ".pdf");
                }
                return;
            }
            foreach (ProizvodIzvestaj p in proizvodi)
            {
                UK += p.Kolicina;
                UV += p.Cena;
                tabela.AddCell(new Phrase(p.Naziv, fTC));
                tabela.AddCell(new Phrase(p.Kolicina.ToString(), fTC));
                tabela.AddCell(new Phrase(p.Cena.ToString(), fTC));
            }

            doc.Add(tabela);
            doc.Add(new Chunk("\n", fHeader));
            doc.Add(new Chunk("Ukupan promet robe: " + UK + " prodatih proizvoda.\n"));
            doc.Add(new Chunk("Ukupna vrednost prodate robe: " + UV + " RSD"));

            doc.Close();
            writer.Close();
            fs.Close();

            if (tabela.Rows.Count < 2)
            {
                MessageBox.Show("Ne postoje prodati proizvodi u prethdnom mesecu za date narudžbenice");
                if (File.Exists(imeFajla + ".pdf"))
                {
                    File.Delete(imeFajla + ".pdf");
                }
                return;
            }
            MessageBox.Show("Sistem je kreirao izvestaj");
        }

        private void ExportToPdf(DataGridView dataGridView1, Narudzbenica narudzbenica)
        {
            string pdfFilePath = @"PDF\";
            string imeFajla = pdfFilePath + narudzbenica.BrojNarudzbenice.ToString();
            if (System.IO.File.Exists(imeFajla + ".pdf"))
            {
                MessageBox.Show("Postoji otpremnica za prikazanu narudzbenicu");
                return;
            }
            FileStream fs = new FileStream(@"PDF\" + narudzbenica.BrojNarudzbenice.ToString() + ".pdf",
                FileMode.Create, FileAccess.Write, FileShare.None);
            Document doc = new Document();
            doc.SetPageSize(iTextSharp.text.PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(doc, fs);
            doc.Open();

            //Header
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            iTextSharp.text.Font fHeader = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 16, 1, iTextSharp.text.BaseColor.BLACK);
            Paragraph pHeader = new Paragraph();
            pHeader.Alignment = Element.ALIGN_LEFT;
            pHeader.Add(new Chunk("OTPREMNICA - RACUN", fHeader));
            doc.Add(pHeader);

            Paragraph pRadnik = new Paragraph();
            iTextSharp.text.Font fRadnik = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 8, 2, iTextSharp.text.BaseColor.GRAY);
            pRadnik.Alignment = Element.ALIGN_RIGHT;
            pRadnik.Add(new Chunk("Radnik: " + narudzbenica.Radnik.ToString() + "", fRadnik));
            pRadnik.Add(new Chunk("\nDatum: " + DateTime.Now.ToShortDateString() + "", fRadnik));
            doc.Add(pRadnik);

            //Line
            Paragraph line = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, iTextSharp.text.BaseColor.BLACK, Element.ALIGN_LEFT, 0)));
            doc.Add(line);

            doc.Add(new Chunk("\n", fHeader));

            //Firma i narucilac
            iTextSharp.text.Font fPDF = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, 1, iTextSharp.text.BaseColor.BLACK);
            doc.Add(new Chunk("\n", fHeader));
            Paragraph pFirma = new Paragraph();
            pFirma.Alignment = Element.ALIGN_LEFT;
            pFirma.Add(new Chunk(" Sportex d.o.o", fPDF));
            pFirma.Add(new Chunk("\n Adresa: Bogdana Teofilovića 20", fPDF));
            pFirma.Add(new Chunk("\n Email: sportex@sportex.com", fPDF));
            pFirma.Add(new Chunk("\n Telefon: 123456", fPDF));
            pFirma.Add(new Chunk("\n PIB: 43215", fPDF));
            doc.Add(pFirma);

            PdfContentByte cb = writer.DirectContent;
            iTextSharp.text.Rectangle rect = new iTextSharp.text.Rectangle(350, 725, 555, 600);
            rect.Border = iTextSharp.text.Rectangle.BOX;
            rect.BorderWidth = 1;
            rect.BorderColor = BaseColor.BLACK;
            cb.Rectangle(rect);
            //cb.Stroke();

            ColumnText ct = new ColumnText(cb);
            ct.SetSimpleColumn(rect);
            Paragraph pNarucilac = new Paragraph();
            pNarucilac.Alignment = Element.ALIGN_LEFT;
            pNarucilac.PaddingTop = 5;
            pNarucilac.Add(new Chunk("\n", fPDF));
            pNarucilac.Add(new Chunk("  Narucilac: " + narudzbenica.Narucilac.ToString() + "\n", fPDF));
            pNarucilac.Add(new Chunk("  Adresa: " + narudzbenica.Narucilac.Adresa + "\n", fPDF));
            pNarucilac.Add(new Chunk("  Email: " + narudzbenica.Narucilac.Email + "\n", fPDF));
            pNarucilac.Add(new Chunk("  Telefon: " + narudzbenica.Narucilac.Telefon + "\n", fPDF));
            pNarucilac.Add(new Chunk("  PIB: " + narudzbenica.Narucilac.Pib + "", fPDF));
            pNarucilac.Add(new Chunk("\n", fPDF));
            ct.AddElement(pNarucilac);
            ct.Go();

            doc.Add(new Chunk("\n", fHeader));
            doc.Add(new Chunk("\n Otpremnica - racun broj: " + narudzbenica.BrojNarudzbenice.ToString()));
            doc.Add(new Chunk("\n", fHeader));
            doc.Add(new Chunk(" Datum prometa dobara: " + narudzbenica.DatumIsporuke.ToShortDateString() + "\n"));
            doc.Add(new Chunk(" Valuta: RSD"));

            //Tabela
            PdfPTable tabela = new PdfPTable(dataGridView1.Columns.Count);
            iTextSharp.text.Font fTH = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 10, 1, iTextSharp.text.BaseColor.BLACK);

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, fTH));
                cell.BackgroundColor = iTextSharp.text.BaseColor.WHITE;
                tabela.AddCell(cell);
            }

            iTextSharp.text.Font fTC = new iTextSharp.text.Font(bf, 10, 1, iTextSharp.text.BaseColor.BLACK);

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    tabela.AddCell(new Phrase(cell.Value.ToString(), fTC));
                }
            }

            doc.Add(tabela);
            doc.Add(new Chunk("\n", fHeader));

            //Iznos
            Paragraph pVrednost = new Paragraph();
            pVrednost.Alignment = Element.ALIGN_LEFT;
            pVrednost.PaddingTop = 3;
            pVrednost.Add(new Chunk("\n Vrednost: " + narudzbenica.VrednostBezPDV.ToString() + "", fPDF));
            pVrednost.Add(new Chunk("\n Vrednost sa PDV: " + narudzbenica.VrednostSaPDV.ToString() + "", fPDF));

            int kolicina = 0;
            foreach (StavkaNarudzbenice stavka in narudzbenica.ListaStavki)
            {
                kolicina += stavka.Kolicina;
            }

            double rabat = 0;
            if (kolicina > 20)
            {
                rabat += narudzbenica.VrednostSaPDV * 0.9 - narudzbenica.VrednostSaPDV;
            }

            pVrednost.Add(new Chunk("\n Rabat: " + rabat + "", fPDF));
            pVrednost.Add(new Chunk("\n Ukupno za naplatu: " + (narudzbenica.VrednostSaPDV + rabat) + " RSD", fPDF));
            doc.Add(pVrednost);

            doc.Add(new Chunk("\n\n", fHeader));
            doc.Add(new Chunk(" Potpis radnika:                                                                             Robu preuzeo:", fPDF));
            Paragraph potpis = new Paragraph();
            potpis.Add(new Chunk("\n", fPDF));
            potpis.Add(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 45.0F, iTextSharp.text.BaseColor.BLACK, Element.ALIGN_LEFT, 0)));
            potpis.Add(new Chunk("                              ", fPDF));
            potpis.Add(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 45.0F, iTextSharp.text.BaseColor.BLACK, Element.ALIGN_LEFT, 0)));

            doc.Add(potpis);

            doc.Close();
            writer.Close();
            fs.Close();
            //MessageBox.Show("Sistem je kreirao otpremnicu");
        }

        #endregion

        #region Proizvod
        public void PopuniPoljaZaProizvod(TextBox txtNaziv, TextBox txtCena, TextBox txtCenaPDV, ComboBox cmbValuta, ComboBox cmbTip, ComboBox cmbStopa)
        {
            txtNaziv.Text = proizvod.NazivProizvoda;
            txtCena.Text = proizvod.CenaBezPDV.ToString();
            txtCenaPDV.Text = proizvod.CenaSaPDV.ToString();
            cmbValuta.SelectedItem = proizvod.Valuta;
            cmbTip.Text = proizvod.Tip.ToString();
            cmbStopa.Text = proizvod.PoreskaStopa.ToString();
        }
        public void PretraziProizvode(TextBox txtNaziv, DataGridView dataGridView2, Button btnPretrazi)
        {
            Proizvod p = new Proizvod();
            p.NazivProizvoda = txtNaziv.Text;

            List<Proizvod> lista = kom.PretraziProizvode(p);
            if (lista == null || lista.Count == 0)
            {
                MessageBox.Show("Sistem ne moze da pronadje proizvode po zadatoj vrednosti!");
                dataGridView2.DataSource = lista;
            }
            else
            {
                if (!btnPretrazi.Enabled && ProveriKorisnika())
                    MessageBox.Show("Sistem je pronasao proizvode po zadatoj vrednosti.");
                dataGridView2.DataSource = lista;
            }
        }
        public bool PrikaziProizvod(DataGridView dataGridView2)
        {
            try
            {
                proizvod = dataGridView2.CurrentRow.DataBoundItem as Proizvod;
                proizvod = kom.PrikaziProizvod(proizvod);
                if (proizvod == null)
                {
                    MessageBox.Show("Sistem ne moze da prikaze odabrani proizvod!");
                    return false;
                }
                else
                {
                    MessageBox.Show("Odabrani proizvod je prikazan.");
                    return true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Niste odabrali proizvod za prikaz!");
                return false;
            }
        }
        public bool ObrisiProizvod()
        {
            Object o = kom.ObrisiProizvod(proizvod);
            if (o == null)
            {
                MessageBox.Show("Sistem ne moze da obrise proizvod!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je obrisao proizvod.");
                return true;
            }
        }
        public bool ZapamtiProizvod(TextBox txtNaziv, TextBox txtCena, ComboBox cmbValuta, ComboBox cmbStopa, ComboBox cmbTip)
        {
            proizvod.NazivProizvoda = txtNaziv.Text;
            if (proizvod.NazivProizvoda == "")
            {
                MessageBox.Show("Morate uneti naziv proizvoda");
                txtNaziv.Focus();
                return false;
            }
            try
            {
                proizvod.CenaBezPDV = double.Parse(txtCena.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Nije validna vrednost za cenu");
                return false;
            }
            proizvod.Tip = cmbTip.SelectedItem as TipProizvoda;
            if (proizvod.Tip == null)
            {
                MessageBox.Show("Niste odabrali tip proizvoda");
                cmbTip.Focus();
                return false;
            }
            proizvod.PoreskaStopa = cmbStopa.SelectedItem as PoreskaStopa;
            if (proizvod.Tip == null)
            {
                MessageBox.Show("Niste odabrali poresku stopu");
                cmbStopa.Focus();
                return false;
            }

            if (cmbValuta.SelectedItem == null)
            {
                MessageBox.Show("Niste odabrali valutu");
                cmbValuta.Focus();
                return false;
            }
            else
            {
                proizvod.Valuta = (Valuta)Enum.Parse(typeof(Valuta), cmbValuta.SelectedItem.ToString());
            }

            proizvod.CenaSaPDV = proizvod.CenaBezPDV + proizvod.CenaBezPDV * proizvod.PoreskaStopa.Stopa / 100;

            Object o = kom.ZapamtiProizvod(proizvod);
            if (o == null)
            {
                MessageBox.Show("Sistem ne moze da zapamti proizvod!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je zapamtio proizvod.");
                return true;
            }
        }
        public void KreirajProizvod(TextBox txtID)
        {
            proizvod = kom.KreirajProizvod();
            if (proizvod == null)
            {
                MessageBox.Show("Sistem ne moze da kreira proizvod!");
            }
            else
            {
                MessageBox.Show("Sistem je kreirao proizvod.");
                txtID.Text = proizvod.ProizvodID.ToString();
            }
        }
        public void UcitajComboBox(ComboBox cmbTip, ComboBox cmbStopa)
        {
            try
            {
                cmbTip.DataSource = kom.UcitajSveTipove();
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne moze da ucita tipove proizvoda!");
                return;
            }
            try
            {
                cmbStopa.DataSource = kom.UcitajSveStope();
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne moze da ucita poreske stope!");
                return;
            }
            cmbTip.Text = "Izaberite tip proizvoda";
            cmbStopa.Text = "Izaberite poresku stopu";
        }
        #endregion

        #region Narucilac
        public bool PrikaziNarucioca(DataGridView dataGridView1)
        {
            try
            {
                narucilac = dataGridView1.CurrentRow.DataBoundItem as Narucilac;
                narucilac = kom.PrikaziNarucioca(narucilac);
                if (narucilac == null)
                {
                    MessageBox.Show("Sistem ne moze da prikaze odabranog narucioca");
                    return false;
                }
                else
                {
                    MessageBox.Show("Odabrani narucilac je prikazan");
                    return true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Niste odabrali narucioca za prikaz!");
                return false;
            }
        }
        public void PopuniPoljaZaNarucioca(TextBox txtKI, TextBox txtLozinka, TextBox txtNazivN, TextBox txtEmail, TextBox txtAdresa, TextBox txtTelefon, TextBox txtPib)
        {
            txtKI.Text = narucilac.KorisnickoIme;
            txtLozinka.Text = narucilac.Lozinka;
            txtNazivN.Text = narucilac.Naziv;
            txtAdresa.Text = narucilac.Adresa;
            txtEmail.Text = narucilac.Email;
            txtTelefon.Text = narucilac.Telefon;
            txtPib.Text = narucilac.Pib;
        }
        public bool ZapamtiNarucioca(TextBox txtKI, TextBox txtLozinka, TextBox txtNaziv, TextBox txtEmail, TextBox txtAdresa, TextBox txtTelefon, TextBox txtPib)
        {
            narucilac.Naziv = txtNaziv.Text;
            if (narucilac.Naziv == "")
            {
                MessageBox.Show("Morate uneti naziv");
                return false;
            }
            narucilac.Email = txtEmail.Text;
            if (narucilac.Email == "")
            {
                MessageBox.Show("Morate uneti email narucioca");
                return false;
            }
            if (!IsValidEmail(narucilac.Email))
            {
                MessageBox.Show("Email adresa nije u dobrom formatu");
                return false;
            }
            narucilac.Adresa = txtAdresa.Text;
            if (narucilac.Adresa == "")
            {
                MessageBox.Show("Morate uneti adresu narucioca");
                return false;
            }
            narucilac.Telefon = txtTelefon.Text;
            if (narucilac.Telefon == "")
            {
                MessageBox.Show("Morate uneti telefon narucioca");
                return false;
            }
            narucilac.Pib = txtPib.Text;
            if (narucilac.Naziv == "")
            {
                MessageBox.Show("Morate uneti PIB narucioca");
                return false;
            }

            if (!ProveriKorisnika())
            {
                narucilac.KorisnickoIme = txtKI.Text;
                narucilac.Lozinka = txtLozinka.Text;
                if (narucilac.KorisnickoIme == "")
                {
                    MessageBox.Show("Morate uneti korisnicko ime");
                    return false;
                }

                if (narucilac.Lozinka == "")
                {
                    MessageBox.Show("Morate uneti lozinku");
                    return false;
                }
            }
            else
            {
                narucilac.KorisnickoIme = narucilac.Naziv;
                narucilac.Lozinka = RandomPassword();
            }

            Object o = kom.ZapamtiNarucioca(narucilac);
            if (o == null)
            {
                MessageBox.Show("Sistem ne moze da zapamti narucioca!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je zapamtio narucioca!");

                if (ProveriKorisnika())
                {
                    try
                    {
                        MailMessage msg = new MailMessage();
                        msg.From = new MailAddress("mail");
                        msg.To.Add("narucilac.Email");
                        msg.Subject = "Nalog za aplikaciju";
                        msg.Body = "Narucilac: " + narucilac.Naziv + "\nKorisnicko ime: " + narucilac.Email + "\nLozinka: " + narucilac.Lozinka + "\nSavetujemo da nakon logovanja na vasem profilu promenite lozinku.\nPozdrav!";

                        SmtpClient smt = new SmtpClient();
                        smt.Host = "smtp.gmail.com";
                        System.Net.NetworkCredential ntcd = new NetworkCredential();
                        ntcd.UserName = "mail";
                        ntcd.Password = "password";
                        smt.Credentials = ntcd;
                        smt.EnableSsl = true;
                        smt.Port = 587;
                        smt.Send(msg);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                return true;
            }
        }
        private static string RandomPassword(int length = 8)
        {
            string karakteri = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*?_-";
            Random random = new Random();

            char[] chars = new char[length];
            for (int i = 0; i < length; i++)
            {
                chars[i] = karakteri[random.Next(0, karakteri.Length)];
            }
            return new string(chars);
        }
        public void PretraziNarucioce(TextBox txtNaziv, DataGridView dataGridView1, Button btnPretrazi)
        {
            Narucilac n = new Narucilac();
            n.Naziv = txtNaziv.Text;

            List<Narucilac> lista = kom.PretraziNarucioce(n);
            if (lista == null || lista.Count == 0)
            {
                MessageBox.Show("Sistem ne moze da pronadje narucioce po zadatoj vrednosti!");
                dataGridView1.DataSource = lista;
            }
            else
            {
                if (!btnPretrazi.Enabled)
                    MessageBox.Show("Sistem je pronasao narucioce po zadatoj vrednosti.");
                dataGridView1.DataSource = lista;
            }
        }
        public void KreirajNarucioca(TextBox txtID)
        {
            narucilac = kom.KreirajNarucioca();
            if (narucilac == null)
            {
                MessageBox.Show("Sistem ne moze da kreira narucioca!");
            }
            else
            {
                MessageBox.Show("Sistem je kreirao narucioca!");
                txtID.Text = narucilac.KorisnikID.ToString();
            }
        }
        public bool ObrisiNarucioca()
        {
            DialogResult dr = MessageBox.Show("Da li ste sigurni da zelite da obrisete nalog",
                      "", MessageBoxButtons.YesNo);
            if(dr == DialogResult.Yes)
            {
                Object o = kom.ObrisiNarucioca(narucilac);
                if (o == null)
                {
                    MessageBox.Show("Sistem ne moze da obrise narucioca!");
                    return false;
                }
                else
                {
                    MessageBox.Show("Sistem je obrisao narucioca.");
                    return true;
                }
            }
            else
            {
                return false;
            }
            
        }

        #endregion

        #region Narudzbenica
        public void PretraziNarudzbenice(TextBox txtNaziv, DataGridView dataGridView1, Panel panelRadnik)
        {
            Narudzbenica n = new Narudzbenica();
            n.Narucilac = new Narucilac();

            if (ProveriKorisnika())
            {
                n.Ulogovan = radnik;
                n.Narucilac.Naziv = txtNaziv.Text;
            }
            else
            {
                n.Narucilac.Naziv = narucilac.Naziv;
            }

            List<Narudzbenica> lista = kom.PretraziNarudzbenice(n);
            if (lista == null || lista.Count == 0)
            {
                MessageBox.Show("Sistem ne moze da pronadje narudzbenice po zadatoj vrednosti!");
                dataGridView1.DataSource = lista;
                if (!ProveriKorisnika())
                {
                    dataGridView1.Columns[0].Visible = false;
                    panelRadnik.Visible = false;
                }
                else
                {
                    dataGridView1.Columns[8].Visible = false;
                }
            }
            else
            {
                if (!panelRadnik.Enabled && ProveriKorisnika())
                {
                    MessageBox.Show("Sistem je pronasao narudzbenice po zadatoj vrednosti.");
                    txtNaziv.Clear();
                }
                dataGridView1.DataSource = lista;
                if (!ProveriKorisnika())
                {
                    dataGridView1.Columns[0].Visible = false;
                    panelRadnik.Visible = false;
                }
                else
                {
                    dataGridView1.Columns[8].Visible = false;
                }
            }
        }
        public void PretraziNarudzbenice2(ComboBox cmbStatus, DataGridView dataGridView1, Panel panelRadnik)
        {
            Narudzbenica n = new Narudzbenica();
            n.Narucilac = new Narucilac();
            n.Ulogovan = narucilac;
            n.Narucilac.Naziv = narucilac.Naziv;
            if (cmbStatus.SelectedItem == null)
            {
                MessageBox.Show("Niste odabrali status narudzbine");
                cmbStatus.Focus();
                return;
            }
            else
            {
                n.Status = (StatusNarudzbine)Enum.Parse(typeof(StatusNarudzbine), cmbStatus.SelectedItem.ToString());
            }


            List<Narudzbenica> lista = kom.PretraziNarudzbenice(n);
            if (lista == null || lista.Count == 0)
            {
                MessageBox.Show("Sistem ne moze da pronadje narudzbenice po zadatoj vrednosti!");
                dataGridView1.DataSource = lista;
                dataGridView1.Columns[0].Visible = false;
                panelRadnik.Visible = false;
            }
            else
            {

                dataGridView1.DataSource = lista;
                dataGridView1.Columns[0].Visible = false;
                panelRadnik.Visible = false;
            }
        }
        public bool ZapamtiNarudzbenicu(TextBox txtDatum, TextBox txtVrednost, TextBox txtVrednostPDV, ComboBox cmbPlacanje, ComboBox cmbStatus, DataGridView dataGridView1, TextBox txtNarucilac)
        {
            if (narudzbenica.Obradjena)
            {
                MessageBox.Show("Odabrana narudzbenica je obradjena, ne moze se dalje menjati");
                return false;
            }
            if (narudzbenica.Status == StatusNarudzbine.Odbijena)
            {
                MessageBox.Show("Odabrana narudzbenica je obradjena, ne moze se dalje menjati");
                return false;
            }
            if (narudzbenica.DatumIzdavanja.Year < 2020)
            {
                narudzbenica.DatumIzdavanja = DateTime.Now; 
            }
            txtDatum.Text = narudzbenica.DatumIzdavanja.ToString("dd.MM.yyyy");
            if (ProveriKorisnika())
            {
                narudzbenica.Placanje = (StatusPlacanja)Enum.Parse(typeof(StatusPlacanja), cmbPlacanje.SelectedItem.ToString());
                narudzbenica.Status = (StatusNarudzbine)Enum.Parse(typeof(StatusNarudzbine), cmbStatus.SelectedItem.ToString());
                narudzbenica.Radnik = radnik;
            }
            else
            {
                narudzbenica.Placanje = StatusPlacanja.Neplacena;
                narudzbenica.Status = StatusNarudzbine.Primljena;
                narudzbenica.Radnik = new Radnik();
                narudzbenica.Radnik.KorisnikID = 1;
                narudzbenica.Narucilac = narucilac;
            }

            if (narudzbenica.Status == StatusNarudzbine.Isporucena && narudzbenica.Placanje == StatusPlacanja.Placena)
            {
                narudzbenica.Obradjena = true;
            }
            else
            {
                narudzbenica.Obradjena = false;
            }


            narudzbenica.VrednostBezPDV = 0;
            narudzbenica.VrednostSaPDV = 0;
            foreach (StavkaNarudzbenice stavka in narudzbenica.ListaStavki)
            {
                narudzbenica.VrednostBezPDV += stavka.UkupnaCenaBezPDV;
                narudzbenica.VrednostSaPDV += stavka.UkupnaCenaSaPDV;
            }

            txtVrednost.Text = narudzbenica.VrednostBezPDV.ToString();
            txtVrednostPDV.Text = narudzbenica.VrednostSaPDV.ToString();

            txtNarucilac.Text = narudzbenica.Narucilac.ToString();
            cmbPlacanje.Enabled = false;
            cmbStatus.Enabled = false;
            cmbStatus.Text = narudzbenica.Status.ToString();
            cmbPlacanje.Text = narudzbenica.Placanje.ToString();

            if (narudzbenica.Status == StatusNarudzbine.Isporucena)
            {
                narudzbenica.DatumIsporuke = DateTime.Now;
            }

            if (narudzbenica.ListaStavki.Count < 1)
            {
                MessageBox.Show("Narudzbenica mora imati barem jednu stavku");
                return false;
            }

            Object o = kom.ZapamtiNarudzbenicu(narudzbenica);
            if (o == null)
            {
                MessageBox.Show("Sistem ne moze da zapamti narudzbenicu!");
                return false;
            }
            else
            {
                MessageBox.Show("Sistem je zapamtio narudzbenicu.");
                return true;
            }
        }
        public bool PrikaziNarudzbenicu(DataGridView dataGridView1)
        {
            try
            {
                narudzbenica = dataGridView1.CurrentRow.DataBoundItem as Narudzbenica;
                if (narudzbenica.Obradjena)
                {

                }
                narudzbenica = kom.PrikaziNarudzbenicu(narudzbenica);
                if (narudzbenica == null)
                {
                    MessageBox.Show("Sistem ne moze da prikaze odabranu narudzbenicu!");
                    return false;
                }
                else
                {
                    MessageBox.Show("Odabrana narudzbenica je prikazana");
                    return true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Niste odabrali narudzbenicu za prikaz!");
                return false;
            }
        }
        public void PopuniPoljaZaNarudzbenicu(TextBox txtDatum, TextBox txtVrednost, TextBox txtVrednostPDV, ComboBox cmbPlacanje, ComboBox cmbStatus, TextBox txtNarucilac, DataGridView dataGridView1, Panel panelOtpremnica)
        {
            txtDatum.Text = narudzbenica.DatumIzdavanja.ToString("dd.MM.yyyy.");
            txtVrednost.Text = narudzbenica.VrednostBezPDV.ToString();
            txtVrednostPDV.Text = narudzbenica.VrednostSaPDV.ToString();
            txtNarucilac.Text = narudzbenica.Narucilac.ToString();
            cmbStatus.Text = narudzbenica.Status.ToString();
            cmbPlacanje.Text = narudzbenica.Placanje.ToString();
            dataGridView1.DataSource = narudzbenica.ListaStavki;
            if (narudzbenica.Obradjena && ProveriKorisnika())
            {
                panelOtpremnica.Visible = true;
            }
        }
        public bool DodajStavku(TextBox txtKolicina, DataGridView dataGridView2)
        {
            if (narudzbenica.Obradjena)
            {
                MessageBox.Show("Narudzbenica je obradjena, ne moze se dalje menjati");
                return false;
            }
            StavkaNarudzbenice s = new StavkaNarudzbenice();
            s.BrojNarudzbenice = narudzbenica.BrojNarudzbenice;
            s.Rbr = narudzbenica.ListaStavki.Count + 1;
            try
            {
                s.Kolicina = Convert.ToInt32(txtKolicina.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Kolicina nije validna");
                return false;
            }
            s.Proizvod = dataGridView2.CurrentRow.DataBoundItem as Proizvod;
            if (s.Proizvod == null)
            {
                MessageBox.Show("Niste odabrali proizvod");
                return false;
            }
            s.UkupnaCenaBezPDV = s.Kolicina * s.Proizvod.CenaBezPDV;
            s.UkupnaCenaSaPDV = s.Kolicina * s.Proizvod.CenaSaPDV;
            bool dodat = false;
            foreach (StavkaNarudzbenice st in narudzbenica.ListaStavki)
            {
                if (s.Proizvod.ProizvodID == st.Proizvod.ProizvodID)
                {
                    st.Kolicina += s.Kolicina;
                    st.UkupnaCenaBezPDV += s.UkupnaCenaBezPDV;
                    st.UkupnaCenaSaPDV += s.UkupnaCenaSaPDV;
                    dodat = true;
                }
            }
            if (!dodat)
            {
                narudzbenica.ListaStavki.Add(s);
                //MessageBox.Show("Stavka je uspesno dodata");
                txtKolicina.Clear();
            }
            else
            {
                //MessageBox.Show("Promenjena je kolicina za izabrani proizvod");
                txtKolicina.Clear();
            }

            return true;
        }
        public bool ObrisiStavku(DataGridView dataGridView1)
        {
            if (narudzbenica.Obradjena)
            {
                MessageBox.Show("Narudzbenica je obradjena, ne moze se dalje menjati");
                return false;
            }
            try
            {
                StavkaNarudzbenice s = dataGridView1.CurrentRow.DataBoundItem as StavkaNarudzbenice;
                narudzbenica.ListaStavki.Remove(s);
                int broj = 1;
                foreach (StavkaNarudzbenice stavka in narudzbenica.ListaStavki)
                {
                    stavka.Rbr = broj;
                    broj++;
                }
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Niste odabrali stavku za brisanje");
                return false;
            }
        }
        public void KreirajNarudzbenicu(TextBox txtID, DataGridView dataGridView1)
        {
            narudzbenica = kom.KreirajNarudzbenicu();
            if (narudzbenica == null)
            {
                MessageBox.Show("Sistem ne moze da kreira narudzbenicu!");
            }
            else
            {
                MessageBox.Show("Sistem je kreirao narudzbenicu.");
                txtID.Text = narudzbenica.BrojNarudzbenice.ToString();
                dataGridView1.DataSource = narudzbenica.ListaStavki;
            }
        }

        #endregion

    }
}
