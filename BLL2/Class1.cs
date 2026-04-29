using System;
using DAL;

namespace BLL
{
    public class ContactosBLL
    {

        public static bool Guardar(string nombre, string telefono,
                                   string correo, string direccion)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new Exception("El nombre es obligatorio.");

            return ContactosDAL.Guardar(nombre, telefono, correo, direccion);
        }


        public static bool Eliminar(int idContacto)
        {
            if (idContacto <= 0)
                throw new Exception("Debe seleccionar un contacto válido para eliminar.");

            return ContactosDAL.Eliminar(idContacto);
        }


        public static bool Editar(int idContacto, string nombre, string telefono,
                                  string correo, string direccion)
        {
            if (idContacto <= 0)
                throw new Exception("Debe seleccionar un contacto válido para editar.");

            if (string.IsNullOrWhiteSpace(nombre))
                throw new Exception("El nombre es obligatorio.");

            return ContactosDAL.Editar(idContacto, nombre, telefono, correo, direccion);
        }
    }
}