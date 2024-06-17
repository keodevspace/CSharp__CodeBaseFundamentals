using System;
using System.Text;

namespace ConsoleApp
{
    // 👾 Namespace - divisões lógicas
    namespace ExampleNamespace
    {
        // 👾 Classe - tudo que vai ser executado, Program.cs
        class Program
        {
            // 👾 Método Principal - main 
            static void Main(string[] args)
            {
                // 👾 Variáveis e Constantes
                int idade = 18; // Variável do tipo inteiro
                const int MAX_AGE = 100; // Constante

                // 👾 Tipos primitivos
                float altura = 1.75f; // float com notação F
                double peso = 70.5; // double sem notação (padrão)
                decimal salario = 3000.50m; // decimal com notação M
                bool isEmployed = true; // booleano
                char inicial = 'A'; // caractere
                string nome = "João"; // string
                var idadeDinamica = 25; // var inferido como int

                // 👾 Nullable Types
                int? nullableInt = null;

                // 👾 Operadores de Comparação
                bool isAdult = idade >= 18;
                bool isSenior = idade >= 65;

                // 👾 Operadores Lógicos
                bool canVote = isAdult && isEmployed;
                bool needsAssistance = isSenior || !isEmployed;

                // 👾 If
                if (isAdult)
                {
                    Console.WriteLine("É adulto.");
                }
                else if (isSenior)
                {
                    Console.WriteLine("É idoso.");
                }
                else
                {
                    Console.WriteLine("É menor de idade.");
                }

                // 👾 Switch
                switch (idade)
                {
                    case 18:
                        Console.WriteLine("Acabou de se tornar adulto.");
                        break;
                    case 65:
                        Console.WriteLine("Se aposentou.");
                        break;
                    default:
                        Console.WriteLine("Idade comum.");
                        break;
                }

                // 👾 Laços de Repetição
                // For loop
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Contando: {i}");
                }

                // While loop
                int count = 0;
                while (count < 5)
                {
                    Console.WriteLine($"While contando: {count}");
                    count++;
                }

                // Do While loop
                count = 0;
                do
                {
                    Console.WriteLine($"Do while contando: {count}");
                    count++;
                }
                while (count < 5);

                // 👾 Funções ou Métodos
                MeuMetodo("Parâmetro passado para o método.");
                string nomeCompleto = RetornaNome("João", "Silva");
                Console.WriteLine(nomeCompleto);

                // 👾 Structs
                var product = new Product(1, "Mouse Gamer", 197.23f);
                Console.WriteLine(product.Id);
                Console.WriteLine(product.Title);
                Console.WriteLine(product.Price);

                // 👾 Enums
                var cliente = new Cliente("João Silva", EEstadoCivil.Casado);
                Console.WriteLine($"{cliente.Nome} é {cliente.EstadoCivil}");

                // 👾 String Manipulation
                string mensagem = "Olá, Mundo!";
                Console.WriteLine(mensagem.ToUpper()); // Converte para maiúscula
                Console.WriteLine(mensagem.ToLower()); // Converte para minúscula
                Console.WriteLine(mensagem.Replace("Mundo", "C#")); // Substitui uma substring

                // 👾 StringBuilder
                var sb = new StringBuilder();
                sb.Append("Linha 1\n");
                sb.Append("Linha 2\n");
                sb.Append("Linha 3\n");
                Console.WriteLine(sb.ToString());

                // 👾 DateTime
                DateTime now = DateTime.Now;
                Console.WriteLine(now.ToString("dd/MM/yyyy HH:mm:ss")); // Formata a data

                // 👾 Value Types vs Reference Types
                int x = 25;
                int y = x; // Copia o valor de x
                x = 32; // Altera apenas x

                var arr1 = new string[2];
                arr1[0] = "Item 1";
                var arr2 = arr1; // Referência para o mesmo array
                arr1[0] = "Item Alterado"; // Altera ambos
                Console.WriteLine(arr2[0]); // Exibe "Item Alterado"
            }

            // Método de exemplo
            static void MeuMetodo(string parametro)
            {
                Console.WriteLine(parametro);
            }

            // Método com retorno
            static string RetornaNome(string nome, string sobrenome)
            {
                return $"{nome} {sobrenome}";
            }

            // 👾 Struct
            struct Product
            {
                public int Id;
                public string Title;
                public float Price;

                public Product(int id, string title, float price)
                {
                    Id = id;
                    Title = title;
                    Price = price;
                }

                public float PriceDolar(float dolar)
                {
                    return Price * dolar;
                }
            }

            // 👾 Enum
            enum EEstadoCivil
            {
                Solteiro = 1,
                Casado = 2,
                Divorciado = 3
            }

            // 👾 Struct com enum
            struct Cliente
            {
                public string Nome;
                public EEstadoCivil EstadoCivil;

                public Cliente(string nome, EEstadoCivil estadoCivil)
                {
                    Nome = nome;
                    EstadoCivil = estadoCivil;
                }
            }
        }
    }
}
