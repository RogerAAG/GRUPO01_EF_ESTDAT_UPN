using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GRUPO01_EF_ESTDAT_UPN
{
    public partial class FormTransferencias : Form
    {
        private GrafoTransferencias grafo;

        public FormTransferencias()
        {
            InitializeComponent();
            InicializarGrafo();

            // Suscribir el evento Paint al panel
            panelGrafo.Paint += new PaintEventHandler(PanelGrafo_Paint);
        }

        private void InicializarGrafo()
        {
            grafo = new GrafoTransferencias();

            var ac = grafo.AgregarNodo("Atención al Cliente");
            var f = grafo.AgregarNodo("Facturación");
            var st = grafo.AgregarNodo("Soporte Técnico");
            var rh = grafo.AgregarNodo("Recursos Humanos");
            var ti = grafo.AgregarNodo("TI Interno");
            var a = grafo.AgregarNodo("Administración");

            grafo.AgregarArista(ac, f, 3);
            grafo.AgregarArista(ac, st, 4);
            grafo.AgregarArista(f, rh, 4);
            grafo.AgregarArista(st, ti, 3);
            grafo.AgregarArista(rh, a, 5);
            grafo.AgregarArista(ti, a, 5);
        }

        private void PanelGrafo_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Blue, 2);
            Font font = new Font("Century Gothic", 11);
            Brush brush = Brushes.Black;

            // Tamaño y posición ajustados al panel
            var ancho = panelGrafo.Width;
            var alto = panelGrafo.Height;

            var posiciones = new Dictionary<string, Point>
            {
                { "Atención al Cliente", new Point(ancho / 2, alto / 8) },
                { "Facturación", new Point(ancho / 4, alto / 3) },
                { "Soporte Técnico", new Point(3 * ancho / 4, alto / 3) },
                { "Recursos Humanos", new Point(ancho / 4, 2 * alto / 3) },
                { "TI Interno", new Point(3 * ancho / 4, 2 * alto / 3) },
                { "Administración", new Point(ancho / 2, 7 * alto / 8) }
            };

            // Dibujar conexiones
            foreach (var nodo in grafo.Nodos)
            {
                foreach (var conexion in nodo.Conexiones)
                {
                    Point origen = posiciones[nodo.Departamento];
                    Point destino = posiciones[conexion.Key.Departamento];
                    g.DrawLine(pen, origen, destino);
                    g.DrawString($"{conexion.Value} min", font, brush,
                                 (origen.X + destino.X) / 2,
                                 (origen.Y + destino.Y) / 2);
                }
            }

            // Dibujar nodos
            foreach (var pos in posiciones)
            {
                g.FillEllipse(Brushes.Blue, pos.Value.X - 15, pos.Value.Y - 15, 30, 30);
                g.DrawString(pos.Key, font, Brushes.White, pos.Value.X - 40, pos.Value.Y - 25);
            }
        }
    }
}

