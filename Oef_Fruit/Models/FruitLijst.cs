using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef_Fruit.Models
{
    public class FruitLijst:Fruit
    {
        private List<Fruit> fruitLijst { get; set; }
         
        public FruitLijst():base("",0)
        {
            fruitLijst = new List<Fruit>();
        }

        public void Add(Fruit newFruit)
        {
            fruitLijst.Add(newFruit);
        }
        public void SorteerVolgensPrijs()
        {
            fruitLijst.Sort();
        }
        public void Toon()
        {
            foreach (var item in fruitLijst)
            {
                Console.WriteLine(item);
            }
        }
    }
}
