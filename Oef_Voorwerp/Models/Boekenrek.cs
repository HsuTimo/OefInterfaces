using Oef_Voorwerp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef_Voorwerp.Models
{
    public class Boekenrek:IVoorwerp
    {
        public int Hoogte { get; set; }
        public int Breedte { get; set; }
        public decimal Aankoopprijs { get; set; }
        public double Winst { get; set; }
        public Boekenrek()
        {
        }

        public Boekenrek(int hoogte, int breedte, decimal aankoopprijs)
        {
            Hoogte = hoogte;
            Breedte = breedte;
            Aankoopprijs = aankoopprijs;
            Winst = WinstBerekenen();
        }

        public void GegevensTonen()
        {
            Console.WriteLine(ToString());
        }

        public double WinstBerekenen()
        {
            Winst = (double)(Aankoopprijs * 2m);
            return Winst;
        }

        public override string ToString()
        {
            return $"H:{Hoogte} B:{Breedte} Prijs:{Aankoopprijs} Winst:{Winst}";
        }
    }
}
