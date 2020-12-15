using Oef_Voorwerp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef_Voorwerp.Models
{
    class Leesboek:Boek,IVoorwerp
    {
        public string Onderwerp { get; set; }
        public double Winst { get; set; }

        public Leesboek() 
        {

        }
        public Leesboek(string titel, string auteur, string genre, decimal aankoopprijs, string onderwerp):base(titel, auteur, genre, aankoopprijs)
        {
            Onderwerp = onderwerp;
            Winst = WinstBerekenen();
        }

        public override void GegevensTonen()
        {
            Console.WriteLine(ToString());
        }

        public override double WinstBerekenen()
        {
            Winst = (double)(Aankoopprijs * 1.5m);
            return Winst;
        }
        public override string ToString()
        {
            return $"Titel: {Titel} Auteur: {Auteur} Eigenaar: {Eigenaar} Prijs: {Aankoopprijs} Genre: {Genre} Onderwerp: {Onderwerp} Winst: {Winst}";
        }

    }
}
