using System;

namespace Listas
{
    class Lista3
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

            // convertendo a lista de pagamentos para um array
            // payments.AsEnumerable();
            // payments.ToList(); se fosse um IEnumerable
            // payments.ToArray(); se fosse um IEnumerable
            Payment[] paymentsArray = payments.ToArray();

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