using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore_FluentAPI.Models
{
    public class AlunoCursos
    {
        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }
        public int CursoId { get; set; }
        public Curso Curso { get; set; }
    }
}
