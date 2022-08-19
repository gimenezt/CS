using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double area, ladoB, ladob, h;
            Console.WriteLine("Digite em ordem a altura, o lado maior e o lado menor para cálculo da área do trapézio: ");
            h = double.Parse(Console.ReadLine());
            ladoB = double.Parse(Console.ReadLine());
            ladob = double.Parse(Console.ReadLine());
            area = (ladoB + ladob) * h / 2;
            Console.WriteLine("A área é " + area);
        }
    }
}
