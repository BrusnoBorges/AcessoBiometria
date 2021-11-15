using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoBiometria.Model
{
    public class ProducaoAgricola
    {
        public int id { get; set; }
        public string NomeUniProd { get; set; }
        public int Produto_id { get; set; }
        public int Destino_id { get; set; }
        public int quantEmprg { get; set; }
        public int QuantMaqui { get; set; }
        public string NivelAuto { get; set; }
    }
}
