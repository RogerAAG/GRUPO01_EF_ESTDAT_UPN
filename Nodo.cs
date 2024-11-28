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
            public string Nombre { get; set; }
            public string DNI { get; set; }
            public string Telefono { get; set; }
            public string Cargo { get; set; }
            public string Contraseña { get; set; }

            public NodoUsuario sig { get; set; } // Apunta al siguiente nodo
            public NodoUsuario ant { get; set; } // Apunta al nodo anterior
        }
        //NODO COLA DE LLAMADAS
        public class NodoColaLlamadas
        {
            public string Telefono_Cliente { get; set; }
            public string Cliente { get; set; }
            public string Tipo_Cliente { get; set; }
            public DateTime HoraLlamada { get; set; }
            public NodoColaLlamadas sig { get; set; }
        }
        //NODO LLAMADAS INTERRUMPIDAS
        public class NodoInterrupciones
        {
            public string Telefono { get; set; }
            public string Cliente { get; set; }
            public string TipoCliente { get; set; }
            public DateTime HoraLlamada { get; set; }
            public NodoInterrupciones Siguiente { get; set; } // Apunta al siguiente nodo en la pila
        }
        //NODO ARBOL DE ATENCION
        public class NodoArbol
        {
            public string Pregunta { get; set; }
            public NodoArbol Si { get; set; }
            public NodoArbol No { get; set; }

            public NodoArbol(string pregunta)
            {
                Pregunta = pregunta;
                Si = null;
                No = null;
            }
        }
    }
}
