using System;

namespace Herança
{
    public class Animal
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Raça { get; set; }
        public virtual void EmitirSom(string som)
        {
            Console.WriteLine(som);
        }  
    }

    class Cachorro : Animal
    {
        public string som = "Au Au";
    }
    
    class Gato : Animal
    {
        public string som = "Miau";
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cachorro cachorro = new Cachorro();
            cachorro.Nome = "Totó";
            cachorro.Idade = 5;
            cachorro.Raça = "Vira-lata";
            cachorro.EmitirSom(cachorro.som);

            Gato gato = new Gato();
            gato.Nome = "Felix";
            gato.Idade = 3;
            gato.Raça = "Siames";
            gato.EmitirSom(gato.som);

        Console.WriteLine($"O nome do cachorro é {cachorro.Nome}, ele tem {cachorro.Idade} anos e é da raça {cachorro.Raça}");
        Console.WriteLine($"O nome do gato é {gato.Nome}, ele tem {gato.Idade} anos e é da raça {gato.Raça}");
        
        }
    }
}
