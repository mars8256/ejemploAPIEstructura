using Microsoft.Identity.Client;

namespace ejemploAPIEstructura.Entities
{
    public class Usuario : Base
    {
        public string UserName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
