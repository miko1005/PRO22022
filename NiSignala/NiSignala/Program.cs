using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiSignala
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kupec Janez = new Kupec();
            Janez.Ime = "Janez Novak";
            Janez.BeležiKlic(10, TipKlica.Stacionarno);
            Console.WriteLine(Janez.Ime + " dolguje " + Janez.Stanje);
            Kupec Alenka=new Kupec();
            Alenka.Ime = "Alenka Novak";
            Alenka.BeležiKlic(10, TipKlica.Mobilno);
            Console.WriteLine(Alenka.Ime + " dolguje "+ Alenka.Stanje);
            Console.ReadLine();
        }
    }
}
