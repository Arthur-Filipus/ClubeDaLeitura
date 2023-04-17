using ClubeDaLeitura.MóduloAmigos;
using ClubeDaLeitura.MóduloRevistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.MóduloEmprestimos
{
    public class Emprestimos
    {
        public string datasaida { get; set; }
        public string datadevolucao { get; set; }
        public int IDemprestimos { get; set; } = 1;
        public int remove { get; set; }
        public Amigos amigo { get; set; }
        public Revistas IDrevista { get; set; }
    }
}
