﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GRUPO01_EF_ESTDAT_UPN.Nodo;

namespace GRUPO01_EF_ESTDAT_UPN
{
    internal class ArbolAtencion
    {
        public NodoArbol Raiz;// Raíz del árbol
        public NodoArbol Actual;// Nodo actual en el árbol
        public string ServicioSeleccionado { get; private set; }// Servicio seleccionado

        public ArbolAtencion()//Constructor  
        {

            Raiz = new NodoArbol("Default question");
        }

        // Método para seleccionar el servicio y construir el árbol correspondiente
        public void SeleccionarServicio(string servicio)
        {
            if (string.IsNullOrWhiteSpace(servicio) ||// Verificar si el servicio es válido
            !new List<string> { "Servicio de internet", "TV por Cable", "Telefonia Fija" }
            .Contains(servicio.Trim(), StringComparer.OrdinalIgnoreCase))// Ignorar mayúsculas y minúsculas
            {
                throw new ArgumentException("Servicio no reconocido");
            }
            ServicioSeleccionado = servicio;
            ConstruirArbol();
        }

        // Método para construir el árbol de decisiones según el servicio seleccionado
        private void ConstruirArbol()
        {
            switch (ServicioSeleccionado)//Construir el árbol según el servicio seleccionado
            {
                case "Servicio de Internet"://Construir el árbol para el servicio de Internet
                    ConstruirArbolInternet();
                    break;
                case "TV por Cable"://Construir el árbol para el servicio de TV por cable
                    ConstruirArbolTV();
                    break;
                case "Telefonia Fija"://Construir el árbol para el servicio de telefonía fija
                    ConstruirArbolTelefonia();
                    break;
                default:
                    throw new ArgumentException("Servicio no reconocido");//Lanzar excepción si el servicio no es reconocido
            }
        }

        private void ConstruirArbolInternet()//Método para arbol de decisiones
        {
            Raiz = new NodoArbol("¿El router está encendido?");
            Raiz.Si = new NodoArbol("¿Hay luz en los indicadores del router?");
            Raiz.No = new NodoArbol("Solución: Encienda el router.");

            Raiz.Si.Si = new NodoArbol("¿Los cables están correctamente conectados?");
            Raiz.Si.No = new NodoArbol("Solución: Revise los cables.");

            Raiz.Si.Si.Si = new NodoArbol("Solución: Comuníquese con soporte técnico.");
            Raiz.Si.Si.No = new NodoArbol("Solución: Revise los cables.");

            var nodoIntermitente = new NodoArbol("¿El servicio de Internet es intermitente?");//Nodo para servicio intermitente
            nodoIntermitente.Si = new NodoArbol("Solución: Reinicie el router.");
            nodoIntermitente.No = new NodoArbol("¿Hay interrupciones solo en ciertos dispositivos?");
            nodoIntermitente.No.Si = new NodoArbol("Solución: Revise la configuración del Wi-Fi.");
            nodoIntermitente.No.No = new NodoArbol("Solución: Comuníquese con soporte técnico.");

            Raiz.Si.Si.Si.Si = nodoIntermitente;
        }

        private void ConstruirArbolTV()//Método para arbol de decisiones
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

        public (string texto, bool habilitarSi, bool habilitarNo) ActualizarPregunta()//Método para actualizar la pregunta
        {
            if (Actual == null)
                return ("Fin del Árbol: Decisión Tomada.", false, false);//Mensaje de fin del árbol

            return (Actual.Pregunta, Actual.Si != null, Actual.No != null);//Retorna la pregunta actual
        }
    }
}
