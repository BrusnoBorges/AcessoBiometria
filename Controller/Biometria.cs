using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using XnaFan.ImageComparison;
using AcessoBiometria.Model;
using OpenCvSharp;

namespace AcessoBiometria.Controller
{
    public class Biometria
    {
        string imgEnviada;
        string imgCompare;

        public bool Acesso(byte[] bioAnalise, byte[] bioModelo)
        {                     
            return Compara(bioAnalise, bioModelo);
        }

        public bool Cadastro(string caminho)
        {
            return false;
        }


        private bool Compara(byte[] bioAnalise, byte[] bioModelo)
        {
            //Cv2.CompareHist(caminho, caminho2);


            //float dife = ImageTool.GetPercentageDifference(caminho, caminho2);

            //return dife == 0 ? false : true;

            if (bioAnalise.SequenceEqual(bioModelo))
            {
                return true;
            }
            return false;

        }
        
    }
}
