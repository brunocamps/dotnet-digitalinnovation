using System;

namespace Instrucoes
{
    class Program
    {
        static void Declaracoes()
        {
            int a;
            int b = 2, c = 3;
            const int d = 4; //constante (e nao variavel)
            a = 1;
            a = 2; //possibilidade de alterar, mesmo alterando acima
            Console.WriteLine(a + b +c + d);
        }

        // args passada nos metodos abaixo é apenas o nome da variavel
        static void InstrucaoIf(string[] args) //recebe um array de string (string[])
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Nenhum argumento");
            }
            else if (args.Length == 1)
            {
                Console.WriteLine("Um argumento");
            }
            else
            {
                Console.WriteLine($"{args.Length} argumentos");
            }
        }

        static void InstrucaoSwitch(string[] args) //recebe array de strings como argumento
        {
            int numeroDeArgumentos = args.Length;
            switch (numeroDeArgumentos)
            {
                case 0:
                    Console.WriteLine("Nenhum argumento");
                    break;
                case 1:
                    Console.WriteLine("Um argumento");
                    break;
                default:
                    Console.WriteLine($"{numeroDeArgumentos} argumentos");
                    break;
            }

        }

        static void InstrucaoWhile(string[] args) //iteracao
        {
            int i = 0;
            while(i < args.Length) //enquanto i menor que numero de argumentos que eu tenho
            {
                Console.WriteLine(args[i]); //posicao de i dentro do array
                i++;
            }

        }

        static void InstrucaoDo(string[] args)
        {
            string texto;
            do
            {
                texto = Console.ReadLine(); //lera o valor da tela
                Console.WriteLine(texto);
            } while(!string.IsNullOrEmpty(texto)); //enquanto texto nao for nulo ou vazio
            //exclamacao: negativa da instrucao
        }

        static void InstrucaoFor(string[] args)
        {
            for (int i = 0; i < args.Length; i++) //tres divisoes no For
            {
                Console.WriteLine(args[i]);
            }
        }

        static void InstrucaoForeach(string[] args) //for de forma mais tipada
        {
            foreach(string s in args) //trabalha diretamente com as string do meu array
            {
                Console.WriteLine(s);
            }
        }

        static void InstrucaoBreak(string[] args)
        {
            while (true)
            {
                string s = Console.ReadLine(); //lera o que o usuario inputar

                if (string.IsNullOrEmpty(s))
                    break;

                Console.WriteLine(s);
            }
        }
        
        static void InstrucaoContinue(string[] args)
        {
            for(int i = 0; i < args.Length; i++)
            {
                if (args[i].StartsWith("/"))
                {
                    continue;
                }
                Console.WriteLine(args[i]);
            }
        }

        static void InstrucaoReturn(string[] args) //metodo void nao retorna nada
        {
            int Somar(int a, int b) //metodo vai retornar valor inteiro
            {
                return a + b;
            }
            
            if (args.Length == 0) //se for 0, para a execucao do metodo
            {
                return;
            }

            Console.WriteLine(Somar(1, 2));
            Console.WriteLine(Somar(3, 4));
            Console.WriteLine(Somar(5, 6));
            return;
        }

        static void InstrucoesTryCatchFinallyThrow(string[] args)
        {
            double Dividir(double x, double y)
            {
                if (y == 0)
                    throw new DivideByZeroException();

                return x / y;
            }

            try
            {
                if(args.Length != 2)
                {
                    throw new InvalidOperationException("Informe 2 numeros");
                }

                double x = double.Parse(args[0]);
                double y = double.Parse(args[1]);
                Console.WriteLine(Dividir(x, y));

            }

            //podem-se ter multiplos catches
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine($"Erro generico: {e.Message}");
            }
            finally
            {
                Console.WriteLine("Ate breve!");

            }
        }

        static void InstrucaoUsing(string[] args)
        {
            // System.IO.TextWriter w;
            // w = System.IO.File.CreateText("teste.txt");

            using (System.IO.TextWriter w = System.IO.File.CreateText("teste.txt"))
            {
                w.WriteLine("Line 1");
                w.WriteLine("Line 2");
                w.WriteLine("Line 3");

                //ao terminar, exclui o objeto W da memoria

            }
        }







        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Exemplo de Array Unidimensional
            //O quê o bloco abaixo faz?
            int[] a = new int[10]; //10 posicoes

            for(int i = 0; i < a.Length; i++) //laco for enquanto i for menor que o tamanho
            {
                a[i] = i * i; //pega a na posicao i e preenche o valor com i vezes i
            }
            for (int i = 0; i < a.Length; i++) //outro laco for apenas para imprimir na tela
            {
                Console.WriteLine($"a[{i}] = {a[i]}"); 
            }

            Console.WriteLine("----------");

            int[,] a2 = new int[10, 5];

            int[,,] a3 = new int[10, 5, 2];

            //Inicializador de Array

            // int[] a = new int[] {1, 2, 3};

            // int[] a = {1, 2, 3};


            

        }
    }

}
