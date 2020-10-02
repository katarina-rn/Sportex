using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using BrokerBazePodataka;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;
using SistemskeOperacije.Citanje;
using SistemskeOperacije.Izmena;
using SistemskeOperacije.Upisivanje;
using SistemskeOperacije.Brisanje;

namespace Server
{
    public class Obrada
    {
        BinaryFormatter formater;
        NetworkStream tok;

        public Obrada(NetworkStream tok)
        {
            this.tok = tok;
            formater = new BinaryFormatter();

            ThreadStart ts = ObradiKlijenta;
            Thread nit = new Thread(ts);
            nit.Start();
        }

        public void ObradiKlijenta()
        {
            try
            {
                int operacija = 0;
                while (operacija != (int)Operacije.Kraj)
                {
                    TransferKlasa transfer = formater.Deserialize(tok) as TransferKlasa;
                    Console.WriteLine(operacija);
                    switch (transfer.Operacija)
                    {
                        case Operacije.PretraziNarucioce:
                            transfer.Rezultat = KontrolerAL.KontrolerAL.PretraziNarucioce(transfer.TransferObjekat as IDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.PrikaziNarucioca:
                            transfer.Rezultat = KontrolerAL.KontrolerAL.PrikaziNarucioca(transfer.TransferObjekat as IDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.KreirajNarucioca:
                            transfer.Rezultat = KontrolerAL.KontrolerAL.KreirajNarucioca(transfer.TransferObjekat as IDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.ZapamtiNarucioca:
                            transfer.Rezultat = KontrolerAL.KontrolerAL.ZapamtiNarucioca(transfer.TransferObjekat as IDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.ObrisiNarucioca:
                            transfer.Rezultat = KontrolerAL.KontrolerAL.ObrisiNarucioca(transfer.TransferObjekat as IDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.PretraziProizvode:
                            transfer.Rezultat = KontrolerAL.KontrolerAL.PretraziProizvod(transfer.TransferObjekat as IDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.PrikaziProizvod:
                            transfer.Rezultat = KontrolerAL.KontrolerAL.PrikaziProizvod(transfer.TransferObjekat as IDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.KreirajProizvod:
                            transfer.Rezultat = KontrolerAL.KontrolerAL.KreirajProizvod(transfer.TransferObjekat as IDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.ZapamtiProizvod:
                            transfer.Rezultat = KontrolerAL.KontrolerAL.ZapamtiProizvod(transfer.TransferObjekat as IDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.ObrisiProizvod:
                            transfer.Rezultat = KontrolerAL.KontrolerAL.ObrisiProizvod(transfer.TransferObjekat as IDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.PretraziNarudzbenice:
                            transfer.Rezultat = KontrolerAL.KontrolerAL.PretraziNarudzbenice(transfer.TransferObjekat as IDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.PrikaziNarudzbenicu:
                            transfer.Rezultat = KontrolerAL.KontrolerAL.PrikaziNarudzbenicu(transfer.TransferObjekat as IDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.KreirajNarudzbenicu:
                            transfer.Rezultat = KontrolerAL.KontrolerAL.KreirajNarudzbenicu(transfer.TransferObjekat as IDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.ZapamtiNarudzbenicu:
                            transfer.Rezultat = KontrolerAL.KontrolerAL.ZapamtiNarudzbenicu(transfer.TransferObjekat as IDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.UcitajSveStope:
                            transfer.Rezultat = KontrolerAL.KontrolerAL.UcitajSveStope(transfer.TransferObjekat as IDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.UcitajSveTipove:
                            transfer.Rezultat = KontrolerAL.KontrolerAL.UcitajSveTipove(transfer.TransferObjekat as IDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.VratiSveNarudzbenice:
                            transfer.Rezultat = KontrolerAL.KontrolerAL.VratiSveNarudzbenice(transfer.TransferObjekat as IDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.NadjiKorisnika:
                            transfer.Rezultat = KontrolerAL.KontrolerAL.NadjiKorisnika(transfer.TransferObjekat as IDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.KreirajIzvestaj:
                            transfer.Rezultat = KontrolerAL.KontrolerAL.KreirajIzvestaj(transfer.TransferObjekat as IDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.Kraj:
                            Server.listaTokova.Remove(tok);
                            operacija = 1;
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
