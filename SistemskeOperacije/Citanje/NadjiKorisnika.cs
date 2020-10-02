using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Citanje
{
    public class NadjiKorisnika : OpstaSO
    {
        protected override object Izvrsi(IDomenskiObjekat odo)
        {
            Korisnik k = odo as Korisnik;
            Radnik r = new Radnik();
            r.KorisnickoIme = k.KorisnickoIme;
            r.Lozinka = k.Lozinka;
            Narucilac n = BrokerBazePodataka.Broker.Instance().VratiZaUslov(odo) as Narucilac;
            if (n == null)
            {
                return BrokerBazePodataka.Broker.Instance().VratiZaUslov(r) as Radnik;
            }
            return n;
        }
    }
}
