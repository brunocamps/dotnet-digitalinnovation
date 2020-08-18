namespace Metodos.Metodos
{
    public class Ref
    {
        static void Inverter(ref int x, ref int y) //recebe x e y por referencia, e nao por valor
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public static void Inverter()
        {
            int i = 1, j = 2;
            Inverter(ref i, ref j);
            System.Console.WriteLine($"{i} {j}");  //escreve 1 e 2
        }
    }
}