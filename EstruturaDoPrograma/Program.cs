using System;
using EstruturaDoPrograma.Exemplos;

namespace EstruturaDoPrograma
{
    class Program
    {
        static void Main()
        {
            var s = new Pilha();


            //Adiciona 3 items
            s.Empilha(1);
            s.Empilha(100);
            s.Empilha(2000);

            //Retira 3 items
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
           // Console.WriteLine(s.Desempilha()); exception
            
        }
    }
}
