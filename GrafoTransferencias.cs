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
        public List<NodoGrafo> Nodos { get; set; } = new List<NodoGrafo>();// Lista de nodos

        public NodoGrafo AgregarNodo(string departamento)// Agregar nodo
        {
            var nodo = new NodoGrafo(departamento);// Crea un nuevo nodo
            Nodos.Add(nodo);// Agrega el nodo a la lista
            return nodo;// Retorna el nodo
        }

        public void AgregarArista(NodoGrafo origen, NodoGrafo destino, int peso)
        {
            if (!origen.Conexiones.ContainsKey(destino))// Si no existe la conexión
            {
                origen.Conexiones.Add(destino, peso);// Agrega la conexión
            }
        }
    }
}

