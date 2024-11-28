using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRUPO01_EF_ESTDAT_UPN
{
    public class Nodo
    {
        //NODO USUARIOS (LISTAS)
        public class NodoUsuario
        {
            public int ID { get; set; } // ID único del usuario
            public string Nombre { get; set; }// Nombre del usuario
            public string DNI { get; set; }// DNI del usuario
            public string Telefono { get; set; }// Telefono del usuario
            public string Cargo { get; set; }// Cargo del usuario
            public string Contraseña { get; set; }// Contraseña del usuario

            public NodoUsuario sig { get; set; } // Apunta al siguiente nodo
            public NodoUsuario ant { get; set; } // Apunta al nodo anterior
        }
        //NODO COLA DE LLAMADAS
        public class NodoColaLlamadas
        {
            public string Telefono_Cliente { get; set; }// Telefono del cliente
            public string Cliente { get; set; }// Nombre del cliente
            public string Tipo_Cliente { get; set; }// Tipo de cliente
            public DateTime HoraLlamada { get; set; }// Hora de la llamada
            public NodoColaLlamadas sig { get; set; }// Apunta al siguiente nodo
        }
        //NODO LLAMADAS INTERRUMPIDAS
        public class NodoInterrupciones
        {
            public string Telefono { get; set; }// Telefono del cliente
            public string Cliente { get; set; }// Nombre del cliente
            public string TipoCliente { get; set; }// Tipo de cliente
            public DateTime HoraLlamada { get; set; }// Hora de la llamada
            public string Servicio { get; set; }
            public NodoInterrupciones Siguiente { get; set; } // Apunta al siguiente nodo en la pila
        }
        //NODO ARBOL DE ATENCION
        public class NodoArbol
        {
            public string Pregunta { get; set; }
            public NodoArbol Si { get; set; }
            public NodoArbol No { get; set; }
            public bool EsSolucion => Si == null && No == null; // Identifica si es nodo final
            public NodoArbol Raiz { get; private set; }

            public NodoArbol(string pregunta)
            {
                Pregunta = pregunta;
            }
        }
    }
}
