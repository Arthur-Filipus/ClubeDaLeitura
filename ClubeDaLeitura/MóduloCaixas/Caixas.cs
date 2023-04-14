using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura.MóduloCaixas
{
    public class Caixas
    {
        public string corcaixa { get; set; }
        public string etiqueta { get; set; }
        public int ID { get; set; }
        public int remove { get; set; }
        public List<Caixas> teste { get; set; } = new List<Caixas>();
    }
}
