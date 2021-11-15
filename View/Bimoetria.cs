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

namespace AcessoBiometria.View
{
    public partial class Bimoetria : Form
    {
        OpenFileDialog openFile = new OpenFileDialog();
        Biometria biometria = new Biometria();

        public Bimoetria()
        {
            InitializeComponent();
        }

        private void btnCarrega_Click(object sender, EventArgs e)
        {
            biometria.Acesso(SelectFile(), SelectFile());
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
    }
}
