namespace EL
{
    /// <summary>
    /// Entidad que representa un grupo o categoría para clasificar contactos.
    /// Ejemplos: Familia, Trabajo, Amigos, Escuela, etc.
    /// </summary>
    public class Grupo
    {
        // Identificador único del grupo
        public int IdGrupo { get; set; }

        // Nombre del grupo (ej: "Familia", "Trabajo", "Amigos")
        public string Nombre { get; set; }

        // Descripción opcional del grupo
        public string Descripcion { get; set; }

        // Color representativo del grupo para mostrar en la interfaz (ej: "#FF5733")
        public string Color { get; set; }

        // Fecha en que fue creado el grupo
        public DateTime FechaCreacion { get; set; }

        // Constructor por defecto
        public Grupo()
        {
            FechaCreacion = DateTime.Now;
            Color = "#2196F3"; // Azul por defecto
        }

        // Constructor con parámetros principales
        public Grupo(int idGrupo, string nombre, string descripcion, string color)
        {
            IdGrupo = idGrupo;
            Nombre = nombre;
            Descripcion = descripcion;
            Color = color;
            FechaCreacion = DateTime.Now;
        }
    }
}
