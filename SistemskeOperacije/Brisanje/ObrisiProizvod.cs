using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using BrokerBazePodataka;

namespace SistemskeOperacije.Brisanje
{
    public class ObrisiProizvod : OpstaSO
    {
        protected override object Izvrsi(IDomenskiObjekat odo)
        {
            Proizvod p = odo as Proizvod;
            List<StavkaNarudzbenice> lista = Broker.Instance().VratiSve(new StavkaNarudzbenice()).OfType<StavkaNarudzbenice>().ToList<StavkaNarudzbenice>();
            foreach(StavkaNarudzbenice s in lista)
            {
                if (s.Proizvod.ProizvodID == p.ProizvodID)
                    return null;
            }
            return Broker.Instance().Obrisi(odo);
        }
    }
}
