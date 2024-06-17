using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            // instanciando meu DataContext com o tipo Person            
            var context = new DataContext<Person>();
            context.Save(new Person());

            var context2 = new DataContext<Person, Payments, Subscription>();
            context2.Save(new Person(), new Payments(), new Subscription());
            // passando a instancia na ordem correta

        }

        //o <x> é o tipo genérico
        // recomendado usar uma letra só para cada entidade
        public class DataContext<PE, PY, SB> 
            where PE : Person  // só aceita que eu mande um tipo que seja Person
            where PY : Payments  // preciso passar a instancia na ordem correta
            where SB : Subscription  // serve para classes e interfaces
        {
            public void Save(PE entity) { } 
            public void Save(PY entity) { }
            public void Save(SB entity) { }

        }

        public class Person { } // entidades
        public class Payments { }	
        public class Subscription { }
       
    }
}