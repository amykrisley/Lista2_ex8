using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lisat2_ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Console.Write("Digite é o 1° valor ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Digite é o 2° valor ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Digite é o 3° valor ");
            c = double.Parse(Console.ReadLine());

            if (Math.Pow(a, 2) == (Math.Pow(b, 2) + Math.Pow(c, 2)) ||
                Math.Pow(b, 2) == (Math.Pow(a, 2) + Math.Pow(c, 2)) ||
                Math.Pow(c, 2) == (Math.Pow(a, 2) + Math.Pow(b, 2)))

                Console.WriteLine("Forma um triângulo retângulo");
            else
                Console.WriteLine("Não forma um triângulo retângulo");
        }
    }
}
