using System;
using System.Collections.Generic;

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
        }
    }
}
