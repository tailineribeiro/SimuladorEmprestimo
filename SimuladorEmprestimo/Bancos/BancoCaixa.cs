using SimuladorEmprestimo.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorEmprestimo.Bancos
{
    public class BancoCaixa : Banco
    {
                

        public static void MenuCaixa()
        {
            BancoCaixa banco = new BancoCaixa();
            Console.Write("Escolha a modalidade desejada: ");
            int.TryParse(Console.ReadLine(), out int modalidade);
            EscolhaModalidade op = (EscolhaModalidade)modalidade;
            switch (op)
            {
                case EscolhaModalidade.EmprestimoPessoal:
                    banco.CalculoPessoal();
                    break;
                case EscolhaModalidade.EmprestimoVeicular:
                    banco.CalculoVeicular();
                    break;

            }
                        
                
                   
        }

        public override void CalculoPessoal()
        {
            Console.WriteLine("Taxa de juros Emprestimo Pessoal: 26,46% a.a.");
        }

        public override void CalculoVeicular()
        {
            //calculo
        }
    }
}
