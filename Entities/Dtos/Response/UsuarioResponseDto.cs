﻿namespace ejemploAPIEstructura.Entities.Dtos.Response
{
    public class UsuarioResponseDto
    {
        public int Id { get; set; }
        public string UserName { get; set; } = null!;
        public string Email { get; set; } = null!;
    }
}
