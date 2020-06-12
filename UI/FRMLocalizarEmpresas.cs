using BLL;
using DAL;
using MODELO;
using System;
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
    public partial class FRMLocalizarEmpresas : Form
    {
        
        public MODELOEmpresa modelempresa;
        public FRMLocalizarEmpresas()
        {
            InitializeComponent();
        }

        



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DadosDaConexao dc = new DadosDaConexao();
            DALConexao cx = new DALConexao(dc.StringDeConexao);

            BLLEmpresa bllempresa = new BLLEmpresa(cx);
            DataTable tabela = bllempresa.Localizar(textBox1.Text);
            dataGridView1.DataSource = tabela;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.modelempresa = new MODELOEmpresa();

            this.modelempresa.IdEmpresa = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            this.modelempresa.NomeEmpresa = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.modelempresa.Descricao = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.modelempresa.CodeEmpresa = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

            frmCadastroEmpresa x = new frmCadastroEmpresa();

            x.guardar = modelempresa.IdEmpresa;
            

            

            this.Close();
        }

        private void FRMLocalizarEmpresas_Load(object sender, EventArgs e)
        {

        }
    }
}
