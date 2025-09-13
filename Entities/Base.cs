namespace ejemploAPIEstructura.Entities
{
    public class Base 
    {
        public int Id { get; set; }
        public int IdUsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int IdUsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
