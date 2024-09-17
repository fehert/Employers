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
                Console.Write(b.nev +'\n');
            }
            Console.ReadLine();
        }
    }
}
