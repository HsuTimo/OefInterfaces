using Oef_Fruit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef_Fruit
{
    class Program
    {
        static void Main(string[] args)
        {
            FruitLijst fruitLijst = new FruitLijst();
            fruitLijst.Add(new Citroen("Algarve", 3.0));
            fruitLijst.Add(new SinaasAppel("Jaffa", 3.2, true)); 
            fruitLijst.Add(new SinaasAppel("Bloedappelsien", 3.4, true)); 
            fruitLijst.Add(new Pompelmoes("Roze pompelmoes", 3.1, "roze")); 
            fruitLijst.Add(new SinaasAppel("Persappelsien", 2.5, false)); 
            fruitLijst.Add(new Pompelmoes("Rode pompelmoes", 3.3, "rood")); 
            fruitLijst.Add(new Pompelmoes("Witte pompelmoes", 2.9, "wit"));

            fruitLijst.SorteerVolgensPrijs(); 
            fruitLijst.Toon(); 
            Console.ReadLine();
        }
    }
}
