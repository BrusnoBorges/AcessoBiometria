using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using XnaFan.ImageComparison;

namespace AcessoBiometria.Controller
{
    public class Biometria
    {
        string imgEnviada;
        string imgCompare;

        public bool Acesso(string caminho, string caminho2)
        {           
            return Compara(caminho, caminho2);
        }

        public bool Cadastro()
        {
            return false;
        }


        private bool Compara(string caminho, string caminho2)
        {
            Image img1 = Image.FromFile(caminho);
            Image img2 = Image.FromFile(caminho2);

            float dife = ImageTool.GetPercentageDifference(caminho, caminho, 3);

            return dife == 0 ? false : true;
        }
        
    }
}
