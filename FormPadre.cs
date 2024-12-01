using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GRUPO01_EF_ESTDAT_UPN
{
    public partial class FormPadre : Form
    {
        public FormPadre()
        {
            InitializeComponent();//Inicializa los componentes
        }


        //CONFIGURACION PARA APERTURA DE FORMULARIOS EN PANEL CONTENEDOR
        public Dictionary<string, Form> formulariosAbiertos = new Dictionary<string, Form>();
        public void AbrirFormHijo(Form formulario)//Metodo para abrir FormulariosHijos en panel
        {
            // Verificar si ya existe una instancia del formulario en el diccionario
            if (!formulariosAbiertos.ContainsKey(formulario.GetType().Name) || formulariosAbiertos[formulario.GetType().Name].IsDisposed)
            {
                // Agregar la nueva instancia al diccionario
                formulariosAbiertos[formulario.GetType().Name] = formulario;
            }

            Form fh = formulariosAbiertos[formulario.GetType().Name];//Obtener el formulario del diccionario

            // Limpiar el panel y cargar el formulario hijo
            if (this.pnlContenedor.Controls.Count > 0)//Si hay un formulario cargado
                this.pnlContenedor.Controls.RemoveAt(0);//Elimina el formulario cargado

            fh.TopLevel = false;//Indica que no es un formulario de nivel superior
            fh.Dock = DockStyle.Fill;//Rellena el panel
            this.pnlContenedor.Controls.Add(fh);//Agrega el formulario al panel
            this.pnlContenedor.Tag = fh;//Establece el formulario como etiqueta del panel
            fh.Show();//Muestra el formulario hijo
        }
        //CONFIGURACION PARA APERTURA DE FORMULARIOS EN PANEL CONTENEDOR
        private void btnUsuarios_Click(object sender, EventArgs e)//Muestra el formulario de usuarios
        {
            AbrirFormHijo(new FormUsuarios());//Carga el formulario de usuarios
        }
        private void btnLlamadas_Click(object sender, EventArgs e)//Muestra el formulario de llamadas
        {
            ListaUsuario listaUsuarios = new ListaUsuario();
            FormLlamadas formLlamadas = new FormLlamadas(listaUsuarios, this); // Pasa FormPadre
            AbrirFormHijo(formLlamadas);//Carga el formulario de llamadas
        }
        private void btnInterrupciones_Click(object sender, EventArgs e)//Muestra el formulario de interrupciones
        {
            string llamada = "Datos de la llamada"; // Proporciona los datos necesarios aquí
            FormInterrupciones formInterrupciones = new FormInterrupciones(llamada);

            formInterrupciones.Owner = this;
            AbrirFormHijo(formInterrupciones);//Carga el formulario de interrupciones
        }
        private void btnAgentes_Click(object sender, EventArgs e)//Muestra el formulario de agentes
        {
            List<string> agentes = new List<string> { "Agente 1", "Agente 2", "Agente 3" }; // Ejemplo
            string llamadaInfo = "Llamada simulada"; // Información de prueba
            FormAgentes formAgentes = new FormAgentes(agentes, llamadaInfo, this); // Pasa FormPadre
            AbrirFormHijo(formAgentes);//Carga el formulario de agentes
        }
        private void btnTransferencias_Click(object sender, EventArgs e)//Muestra el formulario de transferencias
        {
            // Obtener la referencia de FormLlamadas desde el diccionario
            if (formulariosAbiertos.ContainsKey("FormLlamadas") && formulariosAbiertos["FormLlamadas"] is FormLlamadas formLlamadas)
            {
                FormTransferencias formTransferencias = new FormTransferencias// Crear instancia de FormTransferencias
                {
                    FormLlamadasReferencia = formLlamadas // Pasar referencia de FormLlamadas
                };
                AbrirFormHijo(formTransferencias); // Abrir el formulario
            }
            else
            {
                MessageBox.Show("Debe abrir primero el formulario de Llamadas para poder ver la última llamada atendida.");
            }
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Inicio());//Carga el formulario de inicio
        }
        private void btnCerrarSes_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Seguro que deseas cerrar sesión?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                FormLogin loginForm = new FormLogin();
                loginForm.Show();//Carga el formulario de inicio de sesión
            }
        }

        //ASPECTO DEL FORMULARIO
        //CODIGO PARA MOVER FORMULARIO
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]//Libreria para mover el formulario
        private extern static void ReleaseCapture();//Metodo para mover el formulario
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]//Libreria para mover el formulario
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);//Metodo para mover el formulario
        private void btnCerrar_Click(object sender, EventArgs e)//Cierra la aplicación
        {
            // Cerrar todos los formularios abiertos
            foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
            {
                form.Close();
            }
            // Salir de la aplicación
            Application.Exit();
        }
        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;//Minimiza la ventana
        }
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;//Maximiza la ventana
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;//Restaura la ventana
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }
        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void FormPadre_Load(object sender, EventArgs e)
        {
            pictureBox7_Click(null, e);//Carga el formulario de inicio
        }
        //Limpieza de Recursos
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            foreach (var form in formulariosAbiertos.Values)//Cierra los formularios abiertos
            {
                if (!form.IsDisposed)//Si el formulario no está cerrado
                {
                    form.Dispose();//Cierra el formulario
                }
            }
            base.OnFormClosing(e);//Cierra el formulario
        }
        private void FormPadre_SizeChanged(object sender, EventArgs e)
        {

        }
        private void pictureBox7_MouseClick(object sender, MouseEventArgs e)
        {
        }
    }
}