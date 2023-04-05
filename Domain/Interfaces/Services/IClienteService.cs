using System.Collections.Generic;
using Domain.Entities.Cliente;

namespace Domain.Interfaces.Services
{
    public interface IClienteService : IServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes);
    }
}