using System;
using System.Collections.Generic;

// Classe Jogador
public class Jogador
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public int NumeroDaCamisa { get; set; }
}

// Classe Time
public class Time
{
    public string NomeDoTime { get; set; }
    public string CidadeDoTime { get; set; }
    public List<Jogador> JogadoresConvocados { get; set; }

    public Time()
    {
        JogadoresConvocados = new List<Jogador>();
    }

    public void ConvocarJogador(Jogador jogador)
    {
        if (jogador.Idade < 30)
        {
            JogadoresConvocados.Add(jogador);
            Console.WriteLine($"Jogador {jogador.Nome} convocado!");
        }
        else
        {
            Console.WriteLine($"Jogador {jogador.Nome} não convocado por ter idade maior que 30 anos.");
        }
    }
}

// Classe Programa
public class Program
{
    static void Main(string[] args)
    {
        // Cria um novo time
        Time time = new Time()
        {
            NomeDoTime = "Time A",
            CidadeDoTime = "Cidade A"
        };

        // Cria jogadores
        Jogador jogador1 = new Jogador() { Nome = "Jogador 1", Idade = 25, NumeroDaCamisa = 10 };
        Jogador jogador2 = new Jogador() { Nome = "Jogador 2", Idade = 35, NumeroDaCamisa = 20 };

        // Convoca jogadores
        time.ConvocarJogador(jogador1);
        time.ConvocarJogador(jogador2);
    }
}