using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using BrokerBazePodataka;

namespace SistemskeOperacije.Upisivanje
{
    public class KreirajNarucioca : OpstaSO
    {
        protected override object Izvrsi(IDomenskiObjekat odo)
        {
            Korisnik k = new Korisnik();
            k.KorisnikID = Broker.Instance().VratiSifru(k);
            Broker.Instance().Sacuvaj(k);
            Narucilac n = odo as Narucilac;
            n.KorisnikID = k.KorisnikID;
            Broker.Instance().Sacuvaj(n);
            return n;
        }
    }
}
