using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GRUPO01_EF_ESTDAT_UPN.Nodo;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace GRUPO01_EF_ESTDAT_UPN
{
    public partial class FormUsuarios : Form
    {
        private ListaUsuario listaUsuarios = new ListaUsuario();
        private NodoUsuario nodoActual;
        public FormUsuarios()
        {
            InitializeComponent();
        }
        //EVENTO DE AGREGAR USUARIO
        private void btnAgregarUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreUser.Text) ||
                string.IsNullOrWhiteSpace(txtDNIuser.Text) ||
                string.IsNullOrWhiteSpace(txtTelefonoUser.Text) ||
                string.IsNullOrWhiteSpace(txtPasswordUser.Text) ||
                string.IsNullOrWhiteSpace(cmbCargo.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }
            listaUsuarios.AgregarUsuario(txtNombreUser.Text, txtDNIuser.Text, txtTelefonoUser.Text, cmbCargo.Text, txtPasswordUser.Text);
            MessageBox.Show("Usuario agregado correctamente.");
            ActualizarDataGrid();
            txtNombreUser.Text = "";
            txtTelefonoUser.Text = "";
            txtDNIuser.Text = "";
            cmbCargo.Text = "";
            txtPasswordUser.Text = "";
            txtNombreUser.Focus();
        }
        //Evento Editar Usuario
        private void btnEditarUser_Click(object sender, EventArgs e)
        {
            if (nodoActual != null)
            {
                nodoActual.Nombre = txtNombreUser.Text;
                nodoActual.Telefono = txtTelefonoUser.Text;
                nodoActual.Cargo = cmbCargo.Text;
                nodoActual.Contraseña = txtPasswordUser.Text;
                MessageBox.Show("Usuario editado correctamente.");
                ActualizarDataGrid();
            }
            else
            {
                MessageBox.Show("Primero busca un usuario para editar.");
            }
        }
        //Evento Eliminar Usuario
        private void btnEliminarUser_Click(object sender, EventArgs e)
        {
            listaUsuarios.EliminarUsuario(txtDNIuser.Text);
            MessageBox.Show("Usuario eliminado correctamente.");
            ActualizarDataGrid();
        }
        //Evento Buscar Usuario
        private void btnBuscarUser_Click(object sender, EventArgs e)
        {
            NodoUsuario usuario = listaUsuarios.BuscarUsuario(txtDNIuser.Text);
            if (usuario != null)
            {
                MessageBox.Show($"Usuario encontrado: {usuario.Nombre}");
                MostrarDatosUsuario(usuario);
                nodoActual = usuario;
            }
            else
            {
                MessageBox.Show("Usuario no encontrado.");
            }
        }
        private void ActualizarDataGrid()
        {
            dgvListaUsuarios.DataSource = listaUsuarios.ObtenerUsuarios()
            .Select(u => new { u.ID, u.Nombre, u.DNI, u.Telefono, u.Cargo })
            .ToList();
        }
        private void MostrarDatosUsuario(NodoUsuario usuario)
        {
            txtNombreUser.Text = usuario.Nombre;
            txtDNIuser.Text = usuario.DNI;
            txtTelefonoUser.Text = usuario.Telefono;
            cmbCargo.Text = usuario.Cargo;
            txtPasswordUser.Text = usuario.Contraseña;
        }
        //BOTON NAVEGAR ATRAS NODO
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (nodoActual != null && nodoActual.ant != null)
            {
                nodoActual = nodoActual.ant;
                MostrarDatosUsuario(nodoActual);
            }
            else
            {
                MessageBox.Show("No hay más usuarios hacia atrás.");
            }
        }
        //BOTON NAVEGAR SIGUIENTE NODO
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (nodoActual != null && nodoActual.sig != null)
            {
                nodoActual = nodoActual.sig;
                MostrarDatosUsuario(nodoActual);
            }
            else
            {
                MessageBox.Show("No hay más usuarios hacia adelante.");
            }
        }
        //GENERAR DATOS ALEATORIOS PARA LLENAR FORMULARIO
        private void btnGenerarUsuario_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            // Generar nombre aleatorio
            string[] nombres = { "Carlos", "María", "Ana", "José", "Luis", "Lucía", "Jorge", "Diana","Roger","Leonel","Yessica","Jonathan","Alex" };
            string[] apellidos = { "Pérez", "González", "Rodríguez", "Fernández", "López", "Martínez","Aldana","Bernaola","Chavez","Pita","Moscoso" };
            string nombreCompleto = $"{nombres[rnd.Next(nombres.Length)]} {apellidos[rnd.Next(apellidos.Length)]}";
            txtNombreUser.Text = nombreCompleto;

            // Generar teléfono aleatorio
            txtTelefonoUser.Text = rnd.Next(910000000, 998000000).ToString();

            // Generar DNI aleatorio
            txtDNIuser.Text = rnd.Next(40102030, 49898989).ToString();

            // Seleccionar cargo aleatorio
            int porcentaje = rnd.Next(1, 101); // 1 a 100
            if (porcentaje <= 10)
                cmbCargo.Text = "Administrador";
            else if (porcentaje <= 80)
                cmbCargo.Text = "Agente";
            else
                cmbCargo.Text = "Supervisor";

            // Establecer contraseña Automatica
            txtPasswordUser.Text = "1234";
        }
    }
}
