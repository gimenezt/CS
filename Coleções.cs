using System;

namespace ExArrayList.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario[] f = new Funcionario[2];
            f[0].Nome = "Maria";
            f[0].Matricula = 123;
            f[0].CPF = "6765657";


            f[1].Nome = "Pedro";
            f[1].Matricula = 789;
            f[1].CPF = "2213438";

            Departamento d = new Departamento();
            d.Nome = "Vendas";

            for (int i = 0; i < 2; i++)
            {
                d.adicionaFuncionario(f[i]);
                d.imprimeDepartamento();
            }
            }
    }
}

//

using System;
using System.Collections.Generic;
using System.Text;

namespace ExArrayList.cs
{
    class Funcionario
    {
        public string Nome { get; set; }
        public int Matricula { get; set; }
        public string CPF { get; set; }

        public Funcionario(string nome, int matricula, string cpf)
        {
            this.Nome = nome;
            this.Matricula = matricula;
            this.CPF = cpf;
        }

        public Funcionario(){}

        public void imprimeFuncionario()
        {
            Console.WriteLine("Nome: ", this.Nome, "\nMatricula: ", this.Matricula, "\nCPF: ", this.CPF);
        }

    }
}

//

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ExArrayList.cs
{
    class Departamento
    {
        public string Nome { get; set; }
        ArrayList ListaFuncionarios = new ArrayList();
        
        public Departamento(string nome)
        {
            this.Nome = nome;
        }

        public Departamento() { }

        public void adicionaFuncionario(Funcionario f)
        {
            ListaFuncionarios.Add(f);
        }

        public void imprimeDepartamento()
        {
            foreach(Funcionario f in ListaFuncionarios)
            {
                f.imprimeFuncionario();
            }
        }
    }
}


