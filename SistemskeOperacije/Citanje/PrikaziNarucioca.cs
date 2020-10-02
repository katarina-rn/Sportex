using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using BrokerBazePodataka;

namespace SistemskeOperacije.Citanje
{
    public class PrikaziNarucioca : OpstaSO
    {
        protected override object Izvrsi(IDomenskiObjekat odo)
        {
            Korisnik k = new Korisnik();
            Narucilac n = odo as Narucilac;
            k.KorisnikID = n.KorisnikID;
            return Broker.Instance().VratiZaId(k) as Narucilac;
        }
    }
}
