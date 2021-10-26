using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore_FluentAPI.Models
{
    public class Aluno
    {
        public int AlunoId { get; set; }
        public string Nome { get; set; }
        public ICollection<AlunoCursos> AlunoCursos { get; set; }
    }
}
