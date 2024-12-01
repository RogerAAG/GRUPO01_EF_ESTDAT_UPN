using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GRUPO01_EF_ESTDAT_UPN.Nodo;

namespace GRUPO01_EF_ESTDAT_UPN
{
    public partial class FormInterrupciones : Form
    {
        
        public PilaInterrupciones Pila { get; private set; }// Pila de interrupciones
        public FormInterrupciones(string llamada)// Constructor de la clase
        {
            InitializeComponent();// Inicializa los componentes
            ConfigurarDataGridView();// Configura el DataGridView
            Pila = new PilaInterrupciones(dgvPila);// Inicializa la pila

            // Si se pasa una llamada, agregarla directamente a la pila
            if (!string.IsNullOrEmpty(llamada))
            {
                string[] datos = llamada.Split(',');// Separar los datos de la llamada
                if (datos.Length == 4)// Verificar que se hayan pasado los 4 datos
                {
                    DateTime fecha;
                    if (DateTime.TryParseExact(datos[3], "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out fecha))//Verifica que la fecha sea valida
                    {
                        Pila.Push(datos[0], datos[1], datos[2], fecha);// Agregar la llamada a la pila
                        Pila.ActualizarDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("Formato de Fecha Invalido.");
                    }
                }
            }
        }
        private void ConfigurarDataGridView()
        {
            dgvPila.Columns.Clear();
            dgvPila.Columns.Add("Telefono", "Teléfono");
            dgvPila.Columns.Add("Cliente", "Cliente");
            dgvPila.Columns.Add("TipoCliente", "Tipo de Cliente");
            dgvPila.Columns.Add("HoraLlamada", "Hora");
        }
        private void btnVaciar_Click(object sender, EventArgs e)
        {

            Pila.Vaciar();
            Pila.ActualizarDataGrid();
        }
        public void btnDevolverLlamada_Click(object sender, EventArgs e)
        {
            var llamada = Pila.Pop();// Elimina la llamada en la cima de la pila
            FormPadre padre = this.Owner as FormPadre;// Obtener el formulario padre

            if (llamada != null)// Si se eliminó una llamada
            {
                MessageBox.Show($"Llamada eliminada:\nTeléfono: {llamada.Telefono}\nCliente: {llamada.Cliente}");
                string servicio = llamada.Servicio;// Obtener el servicio interrumpido
                List<string> agentes = new List<string>(); // Crear una lista de agentes
                FormAgentes formAgentes = new FormAgentes(agentes, llamada.Telefono, padre); // Pasar los argumentos requeridos

                formAgentes.Show();// Mostrar el formulario de agentes
            }
            else
            {
                MessageBox.Show("La pila está vacía.");
            }
        }
        private void btnListar_Click(object sender, EventArgs e)
        {
            Pila.ActualizarDataGrid(); // Llama al método de la pila para actualizar el DataGridView
        }
       
    }
}
