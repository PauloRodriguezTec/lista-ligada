using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lista_ligada.classes
{
    // Implementação da classe Lista em C#
    public class Lista
    {
        private No inicio;

        // Construtor da classe Lista inicializada vazia
        public Lista()
        {
            this.inicio = null;
        }

        // Método para inserir no início
        public void InsereInicio(object elemento)
        {
            No novoNo = new No(elemento, null); // passo 1
            novoNo.SetProximo(this.inicio);       // passo 2
            this.inicio = novoNo;               // passo 3
        }

        // Método para remover do início
        public object RemoveInicio()
        {
            if (this.inicio == null)
            {
                throw new InvalidOperationException("A lista está vazia.");
            }

            No auxiliar = this.inicio;          // passo 1
            this.inicio = auxiliar.GetProximo();     // passo 2
            return auxiliar.GetElemento();           // passo 3
        }
    }

}