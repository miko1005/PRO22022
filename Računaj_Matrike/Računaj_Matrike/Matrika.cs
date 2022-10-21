using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Računaj_Matrike
{
    internal class Matrika
    {
        //tabela realnih matrik
        double[,] m = new double[3, 3];
        //dodamo indekse
        public double this[int x, int y]
        {
            get { return m[x, y]; }
            set { m[x, y] = value; }
        }
        public void Izpis()
        {
            for (int k = 0; k < 3; k++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(m[k, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public static Matrika operator *(Matrika a, Matrika b)
        {
            Matrika r = new Matrika();
            for (int k = 0; k < 3; k++)
            {
                for (int j = 0; j < 3; j++)
                {
                    r[k, j] = a[k, 0] * b[0, j] + a[k, 1] * b[1, j] + a[k, 2] * b[2, j];//kobinacije
                }
                Console.WriteLine();
            }
            return r;
        }
        public static Matrika operator +(Matrika a, Matrika b)
        {
            Matrika r = new Matrika();
            for (int k = 0; k< 3; k++)
            {
                for (int j = 0; j < 3; j++)
                {
                    r[k,j]=
                }
            }
        }

          


              
}
}
