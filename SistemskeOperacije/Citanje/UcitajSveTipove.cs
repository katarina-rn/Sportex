using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrokerBazePodataka;
using Domen;

namespace SistemskeOperacije.Citanje
{
    public class UcitajSveTipove : OpstaSO
    {
        protected override object Izvrsi(IDomenskiObjekat odo)
        {
            return Broker.Instance().VratiSve(odo).OfType<TipProizvoda>().ToList<TipProizvoda>();
        }
    }
}
