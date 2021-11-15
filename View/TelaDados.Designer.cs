
namespace AcessoBiometria.View
{
    partial class TelaDados
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
            this.Menu = new System.Windows.Forms.TabControl();
            this.tabNivel1 = new System.Windows.Forms.TabPage();
            this.gdvProducao = new System.Windows.Forms.DataGridView();
            this.tabNivel2 = new System.Windows.Forms.TabPage();
            this.gdvFiscal = new System.Windows.Forms.DataGridView();
            this.tabNivel3 = new System.Windows.Forms.TabPage();
            this.gdvAgrotoxico = new System.Windows.Forms.DataGridView();
            this.Menu.SuspendLayout();
            this.tabNivel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvProducao)).BeginInit();
            this.tabNivel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvFiscal)).BeginInit();
            this.tabNivel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvAgrotoxico)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.tabNivel1);
            this.Menu.Controls.Add(this.tabNivel2);
            this.Menu.Controls.Add(this.tabNivel3);
            this.Menu.Location = new System.Drawing.Point(12, 12);
            this.Menu.Name = "Menu";
            this.Menu.SelectedIndex = 0;
            this.Menu.Size = new System.Drawing.Size(776, 426);
            this.Menu.TabIndex = 0;
            // 
            // tabNivel1
            // 
            this.tabNivel1.Controls.Add(this.gdvProducao);
            this.tabNivel1.Location = new System.Drawing.Point(4, 22);
            this.tabNivel1.Name = "tabNivel1";
            this.tabNivel1.Padding = new System.Windows.Forms.Padding(3);
            this.tabNivel1.Size = new System.Drawing.Size(768, 400);
            this.tabNivel1.TabIndex = 0;
            this.tabNivel1.Text = "Produção agrícola ";
            this.tabNivel1.UseVisualStyleBackColor = true;
            // 
            // gdvProducao
            // 
            this.gdvProducao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvProducao.Location = new System.Drawing.Point(37, 26);
            this.gdvProducao.Name = "gdvProducao";
            this.gdvProducao.Size = new System.Drawing.Size(725, 368);
            this.gdvProducao.TabIndex = 1;
            // 
            // tabNivel2
            // 
            this.tabNivel2.Controls.Add(this.gdvFiscal);
            this.tabNivel2.Location = new System.Drawing.Point(4, 22);
            this.tabNivel2.Name = "tabNivel2";
            this.tabNivel2.Padding = new System.Windows.Forms.Padding(3);
            this.tabNivel2.Size = new System.Drawing.Size(768, 400);
            this.tabNivel2.TabIndex = 1;
            this.tabNivel2.Text = "Informações fiscais";
            this.tabNivel2.UseVisualStyleBackColor = true;
            // 
            // gdvFiscal
            // 
            this.gdvFiscal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvFiscal.Location = new System.Drawing.Point(6, 5);
            this.gdvFiscal.Name = "gdvFiscal";
            this.gdvFiscal.Size = new System.Drawing.Size(756, 391);
            this.gdvFiscal.TabIndex = 1;
            // 
            // tabNivel3
            // 
            this.tabNivel3.Controls.Add(this.gdvAgrotoxico);
            this.tabNivel3.Location = new System.Drawing.Point(4, 22);
            this.tabNivel3.Name = "tabNivel3";
            this.tabNivel3.Padding = new System.Windows.Forms.Padding(3);
            this.tabNivel3.Size = new System.Drawing.Size(768, 400);
            this.tabNivel3.TabIndex = 2;
            this.tabNivel3.Text = "Agrotóxicos";
            this.tabNivel3.UseVisualStyleBackColor = true;
            // 
            // gdvAgrotoxico
            // 
            this.gdvAgrotoxico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvAgrotoxico.Location = new System.Drawing.Point(6, 3);
            this.gdvAgrotoxico.Name = "gdvAgrotoxico";
            this.gdvAgrotoxico.Size = new System.Drawing.Size(756, 391);
            this.gdvAgrotoxico.TabIndex = 0;
            // 
            // TelaDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Menu);
            this.Name = "TelaDados";
            this.Text = "TelaDados";
            this.Load += new System.EventHandler(this.TelaDados_Load);
            this.Menu.ResumeLayout(false);
            this.tabNivel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvProducao)).EndInit();
            this.tabNivel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvFiscal)).EndInit();
            this.tabNivel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdvAgrotoxico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Menu;
        private System.Windows.Forms.TabPage tabNivel1;
        private System.Windows.Forms.DataGridView gdvProducao;
        private System.Windows.Forms.TabPage tabNivel2;
        private System.Windows.Forms.DataGridView gdvFiscal;
        private System.Windows.Forms.TabPage tabNivel3;
        private System.Windows.Forms.DataGridView gdvAgrotoxico;
    }
}