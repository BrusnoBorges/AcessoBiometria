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
using AcessoBiometria.Controller;
using AcessoBiometria.Model;

namespace AcessoBiometria.View
{
    public partial class Bimoetria : Form
    {
        OpenFileDialog openFile = new OpenFileDialog();
        Biometria biometria = new Biometria();
        Model.Model db = new Model.Model();
        usuario user = new usuario();
        Model.biometria bio = new biometria();

        string file = "";

        public int UserID { get; set; }

        public Bimoetria()
        {            
            InitializeComponent();
        }

        private void btnCarrega_Click(object sender, EventArgs e)
        {
            file = SelectFile();
            imgBio.Image = Image.FromFile(file);

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
            user = db.usuario.FirstOrDefault(d => d.id == UserID);
        }

        private void btnValida_Click(object sender, EventArgs e)
        {  
            if (biometria.Acesso(BioAnalise(), RecuperaBio()))
            {
                TelaDados telaDados = new TelaDados();
                telaDados.Nivel = bio.Nivel_id;
                telaDados.ShowDialog();
            }
        }

        private byte[] RecuperaBio()
        {
            try
            {
                
                bio = db.biometria.FirstOrDefault(d => d.id == user.Biometria_id);


                byte[] BioModelo = (byte[])bio.biometria1;

                return BioModelo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;                
            }
           
        }

        public byte[] BioAnalise()
        {
            
            byte[] ImageData;
            FileStream fs = new FileStream(openFile.FileName, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            ImageData = br.ReadBytes((int)fs.Length);
            
            br.Close();
            fs.Close();

            return ImageData;
        }


    }
}
