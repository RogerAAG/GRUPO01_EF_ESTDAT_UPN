using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GRUPO01_EF_ESTDAT_UPN.Nodo;

namespace GRUPO01_EF_ESTDAT_UPN
{
    public partial class FormAgentes : Form
    {
        private ArbolAtencion arbol;// Árbol de preguntas
        private NodoArbol nodoActual;// Nodo actual en el árbol
        private string llamadaEnCurso; // Datos de la llamada actual
        private FormPadre formPadre;// Referencia al formulario padre
       
        public FormAgentes(List<string> agentes, string llamada, FormPadre formPadre)
        {
            InitializeComponent();
            arbol = new ArbolAtencion();
            nodoActual = arbol.Raiz;
            llamadaEnCurso = llamada;
            this.formPadre = formPadre; // Guardar la referencia del formulario padre
            // Llenar ComboBox con los agentes disponibles
            cmbAgentes.DataSource = agentes;
            // Mostrar la primera pregunta
            lblPregunta.Text = nodoActual.Pregunta;
            // Mostrar información de la llamada
            lblLlamadaInfo.Text = llamadaEnCurso;
        }
        private void btnSi_Click(object sender, EventArgs e)
        {
            AvanzarNodo(nodoActual.Si);
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            AvanzarNodo(nodoActual.No);
        }

        private void AvanzarNodo(NodoArbol siguienteNodo)
        {
            if (siguienteNodo != null)
            {
                nodoActual = siguienteNodo;
                lblPregunta.Text = nodoActual.Pregunta;
                if (nodoActual.EsSolucion) // Considera agregar una propiedad EsSolucion
                {
                    MessageBox.Show(nodoActual.Pregunta);
                    btnSi.Enabled = false;
                    btnNo.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Fin del árbol de atención. No hay más preguntas.");
            }
        }
        private void btnLlamadaInterrumpida_Click(object sender, EventArgs e)
        {
            if (formPadre != null && formPadre.formulariosAbiertos.ContainsKey(nameof(FormLlamadas)))
            {
                var formLlamadas = (FormLlamadas)formPadre.formulariosAbiertos[nameof(FormLlamadas)];
                var ultimaLlamada = formLlamadas.UltimaLlamadaAtendida;

                if (ultimaLlamada != null)
                {
                    // Crear instancia del FormInterrupciones si aún no existe
                    if (!formPadre.formulariosAbiertos.ContainsKey(nameof(FormInterrupciones)) ||
                        formPadre.formulariosAbiertos[nameof(FormInterrupciones)].IsDisposed)
                    {
                        var formInterrupciones = new FormInterrupciones(string.Empty);
                        formInterrupciones.Owner = formPadre; // Set the Owner property
                        formPadre.AbrirFormHijo(formInterrupciones);
                    }

                    // Obtener el formulario abierto de interrupciones
                    var formInterrupcionesAbierto = (FormInterrupciones)formPadre.formulariosAbiertos[nameof(FormInterrupciones)];

                    // Agregar la llamada interrumpida a la pila del formulario
                    formInterrupcionesAbierto.Pila.Push(
                        ultimaLlamada.Telefono_Cliente,
                        ultimaLlamada.Cliente,
                        ultimaLlamada.Tipo_Cliente,
                        ultimaLlamada.HoraLlamada
                    );

                    MessageBox.Show($"Llamada interrumpida agregada:\nTeléfono: {ultimaLlamada.Telefono_Cliente}\nCliente: {ultimaLlamada.Cliente}");
                }
                else
                {
                    MessageBox.Show("No hay llamadas atendidas para interrumpir.");
                }
            }
            else
            {
                MessageBox.Show("No se pudo encontrar el formulario de llamadas.");
            }
        }

        private void btnFinalizarLlamada_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Llamada finalizada por el agente: {cmbAgentes.SelectedItem}");
            this.Close(); // Cerrar formulario al finalizar
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            arbol.Reiniciar(); // Reinicia el árbol
            nodoActual = arbol.Raiz; // Actualiza el nodo actual al inicio del árbol
            lblPregunta.Text = nodoActual.Pregunta; // Muestra la primera pregunta
            MessageBox.Show("El árbol se ha reiniciado.");
        }
        private void ActualizarInterfaz()
        {
            lblPregunta.Text = nodoActual.Pregunta;
            btnSi.Enabled = nodoActual.Si != null;
            btnNo.Enabled = nodoActual.No != null;
        }

        private void btnSeleccionarServicio_Click(object sender, EventArgs e)
        {
            var servicioSeleccionado = cmbServicios.SelectedItem?.ToString();  // Obtener el servicio seleccionado

            if (string.IsNullOrEmpty(servicioSeleccionado))
            {
                MessageBox.Show("Por favor, seleccione un servicio.");
                return;
            }

            arbol.SeleccionarServicio(servicioSeleccionado); // Seleccionar y construir el árbol
            nodoActual = arbol.Raiz;                         // Inicia en la raíz
            lblPregunta.Text = nodoActual.Pregunta;          // Mostrar la primera pregunta
            ActualizarBotones();                             // Habilitar botones según el nodo
        }
        private void ActualizarBotones(bool habilitar = true)
        {
            btnSi.Enabled = habilitar && nodoActual?.Si != null;
            btnNo.Enabled = habilitar && nodoActual?.No != null;
        }
    }
}
