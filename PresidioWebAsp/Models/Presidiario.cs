using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PresidioWebAsp.Models
{
    public class Presidiario
    {

        public int PresidiarioId { get; set; }
        public string Nome { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public Escolaridade Escolaridade { get; set; }

        public Cela Cela { get; set; }
    }
}
