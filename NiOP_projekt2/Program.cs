using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiOP_projekt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UpravljanjeKorisnicima upravljanje = new UpravljanjeKorisnicima();
            bool izlaz = false;

            while (!izlaz)
            {
                Console.WriteLine("\nOdaberite opciju:");
                Console.WriteLine("1 - Dodaj korisnika");
                Console.WriteLine("2 - Obrisi korisnika");
                Console.WriteLine("3 - Ispis svih korisnika");
                Console.WriteLine("0 - Izlaz");
                Console.Write("Vaš izbor: ");

                string izbor = Console.ReadLine();
                switch (izbor)
                {
                    case "1":
                        DodajNovogKorisnika(upravljanje);
                        break;
                    case "2":
                        ObrisiPostojecegKorisnika(upravljanje);
                        break;
                    case "3":
                        IspisiSveKorisnike(upravljanje);
                        break;
                    case "0":
                        izlaz = true;
                        Console.WriteLine("Izlaz iz programa...");
                        break;
                    default:
                        Console.WriteLine("Nepoznata opcija, pokušajte ponovno.");
                        break;
                }
            }
        }

        static void DodajNovogKorisnika(UpravljanjeKorisnicima upravljanje)
        {
            Console.Write("Unesite ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Unesite ime: ");
            string ime = Console.ReadLine();
            Console.Write("Unesite prezime: ");
            string prezime = Console.ReadLine();
            Console.Write("Unesite kontakt: ");
            string kontakt = Console.ReadLine();

            Korisnik noviKorisnik = new Korisnik(id, ime, prezime, kontakt);
            upravljanje.DodajKorisnika(noviKorisnik);
        }

        static void ObrisiPostojecegKorisnika(UpravljanjeKorisnicima upravljanje)
        {
            Console.Write("Unesite ID korisnika za brisanje: ");
            int id = int.Parse(Console.ReadLine());
            upravljanje.ObrisiKorisnika(id);
        }

        static void IspisiSveKorisnike(UpravljanjeKorisnicima upravljanje)
        {
            var korisnici = upravljanje.DohvatiSveKorisnike();
            if (korisnici.Count > 0)
            {
                Console.WriteLine("\nPopis korisnika:");
                foreach (var korisnik in korisnici)
                {
                    Console.WriteLine(korisnik);
                }
            }
            else
            {
                Console.WriteLine("Popis korisnika je prazan.");
            }
        }
    }
}
