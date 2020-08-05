using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ga
{
    class Program
    {
        static void Main(string[] args)
        {

            int n1, n2;
            Console.Write("Digite el valor de n1: ");
            n1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("\nDigite el valor de n2: ");
            n2 = Convert.ToInt16(Console.ReadLine());

            int t = n1 + n2;
            Console.Write("El valor de la suma es : " + t);
            Console.ReadKey();
        }
    }
}
