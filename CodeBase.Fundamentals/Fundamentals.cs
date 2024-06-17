// C# Console Application
using System;
using System.Collections.Generic;

// Classe básica
public class Program
{
    // Método principal
    static void Main(string[] args)
    {
        // Strings
        string nome = "João";
        Console.WriteLine("Nome: " + nome);

        // Datas
        DateTime data = DateTime.Now;
        Console.WriteLine("Data: " + data);

        // Moedas
        decimal valor = 10.5m;
        Console.WriteLine("Valor: " + valor);

        // Arrays
        int[] numeros = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Números: " + string.Join(", ", numeros));

        // Operadores aritméticos
        int soma = 5 + 5;
        Console.WriteLine("Soma: " + soma);

        // Operadores de atribuição
        int x = 10;
        x += 5;
        Console.WriteLine("X: " + x);

        // Operadores de comparação
        bool comparacao = 10 > 5;
        Console.WriteLine("Comparação: " + comparacao);

        // Operadores lógicos
        bool logico = true && false;
        Console.WriteLine("Lógico: " + logico);

        // Estruturas condicionais
        if (x > 10)
        {
            Console.WriteLine("X é maior que 10");
        }
        else
        {
            Console.WriteLine("X é menor ou igual a 10");
        }

        // Estruturas de repetição
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Número: " + i);
        }

        // Métodos e funções
        Saudacao("João");

        // Structs
        Pessoa pessoa = new Pessoa();
        pessoa.Nome = "João";
        pessoa.Idade = 25;
        Console.WriteLine("Pessoa: " + pessoa.Nome + ", " + pessoa.Idade);

        // Enums
        Dias dia = Dias.Segunda;
        Console.WriteLine("Dia: " + dia);

        // Exceções
        try
        {
            int divisao = 10 / 0;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Não é possível dividir por zero");
        }

        // Classes
        Carro carro = new Carro();
        carro.Marca = "Fiat";
        carro.Modelo = "Uno";
        Console.WriteLine("Carro: " + carro.Marca + ", " + carro.Modelo);

        // Encapsulamento
        Conta conta = new Conta();
        conta.Depositar(100);
        conta.Sacar(50);
        Console.WriteLine("Saldo: " + conta.Saldo);

        // Abstração
        Animal animal = new Cachorro();
        animal.FazerBarulho();

        // Herança
        Cachorro cachorro = new Cachorro();
        cachorro.FazerBarulho();

        // Polimorfismo
        FazerBarulho(cachorro);

        // Modificadores de acesso
        // A classe Conta demonstra isso

        // Tipos complexos
        // As classes, structs e enums são exemplos disso

        // Propriedades
        // A classe Carro demonstra isso

        // Métodos
        // A classe Conta demonstra isso

        // Classes estáticas
        Console.WriteLine("Número aleatório: " + Utilidades.GerarNumeroAleatorio());

        // Interfaces
        // A interface IAnimal e a classe Cachorro demonstram isso

        // Classes abstratas
        // A classe Animal demonstra isso

        // Upcast e Downcast
        Animal animal2 = cachorro; // Upcast
        Cachorro cachorro2 = (Cachorro)animal2; // Downcast

        // Comparando objetos
        bool saoIguais = carro.Equals(new Carro());

        // Generics
        List<int> lista = new List<int>();
        lista.Add(1);
        lista.Add(2);
        lista.Add(3);
        Console.WriteLine("Lista: " + string.Join(", ", lista));
    }

    // Método para saudação
    static void Saudacao(string nome)
    {
        Console.WriteLine("Olá, " + nome);
    }

    // Método para fazer barulho
    static void FazerBarulho(IAnimal animal)
    {
        animal.FazerBarulho();
    }
}

// Struct
public struct Pessoa
{
    public string Nome;
    public int Idade;
}

// Enum
public enum Dias
{
    Domingo,
    Segunda,
    Terca,
    Quarta,
    Quinta,
    Sexta,
    Sabado
}

// Classe Carro
public class Carro
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
}

// Classe Conta
public class Conta
{
    private decimal saldo;

    public decimal Saldo
    {
        get { return saldo; }
    }

    public void Depositar(decimal valor)
    {
        saldo += valor;
    }

    public void Sacar(decimal valor)
    {
        if (saldo >= valor)
        {
            saldo -= valor;
        }
    }
}

// Interface IAnimal
public interface IAnimal
{
    void FazerBarulho();
}

// Classe Animal
public abstract class Animal : IAnimal
{
    public abstract void FazerBarulho();
}

// Classe Cachorro
public class Cachorro : Animal
{
    public override void FazerBarulho()
    {
        Console.WriteLine("Au au");
    }
}

// Classe Utilidades
public static class Utilidades
{
    public static int GerarNumeroAleatorio()
    {
        Random random = new Random();
        return random.Next();
    }
}

// Using e Dispose
// A instrução using é usada para trabalhar com um objeto no bloco de código e então descartá-lo corretamente.
// Aqui está um exemplo de como usar a instrução using com um objeto que implementa IDisposable (como um StreamWriter).

using (StreamWriter writer = new StreamWriter("arquivo.txt"))
{
    writer.Write("Olá, mundo!");
} // O objeto writer é descartado automaticamente aqui

// Classes Seladas
// Uma classe selada é uma classe que não pode ser herdada. Aqui está um exemplo:

public sealed class ClasseSelada
{
    public int Valor { get; set; }
}

// Não é permitido:
// public class ClasseDerivada : ClasseSelada { }

// Partial Class
// Uma classe parcial é uma classe cuja definição pode ser dividida em várias partes ou vários arquivos. Cada parte contém uma seção da definição da classe, e todas as partes são combinadas quando a aplicação é compilada.

// Arquivo 1
public partial class ClasseParcial
{
    public void Metodo1()
    {
        Console.WriteLine("Método 1");
    }
}

// Arquivo 2
public partial class ClasseParcial
{
    public void Metodo2()
    {
        Console.WriteLine("Método 2");
    }
}