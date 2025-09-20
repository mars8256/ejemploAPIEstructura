using Microsoft.Identity.Client;

namespace ejemploAPIEstructura.Entities.Dtos.Request
{
    public class UserLoginRequestDto
    {
        public string User { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
