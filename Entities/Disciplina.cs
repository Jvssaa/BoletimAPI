using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BoletimAPI.Entities
{
    public class Disciplina
    {

        public int id { get; set; }
        public string Nome { get; set; }
        public ICollection<AlunoDisciplina> AlunoDisciplinas { get; set; }
        public ICollection<Professor> Professores { get; set; }
    }
}