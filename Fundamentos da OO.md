#### 👾Paradigmas de OO👾
✔️Encapsulamento
✔️Abstração
✔️Herança
✔️Polimorfismo

#### 👾Objetos👾
✔️ propriedades, métodos e eventos
✔️ atacar os problemas de forma mais direcionada

#### 👾Classes👾
Struct: é uma estrutura de dados.
![[Pasted image 20240603184753.png]]
Se eu mudar o struct para class, o código é o mesmo
![[Pasted image 20240603184847.png]]
Qual a diferença do struct para o class?
✔️ O *objeto class* sempre vai ser um *tipo de referência* só armazena o endereço dos dados. 
✔️ O objeto possui *propriedade, método e evento.*
✔️ A classe é o **molde do objeto**.

#### 👾Encapsulamento👾
Primeiro passo quando eu pego um problema grande é dividir ele em *pequenos pedaços*.
✔️ Encapsular é *agrupar* propriedades, métodos e eventos de um mesmo objeto.
````
class Pagamento
    {
        DateTime Vencimento; // as variáveis são propriedade
        void Pagar(){} // as funções são os métodos
    }
````

#### 👾Abstração👾
Não sei os detalhes de funções que acontecem no dia a dia. Ex: ligar o interruptor para ligar a luz, levar o carro para oficina para consertar.
Eu sei que tenho um problema, não sei como ele foi resolvido.
✔️ Quanto menos outras classes souberem dos métodos do meu objeto, melhor. 
✔️ Exponho menos as informações privando os métodos e abstraindo para outras classes
````
class Pagamento

    {
       DateTime Vencimento; // as variáveis são propriedade  

        void Pagar(){} // as funções são os métodos

        ConsultarSaldoDoCartao(); // método de abstração da classe pagamento

    }
        private void ConsultarSaldoDoCartao() 
        // private para privar que outras classes acessem esse método
        // as outras classes não precisam saber que ele acontece
        {
        }
````

#### 👾Herança👾
✔️Capacidade que um objeto tem de herdar propriedades, métodos e eventos de outro objeto.
No caso do exemplo "Pagamento", podemos ter vários tipos de pagamento: pagamento com cartão, com boleto, com pix, etc. Se tivessemos esses outros tipos de pagamento, não faria sentido, por exemplo, ter o número do cartão no tipo de pagamento boleto, certo?
✔️ Toda propriedade ou método que não passamos nada vão ser *private*, até que eu passe *public*
✔️ INSTÂNCIA é o ato de transformar a classe em um objeto
````
class Program
{
    static void Main(string[] args)
    {

        var pagamentoBoleto = new PagamentoBoleto(); // instanciando a  classe PagamentoBoleto

        pagamentoBoleto.Vencimento = DateTime.Now; // atribuindo valor a variável Vencimento, consigo acessar os métodos e propriedades da classe Pagamento

        pagamentoBoleto.Pagar(); // chamando o método Pagar

    }

    class Pagamento

    {
        public DateTime Vencimento; // as variáveis são propriedade

        public void Pagar(){} // as funções são os métodos

    }

        class PagamentoBoleto : Pagamento // herança: classe PagamentoBoleto herda de Pagamento    

    {
	    public string NumeroBoleto;  // uma propriedade exclusiva do boleto
    }
}
`````
✔️ Com a herança, eu trago todos os eventos e métodos da classe/objeto pai/base
✔️ Posso ter quantas heranças únicas do objeto base

#### 👾Polimorfismo👾
✔️ *virtual* no pai, permite que o método seja sobrescrito
✔️ *override* no filho, atribui nova forma para o método
````
class Pagamento
    {
        public DateTime Vencimento;

        public virtual void Pagar(){} 
        // virtual permite que o método seja sobrescrito
    }
        class PagamentoBoleto : Pagamento

        {
         public override void Pagar() 
         // sobrescrevendo o método Pagar  
         // Regra do Boleto
        }
````
#### 👾Modificadores de acesso👾
✔️ **private** - só a classe acessa; default das classes; usa  __ na frente do nome
✔️ **protected** - usar *base.* , é visivel só para os filhos da classe
✔️ **internal** - disponivel dentro do msm namespace (msm assembly)
✔️ **public** - visivel em qq lugar

#### 👾Tipos complexos👾
Toda vez que eu crio uma NOVA CLASSE, eu estou criando um NOVO TIPO. Tudo que eu escrever NEW é um tipo complexo
✔️ DateTime e Address tb
	![[Pasted image 20240604183445.png]]

#### 👾Propriedades👾
As **propriedades** têm muitos usos: Elas podem validar dados antes de permitir uma alteração. Elas podem expor dados de forma transparente em uma classe em que esses dados **são** recuperados de alguma outra fonte, como um banco de dados.
✔️ prop + *tab*  cria uma propriedade
✔️ prop full + *tab* cria uma propriedade mais completa
✔️ Bom para aferir dados
Uma propriedade que tem os dois acessadores: leitura/gravação.
As propriedades têm muitos usos:
- Elas podem validar dados antes de permitir uma alteração.
- Elas podem expor dados de forma transparente em uma classe em que esses dados são recuperados de alguma outra fonte, como um banco de dados.
- Elas podem executar uma ação quando os dados são alterados, como gerar um evento ou alterar o valor de outros campos.
	![[Pasted image 20240604193907.png]]
	![[Pasted image 20240604194816.png]]
	
````
public string DateTime {get; set}

se for algo mais rubusto usa o prop g
````

DIFERENÇA DE VARIÀVEL PARA PROPRIEDADE
-  Variáveis
Uma _variável_ corresponde diretamente a um local de memória. Você define uma variável com uma única instrução de declaração. Uma variável de membro também é chamada de _campo_.
- Proriedades
Uma _propriedade_ é um elemento de dados definido em um módulo, classe ou estrutura. Você define uma propriedade com um bloco de código que contém um procedimento `Get`, um procedimento `Set` ou ambos. Esses procedimentos são chamados de *acessadores de propriedade*. Além de recuperar ou armazenar o valor da propriedade, eles também podem executar ações personalizadas, como atualizar um contador de acesso.
Fonte: https://learn.microsoft.com/pt-br/dotnet/visual-basic/programming-guide/language-features/procedures/differences-between-properties-and-variables

#### 👾Métodos👾
Métodos são funções.
✔️ *Sobrecarga de Métodos*: podem receber parâmetros diferentes, versões diferentes do método. Assinaturas diferentes.
✔️ *Sobrescrita de Métodos*: caso do virtual + override, reescrita do método
````
public void Pagar (string numero, DateTime vencimento)
{
// nome do método é pagar
// assinatura do método é Pagar (string numero, DateTime vencimento)
}
`````
![[Pasted image 20240605073933.png]]

✔️ INSTANCIANDO O MÉTODO - ctor + tab
- toda vez que eu usar o NEW eu estou instanciando, ou seja, pegando o molde da classe e usando para criar um novo objeto. MÉTODO CONSTRUTOR
- Posso iniciar as variáveis através do método construtor.
	![[Pasted image 20240605075506.png]]
	![[Pasted image 20240605075543.png]]
	Mas, quando ele chamou o Console "iniciando"?
	![[Pasted image 20240605075622.png]]
	Quando nosso método foi iniciado
	Mas, quando usar isso?
	Posso usar para preencher as variáveis.
	![[Pasted image 20240605075805.png]]
	A variável nesse caso inicia ser valor nulo.
- Tomar cuidado quando colocar parâmetro no construtor. Resolve com construtor vazio (parametless - sem parametro)

#### 👾Using e Dispose👾
Método "destrutor"
Depois de um tempo que a classe fica inativa, ela vai pro Garbage Colector automaticamente, não preciso fazer nada.
✔️ Só que quando eu *preciso sair do método depois dele processado*, inicio/processo/saida, eu uso o dispose e o using. 
No SQL Server, por exemplo, eu tenho LIMITE DE CONEXÕES COM BD. Quem entrar no bd, se eu já usei meu limite, vai ficar numa fila de espera. A APP FICA LENTA. Então, sair dessa conexão é importante por isso.
✔️ **Sempre que eu tiver uma classe que se conecta ao BD** (não tenho uma classe que fica conectada o tempo todo no bd, eu vou ao bd ocasionalmente para pegar um dado e depois não uso mais a classe, PRECISO DESLIGAR A CONEXÃO COM O BD. Garantindo que não deixei nenhuma conexão aberta.
![[Pasted image 20240606081943.png]]

#### 👾Classes Estáticas👾
Classes Estáticas não conseguem ser instanciadas.
✔️ Se a classe for static, o método e propriedade tb devem ser.
STATIC - modificador
✔️A classe já fica disponível no start da aplicação e a partir daí é SEMPRE A MESMA INFO que teremos acesso.
````
ao invés de usar
var pagamento = new Pagamento();

posso usar
Pagamento.METODO
````
Quando usar static?
✔️ uma classe que eu não vou muito usar, tipo SETTINGS da aplicação:
````
public static class Settings
{
	public static string API_URL {get;set;}	
}
````
Se tiver muitos usuários, todos vão acessar o mesmo endereço url, por exemplo. Diferente do Pagamento, que teríamos vários tipos de pagamentos.
#### 👾Classes Seladas👾
Quando quero inibir a possibilidade de alguém estender a minha classe.
✔️ Não deixo criar herança
✔️ SEALED
![[Pasted image 20240606110902.png]]
✔️ Cenários onde eu preciso GARANTIR QUE MINHA CLASSE SÓ TENHA UMA FORMA.
✔️ Pacote FLUNT, classe NOTIFICATION
#### 👾Partial Class👾
Divide a classe em partes que segmenta a classe em classes menores. No desenvolvimento de windows usa muito, pra dividir classe de interfaces.
✔️ Não usa muito no dia a dia de dev
✔️ Quando a classe precisa ser muito segmentada (não indicado)

#### 👾Interfaces👾

Contrato de classes.
	A *diferença entre interface e classe* é que a *interface não contém implementação* (até pode, mas não é indicado)
````
// ...relembrando o que é implementação
public void Pagar ()
{

}
````

✔️ Começa SEMPRE COM LETRA I
````
public interface IPagamento
{

}
`````

✔️ Uma implementação seria uma classe que faz tudo que o contrato pede:
````
public interface IPagamento
{
	public DateTime Vencimento { get; set; }
	
	public void Pagar (double valor)

}

public class Pagamento : IPagamento
{

	public DateTime Vencimento { get; set; }
	
	public void Pagar (double valor)
	
{

public class pagamentoCartaoCredito : IPagamento
{
	
	public DateTime Vencimento { get; set; }
	
	public void Pagar (double valor)	
	
}
````

✔️ SEMPRE PENSAR PRIMEIRO NAS INTERFACES, depois pensar as implementações.
	1º) o que tem que ser feito --> INTERFACES
	2º) como fazer --> IMPLEMENTAÇÕES

#### 👾Classes Abstratas👾

✔️ "Pagamento" é uma *classe abstrata que não pode ser instanciada, só pode ser herdada*. 
✔️ Ela pode ter uma implementação que serve de base para outras.

Se pagamentoBoleto, pagamentoCartaoCredito, pagamentoPix herdam  da classe ou interface Pagamento - IPagamento, então essa classe/interface não implementa nada, ou seja, ela é uma classe abstrata.
![[Pasted image 20240611091826.png]]
![[Pasted image 20240611092010.png]]

#### 👾Upcast e Downcast👾

✔️**Upcast ou Upcasting**: assimilação de um obj filho pelo obj pai
No caso acima, eu instanciei uma nova pessoa.
Na próxima linha, eu disse que o tipo Pessoa = PessoaJuridica().
Isso acontece pq a *classe filha tem tudo que a classe pai tem.*
✔️ Ou seja, PessoaJuridica tem Nome e CNPJ, sendo o Nome uma variável semelhante tb do tipo Pessoa.
✔️ SÓ FUNCIONA DE CLASSE FILHA PARA PAI.
![[Pasted image 20240611145711.png]]
![[Pasted image 20240611145727.png]]
✔️**Downcast**: 
Nesse caso é o contrário, quero que PessoaFisica (classe filha) seja instanciada por meio de Pessoa (classe pai).
✔️ Para isso, usamos o CASTING EXPLÍCITO - *verificar curso fundamentos c#* 
Fazendo o casting explicito, consigo fazer o downcast.
✔️ SÓ FUNCIONA DE CLASSE FILHA PARA PAI.
![[Pasted image 20240611150603.png]]

#### 👾Comparando objetos👾
✔️ ==  --> está comparando os endereços apenas, tipos de referência
✔️ Equals  ---> sempre usar o Equals para comparações de entidades
````
	var pessoaA = new Pessoa("Keo");
	var pessoaB = new Pessoa("Keo");
	
	Console.WriteLine(pessoaA == pessoaB);  
	// output false  
	// compara endereços/tipos de referências
	}
}
````

✔️ Implementando interface **IEquatable<>**

Nesse outro exemplo, eu vou comparar com Equals para comparar as entidades
````
	var pessoaA = new Pessoa(1, "Keo"); // coloquei msmo id
	var pessoaB = new Pessoa(1, "Keo");

	Console.WriteLine(pessoaA.id == pessoaB.id); // output true 
	Console.WriteLine(pessoaA.Equals(pessoaB));  // output true // usar essa
		// compara as entidades/objetos
	}
}

public class Pessoa : IEquatable<Pessoa>  // ctrl + . implementa a interface
{
	public Pessoa(int id, string nome) // add o id como atributo
	{
		Id = id;
		Nome = nome;
	}
}

// colocar uma prop de Id 
// verificar curso anterior
public int Id {get; set;}

public int Nome {get; set;}

	// implementando a interface
	public bool Equals(Pessoa pessoa)
	{
		return Id == pessoa.id	
	}
}
````

#### 👾Delegates👾 
Delego alguma coisa para alguém fazer.
✔️ Anonymous Methods
![[Pasted image 20240612175310.png]]

Neste outro exemplo, o delegate `AcaoDePagamento` representa um método que recebe um `double` (o valor do pagamento) e retorna `void`.
![[Pasted image 20240612173435.png]]
![[Pasted image 20240612173509.png]]
Neste exemplo, quando chamamos `meusPagamentos.Pagar(200.0, minhaConta.Sacar);`, estamos passando o método `Sacar` da `minhaConta` como um delegate para o método `Pagar`. Então, dentro do método `Pagar`, quando chamamos `acaoDePagamento(valor);`, estamos realmente chamando `minhaConta.Sacar(valor);`.

#### 👾Events👾 
✔️ Sempre vou usar Events + Delegates
![[Pasted image 20240612181944.png]]

#### 👾Generics👾
Tipos Genéricos
- Quero que uma classe salve no BD dados de classes diferentes
- O mesmo método pode salvar tipos diferentes
- ``<T>`` é assim que faz o generics
- Toda vez que eu for salvar o meu tipo, meu generics vai esperar que eu passe a classe
	```var context = DataContext<Person>();```
- WHERE
	- pode ser classes ou interfaces
	- serve para dizer que ali só pode ser para aquela classe/interface
	- só posso instanciar na ordem correta
	- limitação do que pode ser instanciado

#### 👾Listas👾
- Aceita qualquer tipo de lista em .net
- **Todas as listas são IEnumerable** , ou seja, são enumeradas
- O IEnumerable é o que mais restringe acesso a lista
- **WHERE**
	- busca/consulta na lista
	- traz uma lista
	- namespace **Linq** (Language Integrated Query)
	- requer uma expressão lambda onde x => x
	- == por ser uma expressão
- **FIRST**
	- busca/consulta na lista
	- traz um objeto
	- namespace **Linq** (Language Integrated Query)
	- requer uma expressão lambda onde x => x
	- == por ser uma expressão
	- FirstOrDefault se ele não encontrar o objeto, ele retorna null
	- First se ele não encontrar o objeto, ele retorna uma exceção
- **REMOVE**
- **ANY**
	- verifica se existe na lista
- **COUNT**
- **SKIP**
	- pula um item que eu passar
- **TAKE**
	- pega uma qtde de itens que eu passar
- Skip e Take são usados para paginação de dados

# Mão na massa

- Cada pasta do projeto é chamada de CONTEXTO
- Concentrar o que for comum em uma classe para que as outras herdem dela
- Fazer a herança nas classes filhas
- Crie uma instância em Program para ver se funcionou
- Se eu usar ID, ao invés de ser um "int", usar GUID
- Criar um método construtor (ctor) na classe pai 
	- Id = Guid.NewGuid();
	- indica o SPOF (single point of failure) --> para menos pontos de falha
- Marcar a classe pai como ABSTRACT
	- pq não faz sentido instanciá-la já que as classes filhas que tem o conteúdo
- Começar as características de cada classe (as especificidades)
- Não tem problema se uma das classes/interfaces vazia, que podem ser usadas só para agrupar objetos
- Sempre inicializar os modulos no construtor quando eu usar um objeto dentro de outro objeto
- PESQUISAR ARRAY != LIST
