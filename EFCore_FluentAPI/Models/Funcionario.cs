using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore_FluentAPI.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Setor Setor { get; set; }
    }
}
