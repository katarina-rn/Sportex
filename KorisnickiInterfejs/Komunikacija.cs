using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;

namespace Klijent
{
    public class Komunikacija
    {
        TcpClient klijent;
        BinaryFormatter formater;
        NetworkStream tok;

        public bool PoveziSeNaServer()
        {
            try
            {
                klijent = new TcpClient("localhost", 20000);
                tok = klijent.GetStream();
                formater = new BinaryFormatter();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Kraj()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.Kraj;
            formater.Serialize(tok, transfer);
        }

        public Korisnik NadjiKorisnika(Korisnik k)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.NadjiKorisnika;
            transfer.TransferObjekat = k;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat as Korisnik;
        }

        public Proizvod KreirajProizvod()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.KreirajProizvod;
            transfer.TransferObjekat = new Proizvod();
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat as Proizvod;
        }

        public Object ZapamtiProizvod(Proizvod p)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ZapamtiProizvod;
            transfer.TransferObjekat = p;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public Object ObrisiProizvod(Proizvod p)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ObrisiProizvod;
            transfer.TransferObjekat = p;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public List<Proizvod> PretraziProizvode(Proizvod p)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PretraziProizvode;
            transfer.TransferObjekat = p;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat as List<Proizvod>;
        }

        public Proizvod PrikaziProizvod(Proizvod p)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PrikaziProizvod;
            transfer.TransferObjekat = p;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat as Proizvod;
        }

        public List<Narudzbenica> VratiSveNarudzbenice()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.VratiSveNarudzbenice;
            transfer.TransferObjekat = new Narudzbenica();
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat as List<Narudzbenica>;
        }

        public Narucilac KreirajNarucioca()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.KreirajNarucioca;
            transfer.TransferObjekat = new Narucilac();
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat as Narucilac;
        }

        public Object ZapamtiNarucioca(Narucilac n)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ZapamtiNarucioca;
            transfer.TransferObjekat = n;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public List<Narucilac> PretraziNarucioce(Narucilac n)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PretraziNarucioce;
            transfer.TransferObjekat = n;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat as List<Narucilac>;
        }

        public Narucilac PrikaziNarucioca(Narucilac n)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PrikaziNarucioca;
            transfer.TransferObjekat = n;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat as Narucilac;
        }

        public Narudzbenica KreirajNarudzbenicu()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.KreirajNarudzbenicu;
            transfer.TransferObjekat = new Narudzbenica();
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat as Narudzbenica;
        }

        public Object ZapamtiNarudzbenicu(Narudzbenica n)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ZapamtiNarudzbenicu;
            transfer.TransferObjekat = n;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }

        public List<Narudzbenica> PretraziNarudzbenice(Narudzbenica n)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PretraziNarudzbenice;
            transfer.TransferObjekat = n;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat as List<Narudzbenica>;
        }

        public Narudzbenica PrikaziNarudzbenicu(Narudzbenica n)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.PrikaziNarudzbenicu;
            transfer.TransferObjekat = n;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat as Narudzbenica;
        }

        public List<TipProizvoda> UcitajSveTipove()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.UcitajSveTipove;
            transfer.TransferObjekat = new TipProizvoda();
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat as List<TipProizvoda>;
        }

        public List<PoreskaStopa> UcitajSveStope()
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.UcitajSveStope;
            transfer.TransferObjekat = new PoreskaStopa();
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat as List<PoreskaStopa>;
        }

        public List<ProizvodIzvestaj> KreirajIzvestaj(ProizvodIzvestaj pi)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.KreirajIzvestaj;
            transfer.TransferObjekat = pi;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat as List<ProizvodIzvestaj>;
        }

        public object ObrisiNarucioca(Narucilac n)
        {
            TransferKlasa transfer = new TransferKlasa();
            transfer.Operacija = Operacije.ObrisiNarucioca;
            transfer.TransferObjekat = n;
            formater.Serialize(tok, transfer);

            transfer = formater.Deserialize(tok) as TransferKlasa;
            return transfer.Rezultat;
        }
    }
}
