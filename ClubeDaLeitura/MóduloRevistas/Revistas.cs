using ClubeDaLeitura.MóduloCaixas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.MóduloRevistas
{
    public class Revistas
    {
        public string colecao { get; set; }
        public string edicao { get; set; }
        public string ano { get; set; }
        public int IDrevistas { get; set; } = 1;
        public int remove { get; set; }
        public Caixas caixaescolhida { get; set; }
        public bool achou { get; set; }
    }
}
