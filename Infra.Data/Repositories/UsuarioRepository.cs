using Domain.Entities.Usuario;
using Domain.Interfaces;
using Domain.Interfaces.Repositories;

namespace Infra.Data.Repositories
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
    {
    }
}