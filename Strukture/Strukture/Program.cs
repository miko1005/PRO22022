using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strukture
{
    internal class Program
    {
        struct Vektor
        {
            public double x;
            public double y, z;
            public override string ToString()
            {
                return "(" + x + "," + y + ", " + z + ")";
            }
            public Vektor(double x1, double y1,double z1)
            {
                x = x1;y=y1;z = z1;
            }
            public Vektor(Vektor v)
            {
                x = v.x;
                y = v.y;
                z = v.z;
            }
            public static  Vektor operator+(Vektor levi,Vektor desni)
            {
                Vektor r = new Vektor();
                r.x = levi.x + desni.x;
                r.y = levi.y + desni.y;
                r.z = levi.z + desni.z;

                return r;
            }
            public static Vektor operator*(double a,Vektor b)

            {
                Vektor r = new Vektor();
                r.x = a * b.x;
                r.y = a * b.y;
                r.z = a * b.z;
                return r;
            }
            public static Vektor operator*(Vektor a,double b)
            {
                return b * a;

            }
            public static double operator*(Vektor a,Vektor b)
            {
                return a.x * b.x + a.y * b.y + a.z * b.z;
            }
            public static bool operator==(Vektor a, Vektor b)
            {
                return a.x == b.x && a.y == b.y && a.z == b.z;

            }
            public static bool operator !=(Vektor a, Vektor b)
            {
                return !(a == b);
            }
        }
        static void Main(string[] args)
        {
            Vektor v;
            v.x = 1;
            v.y = -1;
            v.z = 0;
            Vektor a = new Vektor();
            a.x = 2;
            a.y = 2;
            a.z = 3;
            Console.WriteLine(v.ToString());
            Console.WriteLine(a.ToString());
            Vektor c = v + a;
            Console.WriteLine("Vsota je "+c.ToString());
            c = 5 * v;
            Console.WriteLine("Mnozenje s skalarjem "+c.ToString());
            Console.WriteLine("v==a? "+(v==a));
            Console.ReadLine();
        }
    }
}
