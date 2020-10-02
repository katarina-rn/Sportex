using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Radnik : Korisnik, IDomenskiObjekat
    {
        public override string ToString()
        {
            return ime+" "+prezime;
        }

        public new IDomenskiObjekat napuni(DataRow red)
        {
            Radnik r = new Radnik();
            r.KorisnikID = Convert.ToInt32(red[0]);
            r.KorisnickoIme = red[1].ToString();
            r.Lozinka = red[2].ToString();
            r.Ime = red[4].ToString();
            r.Prezime = red[5].ToString();

            return r;
        }

        
        string ime;
        string prezime;

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }

        

        public new string InsertValues =>  null;

        public new string UpdateValues =>  null;

        public new string Join =>  $" k join Radnik r on k.KorisnikID = r.KorisnikID";

        public new string SearchId
        {
            get
            {
                return "KorisnikID ="+KorisnikID;
            }
        }

        public new string ColumnId 
        {
            get
            {
                return "KorisnikID";
            }
        }

    }
}
