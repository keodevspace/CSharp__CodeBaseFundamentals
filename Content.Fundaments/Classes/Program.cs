using System;

namespace Revisoes
{
    public class Pessoa
    {
        public string Nome {get; set;}
        public string Sobrenome {get; set;}
        public int Idade {get; set;}
    }
    class Program
    {
        static void Main (string[] args)
        {
            Pessoa novaPessoa = new Pessoa();
            novaPessoa.Nome = "João";
            novaPessoa.Sobrenome = "Silva";
            novaPessoa.Idade = 25;
            
            Console.WriteLine("Nome: " + novaPessoa.Nome);
            Console.WriteLine("Sobrenome: " + novaPessoa.Sobrenome);
            Console.WriteLine("Idade: " + novaPessoa.Idade);
        }
    }
}