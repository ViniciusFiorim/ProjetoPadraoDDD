using System.Collections.Generic;
using Domain.Entities.Cliente;

namespace Application.Interface
{
    public interface IClienteAppService : IAppServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais();
    }
}