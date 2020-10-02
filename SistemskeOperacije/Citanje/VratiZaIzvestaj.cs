using BrokerBazePodataka;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Citanje
{
    public class VratiZaIzvestaj : OpstaSO
    {
        protected override object Izvrsi(IDomenskiObjekat odo)
        {
           return Broker.Instance().VratiGrupisane(odo).OfType<ProizvodIzvestaj>().ToList<ProizvodIzvestaj>();
        }
    }
}
