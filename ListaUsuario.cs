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
        private NodoUsuario ini;//Nodo inicial
        private NodoUsuario fin;//Nodo final
        private static int contadorID = 1; // Contador para IDs
        //AGREGAR USUARIO
        public void AgregarUsuario(string nombre, string dni, string telefono, string cargo, string contraseña)
        {
            NodoUsuario nuevoNodo = new NodoUsuario//Nuevo nodo
            {
                ID = contadorID++, // Asignar ID y luego incrementar
                Nombre = nombre,
                DNI = dni,
                Telefono = telefono,
                Cargo = cargo,
                Contraseña = contraseña,
                sig = null,// Apuntar al siguiente nodo
                ant = fin// Apuntar al último nodo
            };

            if (ini == null)
            {
                ini = nuevoNodo;// Si la lista está vacía, el nuevo nodo es el primero
            }
            else
            {
                fin.sig = nuevoNodo;// Si no, el último nodo apunta al nuevo nodo
            }
            fin = nuevoNodo;// El nuevo nodo es el último
        }
        //BUSCAR USUARIO
        public NodoUsuario BuscarUsuario(string dni)//Buscar usuario por DNI
        {
            NodoUsuario actual = ini;//Nodo actual es el primero
            while (actual != null)//Mientras el nodo actual no sea nulo
            {
                if (actual.DNI == dni) return actual;
                actual = actual.sig;// Avanzar al siguiente nodo
            }
            return null;//Retornar nulo si no se encuentra el usuario
        }
        //ELIMINAR USUARIO
        public void EliminarUsuario(string dni)
        {
            NodoUsuario actual = ini;//Nodo actual es el primero

            while (actual != null)//Mientras el nodo actual no sea nulo
            {
                if (actual.DNI == dni)//Si el DNI del nodo actual es igual al DNI buscado
                {
                    if (actual.ant != null)//Si el nodo anterior no es nulo
                    {
                        actual.ant.sig = actual.sig;//El nodo siguiente del anterior nodo es el siguiente del nodo actual
                    }
                    else
                    {
                        ini = actual.sig;//El nodo siguiente es el primero
                    }

                    if (actual.sig != null)//Si el nodo siguiente no es nulo
                    {
                        actual.sig.ant = actual.ant;//El nodo anterior del siguiente nodo es el anterior del nodo actual
                    }
                    else
                    {
                        ini = actual.ant;//El nodo anterior es el último
                    }

                    return;
                }
                actual = actual.sig;//Avanzar al siguiente nodo
            }
        }
        //recursividad
        public List<NodoUsuario> ObtenerUsuarios()//Obtener lista de usuarios
        {
            List<NodoUsuario> usuarios = new List<NodoUsuario>();//Lista de usuarios
            NodoUsuario actual = ini;//Nodo actual es el primero

            while (actual != null)//Mientras el nodo actual no sea nulo
            {
                usuarios.Add(actual);//Agregar el nodo actual a la lista
                actual = actual.sig;//Avanzar al siguiente nodo
            }
            return usuarios;//Retornar la lista de usuarios
        }
    }
}
