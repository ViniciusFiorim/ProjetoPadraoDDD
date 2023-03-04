using Domain.Entities.Cliente;
using Domain.Interfaces;

namespace Infra.Data.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
    }
}