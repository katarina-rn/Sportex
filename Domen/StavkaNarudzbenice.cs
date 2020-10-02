using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class StavkaNarudzbenice : IDomenskiObjekat
    {
        int brojNarudzbenice;
        int rbr;
        int kolicina;
        double ukupnaCenaBezPDV;
        double ukupnaCenaSaPDV;
        Proizvod proizvod;

        [Browsable(false)]
        public int BrojNarudzbenice { get => brojNarudzbenice; set => brojNarudzbenice = value; }
        public int Rbr { get => rbr; set => rbr = value; }
        public Proizvod Proizvod { get => proizvod; set => proizvod = value; }
        public int Kolicina { get => kolicina; set => kolicina = value; }
        [DisplayName("Cena bez PDV-a")]
        public double UkupnaCenaBezPDV { get => ukupnaCenaBezPDV; set => ukupnaCenaBezPDV = value; }
        [DisplayName("Cena sa PDV-om")]
        public double UkupnaCenaSaPDV { get => ukupnaCenaSaPDV; set => ukupnaCenaSaPDV = value; }
        
        [Browsable(false)]
        public string Table => "StavkaNarudzbenice ";
        [Browsable(false)]
        public string InsertValues => $" values ({BrojNarudzbenice}, {Rbr}, {Kolicina}, {UkupnaCenaBezPDV.ToString("00.00", CultureInfo.InvariantCulture)}, {ukupnaCenaSaPDV.ToString("00.00", CultureInfo.InvariantCulture)}, {Proizvod.ProizvodID})";
        [Browsable(false)]
        public string UpdateValues => $"Kolicina = {Kolicina}, UkupnaCenaBezPDV={UkupnaCenaBezPDV}, UkupnaCenaSaPDV={UkupnaCenaSaPDV}, IDProizvoda={Proizvod.ProizvodID}";
        [Browsable(false)]
        public string Join => $" s join Proizvod p on s.IDProizvoda=p.IDProizvoda";
        [Browsable(false)]
        public string SearchWhere => "BrojNarudzbenice = " + brojNarudzbenice;
        [Browsable(false)]
        public string SearchId => "BrojNarudzbenice = "+brojNarudzbenice;
        [Browsable(false)]
        public string ColumnId => null;
        [Browsable(false)]
        public string SearchID => "BrojNarudzbenice = " + brojNarudzbenice;
        [Browsable(false)]
        public string Select => null;
        [Browsable(false)]
        public string GroupBy => null;
        [Browsable(false)]
        public string OrderBy => $"";

        [Browsable(false)]
        public IDomenskiObjekat napuni(DataRow red)
        {
            StavkaNarudzbenice s = new StavkaNarudzbenice
            {
                BrojNarudzbenice = Convert.ToInt32(red[0]),
                Rbr = Convert.ToInt32(red[1]),
                Kolicina = Convert.ToInt32(red[2]),
                UkupnaCenaBezPDV = Convert.ToDouble(red[3]),
                UkupnaCenaSaPDV = Convert.ToDouble(red[4]),
                Proizvod = new Proizvod
                {
                    ProizvodID = Convert.ToInt32(red[5]),
                    NazivProizvoda = red[7].ToString(),
                    CenaBezPDV = Convert.ToDouble(red[8]),
                    CenaSaPDV = Convert.ToDouble(red[9]),
                    Valuta = (Valuta)Enum.Parse(typeof(Valuta), red[10].ToString()),
                    Tip = new TipProizvoda 
                    { 
                        TipID =  Convert.ToInt32(red[11]),
                    },
                    PoreskaStopa = new PoreskaStopa
                    {
                        StopaID = Convert.ToInt32(red[12]),
                    }
                }
            };
            return s;
        }
    }
}
