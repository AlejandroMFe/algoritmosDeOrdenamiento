using System;

namespace algoritmosDeOrdenamiento
{
    public static class MyExtensions
    {
        /// <summary>
        /// Carga el arreglo con números del 1 al maxValue.
        /// </summary>
        /// <param name="arreglo"></param>
        /// <returns></returns>
        public static int[] Cargar(this int[] arreglo, int maxValue)
        {
            var rnd = new Random();

            for (int i = 0; i < arreglo.Length; i++)
            {
                var nro = rnd.Next(1, maxValue);
                arreglo[i] = nro;
            }

            return arreglo;
        }

        public static void Imprimir(this int[] arreglo)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine($"#-{i} valor: {arreglo[i]}");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Ordena el arreglo de menor a mayor, a través del algoritmo de Burbuja.
        /// </summary>
        /// <param name="arreglo"></param>
        /// <returns></returns>
        public static int[] OrdernarPorBurbuja(this int[] arreglo)
        {
            // Tamaño del arreglo.
            var dimension = arreglo.Length;

            // Recorre desde el inicio del arreglo
            for (int i = 0; i < dimension; i++)
            {
                // Recorre desde la posición siguiente: i + 1
                for (int x = i +1 ; x < dimension; x++)
                {
                    /**
                     arreglo[i] tendría que ser el menor valor
                     arreglo[x] es la posición sigueinte

                     Si arreglo[i] es Mayor que arreglo[x]?
                     Tengo que hacer el enrroque, para ordenar el arreglo.
                    */
                    if (arreglo[i] > arreglo[x])
                    {
                        // Enrroque
                        var aux = arreglo[i];     // Guardo el mayor valor
                        arreglo[i] = arreglo[x];  // Asigno el menor valor a la posición anterior
                        arreglo[x] = aux;         // Asigno el mayor valor a la posición siguiente
                    }
                }
            }

            return arreglo;
        }
    }
}
