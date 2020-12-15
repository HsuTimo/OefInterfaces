using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef_Fruit.Models
{
    public abstract class Fruit : IComparable<Fruit>
    {
        private readonly double prijsPerKg;
        public string Naam { get; set; }
        public double PrijsPerKg { get => prijsPerKg; }
        protected Fruit(string naam, double prijsPerKg)
        {
            Naam = naam;
            this.prijsPerKg = prijsPerKg;
        }

        public override string ToString()
        {
            return $"naam: {Naam} \tprijs: {PrijsPerKg}";
        }

        public int CompareTo(Fruit fruit)
        {
            return PrijsPerKg.CompareTo(fruit.PrijsPerKg);
        }
    }
}
