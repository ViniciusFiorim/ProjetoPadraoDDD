using System;
using System.Collections.Generic;
using Domain.Entities.Produto;

namespace Application.Interface
{
    public interface IProdutoAppService : IAppServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(String nome);
    }
}