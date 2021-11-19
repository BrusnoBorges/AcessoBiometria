using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AcessoBiometria.Model;

namespace AcessoBiometria.View
{
    public partial class Login : Form
    {
        OpenFileDialog openFile = new OpenFileDialog();
        Model.Model db = new Model.Model();

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (VerificaLogin(txtLogin.Text, txtSenha.Text))
            {
                View.Bimoetria bio = new Bimoetria();
                bio.UserID = db.usuario.FirstOrDefault(d => d.Login == txtLogin.Text && d.Senha == txtSenha.Text).Biometria_id;
                bio.ShowDialog();                
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        public bool VerificaLogin(string Login, string Senha)
        {
            return db.usuario.FirstOrDefault(d => d.Login == txtLogin.Text && d.Senha == txtSenha.Text) == null ? false : true;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.ShowDialog();
        }

        
    }
}
