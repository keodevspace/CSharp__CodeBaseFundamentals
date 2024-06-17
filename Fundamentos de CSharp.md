Linguagem de Programação é um intermediário entre linguagem humana e linguagem binária. Esse processo de tradução se chama <mark class="hltr-purple">COMPILAÇÃO</mark>. Cada compilador trabalha de forma diferente e tem suas características.

#### Alto e Baixo Nível

Nível de máquina: instrução de baixo nível. Quanto mais detalhada a necessidade, mais baixo o nível da linguagem (binário). 
Ex: Assembly.

Linguagem de Alto Nível: favorece mais o desenvolvedor. 
Ex: C#. Trade off: não temos tanto controle como no Assembly.


#### Compilada e Interpretada

Linguagem Compilada: quando existe o processo de compilação de uma linguagem humana para uma linguagem binária. 

- Prós: <mark class="hltr-purple">vemos os erros quando o programa está sendo compilado</mark> (antes de ser executado), detectando rapidamente possíveis bugs. Gera apenas um arquivo final, compactado e binário.
- Contra: <mark class="hltr-purple">precisa de um compilador</mark> (transforma o código numa linguagem de baixo nívvel), sendo mais burocrática.

Linguagem Interpretada: são arquivos de textos puros lidos e interpretados em tempo de execução. Ex: JS. 

No caso do JS, o navegador é escrito e uma linguagem de alto nível que executa um arquivo de texto. Em tempo real ele vai interpretando o texto.

- Prós: não existe tempo de compilação, <mark class="hltr-purple">atualiza quando interpretada pelo browser</mark>. São mais fáceis de serem distribuídas. Ex: Node.
- Contra (Trade Offs): detecção de <mark class="hltr-purple">erros somente em tempo de execução</mark>. A <mark class="hltr-purple">aplicação fica maior</mark>, por não ter binários.


👾 Tipagem de dados 👾

Linguagem que obriga a informar o tipo de informação dentro da aplicação. Traz menos liberdade e maior otimização (ele sabe o que deve alocar e onde). O tipo de dado define o formato desse dado.

int idade = 18; // ok
int idade = "18" // error

A tipagem padroniza os dados para o desenvolvedor e para o processador/memória. Ex: o let utiliza sempre o mesmo tamanho de alocação. Se tiparmos, otimizamos essa alocaçõ.

int = 32-bit
float = 32-bit 
double = 64-bit 
decimal = 128-bit 


👾 Definições do C# 👾

LP tipada, compilada e gerenciada. Criada em meados de 2001. Principal linguagem da Microsoft.

Vantagens:
✔️ Linguagem completa
✔️ Maturidade
✔️ Grande mercado entrerprise
✔️ Grande comunidade
✔️ Muita aplicabilidade
✔️ Microsoft por trás
✔️ Orientação à Objetos

Agora é a hora de parar e aprender o básico bem prendido.


👾 Código Gerenciado 👾

Significa que a execução depende de um gerenciador, um runtime. No C# esse runtime se chama CLR ou CLR Runtime (Common Language ou Gerenciador de Linguagem). Gerencia memória, segurança e outros recursos básicos.

Em C/C++ alocamos memória manualmente (tela azul do Windows, pq um programa tentou acessar um local na memória não alocado para ele). No C# isso acontece por trás dos panos com o CLR.


👾 Compilação e Gerenciamento 👾

Ecossistema de linguagens da Microsoft (VB.NET, F#, Cobol.NET, C#) possui compiladores separados para cada LP. Porém, para unificar o gerenciamento dessas LPs, foi crida a compilação inicial que gera um código intermediário, chamado de IL (Intermediate Language), semelhante para todas as LPs da Microsoft. Quando compilamos um código C#, ele é transformado em IL, o que permite que um único gerenciador gerencie essas LPs para depois transformár o código em binário.


👾 IL - Intermediate Language 👾

Embora as compilações sejam diferentes, o gerenciador, a alocação na memória e execução deinstruções no processador são os mesmo para todas as LPs. 

C# ---> IL ---> binário

O CRL recebe um código e compila ele para IL. Então, arquivos C# e Cobol.NET poderiam existir no mesmo projeto, mas nunca no mesmo arquivo. O resultado da compilação do IL é sempre o mesmo.


👾 Frameworks 👾

Conjunto de bibliotecas usada como base para construir aplicações.

.NET Framework: v4.x, side by side, legado
.NET Core: v3.1, side by side, Linux, Mac, totalmente reescrito, retrocompatibilidade
.NET Standart: garante que ambos coexistem, podem ser instalados juntos e usados no mesmo projeto.
.NET 8: versão atual

LTS: long time support

Releases: https://dotnet.microsoft.com/pt-br/platform/support/policy/dotnet-core#lifecycle


👾 Versionamento 👾

✔️ Alpha: está longe de acabar, muitas mudanças
✔️ Beta: versão de testes, mas com ideia das estrutura
✔️ Realese Candidate: provavel ser a final
✔️ Final

As versões são divididas em 3 partes:
✔️ Major: incompativel versões anteriores, Breaking Changes
✔️ Minor: compatível com versões anteriores, Backward Compatibility
✔️ Patch: correção de bugs e itens simples


👾 Runtime e SDK 👾

Runtime é necessário para executar as aplicações.
Possui versões e tem que ser compatível com a versão utilizada durante a codificação.
Usado para distribuir as aplicações, ou seja, apenas executa e é otimizado para execução.
✔️ ASP.NET = web
✔️ Desktop = Desktop
✔️ .NET Core = qq aplicação (console, batch, serviço, não tem interface)

SDK é o kit de desenvolvimento de software que tem tudo que precisa para criar aplicações e já vem com o Runtime integrado. Não pode usar em produção.


👾 C# - Escopo de um Programação  👾

Importações - using
Namespace - divisões lógicas
Classe - tudo que vai ser executado, Program.cs
Método Principal - main 


👾 Namespace 👾

Pastas são divisões físicas e o Namespace são as divisões lógicas. 
Não podemos ter a mesma classe com o mesmo nome em um Namespace. Mas, se estiver em Namespaces diferentes, podem ter o mesmo nome. O ideal é ter 1 namespace e uma classe por arquivo. 
O escopo de um namespace é definido por {}.

Namespace M > Program
Namespace M.test > Program

Se for usar o namespace dentro do outro, para importar, tem que usar using para usar a classe no outro namespace.

Durante a execução, todos os arquivos serão unificados perdendo a dvisão física, e somente a divisão lógica permanecerá, que são os namespaces.


👾 Using 👾

As importações definem as bibliotecas que serão usadas, pq por padrão, só o básico vem incluso.
Precisa importar o que deseja para codar e isso é feito usando a palavra USING. Pode usar a criação de arquivos e namespaces o quanto precisar, para a organização do projeto.


👾 Variáveis e Constantes 👾

Instanciar uma variável = criar uma variável
O tipo vem antes do nome da variável.
Int, Double, Decimal sem valor = inicia com Zero

VAR: 1a letra SEMPRE minúscula.
CONST: todas em maiúsculas e separadas por _


👾 Tipos primitivos 👾

Definir o tipo correto otimiza a execução do programa. Também chamados de TIPOS DE VALOR.
Armazena o valor e não a referência para um item na memória.

✔️ Simple Types 
✔️ Enums
✔️ Structs (dados)
✔️ Nullable Types

Cada tipo primitivo tem uma capacidade.


System
todos os tipos derivam do system
no .net 8 não usa mais

Byte
primitivo
é um byte de fato
sbyte é signed, negatibo

Numeros Inteiros
short/unshort - 16-byt
int/uint - 32-bit
long/ulong - 64-bit

Numeros Reais
float - notação F - 32bit
decimal - 64bit
double - notação M - 128bit

Bool
true e false - 8bit

Char
armazenar apenas um caractere Unicode
Atribuição ' '
16bits

String
Cadeia de caracteres (lista de char)
Atribuição " "

Var
substitui o nome de qq tipo
será do tipo do primeiro valor atrib

Object
tipo generico que recebe qualquer valor ou objeto. Caso nçao saiba o tipo da informação ou ela seja de vários tipos diferentes.
Não possui intelisense
Evitar usar

Nullable
definição de tipo vazio, nada
Void: definição de retono vazio ou nada
!= 0 ou string=""
Todo tipo pode receber null
O tipo deve ser marcado como Nullable Type =  ou ? null

Alias
String = tipo
string = alias
int e Int32

Valores Padrões
Os tipos primitivos (built-in) vem com um valor padrão
Nunca são nulos.
int = 0
float = 0
decimal = 0
bool = false
char = '/0'
String = ""

Conversão Implícita
Possuem tipos e tamanho de dados compatíveis.
float valor = 25.8F;
int outro = 25;
valor = outro; // conv imp
o contrário não poderia acontecer, pq o 25.8 não é numero inteiro

Conversão Explícita
Quando os tipos não são compatíveis
Tem que informar obrigatoriamente o tipo que estamos convertendo.
Uso do tipo entre ().
int inteiro = 100;
uint inteiroSemSInal = (uint)inteiro

Parse
Os tipos primitivos tem uma estensão chamada Parse. Essa função tenta converter um tipo para outro. Só que no caso do Parse, ele sempre espera uma string.
int inteiro = int.Parse("100")
Não consigo ver isso em tempo de debug

Convert
É uma classe (obj) que permite converter vários tipos de valor, não apenas string.
Não é um estensão igual o Parse.
Devemos informar o tipo na chamada da conversão.
int inteiro = Convert.ToInt32("100")
Não consigo ver isso em tempo de debug

Convertendo Tipos
.ToString() = metodo de objetos
.ToInt32()

#### Operador de Comparação

Retorno é <mark class="hltr-purple">true</mark> ou<mark class="hltr-purple"> false</mark>.

````
int x = 25;
x == 0 // false
x != 0 // true
x > 0 // true
x < 0 // false
x <= 0 // false
x >= 0 // true
`````
#### Operadores Lógicos

- Usados em operações condicionais.
- Retorno é <mark class="hltr-purple">true</mark> e <mark class="hltr-purple">false</mark>.

<mark class="hltr-purple">&&</mark> - deve atender todas as condições
<mark class="hltr-purple">||</mark> - se atender a uma condição, já retorna true
<mark class="hltr-purple">!</mark> - não, negação

````
int x = 12;

bool e = (x > 25) && (x < 40); // false

bool ou = (x > 25) || (x < 40); // true

bool negacao = !(x < 25); //false

````

#### If

Caso <mark class="hltr-purple">alguma condição</mark> seja atendida.

````
if (condicao) //verdadeira
// se for só 1 linha não precisa de {}


if (condicao) {
...
} else // se for falso


if (condicao) {
...
} else if (condicao) { 
// senão, teste esse caso
} else if ...{
...
} else
````

#### Switch

- Chaveamento
- Quando tem <mark class="hltr-purple">mtas decisões</mark>
- Executa em cascata
- Parada manual com <mark class="hltr-purple">break</mark>
- Possui execução default

````
int valor = 1;
switch (valor);
{
	case 1: Console.WriteLine("1"); break
	case 2: Console.WriteLine("2"); break
	case 3: Console.WriteLine ("3"); break;
	default: Console.WriteLine(4"); break;
}
`````

#### Laços de Repetição
##### For
- "Para" cada item em um valor...
- <mark class="hltr-purple">Executa ação várias vezes</mark>
- Definido pela palavra reservada "for"
- Exige 3 parâmetros:
	- contador
	- condição
	- incremento

````
for (var i = 0; i <= 5; i++)
// conta de 0 a 5

for (var i = 0; i <= 5; i--)
// conta de 5 a 0
````
##### While
- <mark class="hltr-purple">Enquanto</mark> uma condição for verdadeira...
- Exige apenas uma condição
- Checa a condição <mark class="hltr-purple">antes</mark> de executar.

````
while (valor <= 5)
{
	Console.WriteLine(valor)
	valor++
}
````

##### Do While
- Realize uma ação enquanto...
- Exige apenas uma condição
- Checa a condição <mark class="hltr-purple">depois</mark> de executar.

````
do
{
	Console.WriteLine(valor);
	valor++
} 
while (valor < 5)
````



#### Funções ou Métodos

- <mark class="hltr-purple">Main</mark> é um exemplo de <mark class="hltr-purple">método</mark>
- Possui
	- um retorno ou não
	- um nome
	- parâmetros
- Esta composição é a camada de assinatura
- Começa sempre com <mark class="hltr-purple">Maiúscula</mark>

````
static void MeuMetodo (string parametro)
{
Console.WriteLine(parametro)
} 


Class Program
{
	static voide Main (string[] args)
	{
		MeuMetodo();
		RetornaNome()
	}

	static void MeuMetodo()
	{
		Console.WriteLine("C# é dahora!)
	}


	static string RetornaNome(
		string nome, 
		string sobrenome
		)
			{
				return nome + "" + sobrenome;
			} 
````

#### Value Types e Reference Types

- A memória é dividida em duas partes
	- <mark class="hltr-purple">Heap</mark>: armazena <mark class="hltr-purple">dados</mark>
	- <mark class="hltr-purple">Stack</mark>: armazena as <mark class="hltr-purple">referências para os dados</mark>
- Qualquer tipo no .NET é tratado como
	- Reference Type
	- Value Type
##### Value Types
- <mark class="hltr-purple">Tipos de valor armazenam dados</mark>
- São armazenados no Stack
- Quando armazenamos um valor, a <mark class="hltr-purple">memória é alocada</mark>
- Este espaço armazena o dado criado
- Nossa <mark class="hltr-purple">variável acessa</mark> este dado <mark class="hltr-purple">diretamente</mark>
- Se assimilarmos uma variável do tipo valor a outra:
	- o valor será *<mark class="hltr-purple">copiado</mark>
	- ambas serão independentes
-<mark class="hltr-purple"> Built-in</mark>, <mark class="hltr-purple">Structs</mark>, <mark class="hltr-purple">Enums</mark>
- Garbage Collector não acessa o Stack
	- garbage colletor otimiza nosso programa deletando algo que não está sendo

````
int x = 25;

int y = x; // Y é uma cópia de X

Console.WriteLine(x); // 25

Console.WriteLine(y); // 25

x = 32; // Somente X foi alterado

Console.WriteLine(x); // 32

Console.WriteLine(y); // 25
````

##### Reference Types
- Armazenam o <mark class="hltr-purple">endereço do objeto que contém os dados</mark>
- Não armazena os dados em si
- São armazenados em um local da memória chamado de Heap
- Ao assimilar uma variável
	- Criará uma referência
	- Aponta para a mesma informação
	- Não são independentes
- Quando não mais utilizados são marcados para exclusão
- Garbage Collector passa removendo todos eles
- <mark class="hltr-purple">Classes</mark>, <mark class="hltr-purple">Objects</mark>, <mark class="hltr-purple">Arrays</mark>…

````
var arr = new string[2];

arr[0] = "Item 1";

var arr2 = arr; // Não cria uma cópia

Console.WriteLine(arr[0]);

Console.WriteLine(arr2[0]);

// Altera as duas listas

arr[0] = "Item Alterado";

Console.WriteLine(arr[0]);

Console.WriteLine(arr2[0]);
````

#### Structs

- <mark class="hltr-purple">Tipo de dado estruturado</mark>
- Apenas a estrutura
- <mark class="hltr-purple">Tipo de valor</mark>
- Armazenam apenas outros tipos de dados
- Composto por propriedades e métodos
- Propriedade sempre em <mark class="hltr-purple">Maiúsculo</mark>
- Parâmetro sempre em <mark class="hltr-purple">minúsculo</mark>
- Instanciado a partir de <mark class="hltr-purple">new</mark>
	- Nesse momento sim temos os valores
- Geralmente usa o <mark class="hltr-purple">Id</mark>
- Struct não é função, então não pode ficar dentro do Main. Tem que estar <mark class="hltr-purple">fora de classe e de função</mark>.

````
struct Product 
{
	// propriedades
	public int Id;
	public float Price;
	
	// métodos
	public float PriceDolar (float dolar)
	{
		return Price * dolar;
	}
}
````


- Para criar a <mark class="hltr-purple">estrutura</mark>
````
static voide Main (string [] args)
{
	// instancia a estrutura
	var product = new Product();
}

// outro exemplo
var product = new Product();

product.Id = 1;

product.Title = "Mouse gamer";

product.Price = 197.23f;

Console.WriteLine(product.Id);

Console.WriteLine(product.Title);

Console.WriteLine(product.Price);
````


- <mark class="hltr-purple">Método construtor</mark>
	- executado sempre que o struct é criado
	- toda vez que eu der um <mark class="hltr-purple">new</mark> instanciando a estrutura, esse método vai ser chamado
	
````
namespace MeuApp
{
	class Program...

	struct Product
	
	{
	    public Product(int id, string title, float price)
	
	    {
	        Id = id;
	
	        Title = title;
	
	        Price = price;
	    }
	}
}
````


- Facilita a criação de estruturas
````
var product = new Product(1, "Mouse Gamer", 128.75f);

Console.WriteLine(product.Id);

Console.WriteLine(product.Title);

Console.WriteLine(product.Price);

Console.WriteLine(product.PriceInDolar(5.70f));
````

#### Enums
- Usado para fornecer uma melhor visualização do código
- <mark class="hltr-purple">Substituem o uso de inteiros</mark>
- Usados em <mark class="hltr-purple">listas curtas</mark>
- Usados em <mark class="hltr-purple">dados fixos</mark>
- Hard Coded
- Sempre em <mark class="hltr-purple">Maiúsculo</mark>
- Começar com a letra <mark class="hltr-purple">E</mark>

````
enum EEstadoCivil

{
    Solteiro = 1,

    Casado = 2,

    Divorciado = 3
}

struct Cliente

{
    public string Nome;

    public EEstadoCivil EstadoCivil;
}

// Sem enumeradores
// var cliente = new Cliente("João Silva", 1);

  
// Com enumerador

var cliente = new Cliente("João Silva", EEstadoCivil.Casado);
````

#### String
##### Guid
- Global Unic Identifier
- Chance do Id se repetir é pequena
- ![[Pasted image 20240524201235.png]]
- var id = Guid.NewGuid(); Console.WriteLine(id.ToString().Substring(0, 8));
- ![[Pasted image 20240524201838.png]]
- Valor randômico
- 36 caracteres
##### Interpolação de strings
- var texto = string.Format("O conteúdo {0} vai ali", 0)  --- nesse caso pega o índice
- $"O conteúdo é {variável} aí dentro."
- @ se tiver quebra de texto
##### Comparação de strings
- CompareTo  e  Contains
- <mark class="hltr-purple">CompareTo</mark> faz a comparação com qualquer objeto que passar como parâmetro. Vai retornar 0 ou 1
- ![[Pasted image 20240524203126.png]]
- <mark class="hltr-purple">Contains</mark> retorna true ou false
- <mark class="hltr-purple">StringComparison.OrdinallIgnoreCase</mark> para ignorar o case sensitive
- Não tem como o valor ser null
##### StartsWith e EndsWith
- Retorna <mark class="hltr-purple">true</mark> ou <mark class="hltr-purple">false</mark>
##### Equals
- Tem que ser exatamente igual
- Dá pra ignorar o case sensitive
- serve para qualquer tipo de objeto
##### Indice
- Indica a posição de um item/caractere
- Posição onde está no array
- <mark class="hltr-purple">IndexOf</mark>
- Tem que ser o mesmo tipo
- Retorna a posição do item
- <mark class="hltr-purple">LastIndexOf</mark>
##### Métodos Adicionais
- <mark class="hltr-purple">ToLower</mark> converte a string para minúscula
- <mark class="hltr-purple">ToUpper</mark> converte a string para maiúscula
- <mark class="hltr-purple">Insert</mark> inseri o texto no índice que desejar .Insert (5, "aqui")
- <mark class="hltr-purple">Remove</mark> remove o texto e a quantidade de texto .Remove (5,5)
##### Manipulando Strings
- <mark class="hltr-purple">.Replace</mark> vai pedir o caractere antigo e o nome ("antigo", "novo")
- <mark class="hltr-purple">.Split</mark> divide o texto
	- ![[Pasted image 20240524205335.png]]
- <mark class="hltr-purple"> .Substring</mark> ele pega a palavra ou item por indice
	- ![[Pasted image 20240524205523.png]]
	- ![[Pasted image 20240524205620.png]]
- <mark class="hltr-purple">.Trim</mark> o trim remove espaço
##### StringBuilder
- Quando o texto tem muitas linhas/muito grande
- O texto += seria muito usado sobrecarregando a memória
- <mark class="hltr-purple">using System.Text
  var texto = new StringBuilder()
  texto.Append("Outra linha")
  texto.Append("Outra linha")
  texto.Append("Outra linha")</mark>
- é um construtor
- Ele retorna o texto como uma string
- Usar ToString() se eu quiser o valor gerado
#### Datas
- <mark class="hltr-purple">DateTime</mark> é um tipo struct, primitivo, inteiros
- Botão direito em cima do tipo, consigo ver as definições
- Eles <mark class="hltr-purple">sempre</mark> tem que ser <mark class="hltr-purple">inicializados</mark>
- Não existe null
- ![[Pasted image 20240525180717.png]]
- É uma propriedade get
###### Obter valores da data
- Se eu apertar setinha para baixo em DateTime:
- ![[Pasted image 20240525181039.png]]
- Passei ano, mês, dia... como o próprio c# explica no modal
- Posso obter as datas separadas:
- ![[Pasted image 20240525181222.png]]
###### Formatar as datas
- Y - year, M - mês, d - dia, h - hora, m - minuto, s - segundo, z - timezone
- ![[Pasted image 20240525181830.png]]
- var data = DataTime.Now;
  var formatada = String.Format("{0:dd-MM-YYYY hh:mm:ss z}, data);
###### Padrões de formatação de data
- ("{ 0:<mark class="hltr-purple">t</mark> }" , data ) -- short date time
- d -- só a data
- T -- tempo e data longa
- f -- combina data e hora longo
- s -- formato bd
- u -- formato json
###### Adiconar valores
- Sempre que eu precisar acrescentar algo, é melhor fazer com métodos da propriedade DateTime, pq, por exemplo, se eu quero acrescentar um dia com *var dia = data.Day + 1* podera acrescentar o 32º dia de um mês de 31 dias, ou acrescentar 31º dia de um mês de 30 dias. O recomendado então é usar os métodos que  o DataTime tem.
- .AddDay
- .AddMonth
- .AddYear
- Esses métodos não modificam as datas, eles acrescentam/subtraem sem modifcá-la
- Tem pra horas, segundos...
###### Comparando datas
- Não tem como comparar datas com o *if (data == DataTime.Now)* pq a data vai ter <mark class="hltr-purple">frações de segundo diferente</mark> do que a data de agora
- se eu usar o <mark class="hltr-purple">data.Date == DateTime.Now.Date</mark> vai funcionar, pq ele tá pegando só a data
- Então, não tem como comparar a estrutura como o todo, mas sim partes dela para comparar.
##### CultureInfo
- Localização e Globalização
- <mark class="hltr-purple">var pt = new System.Globalization.CultureInfo("pt-br")</mark>
- ou só CultureInfo(), usando o using no topo do arquivo
- Existem diversos tipos de cultura diferentes: procurar no google
- ![[Pasted image 20240525185317.png]]
- ![[Pasted image 20240525193002.png]]
- <mark class="hltr-purple">DataTime.Now.ToString("D", pt-br)</mark>
- para pegar a cultura da máquina: <mark class="hltr-purple">CultureInfo.CurrentCulture</mark>
##### Timezone
  - Nem sempre o servidor está no Brasil,<mark class="hltr-purple"> a aplicação pega a cultura da máquina</mark>
  - Como saber qual culture usar?
  - <mark class="hltr-purple">var utcDate = DateTime.UtcNow;</mark>
  - Sempre utilizar a data nesse valor por se tratar de aplicações globalizadas
  - <mark class="hltr-purple">Converter o utc globalizado para meu local</mark>
  - var utcDate = DateTime.UtcNow;
    // Console.WriteLine(DateTime.Now); 
    // Concole.WriteLine(utcDate);
    Console.WriteLine(utcDate.ToLocalTime()) 
- <mark class="hltr-purple">Convertendo para um timezone de outro local</mark>
- // pega a data do local
- var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById ( "Pacific/Auckland" );
- // converte o utc para a hora desse local
  var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc ( dateTime , timezoneAustralia );
- ![[Pasted image 20240525201705.png]]
###### Timespan
- Unidade de medida Universal
- Sempre inicia vazio 00:00:00
- Consegue trazer nanosegundos
- ![[Pasted image 20240525202609.png]]
- como parametro: h, m, s OU d, m, h, s
- Utilizado para cálculo aritmético de data/hora
##### Moedas
###### Formatando moedas
- Usa-se mais o *decimal* (usa o "m" no final)
- Importante passar a cultura de onde se está
- decimal valor = 10.25m;
  Console.WriteLine ( 
	  valor.ToString(
		  <mark class="hltr-purple">"G"</mark>, // valor generico		
		  CultureInfo.CreateSpecificCulture( "pt-BR" ) ));
		  
		  "C", // currence, o simbolo da moeda, R$
		  "E04", // nº muito grande, anexa +no final
		  "F",  // traz uma precisão maior na moeda
		  "N", // formata sem o simbolo de moeda
		  "P", // porcentagem
###### Math
- Math.Round() -- arrendonda
- Math.Ceiling() -- arrendonda pra cima
- Math.Floor() -- arredonda pra baixo
#### Arrays
- Multidimencional
- Abre e fecha colchetes
````
var meuArray = new int [5] // tamanho do array = 4
int[5] meuArray = new int // igual a linha de cima
int[5] meuArray = new int {1,2,3,4,5}

meuArray[0] = 12; // assimilação

Console.WriteLine ( meuArray [0] ); // passo o indice
Console.WriteLine ( meuArray [1] )
Console.WriteLine ( meuArray [2] )
Console.WriteLine ( meuArray [3] )
Console.WriteLine ( meuArray [4] ) // só até o 4
````

- Tem como fazer array de structs
  ![[Pasted image 20240525210008.png]] 
- Não se utiliza muito arrays em .net
- forEach (var item in myArray) { Console.WriteLibe(item)}
  ![[Pasted image 20240525210807.png]]
#### Exceptions
- Erros = Exceptions
- Tratamento de erros
- Toda ver que acontece uma exceção, ela para a execução do programa
##### Try/Catch
- Para amenizar a parada por exceção, podemos usar o try/catch
````
var arr = new int[3];

  try
  {
	  for (i = 0; i < 10; i++)
	  {
	  // System.IndexOutOfRangeException
	  Console.WriteLine(arr[i]);
	  }	
  } 
  catch (Exceptions ex)
  {
	  Console.WriteLine(ex.InnerException);
	  Console.WriteLine(ex.Message);
	  Console.WriteLine("Ops...algo deu errado");
  }
````
- Fazer o try/catch por blocos para conseguir encontrar onde está exatamente o erro
- <mark class="hltr-purple">ex.</mark> traz várias formas de ver o erro e sua mensagem
- o <mark class="hltr-purple">.InnerException</mark> e o <mark class="hltr-purple">.Message</mark> trazem a mensagem de forma mais clara sobre o que deu errado
- Dá pra fazer um <mark class="hltr-purple">log da aplicação</mark>
- Posso ter um catch embaixo do outro
- Se eu passar o <mark class="hltr-purple">tipo de erro como parâmetro no catch</mark> eu vou mostrar/tratar várias exceções para erros
  ![[Pasted image 20240525213437.png]]
- IndexOutOfRangeExceptions tem mais métodos
- Exceptions é o tipo base
- <mark class="hltr-purple">SEMPRE começar do mais específico para o mais genérico</mark>
##### Disparando exceções na execução de métodos
- Eu posso criar um método e quando eu chamar esse método, dentro dele pode ter uma estrutura que valida se tem erro e, se tiver, chama o catch de erro que eu já implementei
- Nesse caso, uso o <mark class="hltr-purple">throw</mark>
  ![[Pasted image 20240525214410.png]]
- Se o valor em Cadastrar for nulo, ele vai passar pelo meu if e depois pelo try/catch onde tem o Exception 
  ![[Pasted image 20240525214602.png]]
- Posso também colocar tipos específicos de exceção, mas o melhor é cadastrar ele lá em cima no catch, para ficar melhor a visualização
  ![[Pasted image 20240525214647.png]]
##### Custom Exceptions
- Posso criar classes para as exceções para customiza-las
- Posso inserir ela no catch lá em cima
![[Pasted image 20240525215039.png]]
![[Pasted image 20240525215125.png]]
##### Finally
- Quer dizer que passou por toda a execução e chegou ao fim
- Para fechar os arquivos que foram abertos no try/catch
- No final do catch
![[Pasted image 20240525215418.png]]
  


