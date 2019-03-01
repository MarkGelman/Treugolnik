using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treugolnik
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string[] str = Console.ReadLine().Split();
            //int[] index = { 1, 2, 3, 4, 5 };
            double[] lenth = new double[5];
            for (int i = 0; i < 5; i++)
                lenth[i] = double.Parse(str[i]);
            //Array.Sort(index, lenth);
            for (int i = 0; i < 3; i++)
                for (int g = i + 1; g < 4; g++)
                {
                    for (int j = g + 1; j < 5; j++)
                        if (compartion(lenth[i], lenth[g], lenth[j]))
                            count++;
                }   
            Console.WriteLine(count);
        }

        static bool compartion(double a, double b, double c)
        {
            if (a + b > c && a + c > b && b + c > a) return true;
            return false;
        }
    }
}
