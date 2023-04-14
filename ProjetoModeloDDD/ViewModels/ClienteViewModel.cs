using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModeloDDD.ViewModels
{
    public class ClienteViewModel
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Nome { get; set; }
        
        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string SobreNome { get; set; }
        
        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [EmailAddress(ErrorMessage = "Informe um E-mail válido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(11, ErrorMessage = "Máximo {0} caracteres")]
        [EmailAddress(ErrorMessage = "Informe um celular válido")]
        [DisplayName("Celular")]
        public string Celular { get; set; }
        
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        
        public bool Ativo { get; set; }
        public virtual IEnumerable<ProdutoViewModel> produtos { get; set; }
    }
}