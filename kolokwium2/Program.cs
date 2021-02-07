using System;
using System.Collections.Generic;
using System.IO;

namespace kolokwium2
{
    class Program
    {
        public void DodajPracownika(List<Pracownik> lista)
        {
            lista.Add(new Pracownik());
        }
        public void UsunPracownika(List<Pracownik> lista,Pracownik a)
        {
            lista.Remove(a);
        }
        static void Main(string[] args)
        {
            string tekst;

            tekst = Console.ReadLine();
            List<char> lista = new List<char>();
            List <Pracownik> listapracownikow = new List<Pracownik>();
            FileStream a = new FileStream("p3.txt",FileMode.Open,FileAccess.ReadWrite,FileShare.Read);
            foreach (var item in listapracownikow)
            {
                
            }
        }
    }
}
