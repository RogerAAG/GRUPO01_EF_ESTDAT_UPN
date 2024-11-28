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
        
        public PilaInterrupciones Pila { get; private set; }
        public FormInterrupciones(string llamada)
        {
            InitializeComponent();
            ConfigurarDataGridView();
            Pila = new PilaInterrupciones(dgvPila);

            // Si se pasa una llamada, agregarla directamente a la pila
            if (!string.IsNullOrEmpty(llamada))
            {
                string[] datos = llamada.Split(',');
                if (datos.Length == 4)
                {
                    DateTime fecha;
                    if (DateTime.TryParseExact(datos[3], "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out fecha))
                    {
                        Pila.Push(datos[0], datos[1], datos[2], fecha);
                        Pila.ActualizarDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("Invalid date format.");
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
            var llamada = Pila.Pop();
            FormPadre padre = this.Owner as FormPadre;

            if (llamada != null)
            {
                MessageBox.Show($"Llamada eliminada:\nTeléfono: {llamada.Telefono}\nCliente: {llamada.Cliente}");
                List<string> agentes = new List<string>(); // Crear una lista de agentes
                FormAgentes formAgentes = new FormAgentes(agentes, llamada.Telefono, padre); // Pasar los argumentos requeridos

                formAgentes.Show();
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
