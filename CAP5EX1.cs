using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4
{
    class Program
    {
        static void Main(string[] args)
        {

            Aluno a1 = new Aluno("Lilian");
            Aluno a2 = new Aluno(23456);
            Aluno a3 = new Aluno("giovanni@mail.com", 73845);

            a1.setEmail("lilian@gmail.com");
            a1.setNumero(12231);
            a2.setNome("Ana");
            a2.setEmail("ana@gmail.com");
            a3.setNome("Giovanni");

            Console.WriteLine(a1.getNome() + " " + a1.getNumero() + " " + a1.getEmail());
            Console.WriteLine(a2.getNome() + " " + a2.getNumero() + " " + a2.getEmail());
            Console.WriteLine(a3.getNome() + " " + a3.getNumero() + " " + a3.getEmail());
             
            Console.ReadKey();
        }
    }
}

class Aluno
    {
        private string nome;
        private int numero;
        private string email;

        public Aluno(string nome){
            this.nome = nome;
        }

        public Aluno(int numero){
            this.numero = numero;
        }

        public Aluno(string email, int numero){
            this.email = email;
            this.numero = numero;
        }

        public string getNome()
        {
            return this.nome;
        }
        public int getNumero()
        {
            return this.numero;
        }
        public string getEmail()
        {
            return this.email;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public void setNumero(int numero)
        {
            this.numero = numero;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }
    }
}
