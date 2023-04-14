using System;
using System.Collections.Generic;

namespace Domain.Entities.Cliente
{
    public class Cliente : BaseEntity
    {
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }

        #region Colection

        public virtual IEnumerable<Produto.Produto> Produtos { get; set; }

        #endregion
        
        public bool ClienteEspecial(Cliente cliente)
        {
            return cliente.Ativo && DateTime.Now.Year - cliente.DataCadastro.Year >= 5;
        }
    }
}