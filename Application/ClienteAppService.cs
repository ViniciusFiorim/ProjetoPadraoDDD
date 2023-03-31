using System.Collections.Generic;
using Application.Interface;
using Domain.Entities.Cliente;
using Domain.Interfaces.Services;

namespace Application
{
    public class ClienteAppService : AppServiceBase<Cliente>, IClienteAppService
    {
        private readonly IClienteService _clienteService;
        public ClienteAppService(IClienteService clienteService) : base(clienteService)
        {
            _clienteService = clienteService;
        }

        public IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> getAll)
        {
            return _clienteService.ObterClientesEspeciais(_clienteService.GetAll());
        }
    }
}