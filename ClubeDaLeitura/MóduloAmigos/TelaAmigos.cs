using ClubeDaLeitura.Compartilhamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.MóduloAmigos
{
    public class TelaAmigos : RepositorioMae
    {
        public void MenuAmigos(RepositorioAmigos amigos)
        {
            bool menuamigos = true;

            while (menuamigos)
            {
                Console.WriteLine("QQ ce quer");
                Console.WriteLine("(1) Cadastro - (2) Editar - (3) Excluir - (4) Verificar - (S) Sair");

                string escolha = Console.ReadLine().ToUpper();

                if (escolha == "1")
                {
                    amigos.CadastrarAmigos();
                }
                else if (escolha == "2")
                {
                    amigos.EditarAmigos();
                }
                else if (escolha == "3")
                {
                    amigos.ExcluirAmigos();
                }
                else if (escolha == "4")
                {
                    VerificarAmigos();
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
        public void VerificarAmigos()
        {
            Console.WriteLine("ID - Nome - Nome do Responsável - Numero de Telefone - Endereço");
            foreach (Amigos item in listaRegistros)
            {
                Console.Write($"{item.ID}  {item.nome}  {item.nomeresponsavel}  {item.numerotelefone}  {item.endereco}\n");
            }
        }
    }
}