using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoletimAPI.Entities
{
    public class Professor
    {

        public int id { get; set; }

        public string Nome { get; set; }

        public ICollection<Disciplina> Disciplinas { get; set; }
    }
}