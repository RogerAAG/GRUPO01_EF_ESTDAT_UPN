using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GRUPO01_EF_ESTDAT_UPN.Nodo;

namespace GRUPO01_EF_ESTDAT_UPN
{
    public class ListaUsuario
    {
        private NodoUsuario ini;
        private NodoUsuario fin;
        private static int contadorID = 1; // Contador para IDs
        //AGREGAR USUARIO
        public void AgregarUsuario(string nombre, string dni, string telefono, string cargo, string contraseña)
        {
            NodoUsuario nuevoNodo = new NodoUsuario
            {
                ID = contadorID++, // Asignar ID y luego incrementar
                Nombre = nombre,
                DNI = dni,
                Telefono = telefono,
                Cargo = cargo,
                Contraseña = contraseña,
                sig = null,
                ant = fin
            };

            if (ini == null)
            {
                ini = nuevoNodo;
            }
            else
            {
                fin.sig = nuevoNodo;
            }
            fin = nuevoNodo;
        }
        //BUSCAR USUARIO
        public NodoUsuario BuscarUsuario(string dni)
        {
            NodoUsuario actual = ini;
            while (actual != null)
            {
                if (actual.DNI == dni) return actual;
                actual = actual.sig;
            }
            return null;
        }
        //ELIMINAR USUARIO
        public void EliminarUsuario(string dni)
        {
            NodoUsuario actual = ini;

            while (actual != null)
            {
                if (actual.DNI == dni)
                {
                    if (actual.ant != null)
                    {
                        actual.ant.sig = actual.sig;
                    }
                    else
                    {
                        ini = actual.sig;
                    }

                    if (actual.sig != null)
                    {
                        actual.sig.ant = actual.ant;
                    }
                    else
                    {
                        ini = actual.ant;
                    }

                    return;
                }
                actual = actual.sig;
            }
        }
        //recursividad
        public List<NodoUsuario> ObtenerUsuarios()
        {
            List<NodoUsuario> usuarios = new List<NodoUsuario>();
            NodoUsuario actual = ini;

            while (actual != null)
            {
                usuarios.Add(actual);
                actual = actual.sig;
            }
            return usuarios;
        }
    }
}
