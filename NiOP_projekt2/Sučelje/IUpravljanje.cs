using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiOP_projekt2
{
    public interface IUpravljanje
    {
        void DodajKorisnika(Korisnik korisnik);
        bool ObrisiKorisnika(int id);
        List<Korisnik> DohvatiSveKorisnike();
    }
}
