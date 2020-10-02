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
    public enum StatusPlacanja { Neplacena, Placena}
    public enum StatusNarudzbine { Primljena, Odbijena, Isporucena}
    [Serializable]
    public class Narudzbenica : IDomenskiObjekat
    {
        int brojNarudzbenice;
        DateTime datumIzdavanja;
        StatusPlacanja placanje;
        double vrednostBezPDV;
        double vrednostSaPDV;
        StatusNarudzbine status;
        bool obradjena;
        DateTime datumIsporuke;
        Radnik radnik;
        Narucilac narucilac;
        BindingList<StavkaNarudzbenice> listaStavki;
        Korisnik ulogovan;
        [Browsable(false)]
        public int BrojNarudzbenice { get => brojNarudzbenice; set => brojNarudzbenice = value; }
        public Narucilac Narucilac { get => narucilac; set => narucilac = value; }
        [DisplayName("Datum izdavanja")]
        public DateTime DatumIzdavanja { get => datumIzdavanja; set => datumIzdavanja = value; }
        [DisplayName("Status placanja")]
        public StatusPlacanja Placanje { get => placanje; set => placanje = value; }
        [DisplayName("Vrednost bez PDV-a")]
        public double VrednostBezPDV { get => vrednostBezPDV; set => vrednostBezPDV = value; }
        [DisplayName("Vrednost sa PDV-om")]
        public double VrednostSaPDV { get => vrednostSaPDV; set => vrednostSaPDV = value; }
        [DisplayName("Status narudzbine")]
        public StatusNarudzbine Status { get => status; set => status = value; }
        public bool Obradjena { get => obradjena; set => obradjena = value; }
        [DisplayName("Datum isporuke")]
        public DateTime DatumIsporuke { get => datumIsporuke; set => datumIsporuke = value; }
        public Radnik Radnik { get => radnik; set => radnik = value; }
        [Browsable(false)]
        public Korisnik Ulogovan { get => ulogovan; set => ulogovan = value; }
        [Browsable(false)]
        public BindingList<StavkaNarudzbenice> ListaStavki { get => listaStavki; set => listaStavki = value; }
        public Narudzbenica()
        {
            listaStavki = new BindingList<StavkaNarudzbenice>();
        }

        [Browsable(false)]
        public string Table => "Narudzbenica ";
        [Browsable(false)]
        public string InsertValues => $"(n.BrojNarudzbenice) values({BrojNarudzbenice})";
        [Browsable(false)]
        public string UpdateValues => $" DatumIzdavanja = '{DatumIzdavanja.ToString("yyyy-MM-dd")}', StatusPlacanja = '{Placanje.ToString()}', VrednostBezPDV = {VrednostBezPDV.ToString("00.00", CultureInfo.InvariantCulture)}, VrednostSaPDV = {VrednostSaPDV.ToString("00.00", CultureInfo.InvariantCulture)}, StatusNarudzbine = '{Status.ToString()}', DatumIsporuke = '{DatumIsporuke.ToString("yyyy-MM-dd")}', Obradjena = {Convert.ToInt32(Obradjena)}, IDRadnika = {Radnik.KorisnikID}, IDNarucioca = {Narucilac.KorisnikID}";
        [Browsable(false)]
        public string Join => $" n join Radnik radnik on (n.IDRadnika=radnik.KorisnikID) join Narucilac narucilac on (n.IDNarucioca=narucilac.KorisnikID)";
        [Browsable(false)]
        public string SearchWhere 
        {
            get
            {
                if(Ulogovan == null)
                {
                    return $"narucilac.Naziv like '%{Narucilac.Naziv}%'";
                }
                if (Ulogovan.GetType() == typeof(Radnik))
                    return $"narucilac.Naziv like '%{Narucilac.Naziv}%'";
                else
                    return $"narucilac.Naziv like '%{Narucilac.Naziv}%' and StatusNarudzbine = '{Status.ToString()}'";
            }
        } 
        [Browsable(false)]
        public string SearchId => $"BrojNarudzbenice = {BrojNarudzbenice}";
        [Browsable(false)]
        public string ColumnId => "BrojNarudzbenice";
        [Browsable(false)]
        public string SearchID => $"BrojNarudzbenice = {BrojNarudzbenice}";
        [Browsable(false)]
        public string Select => null;
        [Browsable(false)]
        public string GroupBy => null;
        [Browsable(false)]
        public string OrderBy => $" order by n.DatumIzdavanja desc";

        [Browsable(false)]
        public IDomenskiObjekat napuni(DataRow red)
        {
            Narudzbenica n = new Narudzbenica
            {
                BrojNarudzbenice = Convert.ToInt32(red[0]),
                DatumIzdavanja = Convert.ToDateTime(red[1]),
                Placanje = (StatusPlacanja)Enum.Parse(typeof(StatusPlacanja), red[2].ToString()),
                VrednostBezPDV = Convert.ToDouble(red[3]),
                VrednostSaPDV = Convert.ToDouble(red[4]),
                Status = (StatusNarudzbine)Enum.Parse(typeof(StatusNarudzbine), red[5].ToString()),
                DatumIsporuke = Convert.ToDateTime(red[6]),
                Obradjena = Convert.ToBoolean(red[7]),
                Radnik = new Radnik
                {
                    KorisnikID = Convert.ToInt32(red[8]),
                    Ime = red[11].ToString(),
                    Prezime = red[12].ToString()
                },
                Narucilac = new Narucilac
                {
                    KorisnikID = Convert.ToInt32(red[9]),
                    Naziv = red[14].ToString(),
                    Email = red[15].ToString(),
                    Adresa = red[16].ToString(),
                    Telefon = red[17].ToString(),
                    Pib = red[18].ToString()
                }
            };
            return n;
        }
    }
}
