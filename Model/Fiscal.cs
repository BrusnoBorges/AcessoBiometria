using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoBiometria.Model
{
    public  class Fiscal
    {
        public int id { get; set; }
        public float InceRece { get; set; }
        public float ImposMuniPago { get; set; }
        public float ImposEstaReco { get; set; }
        public float ImposFedePago { get; set; }
        public float TaxaFedePaga { get; set; }
    }
}
