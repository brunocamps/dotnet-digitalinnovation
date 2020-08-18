using System;
using Metodos.Inheritance; //utiliza classes do namespace Inheritance

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciar objetos
            Ponto p1 = new Ponto(10, 20);

            //ver quais variaveis tera acesso
            Ponto p2 = new Ponto3D(10, 20, 30);

            Ponto3D.Calcular(); //metodo estatico. Pertence a classe, e nao a instancia



            Console.WriteLine("Hello World!");
        }
    }
}
