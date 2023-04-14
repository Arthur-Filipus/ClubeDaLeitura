using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.MóduloCaixas
{
    public class TelaCaixas
    {
        RepositorioCaixas repositorio = new RepositorioCaixas();
        List<Caixas> lista = new List<Caixas>();
        public void MenuCaixas()
        {           
            bool menucaixas = true;

            while (menucaixas)
            {
                Console.WriteLine("                 QQ ce quer");
                Console.WriteLine("(1) Cadastro - (2) Editar - (3) Excluir - (4) Verificar - (S) Sair");

                string escolha = Console.ReadLine().ToUpper();
                Console.WriteLine();

                if (escolha == "1")
                {
                    repositorio.CadastrarCaixas(lista);
                }
                else if (escolha == "2")
                {
                    repositorio.EditarCaixas(lista);
                }
                else if (escolha == "3")
                {
                    repositorio.ExcluirCaixas(lista);
                }
                else if (escolha == "4")
                {
                    repositorio.VerificarCaixas(lista);
                }
                else if (escolha == "S")
                {
                    menucaixas = false;
                }
                else
                {
                    Console.WriteLine("Resposta inválida, tente novamente");
                }
            }
        }
    }
}
