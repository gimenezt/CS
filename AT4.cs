using System;

namespace AT3
{
    class Program
    {
        static void Main(string[] args)
        {
        Aluno a1 = new Aluno();
        a1.Nome ="Zé" ;
        a1.Matricula = 234;
        a1.Email = "ze@gmail.com";

        Aluno a2 = new Aluno("Ana");
        a2.Matricula = 789;
        a2.Email = "ana@xy.com";

        Aluno a3 = new Aluno("Paulo", 989, "paulo@ig.com");

        a1.imprimir();
        a2.imprimir();
        a3.imprimir();

        Console.ReadKey();
    }
}

////

    class Aluno
    {
        public string nome; 
        private int matricula;
        public string email;

        public Aluno(string nome)
        {
            this.nome = nome;
        }

        public Aluno()
        {
        }

        public Aluno(string nome, int matricula, string email)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.email = email;
        }

        public string Nome { get; set; }
        public int Matricula { get; set; }
        public string Email { get; set; }

        public void imprimir()
        {
            Console.WriteLine(this.nome + " " + this.matricula + " " + this.email);
        }
    }
}
