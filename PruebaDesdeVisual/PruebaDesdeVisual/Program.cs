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
            for(int i = 0; i < n.Length; i++)
            {
                Console.WriteLine("Digite el valor de la Matriz ["+(i+1)+"] = ");
                n[i] = Convert.ToInt16(Console.Read());
            }
            Console.Clear();
            for(int i = 0; i < n.Length; i++)
            {
                Console.WriteLine("\n" + n[i]);
            }
            Console.ReadKey();
        }
    }
}
