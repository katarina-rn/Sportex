using BrokerBazePodataka;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Brisanje
{
    public class ObrisiNarucioca : OpstaSO
    {
        protected override object Izvrsi(IDomenskiObjekat odo)
        {
            Narucilac n = odo as Narucilac;
            Korisnik k = new Korisnik();
            k.KorisnikID = n.KorisnikID;
            Narudzbenica nr = new Narudzbenica();
            nr.Narucilac = n;
            List<Narudzbenica> lista = Broker.Instance().VratiSveZaUslov(nr).OfType<Narudzbenica>().ToList<Narudzbenica>();
            foreach (Narudzbenica nar in lista)
            {
                Broker.Instance().Obrisi(nar);
            }
            Broker.Instance().Obrisi(n);
            return Broker.Instance().Obrisi(k);
        }
    }
}
