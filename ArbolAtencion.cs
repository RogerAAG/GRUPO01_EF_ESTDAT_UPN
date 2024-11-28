using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GRUPO01_EF_ESTDAT_UPN.Nodo;

namespace GRUPO01_EF_ESTDAT_UPN
{
    internal class ArbolAtencion
    {
        public NodoArbol Raiz;
        public NodoArbol Actual;
        public string ServicioSeleccionado { get; private set; }

        public ArbolAtencion()
        {

            Raiz = new NodoArbol("Default question");
        }

        // Método para seleccionar el servicio y construir el árbol correspondiente
        public void SeleccionarServicio(string servicio)
        {
            if (string.IsNullOrWhiteSpace(servicio) ||
            !new List<string> { "Servicio de internet", "TV por Cable", "Telefonia Fija" }
            .Contains(servicio.Trim(), StringComparer.OrdinalIgnoreCase))
            {
                throw new ArgumentException("Servicio no reconocido");
            }
            ServicioSeleccionado = servicio;
            ConstruirArbol();
        }

        // Método para construir el árbol de decisiones según el servicio seleccionado
        private void ConstruirArbol()
        {
            switch (ServicioSeleccionado.Trim().ToLower())
            {
                case "Servicio de internet":
                    ConstruirArbolInternet();
                    break;
                case "TV por Cable":
                    ConstruirArbolTV();
                    break;
                case "Telefonia Fija":
                    ConstruirArbolTelefonia();
                    break;
                default:
                    throw new ArgumentException("Servicio no reconocido");
            }
        }

        private void ConstruirArbolInternet()
        {
            Raiz = new NodoArbol("¿El router está encendido?");
            Raiz.Si = new NodoArbol("¿Hay luz en los indicadores del router?");
            Raiz.No = new NodoArbol("Solución: Encienda el router.");

            Raiz.Si.Si = new NodoArbol("¿Los cables están correctamente conectados?");
            Raiz.Si.No = new NodoArbol("Solución: Revise los cables.");

            Raiz.Si.Si.Si = new NodoArbol("Solución: Comuníquese con soporte técnico.");
            Raiz.Si.Si.No = new NodoArbol("Solución: Revise los cables.");

            var nodoIntermitente = new NodoArbol("¿El servicio de Internet es intermitente?");
            nodoIntermitente.Si = new NodoArbol("Solución: Reinicie el router.");
            nodoIntermitente.No = new NodoArbol("¿Hay interrupciones solo en ciertos dispositivos?");
            nodoIntermitente.No.Si = new NodoArbol("Solución: Revise la configuración del Wi-Fi.");
            nodoIntermitente.No.No = new NodoArbol("Solución: Comuníquese con soporte técnico.");

            Raiz.Si.Si.Si.Si = nodoIntermitente;
        }

        private void ConstruirArbolTV()
        {
            Raiz = new NodoArbol("¿La pantalla muestra 'Sin Señal'?");
            Raiz.Si = new NodoArbol("¿Está conectado el cable HDMI?");
            Raiz.No = new NodoArbol("Solución: Comuníquese con soporte técnico.");

            Raiz.Si.Si = new NodoArbol("Solución: Cambie la entrada del televisor al puerto HDMI correcto.");
            Raiz.Si.No = new NodoArbol("Solución: Verifique las conexiones del decodificador.");
        }

        private void ConstruirArbolTelefonia()
        {
            Raiz = new NodoArbol("¿El teléfono tiene tono de marcado?");
            Raiz.Si = new NodoArbol("¿Puede realizar llamadas?");
            Raiz.No = new NodoArbol("Solución: Verifique las conexiones del teléfono.");

            Raiz.Si.Si = new NodoArbol("Solución: El servicio está funcionando correctamente.");
            Raiz.Si.No = new NodoArbol("Solución: Comuníquese con soporte técnico.");
        }

        public void Reiniciar()
        {
            Actual = Raiz; // Vuelve al inicio del árbol
        }

        public (string texto, bool habilitarSi, bool habilitarNo) ActualizarPregunta()
        {
            if (Actual == null)
                return ("Fin del Árbol: Decisión Tomada.", false, false);

            return (Actual.Pregunta, Actual.Si != null, Actual.No != null);
        }
    }
}
