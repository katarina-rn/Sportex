using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using BrokerBazePodataka;

namespace SistemskeOperacije.Izmena
{
    public class ZapamtiProizvod : OpstaSO
    {
        protected override object Izvrsi(IDomenskiObjekat odo)
        {
            return Broker.Instance().Izmeni(odo);
        }
    }
}
