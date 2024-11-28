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
            InitializeComponent();
        }


        //CONFIGURACION PARA APERTURA DE FORMULARIOS EN PANEL CONTENEDOR
        public Dictionary<string, Form> formulariosAbiertos = new Dictionary<string, Form>();
        public void AbrirFormHijo(Form formulario)
        {
            // Verificar si ya existe una instancia del formulario en el diccionario
            if (!formulariosAbiertos.ContainsKey(formulario.GetType().Name) || formulariosAbiertos[formulario.GetType().Name].IsDisposed)
            {
                // Agregar la nueva instancia al diccionario
                formulariosAbiertos[formulario.GetType().Name] = formulario;
            }

            Form fh = formulariosAbiertos[formulario.GetType().Name];

            // Limpiar el panel y cargar el formulario hijo
            if (this.pnlContenedor.Controls.Count > 0)
                this.pnlContenedor.Controls.RemoveAt(0);

            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(fh);
            this.pnlContenedor.Tag = fh;
            fh.Show();//Muestra el formulario hijo
        }
        //CONFIGURACION PARA APERTURA DE FORMULARIOS EN PANEL CONTENEDOR
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FormUsuarios());//Carga el formulario de usuarios
        }
        private void btnLlamadas_Click(object sender, EventArgs e)
        {
            ListaUsuario listaUsuarios = new ListaUsuario();
            FormLlamadas formLlamadas = new FormLlamadas(listaUsuarios, this); // Pasa FormPadre
            AbrirFormHijo(formLlamadas);//Carga el formulario de llamadas
        }
        private void btnInterrupciones_Click(object sender, EventArgs e)
        {
            string llamada = "Datos de la llamada"; // Proporciona los datos necesarios aquí
            FormInterrupciones formInterrupciones = new FormInterrupciones(llamada);

            formInterrupciones.Owner = this;
            AbrirFormHijo(formInterrupciones);//Carga el formulario de interrupciones
        }
        private void btnAgentes_Click(object sender, EventArgs e)
        {
            List<string> agentes = new List<string> { "Agente 1", "Agente 2", "Agente 3" }; // Ejemplo
            string llamadaInfo = "Llamada simulada"; // Información de prueba
            FormAgentes formAgentes = new FormAgentes(agentes, llamadaInfo, this); // Pasa FormPadre
            AbrirFormHijo(formAgentes);//Carga el formulario de agentes
        }
        private void btnTransferencias_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FormTransferencias());//Carga el formulario de transferencias
        }

        //ASPECTO DEL FORMULARIO
        //CODIGO PARA MOVER FORMULARIO
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void btnCerrar_Click(object sender, EventArgs e)
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
        private void FormPadre_SizeChanged(object sender, EventArgs e)
        {
            
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
        private void pictureBox7_MouseClick(object sender, MouseEventArgs e)
        { }
        //Limpieza de Recursos
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            foreach (var form in formulariosAbiertos.Values)
            {
                if (!form.IsDisposed)
                {
                    form.Dispose();
                }
            }
            base.OnFormClosing(e);
        }
    }
}