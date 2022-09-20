using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Funcionario [] f1 = new Funcionario [4];
            f1[0] = new Funcionario();

            f1[0].setNome("Luana");
            f1[0].setMatricula(2345);
            f1[0].setSalario(1800);

            f1.imprimir();
            //f2.imprimir():
            //f3.imprimir():
            //f4.imprimir();

            Console.ReadKey();
        }

        class Funcionario
        {
            private string Nome;
            private int Matricula;
            private decimal Salario;

            //get e set
            public string getNome()
            {
                return this.Nome;
            }
            public void setNome(string Nome)
            {
                this.Nome = Nome;
            }

            public int getMatricula()
            {
                return this.Matricula;
            }
            public void setMatricula(int Matricula)
            {
                this.Matricula = Matricula;
            }

            public decimal getSalario()
            {
                return this.Salario;
            }
            public void setSalario(decimal Salario)
            {
                this.Salario = Salario;
            }

            public void imprimir()
            {
                Console.WriteLine(this.Nome + " " + this.Matricula + " " + this.Salario);
            }
        }
    }
}
