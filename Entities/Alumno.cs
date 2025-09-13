using System.ComponentModel.DataAnnotations.Schema;

namespace ejemploAPIEstructura.Entities
{
    [Table("Alumno")]
    public class Alumno : Base
    {
        public string? Name { get; set; }
        public string? SecondName { get; set; }
        public string? Carnet {  get; set; }
        //public List<Curso>? CursosActuales { get; set; }
    }
}
