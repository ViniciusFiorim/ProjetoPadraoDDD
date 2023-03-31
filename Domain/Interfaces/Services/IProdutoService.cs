using System;
using System.Collections.Generic;
using Domain.Entities.Produto;

namespace Domain.Interfaces.Services
{
    public interface IProdutoService : IServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(String nome);
    }
}