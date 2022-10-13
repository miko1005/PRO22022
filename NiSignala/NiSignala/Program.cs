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
            Console.WriteLine("get type "+Janez.GetType());
            Console.WriteLine("too string " + Janez.ToString());



            Kupec60 Alenka =new Kupec60();
            Alenka.Ime = "Alenka Novak";
            Alenka.BeležiKlic(100, TipKlica.Mobilno);
            Console.WriteLine(Alenka.Ime + " dolguje "+ Alenka.Stanje);
            Console.WriteLine("get type " + Alenka.GetType());
            Console.WriteLine("too string " + Alenka.ToString());
            Console.ReadLine();
        }
    }
}
