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
        public int ID { get; set; }
        public int remove { get; set; }
        public int caixaescolhida { get; set; }
        public int IdCaixaEscolhida { get; set; }
        public bool achou { get; set; }
    }
}
