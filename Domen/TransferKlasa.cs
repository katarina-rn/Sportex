using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public enum Operacije 
    {
        Kraj = 1,
        PretraziNarucioce = 2,
        PrikaziNarucioca = 3,
        KreirajNarucioca = 4,
        ZapamtiNarucioca = 5,
        PretraziProizvode = 6,
        PrikaziProizvod = 7,
        KreirajProizvod = 8,
        ZapamtiProizvod = 9,
        ObrisiProizvod = 10,
        PretraziNarudzbenice = 11,
        PrikaziNarudzbenicu = 12,
        KreirajNarudzbenicu = 13,
        ZapamtiNarudzbenicu = 14,
        UcitajSveTipove = 15,
        UcitajSveStope = 17,
        NadjiKorisnika = 18,
        VratiSveNarudzbenice = 19,
        ObrisiNarucioca = 20,
        KreirajIzvestaj = 21
    }
    [Serializable]
    public class TransferKlasa
    {
        Operacije operacija;
        Object transferObjekat;
        Object rezultat;
        public Operacije Operacija { get => operacija; set => operacija = value; }
        public object TransferObjekat { get => transferObjekat; set => transferObjekat = value; }
        public object Rezultat { get => rezultat; set => rezultat = value; }
    }
}
