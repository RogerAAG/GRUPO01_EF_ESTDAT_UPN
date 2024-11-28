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
    public partial class FormLlamadas : Form
    {
        ColaLlamadas objColaGeneral;
        ColaLlamadas objColaEmpresa;
        private ListaUsuario listaUsuarios;
        private FormPadre formPadre;
        public NodoColaLlamadas UltimaLlamadaAtendida { get; private set; } // Nueva propiedad
        internal FormLlamadas(ListaUsuario listaUsuarios, FormPadre formPadre)
        {
            InitializeComponent();
            objColaGeneral = new ColaLlamadas();
            objColaEmpresa = new ColaLlamadas();
            this.listaUsuarios = listaUsuarios;
            this.formPadre = formPadre; // Guardar la referencia del formulario padre
            ActualizarCantidadLlamadas(); // Mostrar las cantidades iniciales
        }
        private void btnAgregarLlamada_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtCliente.Text) ||
                string.IsNullOrWhiteSpace(cmbTipoCliente.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            string Telefono_Cliente = txtTelefono.Text;
            string Cliente = txtCliente.Text;
            string Tipo_Cliente = cmbTipoCliente.Text;

            if (Tipo_Cliente == "Cliente General")
            {
                objColaGeneral.AgregarLlamada(Telefono_Cliente, Cliente, Tipo_Cliente, DateTime.Now);
            }
            else if (Tipo_Cliente == "Empresarial")
            {
                objColaEmpresa.AgregarLlamada(Telefono_Cliente, Cliente, Tipo_Cliente, DateTime.Now);
            }
            else
            {
                MessageBox.Show("El tipo de cliente seleccionado no es válido.");
                return;
            }

            MessageBox.Show("Llamada agregada correctamente.");
            ActualizarDataGrid();
            ActualizarCantidadLlamadas();
            LimpiarCampos();
        }
        private void btnAtenderLlamada_Click(object sender, EventArgs e)
        {
            NodoColaLlamadas llamadaAtendida = null;

            if (!objColaEmpresa.EstaVacia())
            {
                llamadaAtendida = objColaEmpresa.AtenderLlamada();
            }
            else if (!objColaGeneral.EstaVacia())
            {
                llamadaAtendida = objColaGeneral.AtenderLlamada();
            }

            if (llamadaAtendida != null)
            {
                UltimaLlamadaAtendida = llamadaAtendida; // Guardar la última llamada atendida

                MessageBox.Show($"Atendiendo llamada de: {llamadaAtendida.Cliente}, Teléfono: {llamadaAtendida.Telefono_Cliente}");
                ActualizarDataGrid();
                ActualizarCantidadLlamadas();

                // Enviar llamada al FormAgentes
                List<string> agentes = listaUsuarios.ObtenerUsuarios()
                    .Select(u => u.Nombre)
                    .ToList();
                string llamadaInfo = $"Teléfono: {llamadaAtendida.Telefono_Cliente}, Cliente: {llamadaAtendida.Cliente}";
                FormAgentes formAgentes = new FormAgentes(agentes, llamadaInfo, formPadre);
                formPadre.AbrirFormHijo(formAgentes); // Abrir en el pnlContenedor
            }
            else
            {
                MessageBox.Show("No hay llamadas en espera.");
            }

        }
        private void btnVaciar_Click(object sender, EventArgs e)
        {
            objColaGeneral.Vaciar();
            objColaEmpresa.Vaciar();
            MessageBox.Show("Todas las llamadas han sido eliminadas.");
            ActualizarDataGrid();
            ActualizarCantidadLlamadas();
        }
        // Actualizar los DataGridView
        private void ActualizarDataGrid()
        {
            // Actualizar DataGridView para Cliente General
            dgvGeneral.DataSource = null; // Limpia el contenido previo
            dgvGeneral.DataSource = objColaGeneral.ObtenerLlamadas()
                .Select(l => new
                {
                    Telefono = l.Telefono_Cliente,
                    Cliente = l.Cliente,
                    TipoCliente = l.Tipo_Cliente,
                    HoraLlamada = l.HoraLlamada.ToString("HH:mm:ss")
                })
                .ToList();

            // Actualizar DataGridView para Empresa
            dgvEmpresa.DataSource = null; // Limpia el contenido previo
            dgvEmpresa.DataSource = objColaEmpresa.ObtenerLlamadas()
                .Select(l => new
                {
                    Telefono = l.Telefono_Cliente,
                    Cliente = l.Cliente,
                    TipoCliente = l.Tipo_Cliente,
                    HoraLlamada = l.HoraLlamada.ToString("HH:mm:ss")
                })
                .ToList();
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
            int cantidadGeneral = objColaGeneral.ObtenerLlamadas().Count;
            int cantidadEmpresa = objColaEmpresa.ObtenerLlamadas().Count;

            lblCantidadLlamada.Text = $"Llamadas en cola: General ({cantidadGeneral}), Empresarial ({cantidadEmpresa})";
        }
        private void btnSimular_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

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
