using Oef_Voorwerp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef_Voorwerp.Models
{
    class Woordenboek:Boek,IVoorwerp
    {
        public string Taal { get; set; }
        public double Winst { get; set; }
        public Woordenboek()
        {

        }
        public Woordenboek(string titel, string auteur, string genre, decimal aankoopprijs, string taal) : base(titel, auteur, genre, aankoopprijs)
        {
            Taal = taal;
            Winst = WinstBerekenen();
        }

        public override void GegevensTonen()
        {
            Console.WriteLine(ToString());
        }

        public override double WinstBerekenen()
        {
            Winst = (double)(Aankoopprijs * 1.75m);
            return Winst;
        }

        public override string ToString()
        {
            return $"Titel:{Titel} Auteur:{Auteur} Eigenaar: {Eigenaar} Prijs: {Aankoopprijs} Genre: {Genre} Taal: {Taal} Winst: {Winst}";
        }
    }
}
