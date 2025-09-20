namespace ejemploAPIEstructura.Entities.Dtos.Request
{
    public class UsuarioRequestDto
    {
        public string UserName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
