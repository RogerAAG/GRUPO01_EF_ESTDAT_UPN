using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GRUPO01_EF_ESTDAT_UPN.Nodo;


namespace GRUPO01_EF_ESTDAT_UPN
{
    internal class ColaLlamadas
    {
        public NodoColaLlamadas ini, fin;//Punteros para el inicio y fin de la cola
        //Constructor
        public ColaLlamadas()
        {
            ini = null;//El inicio apunta null
            fin = null;//El fin apunta null
        }
        //AGREGAR LLAMADAS
        public void AgregarLlamada(string Telefono_Cliente, string Cliente, string Tipo_Cliente, DateTime HoraLlamada)
        {
            NodoColaLlamadas nuevo = new NodoColaLlamadas//Nuevo nodo de llamada
            {
                Telefono_Cliente = Telefono_Cliente,
                Cliente = Cliente,
                Tipo_Cliente = Tipo_Cliente,
                HoraLlamada = HoraLlamada,
                sig = null//El nuevo nodo es el último, por lo que no apunta a nadie
            };

            if (ini == null)//Si la cola está vacía
            {
                ini = nuevo;//El nuevo nodo es el primero
                fin = nuevo;//El nuevo nodo es el último
            }
            else
            {
                fin.sig = nuevo;//El último nodo actual apunta al nuevo nodo
                fin = nuevo;//El nuevo nodo es el último
            }
        }
        //ATENDER LLAMADAS
        public NodoColaLlamadas AtenderLlamada()
        {
            // Verificar si la cola está vacía
            if (ini == null)
            {
                MessageBox.Show("No Hay Llamadas por Atender!!!");
                return null; // No hay llamadas en la cola
            }
            // Guardar el nodo que será atendido
            NodoColaLlamadas nodoAtendido = ini;
            // Actualizar el frente para que apunte al siguiente nodo
            ini = ini.sig;
            // Si la cola queda vacía después de atender, también actualiza el fondo
            if (ini == null)
            {
                fin = null;
            }
            // Retornar el nodo atendido
            return nodoAtendido;//Retorna el nodo atendido
        }
        public void Vaciar()//Vacia la cola
        {
            ini = null;//El inicio apunta a null
            fin = null;//El fin apunta a null
        }
        public List<NodoColaLlamadas> ObtenerLlamadas()//Obtiene las llamadas de la cola
        {
            List<NodoColaLlamadas> llamadas = new List<NodoColaLlamadas>();//Lista de llamadas
            NodoColaLlamadas actual = ini;//Nodo actual es el inicio

            while (actual != null)//Mientras el nodo actual no sea null
            {
                llamadas.Add(actual);//Agrega el nodo actual a la lista
                actual = actual.sig;//El nodo actual apunta al siguiente
            }

            return llamadas;//Retorna la lista de llamadas
        }
        public bool EstaVacia()//Verifica si la cola está vacía
        {
            return ini == null;//Retorna true si el inicio es null
        }
    }
}
