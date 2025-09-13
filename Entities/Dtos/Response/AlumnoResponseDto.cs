namespace ejemploAPIEstructura.Entities.Dtos.Response
{
    public class AlumnoResponseDto
    {
        //base
        public int Id { get; set; }
        public int IdUsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int IdUsuarioModificacion { get; set; }
        public DateTime FechaModificacion { get; set; }

        //objeto
        public string? Name { get; set; }

    }
}
