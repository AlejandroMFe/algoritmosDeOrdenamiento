using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritmosDeOrdenamiento
{
    internal interface IArbolBinario
    {
        public int Valor { get; set; }
        public int Izquierda { get; set; }
        public int Derecha { get; set; }
        public int Grado { get; set; }
        public bool ExisteRaiz { get; set; }
        public void Cargar(int valor);
        public void Imprimir();

    }
}
