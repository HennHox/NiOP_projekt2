using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiOP_projekt2
{
    public class UpravljanjeKorisnicima
    {
        private List<Korisnik> korisnici = new List<Korisnik>();

        public void DodajKorisnika(Korisnik korisnik)
        {
            korisnici.Add(korisnik);
            Console.WriteLine("Korisnik uspjesno dodan.");
        }

        public bool ObrisiKorisnika(int id)
        {
            var korisnik = korisnici.FirstOrDefault(k => k.ID == id);
            if (korisnik != null)
            {
                korisnici.Remove(korisnik);
                Console.WriteLine("Korisnik uspjesno obrisan.");
                return true;
            }
            Console.WriteLine("Korisnik s navedenim ID-om nije pronađen.");
            return false;
   
        }

        public List<Korisnik> DohvatiSveKorisnike()
        { return korisnici; }
    }
}
