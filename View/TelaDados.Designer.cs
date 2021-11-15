
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
            this.dgvProducao = new System.Windows.Forms.DataGridView();
            this.tabNivel2 = new System.Windows.Forms.TabPage();
            this.dgvFiscal = new System.Windows.Forms.DataGridView();
            this.tabNivel3 = new System.Windows.Forms.TabPage();
            this.dgvAgrotoxico = new System.Windows.Forms.DataGridView();
            this.Menu.SuspendLayout();
            this.tabNivel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducao)).BeginInit();
            this.tabNivel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiscal)).BeginInit();
            this.tabNivel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgrotoxico)).BeginInit();
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
            this.tabNivel1.Controls.Add(this.dgvProducao);
            this.tabNivel1.Location = new System.Drawing.Point(4, 22);
            this.tabNivel1.Name = "tabNivel1";
            this.tabNivel1.Padding = new System.Windows.Forms.Padding(3);
            this.tabNivel1.Size = new System.Drawing.Size(768, 400);
            this.tabNivel1.TabIndex = 0;
            this.tabNivel1.Text = "Produção agrícola ";
            this.tabNivel1.UseVisualStyleBackColor = true;
            // 
            // dgvProducao
            // 
            this.dgvProducao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducao.Location = new System.Drawing.Point(6, 6);
            this.dgvProducao.Name = "dgvProducao";
            this.dgvProducao.Size = new System.Drawing.Size(756, 388);
            this.dgvProducao.TabIndex = 1;
            // 
            // tabNivel2
            // 
            this.tabNivel2.Controls.Add(this.dgvFiscal);
            this.tabNivel2.Location = new System.Drawing.Point(4, 22);
            this.tabNivel2.Name = "tabNivel2";
            this.tabNivel2.Padding = new System.Windows.Forms.Padding(3);
            this.tabNivel2.Size = new System.Drawing.Size(768, 400);
            this.tabNivel2.TabIndex = 1;
            this.tabNivel2.Text = "Informações fiscais";
            this.tabNivel2.UseVisualStyleBackColor = true;
            // 
            // dgvFiscal
            // 
            this.dgvFiscal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiscal.Location = new System.Drawing.Point(6, 5);
            this.dgvFiscal.Name = "dgvFiscal";
            this.dgvFiscal.Size = new System.Drawing.Size(756, 391);
            this.dgvFiscal.TabIndex = 1;
            // 
            // tabNivel3
            // 
            this.tabNivel3.Controls.Add(this.dgvAgrotoxico);
            this.tabNivel3.Location = new System.Drawing.Point(4, 22);
            this.tabNivel3.Name = "tabNivel3";
            this.tabNivel3.Padding = new System.Windows.Forms.Padding(3);
            this.tabNivel3.Size = new System.Drawing.Size(768, 400);
            this.tabNivel3.TabIndex = 2;
            this.tabNivel3.Text = "Agrotóxicos";
            this.tabNivel3.UseVisualStyleBackColor = true;
            // 
            // dgvAgrotoxico
            // 
            this.dgvAgrotoxico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgrotoxico.Location = new System.Drawing.Point(6, 3);
            this.dgvAgrotoxico.Name = "dgvAgrotoxico";
            this.dgvAgrotoxico.Size = new System.Drawing.Size(756, 391);
            this.dgvAgrotoxico.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducao)).EndInit();
            this.tabNivel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiscal)).EndInit();
            this.tabNivel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgrotoxico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Menu;
        private System.Windows.Forms.TabPage tabNivel1;
        private System.Windows.Forms.DataGridView dgvProducao;
        private System.Windows.Forms.TabPage tabNivel2;
        private System.Windows.Forms.DataGridView dgvFiscal;
        private System.Windows.Forms.TabPage tabNivel3;
        private System.Windows.Forms.DataGridView dgvAgrotoxico;
    }
}