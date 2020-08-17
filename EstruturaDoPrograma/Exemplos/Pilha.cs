using System;

namespace EstruturaDoPrograma.Exemplos
{
    public class Pilha
    {
        Posicao primeiro; //cria objeto primeiro a partir de classe Posicao
        public void Empilha(object item) //funcao Empilha: 
        {
            primeiro = new Posicao(primeiro, item);
        }

        public object Desempilha()
        {
            if (primeiro == null) 
            {
                throw new InvalidOperationException("A pilha está vazia!");
            }

            object resultado = primeiro.item;
            primeiro = primeiro.proximo;
            return resultado;
        }

        class Posicao
        {
            // Dois argumentos para o objeto:
            public Posicao proximo;
            public object item;

            public Posicao(Posicao proximo, object item)
            {
                this.proximo = proximo;
                this.item = item;
            }
        }

    }
}