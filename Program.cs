using System;
using System.Diagnostics;

namespace algoritmosDeOrdenamiento
{
    class Program
    {
        static void Main(string[] args)
        {

            var arreglo = new int[10];
            
            arreglo.Cargar(100);

            Console.WriteLine("Sin Ordenar");
            arreglo.Imprimir();

            Console.WriteLine("Ordenado por Burbuja");
            
            var watch = Stopwatch.StartNew();
            arreglo.OrdernarPorBurbuja();
            watch.Stop();
            arreglo.Imprimir();
            Console.WriteLine($"Cuanto tardo en ordenar? {watch.Elapsed}");           
        }

    }
}
