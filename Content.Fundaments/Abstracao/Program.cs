using System;

namespace Revisoes.Abstracao
{
    public abstract class Pagamento
    {
        public abstract void ProcessarPagamento();
        public abstract void MostrarDetalhes();
    }

    public class CartaoCredito : Pagamento
    {
        public required string NumeroCartao { get; set; }
        public required string NomeTitular { get; set; }
        public required string DataExpiracao { get; set; }
        public required string CodigoSeguranca { get; set; }

        public override void ProcessarPagamento()
        {
            Console.WriteLine("Processando pagamento com cartão de crédito...");
        }

        public override void MostrarDetalhes()
        {
            Console.WriteLine($"Cartão de crédito: {NumeroCartao}");
            Console.WriteLine($"Titular: {NomeTitular}");
            Console.WriteLine($"Data de expiração: {DataExpiracao}");
        }
    }

    public class PayPal : Pagamento
    {
        public required string Email { get; set; }
        public required string Senha { get; set; }

        public override void ProcessarPagamento()
        {
            Console.WriteLine("Processando pagamento com PayPal...");
        }

        public override void MostrarDetalhes()
        {
            Console.WriteLine($"Email: {Email}");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            CartaoCredito cartao = new()
            {
                NumeroCartao = "1234 5678 9012 3456",
                NomeTitular = "Fulano de Tal",
                DataExpiracao = "12/2022",
                CodigoSeguranca = "123"
            };

            cartao.ProcessarPagamento();
            cartao.MostrarDetalhes();

            PayPal paypal = new()
            {
                Email = "emil@email.com",
                Senha = "123456"
            };
            paypal.ProcessarPagamento();
            paypal.MostrarDetalhes();
        }
    }
}
