using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static GRUPO01_EF_ESTDAT_UPN.Nodo;

namespace GRUPO01_EF_ESTDAT_UPN
{
    public partial class FormLlamadas : Form
    {
        ColaLlamadas objColaGeneral;//Cola de llamadas generales
        ColaLlamadas objColaEmpresa;//Cola de llamadas empresariales
        private ListaUsuario listaUsuarios;// Referencia a la lista de usuarios
        private FormPadre formPadre;// Referencia al formulario padre

        public NodoColaLlamadas UltimaLlamadaAtendida { get; private set; } // Propiedad para guardar la última llamada atendida
        internal FormLlamadas(ListaUsuario listaUsuarios, FormPadre formPadre)//Constructor
        {
            InitializeComponent();//Inicializa los componentes
            objColaGeneral = new ColaLlamadas();//Instancia de la cola de llamadas generales
            objColaEmpresa = new ColaLlamadas();//Instancia de la cola de llamadas empresariales
            this.listaUsuarios = listaUsuarios;// Guardar la referencia de la lista de usuarios
            this.formPadre = formPadre; // Guardar la referencia del formulario padre
            ActualizarCantidadLlamadas(); // Mostrar las cantidades iniciales
        }
        private void btnAgregarLlamada_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtCliente.Text) ||
                string.IsNullOrWhiteSpace(cmbTipoCliente.Text))//Validar campos vacíos
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;//Salir del método
            }

            string Telefono_Cliente = txtTelefono.Text;//Obtener el teléfono del cliente
            string Cliente = txtCliente.Text;//Obtener el nombre del cliente
            string Tipo_Cliente = cmbTipoCliente.Text;//Obtener el tipo de cliente

            if (Tipo_Cliente == "Cliente General")//Validar el tipo de cliente
            {
                objColaGeneral.AgregarLlamada(Telefono_Cliente, Cliente, Tipo_Cliente, DateTime.Now);//Agregar llamada a la cola general
            }
            else if (Tipo_Cliente == "Empresarial")//Validar el tipo de cliente
            {
                objColaEmpresa.AgregarLlamada(Telefono_Cliente, Cliente, Tipo_Cliente, DateTime.Now);//Agregar llamada a la cola empresarial
            }
            else
            {
                MessageBox.Show("El tipo de cliente seleccionado no es válido.");
                return;//Salir del método
            }

            MessageBox.Show("Llamada agregada correctamente.");
            ActualizarDataGrid();//Actualizar los DataGridView
            ActualizarCantidadLlamadas();//Actualizar la cantidad de llamadas
            LimpiarCampos();//Limpiar los campos
        }
        private void btnAtenderLlamada_Click(object sender, EventArgs e)
        {
            NodoColaLlamadas llamadaAtendida = null;//Inicializar la llamada atendida en nulo

            if (!objColaEmpresa.EstaVacia())//Verificación
            {
                llamadaAtendida = objColaEmpresa.AtenderLlamada();//Atender llamada de la cola empresarial
            }
            else if (!objColaGeneral.EstaVacia())//Verificación
            {
                llamadaAtendida = objColaGeneral.AtenderLlamada();//Atender llamada cola General
            }

            if (llamadaAtendida != null)//
            {
                UltimaLlamadaAtendida = llamadaAtendida; // Guardar la última llamada atendida

                MessageBox.Show($"Atendiendo llamada de: {llamadaAtendida.Cliente}, Teléfono: {llamadaAtendida.Telefono_Cliente}");
                ActualizarDataGrid();//Actualizar los DataGridView
                ActualizarCantidadLlamadas();//Actualizar la cantidad de llamadas

                // Enviar llamada al FormAgentes
                List<string> agentes = listaUsuarios.ObtenerUsuarios()//Obtener la lista de agentes
                    .Select(u => u.Nombre)//Seleccionar solo los nombres
                    .ToList();//Convertir a lista
                string llamadaInfo = $"Teléfono: {llamadaAtendida.Telefono_Cliente}, Cliente: {llamadaAtendida.Cliente}";//Información de la llamada
                FormAgentes formAgentes = new FormAgentes(agentes, llamadaInfo, formPadre);//Instancia del formulario de agentes
                formPadre.AbrirFormHijo(formAgentes); // Abrir en el pnlContenedor
            }
            else
            {
                MessageBox.Show("No hay llamadas en espera.");
            }

        }
        private void btnVaciar_Click(object sender, EventArgs e)
        {
            objColaGeneral.Vaciar();//Vaciar la cola general
            objColaEmpresa.Vaciar();//Vaciar la cola empresarial
            MessageBox.Show("Todas las llamadas han sido eliminadas.");
            ActualizarDataGrid();
            ActualizarCantidadLlamadas();
        }
        // Actualizar los DataGridView
        private void ActualizarDataGrid()
        {
            // Actualizar DataGridView para Cliente General
            dgvGeneral.DataSource = null; // Limpia el contenido previo
            dgvGeneral.DataSource = objColaGeneral.ObtenerLlamadas()//Obtener las llamadas de la cola general
                .Select(l => new
                {
                    Telefono = l.Telefono_Cliente,
                    Cliente = l.Cliente,
                    TipoCliente = l.Tipo_Cliente,
                    HoraLlamada = l.HoraLlamada.ToString("HH:mm:ss")
                })
                .ToList();//Convertir a lista

            // Actualizar DataGridView para Empresa
            dgvEmpresa.DataSource = null; // Limpia el contenido previo
            dgvEmpresa.DataSource = objColaEmpresa.ObtenerLlamadas()//Obtener las llamadas de la cola empresarial
                .Select(l => new
                {
                    Telefono = l.Telefono_Cliente,
                    Cliente = l.Cliente,
                    TipoCliente = l.Tipo_Cliente,
                    HoraLlamada = l.HoraLlamada.ToString("HH:mm:ss")
                })
                .ToList();//Convertir a lista
        }
        private void LimpiarCampos()
        {
            txtTelefono.Text = "";
            txtCliente.Text = "";
            cmbTipoCliente.Text = "";
            txtTelefono.Focus();
        }
        private void ActualizarCantidadLlamadas()
        {
            int cantidadGeneral = objColaGeneral.ObtenerLlamadas().Count;//Obtener la cantidad de llamadas en la cola general
            int cantidadEmpresa = objColaEmpresa.ObtenerLlamadas().Count;//Obtener la cantidad de llamadas en la cola empresarial

            lblCantidadLlamada.Text = $"Llamadas en cola: General ({cantidadGeneral}), Empresarial ({cantidadEmpresa})";

        }
        private void btnSimular_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();//Generador de números aleatorios

            // Seleccionar tipo de cliente
            int tipoClienteProbabilidad = rnd.Next(1, 101); // 1 a 100
            if (tipoClienteProbabilidad <= 60)
            {
                // Cliente General
                cmbTipoCliente.Text = "Cliente General";
                txtTelefono.Text = rnd.Next(910100100, 998100101).ToString(); // Generar teléfono en rango
                string[] nombres = { "Carlos", "Ana", "Luis", "María", "Jorge", "Lucía","Patricia","Iván","Jorge","Diana","Yessica","Franco","Jonathan", "Camila", "Ruth", "Rosa" };
                string[] apellidos = { "Pérez", "González", "López", "Rodríguez", "Martínez","Chavez","Aldana","García","Bernaola","Moscoso","Valverde","Soto", "Vásquez", "Flores", "Huamán" };
                txtCliente.Text = $"{nombres[rnd.Next(nombres.Length)]} {apellidos[rnd.Next(apellidos.Length)]}"; // Nombre completo
            }
            else
            {
                // Empresarial
                cmbTipoCliente.Text = "Empresarial";
                txtTelefono.Text = $"01-{rnd.Next(3303300, 4988081)}"; // Generar teléfono empresarial
                string[] empresas = { "TechCorp", "Innovatech", "GlobalSoft", "BizGroup", "EnterprisePlus", "Alicorp", "Backus AB InBev", "Petróleos del Perú", "Saga Falabella", "Intercorp Financial Services Inc" };
                txtCliente.Text = empresas[rnd.Next(empresas.Length)]; // Nombre de la empresa
            }
        }
        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtCliente_TextChanged(object sender, EventArgs e)
        {

        }
        private void cmbTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
      
    }
}
