
namespace AcessoBiometria.View
{
    partial class Bimoetria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCarrega = new System.Windows.Forms.Button();
            this.btnValida = new System.Windows.Forms.Button();
            this.imgBio = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgBio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCarrega
            // 
            this.btnCarrega.Location = new System.Drawing.Point(12, 269);
            this.btnCarrega.Name = "btnCarrega";
            this.btnCarrega.Size = new System.Drawing.Size(75, 23);
            this.btnCarrega.TabIndex = 0;
            this.btnCarrega.Text = "Carrega";
            this.btnCarrega.UseVisualStyleBackColor = true;
            this.btnCarrega.Click += new System.EventHandler(this.btnCarrega_Click);
            // 
            // btnValida
            // 
            this.btnValida.Location = new System.Drawing.Point(612, 269);
            this.btnValida.Name = "btnValida";
            this.btnValida.Size = new System.Drawing.Size(75, 23);
            this.btnValida.TabIndex = 1;
            this.btnValida.Text = "Validar";
            this.btnValida.UseVisualStyleBackColor = true;
            this.btnValida.Click += new System.EventHandler(this.btnValida_Click);
            // 
            // imgBio
            // 
            this.imgBio.Location = new System.Drawing.Point(12, 12);
            this.imgBio.Name = "imgBio";
            this.imgBio.Size = new System.Drawing.Size(330, 235);
            this.imgBio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBio.TabIndex = 2;
            this.imgBio.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(357, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(330, 235);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Bimoetria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 304);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.imgBio);
            this.Controls.Add(this.btnValida);
            this.Controls.Add(this.btnCarrega);
            this.Name = "Bimoetria";
            this.Text = "Bimoetria";
            this.Load += new System.EventHandler(this.Bimoetria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgBio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCarrega;
        private System.Windows.Forms.Button btnValida;
        private System.Windows.Forms.PictureBox imgBio;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}