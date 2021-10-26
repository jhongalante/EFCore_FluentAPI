using System.Collections.Generic;

namespace EFCore_FluentAPI.Models
{
    public class Setor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Funcionario> Funcionarios { get; set; }
    }
}