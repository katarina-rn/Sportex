using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using BrokerBazePodataka;

namespace SistemskeOperacije.Izmena
{
    public class ZapamtiNarudzbenicu : OpstaSO
    {
        protected override object Izvrsi(IDomenskiObjekat odo)
        {
            Broker.Instance().Izmeni(odo);
            Narudzbenica n = odo as Narudzbenica;
            
            StavkaNarudzbenice s = new StavkaNarudzbenice();
            s.BrojNarudzbenice = n.BrojNarudzbenice;
            Broker.Instance().Obrisi(s);
            foreach(StavkaNarudzbenice stavka in n.ListaStavki)
            {
                Broker.Instance().Sacuvaj(stavka);
            }

            return 1;
        }
    }
}
