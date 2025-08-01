using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoletimAPI.Entities
{
    public class Aluno
    {

        public int id { get; set; }
        public string Nome { get; set; }

        public ICollection<AlunoDisciplina> AlunoDisciplinas { get; set; }
    }
}