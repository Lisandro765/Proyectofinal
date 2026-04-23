using System;
using DAL;

namespace BLL
{
    public class ContactosBLL
    {
        public static bool Guardar(string nombre, string telefono,
                                   string correo, string direccion)
        {
            if (string.IsNullOrEmpty(nombre))
                throw new Exception("El nombre es obligatorio.");

            return ContactosDAL.Guardar(nombre, telefono, correo, direccion);
        }
    }
}