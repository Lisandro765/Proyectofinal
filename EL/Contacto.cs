namespace EL
{
    /// <summary>
    /// Entidad que representa un contacto en la agenda.
    /// </summary>
    public class Contacto
    {
        // Identificador único del contacto
        public int IdContacto { get; set; }

        // Nombre del contacto
        public string Nombre { get; set; }

        // Apellido del contacto
        public string Apellido { get; set; }

        // Número de teléfono principal
        public string Telefono { get; set; }

        // Número de teléfono alternativo (opcional)
        public string TelefonoAlternativo { get; set; }

        // Dirección de correo electrónico
        public string Email { get; set; }

        // Dirección física del contacto
        public string Direccion { get; set; }

        // Fecha en que fue agregado el contacto
        public DateTime FechaRegistro { get; set; }

        // Constructor por defecto
        public Contacto()
        {
            FechaRegistro = DateTime.Now;
        }

        // Constructor con parámetros principales
        public Contacto(int idContacto, string nombre, string apellido, string telefono, string email)
        {
            IdContacto = idContacto;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Email = email;
            FechaRegistro = DateTime.Now;
        }

        // Retorna el nombre completo del contacto
        public string NombreCompleto()
        {
            return $"{Nombre} {Apellido}";
        }
    }
}
