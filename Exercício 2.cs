using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double lado, area;
            Console.WriteLine("Digite o tamanho do lado do quadrado: ");
            lado = double.Parse(Console.ReadLine());
            area = lado * lado;
            Console.WriteLine("A área é {0}", area);
        }
    }
}
