using System;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            // var payments = new List<Payment>(); // outra forma de declarar a lista
            IList<Payment> payments = new List<Payment>();
            payments.Add(new Payment(1));
            payments.Add(new Payment(2));
            payments.Add(new Payment(3));
            payments.Add(new Payment(4));
            payments.Add(new Payment(5));

            // foreach (var payment in payments) // outra forma de percorrer a lista
            foreach (Payment payment in payments) // percorrer a lista genérica
            {
                Console.WriteLine(payment.Id);
            }

            // quero buscar/consultar o pagamento 3
            // sempre espera uma expressão lambda
            // Where traz uma lista
            // FirstOrDefault se ele não encontrar o objeto, ele retorna null
            // First se ele não encontrar o objeto, ele retorna uma exceção
            var payment = payments.Where(x => x.Id == 3);  // traz uma lista
            var payment2 = payments.First(x => x.Id == 3); // traz um objeto

            // remove da lista
            payments.Remove(payment);
            // remove uma lista de outra lista
            payments.RemoveRange(payment);
            // limpa a lista
            payments.Clear();

            // verifica se existe na lista
            var exists = payments.Any(x => x.Id == 3); //true or false

            // conta quantos itens tem na lista
            var exists = payments.Count(x => x.Id == 3);

            // pula o item que eu quero
            var exists = payments.Skip(1);
            // Skip e Take são usados para paginação de dados
            // pega uma qtde de itens
            var exists = payments.Take(3);


            var paidPayments = new List<Payment>(); // nova lista
            paidPayments.AddRange(payments); // adiciona uma lista dentro da outra


        }

    }

    public class Payment
    {

        public int Id { get; set; }

        public Payment(int id)
        {
            Id = id;
        }
    }
}