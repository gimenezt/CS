using System;

namespace Atividade3
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal media;
            Funcionario[] f1 = new Funcionario[4];

            f1[0] = new Funcionario();
            f1[0].Nome = "Luana";
            f1[0].Matricula = 3758;
            f1[0].Salario = 1800;

            f1[1] = new Funcionario();
            f1[1].Nome = "Ruan";
            f1[1].Matricula = 9586;
            f1[1].Salario = 3800;

            f1[2] = new Funcionario();
            f1[2].Nome = "Rodrigo";
            f1[2].Matricula = 0284;
            f1[2].Salario = 1500;

            f1[3] = new Funcionario();
            f1[3].Nome = "Richard";
            f1[3].Matricula = 2546;
            f1[3].Salario = 1400;

            media = (f1[0].Salario + f1[1].Salario + f1[2].Salario + f1[3].Salario) / 4;

            Console.WriteLine("O(s) funcionário(s) com salário acima da média salarial é(são): ");

            for (int i = 0; i < 4; i++)
            {
                if (f1[i].Salario > media)
                    f1[i].imprimir();
            }

            Console.ReadKey();
        }
    }

    class Funcionario
    {
        public Funcionario()
        {
        }

        public Funcionario(string nome, int matricula, decimal salario)
        {
            this.Nome = nome;
            this.Matricula = matricula;
            this.Salario = salario;
        }

        public string Nome { get; set; }
        public int Matricula { get; set; }
        public decimal Salario { get; set; }
        

        public void imprimir()
        {
            Console.WriteLine("Nome: " + this.Nome + ", matrícula: " + this.Matricula + ", salário: " + this.Salario);
        }
    }
}
