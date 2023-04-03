using System;

namespace Domain.Entities.Produto
{
    public class Produto : BaseEntity
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public int? ClienteId { get; set; }

        #region FK's
        
        public virtual Cliente.Cliente Cliente { get; set; }      
        
        #endregion
    }
}