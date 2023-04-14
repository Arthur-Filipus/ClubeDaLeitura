using ClubeDaLeitura.Compartilhamento;
using ClubeDaLeitura.MóduloCaixas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.MóduloRevistas
{
    public class RepositorioRevistas : RepositorioMae
    {
        public void CadastrarRevistas()
        {
            Revistas revistas = new Revistas();

            Console.Write("Digite a Coleção da Revista: ");
            revistas.colecao = Console.ReadLine();

            Console.Write("Digite a Edição da Revista: ");
            revistas.edicao = Console.ReadLine();

            Console.Write("Digite o Ano da Revista: ");
            revistas.ano = Console.ReadLine();

            TelaCaixas teste = new TelaCaixas();

            teste.VerificarCaixas();

            Console.WriteLine();

            Console.Write("Digite o ID da Caixa em que a Revista esta: ");
            int Idcaixa = Convert.ToInt32(Console.ReadLine());

                foreach (Caixas item in listaRegistros)
                {
                    if (item.ID == Idcaixa)
                    {
                        revistas.achou = true;
                    }
                    else
                    {
                        revistas.achou = false;
                    }
                }

            if (revistas.achou == true)
            {
                revistas.ID = listaRegistros.Count;
                listaRegistros.Add(revistas);
                Console.WriteLine("Edição feita com sucesso.");
            }
            else
            {
                Console.WriteLine("Caixa não existe, tente Cadastra-la");
            }
        }
        public void EditarRevistas()
        {
            Revistas revistas = new Revistas();

            Console.Write("Qual o ID gostaria de Editar: ");
            revistas.remove = Convert.ToInt32(Console.ReadLine());

            SelecionarPorID(revistas.remove);

            listaRegistros.RemoveAt(revistas.remove);

            Console.Write("Digite a Coleção da Revista: ");
            revistas.colecao = Console.ReadLine();

            Console.Write("Digite a Edição da Revista: ");
            revistas.edicao = Console.ReadLine();

            Console.Write("Digite o Ano da Revista: ");
            revistas.ano = Console.ReadLine();

            Console.Write("Digite a Caixa que a Revista esta: ");
            int Idcaixa = Convert.ToInt32(Console.ReadLine());


                foreach (Caixas item in listaRegistros)
                {
                    if (item.ID == Idcaixa)
                    {
                        revistas.achou = true;
                    }
                    else
                    {
                        revistas.achou = false;
                    }
                }

            if (revistas.achou == true)
            {
                revistas.ID = listaRegistros.Count;
                listaRegistros.Add(revistas);
                Console.WriteLine("Edição feita com sucesso.");
            }
            else
            {
                Console.WriteLine("Caixa não existe, tente Cadastra-la");
            }
        }
        public void ExcluirRevistas()
        {
            Revistas revistas = new Revistas();
            Console.Write("Qual o ID gostaria de Editar: ");
            revistas.remove = Convert.ToInt32(Console.ReadLine());

            SelecionarPorID(revistas.remove);
            listaRegistros.RemoveAt(revistas.remove);

            Console.WriteLine("Edição feita com sucesso.");
        }
        public Revistas SelecionarPorID(int id)
        {
            foreach (Revistas r in listaRegistros)
            {
                if (r.ID == id)
                {
                    return r;
                }
            }
            return null;
        }
    }
}
