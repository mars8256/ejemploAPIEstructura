namespace ejemploAPIEstructura.Entities.Interfaces.Repository
{
    public interface IUsuarioRepository : IRepositoryBase<Usuario>
    {
        IQueryable<Usuario> GetAllByFilter();
    }
}
