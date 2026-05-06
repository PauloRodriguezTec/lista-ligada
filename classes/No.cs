using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lista_ligada.classes
{
    // Implementação da classe No em C#
    public class No
    {
        private No proximo;   // aponta para o próximo No da Lista
        private object elemento; // armazena o elemento de cada No

        // Construtor da classe No
        public No(object elemento, No proximo)
        {
            this.elemento = elemento;
            this.proximo = proximo;
        }

        // Método que altera o próximo No da Lista
        public void SetProximo(No proximo)
        {
            this.proximo = proximo;
        }

        // Método que retorna o próximo No da Lista
        public No GetProximo()
        {
            return proximo;
        }

        // Método para alterar o elemento
        public void SetElemento(object elemento)
        {
            this.elemento = elemento;
        }

        // Método que retorna o objeto contido no No
        public object GetElemento()
        {
            return elemento;
        }
    }
}