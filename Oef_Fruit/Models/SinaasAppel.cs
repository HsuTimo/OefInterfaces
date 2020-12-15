using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef_Fruit.Models
{
    class SinaasAppel:Fruit
    {
        public bool Soort { get; set; }
        public SinaasAppel(string naam, double prijsPerKg, bool soort) : base(naam, prijsPerKg)
        {
            Soort = soort;
        }
        public override string ToString()
        {
            string soortText = "eetappelsien";
            if (!Soort)
            {
                soortText = "persappelsien";
            }
            return $"naam: {Naam} \tprijs: {PrijsPerKg} \tsoort: {Soort}({soortText})";
        }
    }
}
