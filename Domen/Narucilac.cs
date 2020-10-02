using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Narucilac : Korisnik, IDomenskiObjekat
    {
        public override string ToString()
        {
            return naziv;
        }

        public new IDomenskiObjekat napuni(DataRow red)
        {
            Narucilac n = new Narucilac
            {
                KorisnikID = Convert.ToInt32(red[0]),
                Naziv = red[1].ToString(),
                Email = red[2].ToString(),
                Adresa = red[3].ToString(),
                Telefon = red[4].ToString(),
                Pib = red[5].ToString(),
                //KorisnickoIme = red[7].ToString(),
                //Lozinka = red[8].ToString(),
            };
            return n;
        }

        string naziv;
        string adresa;
        string email;
        string telefon;
        string pib;
        
        
        public string Naziv { get => naziv; set => naziv = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        public string Email { get => email; set => email = value; }
        public string Telefon { get => telefon; set => telefon = value; }
        public string Pib { get => pib; set => pib = value; }

        [Browsable(false)]
        public new string Table => "Narucilac ";
        [Browsable(false)]
        public new string InsertValues => $" (KorisnikID) values ({KorisnikID})";
        [Browsable(false)]
        public new string UpdateValues => $"Naziv = '{Naziv}', Email='{Email}'," +
            $" Adresa='{Adresa}', Telefon='{Telefon}', PIB='{Pib}'";
        [Browsable(false)]
        public new string  Join => $"";
        [Browsable(false)]
        public new string SearchWhere => $"Naziv like '%{Naziv}%'";
        [Browsable(false)]
        public new string SearchId => $"KorisnikID = {KorisnikID}";
        [Browsable(false)]
        public new string ColumnId => "KorisnikID";
    }
}
