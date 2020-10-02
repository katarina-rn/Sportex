using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using BrokerBazePodataka;
namespace SistemskeOperacije.Citanje
{
    public class PretraziNaarudzbenice : OpstaSO
    {
        protected override object Izvrsi(IDomenskiObjekat odo)
        {
            return Broker.Instance().VratiSveZaUslov(odo).OfType<Narudzbenica>().ToList<Narudzbenica>();
        }
    }
}
