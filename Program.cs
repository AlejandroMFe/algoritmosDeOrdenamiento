using System;
using System.Collections.Generic;
using System.Linq;

namespace algoritmosDeOrdenamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
            //var arreglo = new int[10];

            //arreglo.Cargar(100);

            //Console.WriteLine("Sin Ordenar");
            //arreglo.Imprimir();

            //Console.WriteLine("Ordenado por Burbuja");

            //var watch = Stopwatch.StartNew();

            //arreglo.OrdernarPorBurbuja();
            //watch.Stop();
            //arreglo.Imprimir();
            //Console.WriteLine($"Cuanto tardo en ordenar? {watch.Elapsed}");           
            */

            var entrada = new int[10];
            entrada.Cargar(100);

            //Array.ForEach(entrada, e => Console.WriteLine(e));

            var arbol = new ArbolBinario();
            Array.ForEach(entrada, e => arbol.AgregarNodo(e));

            //arbol.Imprimir();

        }

    }
}
