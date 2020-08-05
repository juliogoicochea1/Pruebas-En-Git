using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaDesdeVisual
{
    class Program
    {
        static void Main(string[] args)
        {
            int []n;
            n = new int[2];
            n[0] = 5;
            n[1] = 7;
            for(int i = 0; i < n.Length; i++)
            {
                Console.WriteLine("Valor de n[" + i + "] = "+n[i]);
            }
            Console.Write("\nF");
            Console.ReadKey();
        }
    }
}
