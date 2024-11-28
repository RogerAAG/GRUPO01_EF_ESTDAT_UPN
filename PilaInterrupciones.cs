using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GRUPO01_EF_ESTDAT_UPN.Nodo;
using System.Windows.Forms;

namespace GRUPO01_EF_ESTDAT_UPN
{
    
    public class PilaInterrupciones
    {
        public NodoInterrupciones cima; // Nodo en la cima de la pila
        private DataGridView dgvPila; // DataGridView para mostrar la pila

        public PilaInterrupciones(DataGridView dgvPila)
        {
            this.dgvPila = dgvPila;
            cima = null;
        }

        // Método para agregar una llamada a la pila
        public void Push(string telefono, string cliente, string tipoCliente, DateTime horaLlamada)
        {
            NodoInterrupciones nuevoNodo = new NodoInterrupciones
            {
                Telefono = telefono,
                Cliente = cliente,
                TipoCliente = tipoCliente,
                HoraLlamada = horaLlamada,
                Siguiente = cima // El nuevo nodo apunta a la cima actual
            };

            cima = nuevoNodo; // Actualiza la cima de la pila
            //ActualizarDataGrid();
        }

        // Método para eliminar la llamada en la cima de la pila
        public NodoInterrupciones Pop()
        {
            if (cima == null)
            {
                MessageBox.Show("La pila está vacía.");
                return null;
            }

            NodoInterrupciones nodoEliminado = cima;
            cima = cima.Siguiente; // Actualiza la cima al siguiente nodo
            
            return nodoEliminado;
        }

        // Método para actualizar el DataGridView
        public void ActualizarDataGrid()
        {
            dgvPila.Rows.Clear(); // Limpia las filas actuales del DataGridView
            NodoInterrupciones actual = cima;

            while (actual != null)
            {
                dgvPila.Rows.Add(
                    actual.Telefono,
                    actual.Cliente,
                    actual.TipoCliente,
                    actual.HoraLlamada.ToString("HH:mm:ss")
                );

                actual = actual.Siguiente; // Avanza al siguiente nodo
            }
        }

        // Método para vaciar la pila
        public void Vaciar()
        {
            cima = null;
            ActualizarDataGrid();
        }

        // Método para contar las llamadas en la pila
        public int Contar()
        {
            int contador = 0;
            NodoInterrupciones actual = cima;

            while (actual != null)
            {
                contador++;
                actual = actual.Siguiente;
            }

            return contador;
        }
    }
}
