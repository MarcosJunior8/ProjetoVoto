namespace PadraoDeProjetoEmCamadas
{
    partial class frmCadastroEmpresa
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.cnpjBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.painel_campos.SuspendLayout();
            this.Painel_botoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // painel_campos
            // 
            this.painel_campos.Controls.Add(this.label3);
            this.painel_campos.Controls.Add(this.label2);
            this.painel_campos.Controls.Add(this.label1);
            this.painel_campos.Controls.Add(this.cnpjBox);
            this.painel_campos.Controls.Add(this.descriptionBox);
            this.painel_campos.Controls.Add(this.nameBox);
            this.painel_campos.Size = new System.Drawing.Size(611, 372);
            this.painel_campos.Paint += new System.Windows.Forms.PaintEventHandler(this.painel_campos_Paint);
            // 
            // Painel_botoes
            // 
            this.Painel_botoes.Location = new System.Drawing.Point(3, 390);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click_1);
            // 
            // btn_deletar
            // 
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click_1);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click_1);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_inserir
            // 
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click_1);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(153, 20);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(302, 20);
            this.nameBox.TabIndex = 0;
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(153, 83);
            this.descriptionBox.MaxLength = 500;
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionBox.Size = new System.Drawing.Size(302, 138);
            this.descriptionBox.TabIndex = 1;
            this.descriptionBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // cnpjBox
            // 
            this.cnpjBox.Location = new System.Drawing.Point(153, 264);
            this.cnpjBox.Name = "cnpjBox";
            this.cnpjBox.Size = new System.Drawing.Size(302, 20);
            this.cnpjBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome da Empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descrição da Empresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "CNPJ/Código";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // frmCadastroEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(616, 553);
            this.Name = "frmCadastroEmpresa";
            this.Load += new System.EventHandler(this.frmCadastroEmpresa_Load);
            this.painel_campos.ResumeLayout(false);
            this.painel_campos.PerformLayout();
            this.Painel_botoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox nameBox;
        public System.Windows.Forms.TextBox cnpjBox;
        public System.Windows.Forms.TextBox descriptionBox;
    }
}
