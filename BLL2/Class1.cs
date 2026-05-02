using System;
using System.Data;
using System.Text.RegularExpressions;
using DAL;

namespace BLL
{
    public class ContactosBLL
    {
        // ── GUARDAR ──────────────────────────────────────
        public static bool Guardar(string nombre, string telefono,
                                   string correo, string direccion)
        {
            // Campos vacíos
            if (string.IsNullOrWhiteSpace(nombre))
                throw new Exception("El nombre es obligatorio.");

            if (string.IsNullOrWhiteSpace(telefono))
                throw new Exception("El teléfono es obligatorio.");

            if (string.IsNullOrWhiteSpace(correo))
                throw new Exception("El correo es obligatorio.");

            if (string.IsNullOrWhiteSpace(direccion))
                throw new Exception("La dirección es obligatoria.");

            // Formato teléfono: solo dígitos/guiones/espacios, 7-15 dígitos
            string soloDigitosTel = Regex.Replace(telefono, @"[\s\-]", "");
            if (!Regex.IsMatch(soloDigitosTel, @"^\d+$"))
                throw new Exception("El teléfono solo puede contener dígitos, guiones o espacios.");
            if (soloDigitosTel.Length < 7 || soloDigitosTel.Length > 15)
                throw new Exception("El teléfono debe tener entre 7 y 15 dígitos.");

            // Formato correo
            if (!Regex.IsMatch(correo.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase))
                throw new Exception("El correo no tiene un formato válido (ejemplo: usuario@correo.com).");

          
            if (ContactosDAL.ExisteCorreo(correo.Trim()))
                throw new Exception($"Ya existe un contacto con el correo '{correo.Trim()}'.");

       
            if (ContactosDAL.ExisteTelefono(telefono.Trim()))
                throw new Exception($"Ya existe un contacto con el teléfono '{telefono.Trim()}'.");

            return ContactosDAL.Guardar(nombre.Trim(), telefono.Trim(),
                                        correo.Trim(), direccion.Trim());
        }

    
        public static bool Editar(int idContacto, string nombre, string telefono,
                                  string correo, string direccion)
        {
            if (idContacto <= 0)
                throw new Exception("Debe seleccionar un contacto válido para editar.");

            if (string.IsNullOrWhiteSpace(nombre))
                throw new Exception("El nombre es obligatorio.");

            if (string.IsNullOrWhiteSpace(telefono))
                throw new Exception("El teléfono es obligatorio.");

            if (string.IsNullOrWhiteSpace(correo))
                throw new Exception("El correo es obligatorio.");

            if (string.IsNullOrWhiteSpace(direccion))
                throw new Exception("La dirección es obligatoria.");

            string soloDigitosTel = Regex.Replace(telefono, @"[\s\-]", "");
            if (!Regex.IsMatch(soloDigitosTel, @"^\d+$"))
                throw new Exception("El teléfono solo puede contener dígitos, guiones o espacios.");
            if (soloDigitosTel.Length < 7 || soloDigitosTel.Length > 15)
                throw new Exception("El teléfono debe tener entre 7 y 15 dígitos.");

            if (!Regex.IsMatch(correo.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase))
                throw new Exception("El correo no tiene un formato válido (ejemplo: usuario@correo.com).");

        
            if (ContactosDAL.ExisteCorreo(correo.Trim(), idContacto))
                throw new Exception($"Otro contacto ya usa el correo '{correo.Trim()}'.");

            if (ContactosDAL.ExisteTelefono(telefono.Trim(), idContacto))
                throw new Exception($"Otro contacto ya usa el teléfono '{telefono.Trim()}'.");

            return ContactosDAL.Editar(idContacto, nombre.Trim(), telefono.Trim(),
                                       correo.Trim(), direccion.Trim());
        }

       
        public static bool Eliminar(int idContacto)
        {
            if (idContacto <= 0)
                throw new Exception("Debe seleccionar un contacto válido para eliminar.");

            return ContactosDAL.Eliminar(idContacto);
        }

      
        public static DataTable ObtenerTodos()
        {
            return ContactosDAL.ObtenerTodos();
        }
    }
}