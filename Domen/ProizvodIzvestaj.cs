using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class ProizvodIzvestaj : IDomenskiObjekat
    {
        string naziv;
        int kolicina;
        double cena;
        int mesec;
        public string Naziv { get => naziv; set => naziv = value; }
        public int Kolicina { get => kolicina; set => kolicina = value; }
        public double Cena { get => cena; set => cena = value; }
        public int Mesec { get => mesec; set => mesec = value; }

        public string Table => $"Narudzbenica";

        public string InsertValues => null;

        public string UpdateValues => null;

        public string Join => $" n join StavkaNarudzbenice s on n.BrojNarudzbenice = s.BrojNarudzbenice join Proizvod p on s.IDProizvoda=p.IDProizvoda";

        public string SearchWhere => $" n.Obradjena = 1 and DATEPART(month, n.DatumIzdavanja) = " + Mesec + "";

        public string SearchId => null;

        public string SearchID => null;

        public string ColumnId => null;

        public string Select => $"p.NazivProizvoda, sum(s.Kolicina), sum(s.UkupnaCenaSaPDV)";

        public string GroupBy => $" group by p.NazivProizvoda";

        public string OrderBy => $" order by sum(s.UkupnaCenaSaPDV) desc";

        public IDomenskiObjekat napuni(DataRow red)
        {
            ProizvodIzvestaj pi = new ProizvodIzvestaj();
            pi.Naziv = red[0].ToString();
            pi.Kolicina = Convert.ToInt32(red[1]);
            pi.Cena = Convert.ToDouble(red[2]);
            return pi;
        }
    }
}
