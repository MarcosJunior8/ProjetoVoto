﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadraoDeProjetoEmCamadas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void pessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroPessoa f = new frmCadastroPessoa(this);
            f.ShowDialog();
            f.Dispose();
            this.Text = "Menu";
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroEmpresa x = new frmCadastroEmpresa(this);
            x.ShowDialog();
            x.Dispose();
            this.Text = "Menu";
        }

        private void eleiçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroEleicao z = new frmCadastroEleicao(this);
            z.ShowDialog();
            z.Dispose();
            this.Text = "Menu";
        }
    }
}
