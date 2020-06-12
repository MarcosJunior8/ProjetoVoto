namespace PadraoDeProjetoEmCamadas
{
    partial class FRMLLocaElei
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
            this.label1 = new System.Windows.Forms.Label();
            this.TXTBuscar = new System.Windows.Forms.TextBox();
            this.DGVDados = new System.Windows.Forms.DataGridView();
            this.BTNBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Localizar nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TXTBuscar
            // 
            this.TXTBuscar.Location = new System.Drawing.Point(10, 24);
            this.TXTBuscar.Name = "TXTBuscar";
            this.TXTBuscar.Size = new System.Drawing.Size(516, 20);
            this.TXTBuscar.TabIndex = 1;
            // 
            // DGVDados
            // 
            this.DGVDados.AllowUserToAddRows = false;
            this.DGVDados.AllowUserToDeleteRows = false;
            this.DGVDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDados.Location = new System.Drawing.Point(10, 50);
            this.DGVDados.Name = "DGVDados";
            this.DGVDados.ReadOnly = true;
            this.DGVDados.Size = new System.Drawing.Size(597, 286);
            this.DGVDados.TabIndex = 2;
            this.DGVDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDados_CellDoubleClick);
            // 
            // BTNBuscar
            // 
            this.BTNBuscar.Location = new System.Drawing.Point(532, 23);
            this.BTNBuscar.Name = "BTNBuscar";
            this.BTNBuscar.Size = new System.Drawing.Size(75, 20);
            this.BTNBuscar.TabIndex = 3;
            this.BTNBuscar.Text = "Buscar";
            this.BTNBuscar.UseVisualStyleBackColor = true;
            this.BTNBuscar.Click += new System.EventHandler(this.BTNBuscar_Click_1);
            // 
            // FRMLLocaElei
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 348);
            this.Controls.Add(this.BTNBuscar);
            this.Controls.Add(this.DGVDados);
            this.Controls.Add(this.TXTBuscar);
            this.Controls.Add(this.label1);
            this.Name = "FRMLLocaElei";
            this.Text = "FRMLLocaElei";
            this.Load += new System.EventHandler(this.FRMLLocaElei_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTBuscar;
        private System.Windows.Forms.DataGridView DGVDados;
        private System.Windows.Forms.Button BTNBuscar;
    }
}