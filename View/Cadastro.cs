﻿using AcessoBiometria.Model;
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

namespace AcessoBiometria.View
{
    public partial class Cadastro : Form
    {

        OpenFileDialog openFile = new OpenFileDialog();
        Model.Model db = new Model.Model();
        biometria bio = new biometria();
        string fileWay = string.Empty;
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLogin.Text) || string.IsNullOrEmpty(txtSenha.Text))
            {
                return;
            }
            else
            {
                usuario user = new usuario();
                user = db.usuario.Where(d => d.Login == txtLogin.Text && d.Senha == txtSenha.Text).FirstOrDefault();
                if (user == null)
                {
                    bio.Nivel_id = SelecionaNivel();
                    db.biometria.Add(bio);
                    db.SaveChanges();

                    user = new usuario();
                    user.Login = txtLogin.Text;
                    user.Senha = txtSenha.Text;
                    user.Biometria_id = bio.id;

                    db.usuario.Add(user);
                    db.SaveChanges();

                }
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            bio.biometria1 = SelectFile();
            txtBio.Text = fileWay;
        }

        public byte[] SelectFile()
        {
            byte[] img;
            openFile.InitialDirectory = "c:\\";
            openFile.Filter = "Database files (*.png, *.jpg)|*.png;*.jpg";
            openFile.FilterIndex = 0;
            openFile.RestoreDirectory = true;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                FileInfo arqImagem = new FileInfo(openFile.FileName);
                float tamanhoArquivoImagem = arqImagem.Length;
                FileStream fs = new FileStream(openFile.FileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                img = new byte[Convert.ToInt32(tamanhoArquivoImagem)];
                fileWay = openFile.FileName;
                return img;
            }
            return new byte[0];
        }

        private int SelecionaNivel()
        {
            if (rbtnGeral.Checked)
            {
                return 1;
            }
            else if (rbtnDiretor.Checked)
            {
                return 2;
            }
            else if (rbtnMinistro.Checked)
            {
                return 3;
            }
            else
            {
                return 0;
            }
        }

        
    }
}
