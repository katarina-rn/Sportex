using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using BrokerBazePodataka;

namespace SistemskeOperacije.Upisivanje
{
    public class KreirajProizvod : OpstaSO
    {
        protected override object Izvrsi(IDomenskiObjekat odo)
        {
            Proizvod p = odo as Proizvod;
            p.ProizvodID = Broker.Instance().VratiSifru(p);
            Broker.Instance().Sacuvaj(p);
            return p;
        }
    }
}
