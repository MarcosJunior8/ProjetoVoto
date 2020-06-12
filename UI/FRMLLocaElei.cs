using BLL;
using DAL;
using MODELO;
using System;
using System.Data;
using System.Windows.Forms;

namespace PadraoDeProjetoEmCamadas
{
    public partial class FRMLLocaElei : Form
    {
        public MODELOEleicao modeloelei;
        public FRMLLocaElei()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FRMLLocaElei_Load(object sender, EventArgs e)
        {

        }

        private void BTNBuscar_Click_1(object sender, EventArgs e)
        {
            DadosDaConexao dc = new DadosDaConexao();
            DALConexao cx = new DALConexao(dc.StringDeConexao);

            BLLEleicao bllpessoa = new BLLEleicao(cx);
            DataTable tabela = bllpessoa.Localizar(TXTBuscar.Text);
            DGVDados.DataSource = tabela;
        }

        private void DGVDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.modeloelei = new MODELOEleicao();

            this.modeloelei.Ideleicao = Convert.ToInt32(DGVDados.Rows[e.RowIndex].Cells[0].Value.ToString());
            this.modeloelei.Idempresa = Convert.ToInt32(DGVDados.Rows[e.RowIndex].Cells[1].Value.ToString());
            this.modeloelei.Nome = DGVDados.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.modeloelei.Descricao = DGVDados.Rows[e.RowIndex].Cells[3].Value.ToString();
            this.modeloelei.Tipovoto = Convert.ToByte(DGVDados.Rows[e.RowIndex].Cells[4].Value);
            this.modeloelei.Mensagemencerrado = DGVDados.Rows[e.RowIndex].Cells[5].Value.ToString();
            this.modeloelei.Mensagemfim = DGVDados.Rows[e.RowIndex].Cells[6].Value.ToString();
            DateTime data = Convert.ToDateTime(DGVDados.Rows[e.RowIndex].Cells[7].Value.ToString());
            DateTime data1 = Convert.ToDateTime(DGVDados.Rows[e.RowIndex].Cells[7].Value.ToString());

            this.modeloelei.Datainicio = data;
            this.modeloelei.Datafim = data1;
            this.Close();
        }
    }
}
