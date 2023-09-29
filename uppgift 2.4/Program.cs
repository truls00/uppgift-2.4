using System;
using System.Diagnostics.CodeAnalysis;

namespace Uppgift_2._4
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("mata in lönen på 3 av dina anställda");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());

            double Summa = (x + y + z) / 3;
            Console.WriteLine("Medelönen för personalen är " + Summa);
            Console.ReadKey();





        }
    }
}
