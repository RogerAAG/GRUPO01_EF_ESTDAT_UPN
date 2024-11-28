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
        public NodoArbol Raiz { get; private set; }
        public NodoArbol Actual;
        public ArbolAtencion()
        {
            ConstruirArbol();
        }

        private void ConstruirArbol()
        {
            Raiz = new NodoArbol("¿El router está encendido?");
            Raiz.Si = new NodoArbol("¿Hay luz en los indicadores del router?");
            Raiz.No = new NodoArbol("Solución: Encienda el router.");

            Raiz.Si.Si = new NodoArbol("¿Los cables están correctamente conectados?");
            Raiz.Si.No = new NodoArbol("Solución: Revise los cables.");

            Raiz.Si.Si.Si = new NodoArbol("Solución: Comuníquese con soporte técnico.");
            Raiz.Si.Si.No = new NodoArbol("Solución: Revise los cables.");

            Raiz.Si.Si.Si.Si = new NodoArbol("¿El servicio de Internet es intermitente?");
            Raiz.Si.Si.Si.Si.Si = new NodoArbol("Solución: Reinicie el router.");
            Raiz.Si.Si.Si.Si.No = new NodoArbol("¿Hay interrupciones solo en ciertos dispositivos?");
            Raiz.Si.Si.Si.Si.No.Si = new NodoArbol("Solución: Revise la configuración del Wi-Fi.");
            Raiz.Si.Si.Si.Si.No.No = new NodoArbol("Solución: Comuníquese con soporte técnico.");

            Raiz.No.Si = new NodoArbol("¿La pantalla muestra 'Sin Señal'?");
            Raiz.No.Si.Si = new NodoArbol("¿Está conectado el cable HDMI?");
            Raiz.No.Si.Si.Si = new NodoArbol("Solución: Cambie la entrada del televisor al puerto HDMI correcto.");
            Raiz.No.Si.Si.No = new NodoArbol("Solución: Verifique las conexiones del decodificador.");
            Raiz.No.Si.No = new NodoArbol("Solución: Comuníquese con soporte técnico.");
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
