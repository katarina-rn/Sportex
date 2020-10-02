using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Korisnik : IDomenskiObjekat
    {
        protected int korisnikID;
        protected string korisnickoIme;
        protected string lozinka;

        [Browsable(false)]
        public int KorisnikID { get => korisnikID; set => korisnikID = value; }
        [Browsable(false)]
        public string Table => $"Korisnik";
        [Browsable(false)]
        public string InsertValues => $" (KorisnikID) values ({KorisnikID})";
        [Browsable(false)]
        public string UpdateValues => $"KorisnickoIme = '{KorisnickoIme}', Lozinka='{Lozinka}'";
        [Browsable(false)]
        public string Join => $" k join Narucilac n on n.KorisnikID = k.KorisnikID";
        [Browsable(false)]
        public string SearchWhere => $"k.KorisnickoIme = '{KorisnickoIme}' and k.Lozinka = '{Lozinka}'";
        [Browsable(false)]
        public string SearchId => $"KorisnikID = {KorisnikID}";
        [Browsable(false)]
        public string ColumnId => $"KorisnikID";
        [Browsable(false)]
        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }
        [Browsable(false)]
        public string Lozinka { get => lozinka; set => lozinka = value; }
        [Browsable(false)]
        public string SearchID => $"n.KorisnikID = {KorisnikID}";
        [Browsable(false)]
        public string Select => null;
        [Browsable(false)]
        public string GroupBy => null;
        [Browsable(false)]
        public string OrderBy => $"";

        [Browsable(false)]
        public IDomenskiObjekat napuni(DataRow red)
        {
            Narucilac n = new Narucilac
            {
                KorisnikID = Convert.ToInt32(red[0]),
                KorisnickoIme = red[1].ToString(),
                Lozinka = red[2].ToString(),
                Naziv = red[4].ToString(),
                Email = red[5].ToString(),
                Adresa = red[6].ToString(),
                Telefon = red[7].ToString(),
                Pib = red[8].ToString(),
            };
            return n;
        }
    }
}
