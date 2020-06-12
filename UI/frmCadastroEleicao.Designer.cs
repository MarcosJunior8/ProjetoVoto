namespace PadraoDeProjetoEmCamadas
{
    partial class frmCadastroEleicao
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.NomeElei = new System.Windows.Forms.TextBox();
            this.ss = new System.Windows.Forms.Label();
            this.Eleidesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Encerramento = new System.Windows.Forms.TextBox();
            this.Conclusao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Inicio = new System.Windows.Forms.DateTimePicker();
            this.Fim = new System.Windows.Forms.DateTimePicker();
            this.IdEmpresa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TipoVoto = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.painel_campos.SuspendLayout();
            this.Painel_botoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // painel_campos
            // 
            this.painel_campos.Controls.Add(this.label2);
            this.painel_campos.Controls.Add(this.TipoVoto);
            this.painel_campos.Controls.Add(this.label7);
            this.painel_campos.Controls.Add(this.IdEmpresa);
            this.painel_campos.Controls.Add(this.Fim);
            this.painel_campos.Controls.Add(this.Inicio);
            this.painel_campos.Controls.Add(this.label6);
            this.painel_campos.Controls.Add(this.label5);
            this.painel_campos.Controls.Add(this.label4);
            this.painel_campos.Controls.Add(this.label3);
            this.painel_campos.Controls.Add(this.Conclusao);
            this.painel_campos.Controls.Add(this.Encerramento);
            this.painel_campos.Controls.Add(this.label1);
            this.painel_campos.Controls.Add(this.Eleidesc);
            this.painel_campos.Controls.Add(this.ss);
            this.painel_campos.Controls.Add(this.NomeElei);
            this.painel_campos.Location = new System.Drawing.Point(3, 4);
            this.painel_campos.Size = new System.Drawing.Size(862, 482);
            this.painel_campos.Paint += new System.Windows.Forms.PaintEventHandler(this.painel_campos_Paint);
            // 
            // Painel_botoes
            // 
            this.Painel_botoes.Location = new System.Drawing.Point(3, 489);
            this.Painel_botoes.Size = new System.Drawing.Size(862, 54);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_deletar
            // 
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_inserir
            // 
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click_1);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // NomeElei
            // 
            this.NomeElei.Location = new System.Drawing.Point(151, 21);
            this.NomeElei.Name = "NomeElei";
            this.NomeElei.Size = new System.Drawing.Size(242, 20);
            this.NomeElei.TabIndex = 0;
            // 
            // ss
            // 
            this.ss.AutoSize = true;
            this.ss.Location = new System.Drawing.Point(26, 24);
            this.ss.Name = "ss";
            this.ss.Size = new System.Drawing.Size(73, 13);
            this.ss.TabIndex = 1;
            this.ss.Text = "Nome Eleição";
            // 
            // Eleidesc
            // 
            this.Eleidesc.Location = new System.Drawing.Point(151, 47);
            this.Eleidesc.Multiline = true;
            this.Eleidesc.Name = "Eleidesc";
            this.Eleidesc.Size = new System.Drawing.Size(242, 134);
            this.Eleidesc.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descrição";
            // 
            // Encerramento
            // 
            this.Encerramento.Location = new System.Drawing.Point(151, 214);
            this.Encerramento.Multiline = true;
            this.Encerramento.Name = "Encerramento";
            this.Encerramento.Size = new System.Drawing.Size(244, 82);
            this.Encerramento.TabIndex = 6;
            // 
            // Conclusao
            // 
            this.Conclusao.Location = new System.Drawing.Point(151, 300);
            this.Conclusao.Multiline = true;
            this.Conclusao.Name = "Conclusao";
            this.Conclusao.Size = new System.Drawing.Size(244, 81);
            this.Conclusao.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mnesagem de encerramento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mensagem conclusao";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data Inicio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Data termino";
            // 
            // Inicio
            // 
            this.Inicio.Location = new System.Drawing.Point(151, 387);
            this.Inicio.Name = "Inicio";
            this.Inicio.Size = new System.Drawing.Size(244, 20);
            this.Inicio.TabIndex = 12;
            // 
            // Fim
            // 
            this.Fim.Location = new System.Drawing.Point(151, 421);
            this.Fim.Name = "Fim";
            this.Fim.Size = new System.Drawing.Size(244, 20);
            this.Fim.TabIndex = 13;
            // 
            // IdEmpresa
            // 
            this.IdEmpresa.Location = new System.Drawing.Point(572, 20);
            this.IdEmpresa.Name = "IdEmpresa";
            this.IdEmpresa.Size = new System.Drawing.Size(100, 20);
            this.IdEmpresa.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(506, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Id Empresa";
            // 
            // TipoVoto
            // 
            this.TipoVoto.AutoSize = true;
            this.TipoVoto.Location = new System.Drawing.Point(151, 191);
            this.TipoVoto.Name = "TipoVoto";
            this.TipoVoto.Size = new System.Drawing.Size(15, 14);
            this.TipoVoto.TabIndex = 16;
            this.TipoVoto.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Voto Secreto";
            // 
            // frmCadastroEleicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(867, 555);
            this.Name = "frmCadastroEleicao";
            this.Load += new System.EventHandler(this.frmCadastroEleicao_Load);
            this.painel_campos.ResumeLayout(false);
            this.painel_campos.PerformLayout();
            this.Painel_botoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Eleidesc;
        private System.Windows.Forms.Label ss;
        private System.Windows.Forms.TextBox NomeElei;
        private System.Windows.Forms.DateTimePicker Fim;
        private System.Windows.Forms.DateTimePicker Inicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Conclusao;
        private System.Windows.Forms.TextBox Encerramento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox IdEmpresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox TipoVoto;
    }
}
