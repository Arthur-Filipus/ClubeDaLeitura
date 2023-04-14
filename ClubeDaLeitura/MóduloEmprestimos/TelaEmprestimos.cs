using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.MóduloEmprestimos
{
    public class TelaEmprestimos
    {
        RepositorioEmprestimos repositorio = new RepositorioEmprestimos();
        List<Emprestimos> lista = new List<Emprestimos>();
        public void MenuEmprestimos()
        {
            bool menuemprestimo = true;

            while (menuemprestimo)
            {
                Console.WriteLine("QQ C quer");
                Console.WriteLine("(1) Cadastrar - (2) Editar - (3) Excluir - (4) Verificar - (S) Sair");

                string escolha = Console.ReadLine().ToUpper();

                if (escolha == "1")
                {
                    repositorio.CadastrarEmprestimos();
                }
                else if (escolha == "2")
                {
                    repositorio.EditarEmprestimos();
                }
                else if (escolha == "3")
                {
                    repositorio.ExcluirEmprestimos();
                }
                else if (escolha == "4")
                {
                    repositorio.VerificarEmprestimos();
                }
                else if (escolha == "S")
                {
                    menuemprestimo = false;
                }
                else
                {
                    Console.WriteLine("Resposta inválida, tente novamente");
                }
            }
        }
    }
}
