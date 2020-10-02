using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public enum Valuta { RSD}
    [Serializable]
    public class Proizvod : IDomenskiObjekat
    {
        public override string ToString()
        {
            return nazivProizvoda;
        }

        public IDomenskiObjekat napuni(DataRow red)
        {
            Proizvod p = new Proizvod
            {
                ProizvodID = Convert.ToInt32(red[0]),
                NazivProizvoda = red[1].ToString(),
                CenaBezPDV = Convert.ToDouble(red[2]),
                CenaSaPDV = Convert.ToDouble(red[3]),
                Valuta = (Valuta)Enum.Parse(typeof(Valuta), red[4].ToString()),
                Tip = new TipProizvoda
                {
                    TipID = Convert.ToInt32(red[5]),
                    NazivTipa = red[8].ToString()
                },
                PoreskaStopa = new PoreskaStopa
                {
                    StopaID = Convert.ToInt32(red[6]),
                    Naziv = red[10].ToString(),
                    Stopa = Convert.ToDouble(red[11])
                }
            };
            return p;
        }

        int proizvodID;
        string nazivProizvoda;
        double cenaBezPDV;
        double cenaSaPDV;
        Valuta valuta;
        TipProizvoda tip;
        PoreskaStopa poreskaStopa;
        [Browsable(false)]
        public int ProizvodID { get => proizvodID; set => proizvodID = value; }
        [DisplayName("Naziv proizvoda")]
        public string NazivProizvoda { get => nazivProizvoda; set => nazivProizvoda = value; }
        [DisplayName("Cena bez PDV-a")]
        public double CenaBezPDV { get => cenaBezPDV; set => cenaBezPDV = value; }
        [DisplayName("Cena sa PDV-om")]
        public double CenaSaPDV { get => cenaSaPDV; set => cenaSaPDV = value; }
        public Valuta Valuta { get => valuta; set => valuta = value; }
        [DisplayName("Tip proizvoda")]
        public TipProizvoda Tip { get => tip; set => tip = value; }
        [DisplayName("Poreska stopa")]
        public PoreskaStopa PoreskaStopa { get => poreskaStopa; set => poreskaStopa = value; }
        [Browsable(false)]
        public string Table => "Proizvod ";
        [Browsable(false)]
        public string InsertValues => $" (p.IDProizvoda) values({ProizvodID})";
        [Browsable(false)]
        public string UpdateValues => $"NazivProizvoda = '{NazivProizvoda}', CenaBezPDV={CenaBezPDV.ToString("00.00", CultureInfo.InvariantCulture)}," +
            $"CenaSaPDV={(String.Format(CultureInfo.InvariantCulture,"{0:00.00}", CenaSaPDV))}, Valuta='{Valuta}', TipID={Tip.TipID}, StopaID ={PoreskaStopa.StopaID}";
        [Browsable(false)]
        public string Join => $"p join TipProizvoda tip on (p.TipID=tip.IDTipa) join PoreskaStopa stopa on (p.StopaID = stopa.ID)";
        [Browsable(false)]
        public string SearchWhere => $"NazivProizvoda like '%{NazivProizvoda}%'";
        [Browsable(false)]
        public string SearchId => $"IDProizvoda = {ProizvodID}";
        [Browsable(false)]
        public string ColumnId => "IDProizvoda";
        [Browsable(false)]
        public string SearchID => $"IDProizvoda = {ProizvodID}";
        [Browsable(false)]
        public string Select => null;
        [Browsable(false)]
        public string GroupBy => null;
        [Browsable(false)]
        public string OrderBy => $" order by p.NazivProizvoda";
    }
}
