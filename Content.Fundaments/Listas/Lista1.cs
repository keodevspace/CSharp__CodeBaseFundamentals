using System;

namespace Listas
{
    class Profram
    {
        static void Main(string[] args)
        {
            IEnumerable<Payments> payments = new List<Payments>();

            IList<Payments> payments = new List<Payments>();
            payments.Add(new Payments());

            var lista = new Listas<string>();
            lista.Add("Item 1");
            lista.Remove("Item 1");

            // var payments = new IEnumerable<Payments>();
            // Interface que permite apenas a leitura dos itens
            // Mais usado para iteração de itens
            // O que mais restringe o uso de listas

            // var payments = new IList<Payments>();
            // Lista que permite adicionar e remover itens

            // var payments = new ICollection<Payments>(); 
            //Interface que permite adicionar e remover itens


            // var payments = new IReadOnlyCollection<Payments>();´
            // Interface que permite apenas a leitura dos itens e a contagem deles

            // var payments = new IReadOnlyList<Payments>();
            // Interface que permite apenas a leitura dos itens e a contagem deles

            // muitas outras opções de listas

        }

    }

    public class Payments
    {

        public int Id { get; set; }

        public Program(int id)
        {
            Id = id;
        }
    }
}