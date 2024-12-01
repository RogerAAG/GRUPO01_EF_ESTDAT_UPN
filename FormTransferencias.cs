using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GRUPO01_EF_ESTDAT_UPN
{
    public partial class FormTransferencias : Form
    {
        private GrafoTransferencias grafo;

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
    }
}

