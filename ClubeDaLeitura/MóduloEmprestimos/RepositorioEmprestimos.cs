using ClubeDaLeitura.Compartilhamento;
using ClubeDaLeitura.MóduloAmigos;
using ClubeDaLeitura.MóduloRevistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.MóduloEmprestimos
{
    public class RepositorioEmprestimos : RepositorioMae
    {
        public void CadastrarEmprestimos()
        {
            
        }
        public void EditarEmprestimos()
        {

        }
        public void ExcluirEmprestimos()
        {

        }
        public Emprestimos SelecionarPorID(int id)
        {
            foreach (Emprestimos e in listaRegistros)
            {
                if (e.ID == id)
                {
                    return e;
                }
            }
            return null;
        }
    }
}
