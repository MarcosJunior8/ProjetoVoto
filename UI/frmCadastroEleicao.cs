using BLL;
using DAL;
using MODELO;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace PadraoDeProjetoEmCamadas
{
    public partial class frmCadastroEleicao : PadraoDeProjetoEmCamadas.frmModeloDeCadastro
    {
        public int guardar =0 ;
        private frmPrincipal frmPrincipal;

        public frmCadastroEleicao()
        {
            InitializeComponent();
        }

        public frmCadastroEleicao(frmPrincipal frmPrincipal)
        {
            InitializeComponent();
            //f.Font.Size = 30;
            frmPrincipal.Text = "Menu - Cadastro Eleicao";
        }

        private void painel_campos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmCadastroEleicao_Load(object sender, EventArgs e)
        {

        }

        public void limparCampos()
        {
            NomeElei.Clear();
            Eleidesc.Clear();
            TipoVoto.Checked = false;
            Encerramento.Clear();
            Conclusao.Clear();
            IdEmpresa.Clear();
        }

        private void popularcampos(MODELOEleicao p)
        {

            Inicio.Text = Convert.ToString(p.Datainicio);
            Fim.Text = Convert.ToString(p.Datafim);
            NomeElei.Text = p.Nome;
            Eleidesc.Text = p.Descricao;
            Encerramento.Text = p.Mensagemencerrado;
            Conclusao.Text = p.Mensagemfim;
            IdEmpresa.Text = p.Idempresa.ToString();
            if( p.Tipovoto == 1)
            {
                TipoVoto.Checked = true;
            }
            if (p.Tipovoto == 0)
            {
                TipoVoto.Checked = false;
            }
 
        }

        private void frmCadastroPessoa_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_inserir_Click_1(object sender, EventArgs e)
        {
            alterapropriedades(2);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            FRMLLocaElei f = new FRMLLocaElei();
            f.ShowDialog();
            

            popularcampos(f.modeloelei);
             guardar = f.modeloelei.Ideleicao;
            alterapropriedades(3);
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            try
            {
                DadosDaConexao dc = new DadosDaConexao();
                DALConexao cx = new DALConexao(dc.StringDeConexao);

                BLLEleicao bllpessoa = new BLLEleicao(cx);

                MODELOEleicao p = new MODELOEleicao();
                p.Nome = NomeElei.Text;
                p.Datainicio = Convert.ToDateTime(Inicio.Text);
                p.Datafim = Convert.ToDateTime(Fim.Text);
                p.Descricao = Eleidesc.Text;
                p.Mensagemencerrado = Encerramento.Text;
                p.Mensagemfim = Conclusao.Text;
                p.Idempresa = Convert.ToInt32(IdEmpresa.Text);
                p.Ideleicao = guardar;
                if (TipoVoto.Checked == true)
                {
                    p.Tipovoto = 1;
                }
                if (TipoVoto.Checked == false)
                {
                    p.Tipovoto = 0;
                }

                bllpessoa.Alterar(p);
                MessageBox.Show("Usuario alterado com sucesso.");

                limparCampos();
                alterapropriedades(1);
            }
            catch (MySqlException ex)
            {
                if (ex.Message.Contains("Duplicate"))
                {
                    MessageBox.Show("Registro já existe no banco de dados");
                }
                else
                {
                    MessageBox.Show("Falha ao alterar errro:" + ex.Message);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Falha ao alterar errro geral:" + ex.Message);
            }
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            try
            {
                DadosDaConexao dc = new DadosDaConexao();
                DALConexao cx = new DALConexao(dc.StringDeConexao);
                BLLEleicao bllpessoa = new BLLEleicao(cx);
                bllpessoa.Excluir(guardar);
                MessageBox.Show("Usuario excluido com sucesso.");

                limparCampos();
                alterapropriedades(1);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Falha ao excluir erro:" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao excluir erro geral:" + ex.Message);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                DadosDaConexao dc = new DadosDaConexao();
                DALConexao cx = new DALConexao(dc.StringDeConexao);

                BLLEleicao bllpessoa = new BLLEleicao(cx);

                MODELOEleicao p = new MODELOEleicao();
                p.Nome = NomeElei.Text;
                p.Datainicio = Convert.ToDateTime(Inicio.Text);
                p.Datafim = Convert.ToDateTime(Fim.Text);
                p.Descricao = Eleidesc.Text;
                p.Mensagemencerrado = Encerramento.Text;
                p.Mensagemfim = Conclusao.Text;
                p.Idempresa = Convert.ToInt32(IdEmpresa.Text);
                if (TipoVoto.Checked == true)
                {
                    p.Tipovoto = 1;
                }
                if (TipoVoto.Checked == false)
                {
                    p.Tipovoto = 0;
                }

                bllpessoa.Incluir(p);
                MessageBox.Show("Usuario inserido com sucesso id:");

                limparCampos();
                alterapropriedades(1);
            }
            catch (MySqlException ex)
            {
                if (ex.Message.Contains("Duplicate"))
                {
                    MessageBox.Show("Registro j'a existe no banco de dados");
                }
                else
                {
                    MessageBox.Show("Falha ao inserir errro:" + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao inserir errro geral:" + ex.Message);
            }
        }
    }
}
