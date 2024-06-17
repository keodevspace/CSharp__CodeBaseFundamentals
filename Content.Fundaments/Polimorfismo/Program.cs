using System;
using static Revisoes.Veiculo;

namespace Revisoes
{
    public class Veiculo
    {
        public string Modelo { get; set; }
        public string Rodas { get; set; }

        public virtual void Mover(string move)
        {
            Console.WriteLine(move);
        }

        public class Carro : Veiculo
        {
            public string Modelo = "Fusca";
            public string Rodas = "4";
            public string move = "VRAAAAAAAAAAVRAAAAAAAAVRAAAAAAA";
        }

        public class Bicicleta : Veiculo
        {
            public string Modelo = "Caloi";
            public string Rodas = "2";
            public string move = "Tein tein tein tein";
        }
    }

        public class Program {
            static void Main(string[] args)
            {
                Carro carro = new Carro();
                carro.Modelo = "Fusca";
                carro.Rodas = "4";
                carro.Mover(carro.move);

                Bicicleta bicicleta = new Bicicleta();
                bicicleta.Modelo = "Caloi";
                bicicleta.Rodas = "2";
                bicicleta.Mover(bicicleta.move);

                Console.WriteLine($"O modelo do carro é {carro.Modelo}, ele tem {carro.Rodas} rodas");
                Console.WriteLine($"O modelo da bicicleta é {bicicleta.Modelo}, ela tem {bicicleta.Rodas} rodas");

        } 
    }
}
