using SimuladorEmprestimo.Bancos;
using SimuladorEmprestimo.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuSimuladorEmprestimo
{
    internal class MenuBanco
    {
        public static void Menu()
        {
            bool sair = false;
            while (sair==false)
            {
                Console.WriteLine("Bem Vindo ao Simulador de Emprestimo ");
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

                Console.WriteLine("1-Ver Taxas de Juros\n2-Caixa Econômica Federal\n3-Itaú Unibanco\n4-Banco Santander\n5-Banco Bradesco\n6-Sair");
                Console.Write("Escolha a opção desejada: ");
                int.TryParse(Console.ReadLine(), out int opcao);

                EscolhaMenuPrincipal op = (EscolhaMenuPrincipal)opcao;
                switch (op)
                {
                    case EscolhaMenuPrincipal.VerTaxaJuro:
                        //vem do banco de dados;
                        break;
                    
                    case EscolhaMenuPrincipal.Caixa:
                        BancoCaixa.MenuCaixa();
                        break;
                    case EscolhaMenuPrincipal.Itau:
                        break;
                    case EscolhaMenuPrincipal.Santander:
                        break;
                    case EscolhaMenuPrincipal.Bradesco:
                        break;
                    case EscolhaMenuPrincipal.Sair:
                        sair = true;
                        break;
                    default:
                        sair = true;
                        break;
                }
                Console.Clear();

            }
        }
    }
}
