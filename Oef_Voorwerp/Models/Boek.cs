using Oef_Voorwerp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef_Voorwerp.Models
{
    public abstract class Boek : IVoorwerp
    {
        public string Titel { get; set; }
        public string Auteur { get; set; }
        public string Genre { get; set; }
        public decimal Aankoopprijs { get; set; }
        public string Eigenaar { get; set; }

        public Boek()
        {
            Eigenaar = "INTEC BRUSSEL";
        }

        public Boek(string titel, string auteur, string genre, decimal aankoopprijs)
        {
            Titel = titel;
            Auteur = auteur;
            Genre = genre;
            Aankoopprijs = aankoopprijs;
            Eigenaar = "INTEC BRUSSEL";
        }

        public abstract void GegevensTonen();
        public abstract double WinstBerekenen();
    }
}
