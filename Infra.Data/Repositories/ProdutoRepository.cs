using System.Collections.Generic;
using System.Linq;
using Domain.Entities.Produto;
using Domain.Interfaces.Repositories;

namespace Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return Db.Produtos.Where(p => p.Nome == nome);
        }
    }
}