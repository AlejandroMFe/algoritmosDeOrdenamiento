using System;
using System.Collections.Generic;

namespace algoritmosDeOrdenamiento
{
    public class Nodo
    {
        public int Valor { get; set; }
        public Nodo Izquierda { get; set; }
        public Nodo Derecha { get; set; }
    }

    public class ArbolBinario
    {
        public Nodo Raiz { get; set; }

        public void AgregarNodo(int valor)
        {
            // Creo un nodo con el valor recibido
            var nuevoNodo = new Nodo() { Valor = valor };

            // Creo el nodo Raiz
            if (Raiz is null)
            {
                Raiz = nuevoNodo;
                return;
            }
            else
                Inserta(Raiz, nuevoNodo);
        }

        private void Inserta(Nodo nodo, Nodo nuevoNodo)
        {
            if (nodo.Valor < nuevoNodo.Valor)
            {
                if (nodo.Derecha is null)
                {
                    // Inserta el nuevoNodo a la derecha
                    nodo.Derecha = nuevoNodo;
                    return;
                }
                else
                    Inserta(nodo.Derecha, nuevoNodo);
            }
            else
            {
                if (nodo.Izquierda is null)
                {
                    // Inserta el nuevoNodo a la izquierda
                    nodo.Izquierda = nuevoNodo;
                    return;
                }
                else
                    Inserta(nodo.Izquierda, nuevoNodo);
            }
            return;
        }
    }
}
