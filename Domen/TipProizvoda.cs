using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class TipProizvoda :IDomenskiObjekat
    {
        public override string ToString()
        {
            return nazivTipa;
        }

        int tipID;
        string nazivTipa;

        public int TipID { get => tipID; set => tipID = value; }
        public string NazivTipa { get => nazivTipa; set => nazivTipa = value; }

        public string Table => "TipProizvoda";

        public string InsertValues => null;

        public string UpdateValues => null;

        public string Join => $"";

        public string SearchWhere => null;

        public string SearchId => null;

        public string ColumnId => null;

        public string SearchID => null;

        public string Select => null;

        public string GroupBy => null;

        public string OrderBy => $"";

        public IDomenskiObjekat napuni(DataRow red)
        {
            TipProizvoda t = new TipProizvoda();
            t.TipID = Convert.ToInt32(red[0]);
            t.NazivTipa = red[1].ToString();
            return t;
        }
    }
}
