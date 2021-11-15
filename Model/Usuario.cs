using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoBiometria.Model
{
    public class Usuario
    {
        public int id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public int Biometria_Id { get; set; }
    }
}
