using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using BrokerBazePodataka;

namespace SistemskeOperacije.Upisivanje
{
    public class KreirajNarudzbenicu : OpstaSO
    {
        protected override object Izvrsi(IDomenskiObjekat odo)
        {
            Narudzbenica n = odo as Narudzbenica;
            n.BrojNarudzbenice = Broker.Instance().VratiSifru(n);
            Broker.Instance().Sacuvaj(n);
            return n;
        }
    }
}
