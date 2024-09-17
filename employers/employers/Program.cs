using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fajl = File.ReadAllLines("tulajdonsagok_100sor.txt");
            List<dolgozo> tulajdonsaglista = new List<dolgozo>();
            foreach (string sor in fajl)
            {
                tulajdonsaglista.Add(new dolgozo(sor));  
            }
            foreach (var b in tulajdonsaglista)
            {
                Console.Write("Összes dolgozó neve:"+b.nev +'\n');
            }
            int legjobb = 0;
            for (int i = 0; i < tulajdonsaglista.Count; i++) {
                if (tulajdonsaglista[i].kereset > tulajdonsaglista[legjobb].kereset)
                {
                    legjobb = i;
                }
            }
            Console.Write("Legtöbbet kereső:"+tulajdonsaglista[legjobb].nev +" "+tulajdonsaglista[legjobb].kereset+'\n');

            foreach (var item in tulajdonsaglista)
            {
                if (item.kor==55)
                {
                    Console.Write("Akiknek 10 év van nyugdíjig:"+item.nev +'\n');
                }
            }
            int szamlalo = 0;
            foreach (var item in tulajdonsaglista)
            {
                if (item.kereset>50000)
                {
                    szamlalo++;
                }
            }
            Console.Write("Ennyien többet keresnek 50ezernél:"+szamlalo +"\n");
            Console.ReadLine();
        }
    }
}
