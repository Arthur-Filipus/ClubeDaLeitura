using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.MóduloAmigos
{
    public class TelaAmigos
    {
        List<Amigos> listaamigos = new List<Amigos>();
        RepositorioAmigos repositorio = new RepositorioAmigos();
        public void MenuAmigos()
        {
            bool menuamigos = true;

            while (menuamigos)
            {
                Console.WriteLine("QQ ce quer");
                Console.WriteLine("(1) Cadastro - (2) Editar - (3) Excluir - (4) Verificar - (S) Sair");

                string escolha = Console.ReadLine().ToUpper();

                if (escolha == "1")
                {
                    repositorio.CadastrarAmigos(listaamigos);
                }
                else if (escolha == "2")
                {
                    repositorio.EditarAmigos(listaamigos);
                }
                else if (escolha == "3")
                {
                    repositorio.ExcluirAmigos(listaamigos);
                }
                else if (escolha == "4")
                {
                    repositorio.VerificarAmigos(listaamigos);
                }
                else if (escolha == "S")
                {
                    menuamigos = false;
                }
                else
                {
                    Console.WriteLine("Resposta inválida, tente novamente");
                }
            }
        }
    }
}
