namespace EL
{
    /// <summary>
    /// Entidad que representa un usuario del sistema (para login).
    /// </summary>
    public class Usuario
    {
        // Identificador único del usuario
        public int IdUsuario { get; set; }

        // Nombre de usuario para iniciar sesión
        public string NombreUsuario { get; set; }

        // Contraseña del usuario (se recomienda guardar encriptada)
        public string Contrasena { get; set; }

        // Nombre real del usuario
        public string Nombre { get; set; }

        // Apellido real del usuario
        public string Apellido { get; set; }

        // Rol del usuario dentro del sistema (ej: "admin", "usuario")
        public string Rol { get; set; }

        // Indica si la cuenta está activa
        public bool Activo { get; set; }

        // Fecha en que fue creado el usuario
        public DateTime FechaCreacion { get; set; }

        // Constructor por defecto
        public Usuario()
        {
            Activo = true;
            FechaCreacion = DateTime.Now;
            Rol = "usuario";
        }

        // Constructor con parámetros principales
        public Usuario(int idUsuario, string nombreUsuario, string contrasena, string nombre, string apellido)
        {
            IdUsuario = idUsuario;
            NombreUsuario = nombreUsuario;
            Contrasena = contrasena;
            Nombre = nombre;
            Apellido = apellido;
            Activo = true;
            FechaCreacion = DateTime.Now;
            Rol = "usuario";
        }

        // Retorna el nombre completo del usuario
        public string NombreCompleto()
        {
            return $"{Nombre} {Apellido}";
        }
    }
}
