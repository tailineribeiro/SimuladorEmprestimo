using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorEmprestimo.Bancos
{
    public abstract class Banco
    {
        public double TjPessoal { get; set; }
        public double TjVeicular { get; set; }

        
        public abstract void CalculoPessoal();
        public abstract void CalculoVeicular();

    }
}
