using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.MóduloAmigos
{
    public class RepositorioAmigos
    {
        public void CadastrarAmigos(List<Amigos> ListaAmigos)
        {
            Amigos amigos = new Amigos();

            Console.Write("Digita teu nome: ");
            amigos.nome = Console.ReadLine();

            Console.Write("Digita o nome do teu responsável: ");
            amigos.nomeresponsavel = Console.ReadLine();

            Console.Write("Digita teu número de telefone: ");
            amigos.numerotelefone = Console.ReadLine();

            Console.Write("Digita teu endereço: ");
            amigos.endereco = Console.ReadLine();

            amigos.ID = ListaAmigos.Count;

            ListaAmigos.Add(amigos);

            Console.WriteLine("Tudo OK parça");
        }
        public void EditarAmigos(List<Amigos> ListaAmigos)
        {
            Amigos amigos = new Amigos();

            Console.Write("Qual ID gostaria de Editar: ");
            amigos.remove = Convert.ToInt32(Console.ReadLine());

            int index = ListaAmigos.FindIndex(item => amigos.remove == item.ID);

            ListaAmigos.RemoveAt(index);

            Console.Write("Digita teu nome: ");
            amigos.nome = Console.ReadLine();

            Console.Write("Digita o nome do teu responsável: ");
            amigos.nomeresponsavel = Console.ReadLine();

            Console.Write("Digita teu número de telefone: ");
            amigos.numerotelefone = Console.ReadLine();

            Console.Write("Digita teu endereço: ");
            amigos.endereco = Console.ReadLine();

            amigos.ID = ListaAmigos.Count;

            amigos.ID--;

            ListaAmigos.Add(amigos);

            Console.WriteLine("Edição feita com sucesso.");
        }
        public void ExcluirAmigos(List<Amigos> ListaAmigos)
        {
            Amigos amigos = new Amigos();

            Console.Write("Qual ID gostaria de Excluir: ");
            amigos.remove = Convert.ToInt32(Console.ReadLine());

            int index = ListaAmigos.FindIndex(item => amigos.remove == item.ID);

            Console.WriteLine("Exclusão feita com sucesso.");
        }
        public void VerificarAmigos(List<Amigos> ListaAmigos)
        {
            Console.WriteLine("ID - Nome - Nome do Responsável - Numero de Telefone - Endereço");
            foreach (var item in ListaAmigos)
            {
                Console.Write($"{item.ID}  {item.nome}  {item.nomeresponsavel}  {item.numerotelefone}  {item.endereco}\n");
            }
        }
    }
}
