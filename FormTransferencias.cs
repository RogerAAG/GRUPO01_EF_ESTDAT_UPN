using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GRUPO01_EF_ESTDAT_UPN
{
    public partial class FormTransferencias : Form
    {
        private GrafoTransferencias grafo;//Instancia de la clase GrafoTransferencias
        public FormLlamadas FormLlamadasReferencia { get; set; }// Propiedad para guardar la referencia al formulario de llamadas
        private int tiempoRestante;// Tiempo restante para la transferencia
        public FormTransferencias()//Constructor
        {
            InitializeComponent();
            InicializarGrafo();

            // Suscribir el evento Paint al panel
            panelGrafo.Paint += new PaintEventHandler(PanelGrafo_Paint);
        }

        private void InicializarGrafo()//Inicializa el grafo
        {
            grafo = new GrafoTransferencias();//Instancia de la clase GrafoTransferencias

            var ac = grafo.AgregarNodo("Atención al Cliente");//Agrega un nodo
            var f = grafo.AgregarNodo("Facturación");
            var st = grafo.AgregarNodo("Soporte Técnico");
            var rh = grafo.AgregarNodo("Recursos Humanos");
            var ti = grafo.AgregarNodo("TI Interno");
            var a = grafo.AgregarNodo("Administración");

            grafo.AgregarArista(ac, f, 3);//Agrega una arista
            grafo.AgregarArista(ac, st, 4);
            grafo.AgregarArista(f, rh, 4);
            grafo.AgregarArista(st, ti, 3);
            grafo.AgregarArista(rh, a, 5);
            grafo.AgregarArista(ti, a, 5);
        }
        private void PanelGrafo_Paint(object sender, PaintEventArgs e)//Dibuja el grafo
        {
            Graphics g = e.Graphics;//Instancia de la clase Graphics
            Pen pen = new Pen(Color.Blue, 2);//Instancia de la clase Pen
            Font font = new Font("Century Gothic", 11);//Instancia de la clase Font
            Brush brush = Brushes.Black;//Instancia de la clase Brush

            // Tamaño y posición ajustados al panel
            var ancho = panelGrafo.Width;
            var alto = panelGrafo.Height;

            var posiciones = new Dictionary<string, Point>//Instancia de la clase Dictionary
            {
                { "Atención al Cliente", new Point(ancho / 2, alto / 8) },//Agrega un nodo
                { "Facturación", new Point(ancho / 4, alto / 3) },
                { "Soporte Técnico", new Point(3 * ancho / 4, alto / 3) },
                { "Recursos Humanos", new Point(ancho / 4, 2 * alto / 3) },
                { "TI Interno", new Point(3 * ancho / 4, 2 * alto / 3) },
                { "Administración", new Point(ancho / 2, 7 * alto / 8) }
            };

            // Dibujar conexiones
            foreach (var nodo in grafo.Nodos)//Recorre los nodos
            {
                foreach (var conexion in nodo.Conexiones)//Recorre las conexiones
                {
                    Point origen = posiciones[nodo.Departamento];//Obtiene la posición del nodo
                    Point destino = posiciones[conexion.Key.Departamento];//Obtiene la posición de la conexión
                    g.DrawLine(pen, origen, destino);//Dibuja la línea
                    g.DrawString($"{conexion.Value} min", font, brush,//Dibuja el peso
                                 (origen.X + destino.X) / 2,//Posición X
                                 (origen.Y + destino.Y) / 2);//Posición Y
                }
            }

            // Dibujar nodos
            foreach (var pos in posiciones)//Recorre las posiciones
            {
                g.FillEllipse(Brushes.Blue, pos.Value.X - 15, pos.Value.Y - 15, 30, 30);//Dibuja el nodo
                g.DrawString(pos.Key, font, Brushes.White, pos.Value.X - 40, pos.Value.Y - 25);//Dibuja el nombre del nodo
            }
        }

        private void FormTransferencias_Load(object sender, EventArgs e)
        {
            if (FormLlamadasReferencia != null && FormLlamadasReferencia.UltimaLlamadaAtendida != null)//Si hay una llamada atendida
            {
                lblUltimaLlamadaInfo.Text = $"{FormLlamadasReferencia.UltimaLlamadaAtendida.Telefono_Cliente}, " +
                                            $"{FormLlamadasReferencia.UltimaLlamadaAtendida.Cliente}, " +
                                            $"{FormLlamadasReferencia.UltimaLlamadaAtendida.Tipo_Cliente}, " +
                                            $"Hora: {FormLlamadasReferencia.UltimaLlamadaAtendida.HoraLlamada:HH:mm:ss}";
            }
            else
            {
                lblUltimaLlamadaInfo.Text = "No hay información de la última llamada atendida.";
            }

            cmbAreas.Items.AddRange(tiemposPorArea.Keys.ToArray());//Agrega las áreas al ComboBox
            cmbAreas.SelectedIndex = 0; // Selecciona el primer elemento por defecto
        }
        private Dictionary<string, int> tiemposPorArea = new Dictionary<string, int>//Diccionario de tiempos por área
        {
              { "Atención al Cliente", 2 },
              { "Facturación", 3 },
              { "Soporte Técnico", 4 },
              { "Recursos Humanos", 7 },
              { "TI Interno", 7 },
              { "Administración", 12 }
        };

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            // Validar que haya una selección válida en el ComboBox
            if (cmbAreas.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un área de destino.");
                return;
            }

            string areaSeleccionada = cmbAreas.SelectedItem.ToString();

            // Buscar el tiempo asociado al área seleccionada
            if (tiemposPorArea.TryGetValue(areaSeleccionada, out int tiempo))
            {
                tiempoRestante = tiempo * 60; // Convertir minutos a segundos
                lblTiempoTransferencia.Text = $"Tiempo restante para transferir a {areaSeleccionada}: {tiempo} minutos.";

                // Iniciar el temporizador
                timerTransferencia.Start();//Inicia el temporizador
            }
            else
            {
                lblTiempoTransferencia.Text = "El área seleccionada no tiene un tiempo asignado.";
            }
        }

        private void timerTransferencia_Tick(object sender, EventArgs e)
        {
            if (tiempoRestante > 0)//Si hay tiempo restante
            {
                tiempoRestante--;//Decrementa el tiempo restante

                // Convertir segundos restantes a formato de minutos:segundos
                int minutos = tiempoRestante / 60;//Obtiene los minutos
                int segundos = tiempoRestante % 60;//Obtiene los segundos
                lblTiempoTransferencia.Text = $"Tiempo restante: {minutos:D2}:{segundos:D2}";//Muestra el tiempo restante
            }
            else
            {
                timerTransferencia.Stop(); // Detener el temporizador

                // Mostrar mensaje final
                string areaSeleccionada = cmbAreas.SelectedItem.ToString();//   Obtiene el área seleccionada
                lblTiempoTransferencia.Text = $"Es su turno. Bienvenido a {areaSeleccionada}!";//Muestra el mensaje
                MessageBox.Show($"Es su turno. Bienvenido a {areaSeleccionada}!");//Muestra el mensaje
            }
        }
    }
}

