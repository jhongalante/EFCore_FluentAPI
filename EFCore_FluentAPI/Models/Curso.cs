using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore_FluentAPI.Models
{
    public class Curso
    {
        public int CursoId { get; set; }
        public string CursoNome { get; set; }
        public string Descricao { get; set; }
        public ICollection<AlunoCursos> AlunoCursos { get; set; }
    }
}
