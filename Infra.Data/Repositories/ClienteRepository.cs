using Domain.Entities.Cliente;
using Domain.Interfaces;
using Domain.Interfaces.Repositories;

namespace Infra.Data.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
    }
}