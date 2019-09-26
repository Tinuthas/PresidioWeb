using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PresidioWebAsp.Models
{
    public class Cela
    {
        public int CelaId { get; set; }
        public string Nome { get; set; }
        public List<Presidiario> Presidiarios { get; set; }
    }
}
