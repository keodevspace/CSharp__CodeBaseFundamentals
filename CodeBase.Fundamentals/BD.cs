using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

public class Program
{
    public static void Main()
    {
        using (var db = new MeuDbContext())
        {
            // Cria um novo jogador e salva no banco de dados
            db.Jogadores.Add(new Jogador { Nome = "Jogador1", Idade = 25, NumeroDaCamisa = 10 });
            db.SaveChanges();

            // Consulta todos os jogadores do banco de dados
            var jogadores = db.Jogadores.ToList();
            foreach (var jogador in jogadores)
            {
                Console.WriteLine($"Nome: {jogador.Nome}, Idade: {jogador.Idade}, Numero da Camisa: {jogador.NumeroDaCamisa}");
            }
        }
    }
}

public class Jogador
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public int Idade { get; set; }
    public int NumeroDaCamisa { get; set; }
}

public class MeuDbContext : DbContext
{
    public DbSet<Jogador> Jogadores { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Database=meu_db;Username=meu_usuario;Password=meu_senha");
    }
}