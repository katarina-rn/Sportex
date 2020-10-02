using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using BrokerBazePodataka;

namespace SistemskeOperacije.Izmena
{
    public class ZapamtiNarucioca : OpstaSO
    {
        protected override object Izvrsi(IDomenskiObjekat odo)
        {
            Korisnik k = new Korisnik();
            Narucilac n = odo as Narucilac;
            k.KorisnikID = n.KorisnikID;
            k.KorisnickoIme = n.KorisnickoIme;
            k.Lozinka = n.Lozinka;
            List<Korisnik> lista = BrokerBazePodataka.Broker.Instance().VratiSve(k).OfType<Korisnik>().ToList<Korisnik>();
            lista.AddRange(BrokerBazePodataka.Broker.Instance().VratiSve(new Radnik()).OfType<Korisnik>().ToList<Korisnik>());
            foreach (Korisnik kor in lista)
            {
                if (kor.KorisnickoIme == k.KorisnickoIme && kor.KorisnikID != k.KorisnikID)
                {
                    System.Windows.Forms.MessageBox.Show("Postoji korisnik sa istim korisnickim imenom!");
                    return null;
                }
            }
            Broker.Instance().Izmeni(k);
            return Broker.Instance().Izmeni(n);

        }
    }
}
