using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Domen
{
    public interface IDomenskiObjekat
    {
        string Table { get; }
        string InsertValues { get; }
        string UpdateValues { get; }
        string Join { get; }
        string SearchWhere { get; }
        string SearchId { get; }
        string SearchID { get; }
        string ColumnId { get; }
        string Select { get; }
        string GroupBy { get; }
        string OrderBy { get; }

        IDomenskiObjekat napuni(DataRow red);
    }
}
