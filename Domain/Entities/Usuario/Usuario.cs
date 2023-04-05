using System;
using System.Collections.Generic;

namespace Domain.Entities.Usuario
{
    public class Usuario : BaseEntity
    {
        public string NomeCompleto { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool IsAdmin { get; set; }
    }
}