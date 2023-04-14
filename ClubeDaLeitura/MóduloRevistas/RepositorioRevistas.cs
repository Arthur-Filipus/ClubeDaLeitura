using ClubeDaLeitura.MóduloCaixas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.MóduloRevistas
{
    public class RepositorioRevistas
    {
        Caixas caixa = new Caixas();
        Revistas revista = new Revistas();
        public void CadastrarRevistas(List<Revistas> ListaRevistas)
        {

            List<Caixas> ListaCaixas = new List<Caixas>();

            Console.Write("Digite a Coleção da Revista: ");
            revista.colecao = Console.ReadLine();

            Console.Write("Digite a Edição da Revista: ");
            revista.edicao = Console.ReadLine();

            Console.Write("Digite o Ano da Revista: ");
            revista.ano = Console.ReadLine();

            Console.WriteLine("ID - Cor da Caixa - Etiqueta");

            foreach (Caixas item in ListaCaixas)
            {
                Console.Write($"{item.ID} {item.corcaixa} {item.etiqueta}\n");
            }

            Console.WriteLine();

            Console.Write("Digite o ID da Caixa em que a Revista esta: ");
            int Idcaixa = Convert.ToInt32(Console.ReadLine());

                foreach (Caixas item in ListaCaixas)
                {
                    if (item.ID == Idcaixa)
                    {
                        caixa = item;
                        revista.achou = true;
                    }
                    else
                    {
                        revista.achou = false;
                    }
                }

            if (revista.achou == true)
            {
                revista.ID = ListaRevistas.Count;
                ListaRevistas.Add(revista);
                Console.WriteLine("Edição feita com sucesso.");
            }
            else
            {
                Console.WriteLine("Caixa não existe, tente Cadastra-la");
            }
        }
        public void EditarRevistas(List<Revistas> ListaRevistas, List<Caixas> ListaCaixas)
        {
            Console.Write("Qual o ID gostaria de Editar: ");
            revista.remove = Convert.ToInt32(Console.ReadLine());

            int index = ListaRevistas.FindIndex(item => revista.remove == revista.ID);
            ListaRevistas.RemoveAt(index);

            Console.Write("Digite a Coleção da Revista: ");
            revista.colecao = Console.ReadLine();

            Console.Write("Digite a Edição da Revista: ");
            revista.edicao = Console.ReadLine();

            Console.Write("Digite o Ano da Revista: ");
            revista.ano = Console.ReadLine();

            Console.Write("Digite a Caixa que a Revista esta: ");
            int Idcaixa = Convert.ToInt32(Console.ReadLine());

            bool idinvalido = true;

            while (idinvalido)
            {
                foreach (Caixas item in ListaCaixas)
                {
                    if (item.ID == Idcaixa)
                    {
                        caixa = item;
                        revista.achou = true;
                        idinvalido = false;
                    }
                    else
                    {
                        revista.achou = false;
                    }
                }
            }

            if (revista.achou == true)
            {
                revista.ID = ListaRevistas.Count;
                ListaRevistas.Add(revista);
                Console.WriteLine("Edição feita com sucesso.");
            }
            else
            {
                Console.WriteLine("Caixa não existe, tente Cadastra-la");
            }
        }
        public void ExcluirRevistas(List<Revistas> ListaRevistas)
        {
            Console.Write("Qual o ID gostaria de Editar: ");
            revista.remove = Convert.ToInt32(Console.ReadLine());

            int index = ListaRevistas.FindIndex(item => revista.remove == revista.ID);
            ListaRevistas.RemoveAt(index);

            Console.WriteLine("Edição feita com sucesso.");
        }
        public void VerificarRevistas(List<Revistas> ListaRevistas)
        {
            Console.WriteLine("ID  Coleção  Edição  Ano  Caixa");
            foreach (var item in ListaRevistas)
            {
                Console.Write($"{item.ID}  {item.colecao}  {item.edicao}  {item.ano}  ");//{item.caixa}
            }
        }
    }
}
