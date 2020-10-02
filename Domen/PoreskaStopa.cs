using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class PoreskaStopa : IDomenskiObjekat
    {
        public override string ToString()
        {
            return naziv +": "+stopa.ToString()+"%";
        }

        int stopaID;
        string naziv;
        double stopa;

        public int StopaID { get => stopaID; set => stopaID = value; }
        public double Stopa { get => stopa; set => stopa = value; }

        public string Table => "PoreskaStopa";

        public string InsertValues => null;

        public string UpdateValues => null;

        public string Join => $"";

        public string SearchWhere => null;

        public string SearchId => null;

        public string ColumnId => null;

        public string Naziv { get => naziv; set => naziv = value; }

        public string SearchID=> null;

        public string Select => null;

        public string GroupBy => null;

        public string OrderBy => $"";

        public IDomenskiObjekat napuni(DataRow red)
        {
            PoreskaStopa s = new PoreskaStopa();
            s.StopaID = Convert.ToInt32(red[0]);
            s.Naziv = red[1].ToString();
            s.Stopa = Convert.ToDouble(red[2]);
            return s;
        }
    }
}
