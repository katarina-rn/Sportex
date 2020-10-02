using BrokerBazePodataka;
using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije.Citanje
{
    public class VratiSveNarudzbenice : OpstaSO
    {
        protected override object Izvrsi(IDomenskiObjekat odo)
        {
            List<Narudzbenica> lista = Broker.Instance().VratiSve(odo).OfType<Narudzbenica>().ToList<Narudzbenica>();
            StavkaNarudzbenice s = new StavkaNarudzbenice();
            foreach (Narudzbenica n in lista)
            {
                s.BrojNarudzbenice = n.BrojNarudzbenice;
                n.ListaStavki = new BindingList<StavkaNarudzbenice>(Broker.Instance().VratiSveZaUslov(s).OfType<StavkaNarudzbenice>().ToList<StavkaNarudzbenice>());
            }
            return lista;
        }
    }
}
