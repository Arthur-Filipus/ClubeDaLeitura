using ClubeDaLeitura.MóduloCaixas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.MóduloRevistas
{
    public class TelaRevistas
    {
        List<Revistas> listarevistas = new List<Revistas>();
        RepositorioRevistas repositorio = new RepositorioRevistas();
        List<Caixas> listacaixa = new List<Caixas>();
        public void MenuRevistas()
        { 
            bool menurevistas = true;

            while (menurevistas)
            {

                Console.WriteLine("QQ C quer");
                Console.WriteLine("(1) Cadastrar - (2) Editar - (3) Excluir - (4) Verificar - (S) Sair");

                string escolha = Console.ReadLine().ToUpper();

                if (escolha == "1")
                {
                    repositorio.CadastrarRevistas(listarevistas);
                }
                else if (escolha == "2")
                {
                    repositorio.EditarRevistas(listarevistas, listacaixa);
                }
                else if (escolha == "3")
                {
                    repositorio.ExcluirRevistas(listarevistas);
                }
                else if (escolha == "4")
                {
                    repositorio.VerificarRevistas(listarevistas);
                }
                else if (escolha == "S")
                {
                    menurevistas = false;
                }
                else
                {
                    Console.WriteLine("Resposta inválida, tente novamente");
                }
            }
        }
    }
}
