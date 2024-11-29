using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using static GRUPO01_EF_ESTDAT_UPN.Nodo;

namespace GRUPO01_EF_ESTDAT_UPN
{
    internal class GrafoTransferencias
    {
        public List<NodoGrafo> Nodos { get; set; } = new List<NodoGrafo>();

        public NodoGrafo AgregarNodo(string departamento)
        {
            var nodo = new NodoGrafo(departamento);
            Nodos.Add(nodo);
            return nodo;
        }

        public void AgregarArista(NodoGrafo origen, NodoGrafo destino, int peso)
        {
            if (!origen.Conexiones.ContainsKey(destino))
            {
                origen.Conexiones.Add(destino, peso);
            }
        }
    }
}

