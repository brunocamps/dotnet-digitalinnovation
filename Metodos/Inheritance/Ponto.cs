namespace Metodos.Inheritance
{
    public class Ponto
    {
        public int x, y; //em qualquer lugar do codigo onde instanciar o objeto ponto, terá acesso às variaveis publicas
        private int distancia;

        public Ponto(int x, int y) //construtor publico
        {
            this.x = x; //this é referencia à classe
            this.y = y; //alternativa é o underline (variaveis internas )
        }

        protected void CalcularDistancia()
        {
            CalcularDistancia2();
        }

        private void CalcularDistancia2() //so dentro pode ser utilizado
        {
            //something
        }

        public virtual void CalcularDistancia3()
        {
            //something

            //virtual permite que classe filho sobrescreva (override) a atuacao da classe pai
        }
    }
}