using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoletimAPI.Entities
{
    public class AlunoDisciplina
    {
        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }
        public int DisciplinaId { get; set; }
        public Disciplina Disciplina { get; set; }
        public int Teste1 { get; set; }
        public int Teste2 { get; set; }
        public int Prova2 { get; set; }
    }
}