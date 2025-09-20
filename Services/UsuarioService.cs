using ejemploAPIEstructura.Entities;
using ejemploAPIEstructura.Entities.Dtos.Request;
using ejemploAPIEstructura.Entities.Interfaces.Repository;
using ejemploAPIEstructura.Entities.Interfaces.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace ejemploAPIEstructura.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _repository;

        public UsuarioService(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        public async Task<string> Authentication(UserLoginRequestDto loginRequestDto)
        {
            var usuario =await _repository
                .GetAllAsync()
                .Where(u => u.UserName.ToUpper().Trim() == loginRequestDto.User.ToUpper().Trim())
                .FirstOrDefaultAsync();

            if (usuario == null)
                throw new Exception("User or password invalid");

            var passEncrypt = EncryptPassword(loginRequestDto.Password);

            var allowLogin = passEncrypt == usuario.Password;

            if (!allowLogin)
                throw new Exception("User or password invalid");

            //if (!usuario.status)
            //    throw new Exception("block user");

            //throw new NotImplementedException();

            var token = GetToken(usuario);

            if (token == null)
                throw new Exception("token could not be generated");

            return token;
        }

        string EncryptPassword(string pass)
        {
            var passBytes = Encoding.UTF8.GetBytes(pass);
            var passHash = SHA256.HashData(passBytes);
            return Convert.ToHexString(passHash);
        }

        public Task Delete(int id, Usuario alumno)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public string GetToken(Usuario user)
        {
            if(user == null)
                throw new Exception("User is required");

            var secretKey = _configuration["Authentication:Secretkey"] ?? throw new ArgumentNullException("Authentication:Secretkey", "The secret key is not configured.");

            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));

            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

            var header = new JwtHeader(signingCredentials);

            var claims = new[] {
                new Claim("Id",user.Id.ToString().Trim()),
                new Claim("UserName", user.UserName.ToString().Trim()),
                new Claim("UserEmail", user.Email.ToString().Trim()),
            };

            var payload = new JwtPayload(
                _configuration["Authentication:Issuer"],
                _configuration["Authentication:Audience"],
                claims,
                DateTime.Now,
                DateTime.UtcNow.AddHours(24)
                );

            var token = new JwtSecurityToken(header, payload);

            return new JwtSecurityTokenHandler().WriteToken(token);

            //throw new NotImplementedException();
        }

        public Task<Usuario> Insert(Usuario alumno)
        {
            throw new NotImplementedException();
        }
    }
}
