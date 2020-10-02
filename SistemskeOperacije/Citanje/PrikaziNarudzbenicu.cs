using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using BrokerBazePodataka;

namespace SistemskeOperacije.Citanje
{
    public class PrikaziNarudzbenicu : OpstaSO
    {
        protected override object Izvrsi(IDomenskiObjekat odo)
        {
            Narudzbenica n = odo as Narudzbenica;
            StavkaNarudzbenice s = new StavkaNarudzbenice();
            s.BrojNarudzbenice = n.BrojNarudzbenice;
            List<StavkaNarudzbenice> lista = 
                Broker.Instance().VratiSveZaUslov(s).OfType<StavkaNarudzbenice>().ToList<StavkaNarudzbenice>();
            foreach (StavkaNarudzbenice stavka in lista)
            {
                n.ListaStavki.Add(stavka);
            }
            return n;
        }
    }
}
