using System;

// Interface que define um contrato para transações de pagamento
public interface ITransacaoPagamento
{
    void Pagar();
}

// Classe base para representar uma conta bancária
public class ContaBancaria
{
    public int Numero { get; set; }
    public double Saldo { get; set; }

    public ContaBancaria(int numero, double saldo)
    {
        Numero = numero;
        Saldo = saldo;
    }

    public virtual void Depositar(double valor)
    {
        Saldo += valor;
        Console.WriteLine($"Depósito de R${valor} na conta {Numero}. Novo saldo: R${Saldo}");
    }

    public virtual void Sacar(double valor)
    {
        if (Saldo >= valor)
        {
            Saldo -= valor;
            Console.WriteLine($"Saque de R${valor} na conta {Numero}. Novo saldo: R${Saldo}");
        }
        else
        {
            Console.WriteLine($"Saldo insuficiente na conta {Numero} para sacar R${valor}");
        }
    }
}



// Classe que representa uma conta poupança, que herda de ContaBancaria
public class ContaPoupanca : ContaBancaria
{
    public double TaxaJuros { get; set; }

    public ContaPoupanca(int numero, double saldo, double taxaJuros) : base(numero, saldo)
    {
        TaxaJuros = taxaJuros;
    }

    public void CalcularJuros()
    {
        double juros = Saldo * TaxaJuros;
        Depositar(juros);
    }
}

// Classe que representa um pagamento com cartão de crédito, que implementa a interface ITransacaoPagamento
public class PagamentoCartaoCredito : ITransacaoPagamento
{
    public string NumeroCartao { get; set; }

    public void Pagar()
    {
        Console.WriteLine($"Pagamento com cartão de crédito {NumeroCartao} realizado.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Exemplo de uso das classes

        // Criando uma conta poupança
        ContaPoupanca contaPoupanca = new ContaPoupanca(123, 1000, 0.05);
        contaPoupanca.Depositar(500);
        contaPoupanca.Sacar(200);
        contaPoupanca.CalcularJuros();

        // Realizando um pagamento com cartão de crédito
        PagamentoCartaoCredito pagamentoCartao = new PagamentoCartaoCredito();
        pagamentoCartao.NumeroCartao = "1234 5678 9012 3456";
        pagamentoCartao.Pagar();
    }
}



//----------// DELEGATE //----------//
class Program
{
    static void RealizarPagamento(double valor)
    // é aqui que eu vou fazer o pagamento
    // mesmos parâmetros do delegate
    {
        Console.WriteLine($"Pagamento de R${valor} realizado.");
    }
    static void Main(string[] args)
    {
        var pagar = new Pagamento.Pagar(RealizarPagamento);
        // aqui eu estou delegando a ação de pagar para o método RealizarPagamento
        pagar(100); // aqui eu estou chamando o método RealizarPagamento

    }
}

public class Pagamento
{
    public delegate void Pagar(double valor)
       // toda vez que eu chamar o pagar, eu vou delegar essa ação para outro método
       // ou seja, vou fazer o pagamento de outra forma
       // removo a implementação {} // insiro delegate
    }


//----------// EVENTS  //----------// 

class Program
{
    statuc void Main(string[] args)
    {
        var room = new Room(3);
        room.RoomFullEvent += OnRoomFull; // assimilar o evento a um método
        room.ReserveSeat(1);
    }

    // delego para esse evento 
    // que é acionado quando a sala está cheia
    static void OnRoomFull()
    {
        Console.WriteLine("Room is full.");
    }

    public class Room
    {
        public Room(int seats)
        {
            Seats = seats;
        }

        private int inUseSeats = 0;
        public int Seats { get; set; }

        public void ReserveSeat()
        {
            inUseSeats++;
            if (inUseSeats >= Seats)
            {
                OnRoomFull(EventArgs.Empty); 
                // aqui eu chamo o evento
            }
            else
            {
                Console.WriteLine("Event closed.");
            }
        }

        // os eventos são só assinaturas de métodos
        // vou criar um manipulador desse evento
        public event EventHandler RoomFullEvent;;

        // AoSalaCheia é o manipulador do evento
        // aqui eu executo o evento
        protected virtual void OnRoomFull(EventArgs e)
        {
            RoomFull?.Invoke(this, e); 
            // se RoomFull não for nulo, eu invoco o evento
            // ou
            EventHandler handler = RoomFullEvent;
            handler?.Invoke(this, e);
        }    
    }
}
