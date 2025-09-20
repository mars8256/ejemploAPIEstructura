namespace ejemploAPIEstructura.Entities.Dtos.Response
{
    public class AlumnoResponseDto
    {
        
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? SecondName { get; set; }
        public string? Carnet { get; set; }
        public int IdUsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int IdUsuarioModificacion { get; set; }
        public DateTime FechaModificacion { get; set; }

        public UsuarioResponseDto? UsuarioCreacion { get; set; }


      
      

    }
}
