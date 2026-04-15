namespace EL
{
    /// <summary>
    /// Entidad que representa un contacto marcado como favorito por un usuario.
    /// Relaciona un Usuario con un Contacto destacado.
    /// </summary>
    public class Favorito
    {
        // Identificador único del favorito
        public int IdFavorito { get; set; }

        // ID del usuario que marcó el contacto como favorito (clave foránea → Usuario)
        public int IdUsuario { get; set; }

        // ID del contacto marcado como favorito (clave foránea → Contacto)
        public int IdContacto { get; set; }

        // Fecha en que fue marcado como favorito
        public DateTime FechaAgregado { get; set; }

        // Nota personal opcional que el usuario puede agregar al favorito
        public string Nota { get; set; }

        // Objetos de navegación (relaciones)
        public Usuario Usuario { get; set; }
        public Contacto Contacto { get; set; }

        // Constructor por defecto
        public Favorito()
        {
            FechaAgregado = DateTime.Now;
        }

        // Constructor con parámetros principales
        public Favorito(int idFavorito, int idUsuario, int idContacto)
        {
            IdFavorito = idFavorito;
            IdUsuario = idUsuario;
            IdContacto = idContacto;
            FechaAgregado = DateTime.Now;
        }
    }
}
