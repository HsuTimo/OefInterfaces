using Oef_Voorwerp.Interfaces;
using Oef_Voorwerp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef_Voorwerp
{
    class Program
    {
        static void Main(string[] args)
        {
            double totaalWinst = 0;
            IVoorwerp[] voorwerpArr = new IVoorwerp[] 
            {
                new Leesboek(),
                new Leesboek("Peter Pan","J.M Barrie","sprookje",12.50m,"avontuur"),
                new Woordenboek(),
                new Woordenboek("Van Dale","Van Dale","woordenboek",24.12m,"Nederlands"),
                new Boekenrek(),
                new Boekenrek(2,6,315.45m)
            };
            for (int i = 0; i < voorwerpArr.Length; i++)
            {
                voorwerpArr[i].GegevensTonen();
                totaalWinst += voorwerpArr[i].WinstBerekenen();
            }
            Console.WriteLine(totaalWinst);
        }
    }
}
