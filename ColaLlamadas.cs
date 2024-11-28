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
        public NodoColaLlamadas ini, fin;
        //Constructor
        public ColaLlamadas()
        {
            ini = null;
            fin = null;
        }
        //AGREGAR LLAMADAS
        public void AgregarLlamada(string Telefono_Cliente, string Cliente, string Tipo_Cliente, DateTime HoraLlamada)
        {
            NodoColaLlamadas nuevo = new NodoColaLlamadas
            {
                Telefono_Cliente = Telefono_Cliente,
                Cliente = Cliente,
                Tipo_Cliente = Tipo_Cliente,
                HoraLlamada = HoraLlamada,
                sig = null
            };

            if (ini == null)
            {
                ini = nuevo;
                fin = nuevo;
            }
            else
            {
                fin.sig = nuevo;
                fin = nuevo;
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
            return nodoAtendido;
        }
        public void Vaciar()
        {
            ini = null;
            fin = null;
        }
        public List<NodoColaLlamadas> ObtenerLlamadas()
        {
            List<NodoColaLlamadas> llamadas = new List<NodoColaLlamadas>();
            NodoColaLlamadas actual = ini;

            while (actual != null)
            {
                llamadas.Add(actual);
                actual = actual.sig;
            }

            return llamadas;
        }
        public bool EstaVacia()
        {
            return ini == null;
        }
    }
}
