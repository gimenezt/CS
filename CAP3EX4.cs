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
            double salario, aumento, total;
            Console.WriteLine("Digite seu salário: R$");
            salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o percentual de aumento: ");
            aumento = double.Parse(Console.ReadLine());
            total = salario + (aumento * salario / 100);
            Console.WriteLine("O salário final é R$ " + total);

        }
    }
}
