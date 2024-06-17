using System;
using System.IO;

// Classe Utilidades
public static class Utilidades
{
    public static int GerarNumeroAleatorio()
    {
        Random random = new Random();
        return random.Next();
    }
}

// Classe Programa
public class Program
{
    static void Main(string[] args)
    {
        // Utilizando a classe selada
        ClasseSelada minhaClasseSelada = new ClasseSelada();
        minhaClasseSelada.Valor = Utilidades.GerarNumeroAleatorio();
        Console.WriteLine("Valor da classe selada: " + minhaClasseSelada.Valor);

        // Utilizando a instrução using e Dispose
        using (StreamWriter writer = new StreamWriter("arquivo.txt"))
        {
            writer.Write("Olá, mundo!");
        } // O objeto writer é descartado automaticamente aqui

        // Cria um pagamento via Pix
        Pagamento pagamentoPix = new PagamentoPix()
        {
            Valor = 100,
            Data = DateTime.Now,
            ChavePix = "minha-chave-pix"
        };
        pagamentoPix.RealizarPagamento();

        // Cria um pagamento via Cartão
        Pagamento pagamentoCartao = new PagamentoCartao()
        {
            Valor = 200,
            Data = DateTime.Now,
            NumeroCartao = "1234-5678-9012-3456"
        };
        pagamentoCartao.RealizarPagamento();
    }
}

// Classe Selada
public sealed class ClasseSelada
{
    public int Valor { get; set; }
}

// Classe Pagamento
public abstract class Pagamento
{
    public decimal Valor { get; set; }
    public DateTime Data { get; set; }

    public abstract void RealizarPagamento();
}

// Classe PagamentoPix
public class PagamentoPix : Pagamento
{
    public string ChavePix { get; set; }

    public override void RealizarPagamento()
    {
        // Aqui você pode implementar a lógica para realizar o pagamento via Pix
        Console.WriteLine($"Realizando pagamento de {Valor} via Pix para a chave {ChavePix} na data {Data}");
    }
}

// Classe PagamentoCartao
public class PagamentoCartao : Pagamento
{
    public string NumeroCartao { get; set; }

    public override void RealizarPagamento()
    {
        // Aqui você pode implementar a lógica para realizar o pagamento via cartão
        Console.WriteLine($"Realizando pagamento de {Valor} via cartão de número {NumeroCartao} na data {Data}");
    }
}