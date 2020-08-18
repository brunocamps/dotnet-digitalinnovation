namespace Metodos.Inheritance
{
    public class Ponto3D : Ponto //herda da classe ponto
    { //precisa declarar construtor para tirar o erro

        public int z;

         public Ponto3D( int x, int y, int z) : base(x, y) //passa para base o x e y
         {
             this.z = z;
             CalcularDistancia(); //chama o metodo
             
         }

         public static void Calcular()
         {
             //alguma coisa
         }

         public override void CalcularDistancia3() //virtual na classe pai
         {
             base.CalcularDistancia3();

         }
        
    }
}