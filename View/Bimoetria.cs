using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AcessoBiometria.Controller;
using AcessoBiometria.Model;

namespace AcessoBiometria.View
{
    public partial class Bimoetria : Form
    {
        OpenFileDialog openFile = new OpenFileDialog();
        Biometria biometria = new Biometria();
        Model.Model db = new Model.Model();
        public int UserID { get; set; }

        public Bimoetria()
        {
            InitializeComponent();
        }

        private void btnCarrega_Click(object sender, EventArgs e)
        {
            if(biometria.Acesso(SelectFile(), SelectFile()))
            {
                TelaDados telaDados = new TelaDados();                
                telaDados.ShowDialog();
            }
        }

        public string SelectFile()
        {
            openFile.InitialDirectory = "c:\\";
            openFile.Filter = "Database files (*.png, *.jpg)|*.png;*.jpg";
            openFile.FilterIndex = 0;
            openFile.RestoreDirectory = true;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                return openFile.FileName;
            }
            return "";
        }

        private void Bimoetria_Load(object sender, EventArgs e)
        {

        }
    }
}
