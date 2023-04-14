using ClubeDaLeitura.Compartilhamento;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.MóduloCaixas
{
    public class TelaCaixas : RepositorioMae
    {
        public void MenuCaixas(RepositorioCaixas caixas)
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
                    caixas.CadastrarCaixas();
                }
                else if (escolha == "2")
                {
                    caixas.EditarCaixas();
                }
                else if (escolha == "3")
                {
                    caixas.ExcluirCaixas();
                }
                else if (escolha == "4")
                {
                    VerificarCaixas();
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

        public void VerificarCaixas()
        {
            Console.WriteLine();

            Console.WriteLine("ID - Cor da Caixa - Etiqueta");

            foreach (Caixas item in listaRegistros)
            {
                Console.Write($"{item.ID} {item.corcaixa} {item.etiqueta}\n");
            }
        }
    }
}
