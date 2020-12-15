using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef_Fruit.Models
{
    class Pompelmoes:Fruit
    {
        public string Kleur { get; set; }
        public Pompelmoes(string naam, double prijsPerKg, string kleur) : base(naam, prijsPerKg)
        {
            Kleur = kleur;
        }
        public override string ToString()
        {
            return $"naam: {Naam} \tprijs: {PrijsPerKg} \tkleur: {Kleur}";
        }
    }
}
