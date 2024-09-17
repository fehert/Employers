using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employers
{
    internal class dolgozo
    {
        public int azonosito;
        public string nev;
        public int kor;
        public int kereset;

        
        public dolgozo(string sor) { 
        this.azonosito = int.Parse(sor.Split(';')[0]);
        this.nev = sor.Split(';')[1];
        this.kor = int.Parse(sor.Split(';')[2]);
        this.kereset = int.Parse(sor.Split(';')[3]);
        }
    }
}
