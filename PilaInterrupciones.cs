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
            this.dgvPila = dgvPila;// Asigna el DataGridView
            cima = null;// Inicializa la cima de la pila
        }

        // Método para agregar una llamada a la pila
        public void Push(string telefono, string cliente, string tipoCliente, DateTime horaLlamada)// Agrega un nuevo nodo a la pila
        {
            NodoInterrupciones nuevoNodo = new NodoInterrupciones// Crea un nuevo nodo
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
        public NodoInterrupciones Pop()// Elimina el nodo en la cima de la pila
        {
            if (cima == null)
            {
                MessageBox.Show("La pila está vacía.");
                return null;// La pila está vacía
            }

            NodoInterrupciones nodoEliminado = cima;// Guarda el nodo a eliminar
            cima = cima.Siguiente; // Actualiza la cima al siguiente nodo
            
            return nodoEliminado;// Retorna el nodo eliminado
        }

        // Método para actualizar el DataGridView
        public void ActualizarDataGrid()
        {
            dgvPila.Rows.Clear(); // Limpia las filas actuales del DataGridView
            NodoInterrupciones actual = cima;

            while (actual != null)// Recorre la pila
            {
                dgvPila.Rows.Add(
                    actual.Telefono,
                    actual.Cliente,
                    actual.TipoCliente,
                    actual.HoraLlamada.ToString("HH:mm:ss")
                );// Agrega una fila al DataGridView con los datos del nodo actual

                actual = actual.Siguiente; // Avanza al siguiente nodo
            }
        }

        // Método para vaciar la pila
        public void Vaciar()
        {
            cima = null;// Elimina la cima de la pila
            ActualizarDataGrid();
        }

        // Método para contar las llamadas en la pila
        public int Contar()// Cuenta los nodos de la pila
        {
            int contador = 0;// Inicializa el contador
            NodoInterrupciones actual = cima;// Nodo actual

            while (actual != null)// Recorre la pila
            {
                contador++;// Incrementa el contador
                actual = actual.Siguiente;// Avanza al siguiente nodo
            }

            return contador;// Retorna el contador
        }
    }
}
