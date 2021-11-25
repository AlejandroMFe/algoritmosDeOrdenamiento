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
        public List<Nodo> arbol { get; }
        public Nodo Raiz { get; set; }
        public ArbolBinario() => arbol = new List<Nodo>();

        public void AgregarNodo(int valor)
        {
            // Creo un nodo con el valor recibido
            var nuevoNodo = new Nodo() { Valor = valor };

            // Creo el nodo Raiz
            if (Raiz is null)
                Raiz = nuevoNodo;

            RecorrerNodos(Raiz, nuevoNodo);

        }

        private void RecorrerNodos(Nodo raiz, Nodo nuevoNodo)
        {
            
        }
    }
}
