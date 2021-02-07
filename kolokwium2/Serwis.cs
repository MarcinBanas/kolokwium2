using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace kolokwium2
{
    class Serwis
    {

        public Serwis(FileStream path)
        {

        }
        public double Jeden(int a,int b)
        {
            return a / b;
        }
        public void dwa(List<int> a)
        {
            Console.WriteLine(a.Count);
        }
    }
}
