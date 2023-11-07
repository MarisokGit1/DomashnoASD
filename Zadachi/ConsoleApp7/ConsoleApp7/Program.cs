using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Console.Write("Въведете p: ");
        int p = int.Parse(Console.ReadLine());

        Console.Write("Въведете q: ");
        int q = int.Parse(Console.ReadLine());

        Console.WriteLine($"{p}/{q} = ");

        while (p != 0)
        {
            int a = (q + p - 1) / p;
            Console.Write($"1/{a}");
            p = p * a - q;
            q = q * a;

            if (p != 0)
            {
                Console.Write(" + ");
            }
        }

        Console.WriteLine();
        }
    }
}
