using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            // Suscribir el evento Paint
            this.Paint += new PaintEventHandler(FormTransferencias_Paint);
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

        private void FormTransferencias_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Blue, 2);
            Font font = new Font("Arial", 10);
            Brush brush = Brushes.Black;

            var posiciones = new Dictionary<string, Point>
            {
                { "Atención al Cliente", new Point(100, 50) },
                { "Facturación", new Point(50, 150) },
                { "Soporte Técnico", new Point(150, 150) },
                { "Recursos Humanos", new Point(50, 250) },
                { "TI Interno", new Point(150, 250) },
                { "Administración", new Point(100, 350) }
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
