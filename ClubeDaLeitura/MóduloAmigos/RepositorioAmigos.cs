using ClubeDaLeitura.Compartilhamento;
using ClubeDaLeitura.MóduloCaixas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.MóduloAmigos
{
    public class RepositorioAmigos : RepositorioMae
    {
        public void CadastrarAmigos()
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

            amigos.ID = listaRegistros.Count;

            listaRegistros.Add(amigos);

            Console.WriteLine("Cadastro feito com sucesso.");
            Console.WriteLine();

            Console.WriteLine("ID - Nome - Nome do Responsável - Numero de Telefone - Endereço");
            foreach (Amigos item in listaRegistros)
            {
                Console.Write($"{item.ID}  {item.nome}  {item.nomeresponsavel}  {item.numerotelefone}  {item.endereco}\n");
            }
        }
        public void EditarAmigos()
        {
            Amigos amigos = new Amigos();

            Console.Write("Qual ID gostaria de Editar: ");
            amigos.remove = Convert.ToInt32(Console.ReadLine());

            amigos = SelecionarPorID(amigos.remove);

            listaRegistros.Remove(amigos);

            Console.Write("Digita teu nome: ");
            amigos.nome = Console.ReadLine();

            Console.Write("Digita o nome do teu responsável: ");
            amigos.nomeresponsavel = Console.ReadLine();

            Console.Write("Digita teu número de telefone: ");
            amigos.numerotelefone = Console.ReadLine();

            Console.Write("Digita teu endereço: ");
            amigos.endereco = Console.ReadLine();

            amigos.ID = listaRegistros.Count;

            amigos.ID--;

            listaRegistros.Add(amigos);

            Console.WriteLine("Edição feita com sucesso.");
        }
        public void ExcluirAmigos()
        {
            Amigos amigos = new Amigos();

            Console.Write("Qual ID gostaria de Excluir: ");
            amigos.remove = Convert.ToInt32(Console.ReadLine());

            amigos = SelecionarPorID(amigos.remove);

            listaRegistros.Remove(amigos);

            Console.WriteLine("Exclusão feita com sucesso.");
        }
        public Amigos SelecionarPorID(int id)
        {
            foreach (Amigos a in listaRegistros)
            {
                if (a.ID == id)
                {
                    return a;
                }
            }
            return null;
        }
    }
}
