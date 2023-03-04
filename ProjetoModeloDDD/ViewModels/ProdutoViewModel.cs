using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModeloDDD.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(250, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Nome { get; set; }
        
        [DataType(DataType.Currency)]
        [Range(typeof(Decimal), "0", "999999999999")]
        [Required(ErrorMessage = "Informe um valor")]
        public decimal Valor { get; set; }
        
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }  
        
        [DisplayName("Disponivel?")]
        public bool Ativo { get; set; }

        public int ClienteId { get; set; }
        public virtual ClienteViewModel Cliente { get; set; }
        
    }
}