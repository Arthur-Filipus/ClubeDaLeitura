using ClubeDaLeitura.Compartilhamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.MóduloCaixas
{
    public class RepositorioCaixas : RepositorioMae
    {
        public void CadastrarCaixas()
        {
            Caixas caixa = new Caixas();

            Console.WriteLine("Qual a cor da caixa: ");
            caixa.corcaixa = Console.ReadLine();

            Console.WriteLine("Qual a etiqueta da caixa: ");
            caixa.etiqueta = Console.ReadLine();

            caixa.ID = listaRegistros.Count;

            listaRegistros.Add(caixa);

            Console.WriteLine("Cadastro feito com sucesso.");
        }
        public void EditarCaixas()
        {
            Caixas caixa = new Caixas();

            Console.Write("Qual ID gostaria de Editar: ");
            caixa.remove = Convert.ToInt32(Console.ReadLine());

            caixa = SelecionarPorID(caixa.remove);

            listaRegistros.Remove(caixa);

            Console.Write("Qual a cor da caixa: ");
            caixa.corcaixa = Console.ReadLine();

            Console.Write("Qual a etiqueta da caixa: ");
            caixa.etiqueta = Console.ReadLine();

           caixa.ID = listaRegistros.Count;

            caixa.ID--;

            listaRegistros.Add(caixa);

            Console.WriteLine("Edição feita com sucesso.");
        }
        public void ExcluirCaixas()
        {
            Caixas caixa = new Caixas();

            Console.Write("Qual ID gostaria de Excluir: ");
            caixa.remove = Convert.ToInt32(Console.ReadLine());

            caixa = SelecionarPorID(caixa.remove);

            listaRegistros.Remove(caixa);

            Console.WriteLine("Exclusão feita com sucesso.");
        }
        public Caixas SelecionarPorID(int id)
        {
            foreach (Caixas c in listaRegistros)
            {
                if (c.ID == id)
                {
                    return c;
                }
            }
            return null;
        }
    }
}