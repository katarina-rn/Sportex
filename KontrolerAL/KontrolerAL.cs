using Domen;
using SistemskeOperacije;
using SistemskeOperacije.Brisanje;
using SistemskeOperacije.Citanje;
using SistemskeOperacije.Izmena;
using SistemskeOperacije.Upisivanje;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontrolerAL
{
    public class KontrolerAL
    {
        public static object KreirajProizvod(IDomenskiObjekat odo)
        {
            OpstaSO so = new KreirajProizvod();
            return so.IzvrsiSO(odo);
        }

        public static object KreirajNarudzbenicu(IDomenskiObjekat odo)
        {
            OpstaSO so = new KreirajNarudzbenicu();
            return so.IzvrsiSO(odo);
        }

        public static object KreirajNarucioca(IDomenskiObjekat odo)
        {
            OpstaSO so = new KreirajNarucioca();
            return so.IzvrsiSO(odo);
        }

        public static object ZapamtiNarucioca(IDomenskiObjekat odo)
        {
            OpstaSO so = new ZapamtiNarucioca();
            return so.IzvrsiSO(odo);
        }

        public static object ZapamtiProizvod(IDomenskiObjekat odo)
        {
            OpstaSO so = new ZapamtiProizvod();
            return so.IzvrsiSO(odo);
        }

        public static object ZapamtiNarudzbenicu(IDomenskiObjekat odo)
        {
            OpstaSO so = new ZapamtiNarudzbenicu();
            return so.IzvrsiSO(odo);
        }

        public static object PretraziNarucioce(IDomenskiObjekat odo)
        {
            OpstaSO so = new PretraziNarucioce();
            return so.IzvrsiSO(odo);
        }

        public static object PrikaziNarucioca(IDomenskiObjekat domenskiObjekat)
        {
            OpstaSO so = new PrikaziNarucioca();
            return so.IzvrsiSO(domenskiObjekat);
        }

        public static object PretraziProizvod(IDomenskiObjekat domenskiObjekat)
        {
            OpstaSO so = new PretraziProizvode();
            return so.IzvrsiSO(domenskiObjekat);
        }

        public static object PrikaziProizvod(IDomenskiObjekat domenskiObjekat)
        {
            OpstaSO so = new PrikaziProizvod();
            return so.IzvrsiSO(domenskiObjekat);
        }

        public static object ObrisiProizvod(IDomenskiObjekat domenskiObjekat)
        {
            OpstaSO so = new ObrisiProizvod();
            return so.IzvrsiSO(domenskiObjekat);
        }

        public static object PrikaziNarudzbenicu(IDomenskiObjekat domenskiObjekat)
        {
            OpstaSO so = new PrikaziNarudzbenicu();
            return so.IzvrsiSO(domenskiObjekat);
        }

        public static object ObrisiNarucioca(IDomenskiObjekat domenskiObjekat)
        {
            OpstaSO so = new ObrisiNarucioca();
            return so.IzvrsiSO(domenskiObjekat);
        }

        public static object PretraziNarudzbenice(IDomenskiObjekat domenskiObjekat)
        {
            OpstaSO so = new PretraziNaarudzbenice();
            return so.IzvrsiSO(domenskiObjekat);
        }

        public static object UcitajSveTipove(IDomenskiObjekat domenskiObjekat)
        {
            OpstaSO so = new UcitajSveTipove();
            return so.IzvrsiSO(domenskiObjekat);
        }

        public static object UcitajSveStope(IDomenskiObjekat domenskiObjekat)
        {
            OpstaSO so = new UcitajSveStope();
            return so.IzvrsiSO(domenskiObjekat);
        }

        public static object VratiSveNarudzbenice(IDomenskiObjekat domenskiObjekat)
        {
            OpstaSO so = new VratiSveNarudzbenice();
            return so.IzvrsiSO(domenskiObjekat);
        }
        

        public static object NadjiKorisnika(IDomenskiObjekat domenskiObjekat)
        {
            OpstaSO so = new NadjiKorisnika();
            return so.IzvrsiSO(domenskiObjekat);
        }

        public static object KreirajIzvestaj(IDomenskiObjekat domenskiObjekat)
        {
            OpstaSO so = new VratiZaIzvestaj();
            return so.IzvrsiSO(domenskiObjekat);
        }
    }
}
