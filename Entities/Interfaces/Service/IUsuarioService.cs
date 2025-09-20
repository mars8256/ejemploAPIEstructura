using ejemploAPIEstructura.Entities.Dtos.Request;

namespace ejemploAPIEstructura.Entities.Interfaces.Service
{
    public interface IUsuarioService
    {
        Task<Usuario> Insert(Usuario alumno);
        Task Delete(int id, Usuario alumno);
        Task<Usuario> GetById(int id);
        List<Usuario> GetAll();
        Task<string> Authentication(UserLoginRequestDto loginRequestDto);
        string GetToken(Usuario user);
    }
}
