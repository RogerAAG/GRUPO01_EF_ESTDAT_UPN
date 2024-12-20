﻿using System;
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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // Quitar bordes del formulario
            this.Load += FormLogin_Load; // Asociar el evento Load
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtPassword.Text;// Variables para almacenar usuario y contraseña

            if (usuario == "admin" && contraseña == "1234")// Validar usuario y contraseña
            {
                FormPadre formPadre = new FormPadre();// Crear instancia de FormPadre
                formPadre.Show();// Mostrar FormPadre
                this.Hide();// Ocultar FormLogin
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        //ASPECTO DEL FORMULARIO
        //CODIGO PARA BORDE DE FORMULARIO
        [DllImport("user32.dll")]// Dll para manipular la interfaz de usuario
        private static extern int SetWindowRgn(IntPtr hWnd, IntPtr hRgn, bool bRedraw);// Función para establecer la región de la ventana
        [DllImport("gdi32.dll")]// Dll para manipular la interfaz de usuario
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        //CODIGO PARA MOVER FORMULARIO
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]// Dll para manipular la interfaz de usuario
        private extern static void ReleaseCapture();// Función para liberar la captura
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]// Dll para manipular la interfaz de usuario
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();// Cerrar aplicación
        }
        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();// Liberar captura
            SendMessage(this.Handle, 0x112, 0xf012, 0);// Enviar mensaje
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();// Liberar captura
            SendMessage(this.Handle, 0x112, 0xf012, 0);// Enviar mensaje
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;// Minimizar formulario
        }
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")// Validar si el texto es igual a "USUARIO"
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.DarkCyan;
            }
        }
        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DarkCyan;
            }
        }
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "CONTRASEÑA")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.DarkCyan;
                txtPassword.UseSystemPasswordChar = true;
            }
        }
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "CONTRASEÑA";
                txtPassword.ForeColor = Color.DarkCyan;
                txtPassword.UseSystemPasswordChar = false;
            }
        }
        private void FormLogin_Load(object sender, EventArgs e)// Evento Load
        {
            // Crear bordes redondeados
            int radius = 30; // Radio para las esquinas
            IntPtr region = CreateRoundRectRgn(0, 0, this.Width, this.Height, radius, radius);// Crear región redondeada
            SetWindowRgn(this.Handle, region, true);// Establecer región redondeada
        }
    }
}
