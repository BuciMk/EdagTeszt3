using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdagTeszt3Console
{
    class Program
    {
        static void Main(string[] args)
        {
        List<Auto> autok = new List<Auto>();

            Auto auto = new Auto();
            auto.tipus = EJarmuTipus.Szgk;
            auto.model = "BMW M4";
            auto.evjarat = 2021;
            auto.uzemanyag = EUzemanyag.Benzin;
            auto.szin = "arany";
            autok.Add(auto);

            Console.WriteLine($"{auto.tipus} | {auto.model} | {auto.evjarat} \n{auto.uzemanyag} | {auto.szin}\n");

            auto.Start();
            auto.GPSNyomkovetes();
            auto.KormanyTekereseBalra();
            auto.EloreHaladas(20);
            auto.Stop();

            Console.ReadLine();
        
        }

    }
}



