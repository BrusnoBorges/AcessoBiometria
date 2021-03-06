using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AcessoBiometria.Model;

namespace AcessoBiometria.View
{
    public partial class TelaDados : Form
    {
        public int Nivel = 0;
        Model.Model db = new Model.Model();
        
        public TelaDados()
        {
            InitializeComponent();
        }

        private void TelaDados_Load(object sender, EventArgs e)
        {
            switch (Nivel)
            {
                case 1:
                    dgvProdLoad();
                    break;
                case 2:
                    dgvProdLoad();
                    dgvFiscalLoad();
                    break;
                case 3:
                    dgvProdLoad();
                    dgvFiscalLoad();
                    dgvAgroLoad();
                    break;
                default:
                    break;
            }
        }

        public void dgvProdLoad()  
        {
            dgvProducao.DataSource = db.producaoagricola.ToList();
        }
        public void dgvFiscalLoad() 
        {
            dgvFiscal.DataSource = db.fiscal.ToList();
        }
        public void dgvAgroLoad() 
        {
            dgvAgrotoxico.DataSource = db.agrotoxico.ToList();
        }
    }
}
