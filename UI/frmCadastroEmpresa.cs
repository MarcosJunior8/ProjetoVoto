using BLL;
using DAL;
using MODELO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace PadraoDeProjetoEmCamadas
{
    public partial class frmCadastroEmpresa : PadraoDeProjetoEmCamadas.frmModeloDeCadastro
    {
        public int guardar = 0;

        public frmCadastroEmpresa()
        {
            InitializeComponent();
        }
        public void limparCampos()
        {
            nameBox.Clear();
            descriptionBox.Clear();
            cnpjBox.Clear();
        }

        private void popularcampos(MODELOEmpresa p)
        {
            guardar = p.IdEmpresa;
            nameBox.Text = p.NomeEmpresa;
            descriptionBox.Text = p.Descricao;
            cnpjBox.Text = p.CodeEmpresa;
            

        }


        public frmCadastroEmpresa(frmPrincipal x)
        {
            InitializeComponent();
            //f.Font.Size = 30;
            x.Text = "Menu - Cadastro Empresa";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            alterapropriedades(2);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            FRMLocalizarEmpresas f = new FRMLocalizarEmpresas();
            f.ShowDialog();
            popularcampos(f.modelempresa);
            alterapropriedades(3);
        }

        private void btn_salvar_Click_1(object sender, EventArgs e)
        {
            try
            {
                DadosDaConexao dc = new DadosDaConexao();
                DALConexao cx = new DALConexao(dc.StringDeConexao);

                BLLEmpresa bllempresa = new BLLEmpresa(cx);

                MODELOEmpresa p = new MODELOEmpresa();

               
                p.NomeEmpresa = nameBox.Text;
                p.Descricao = descriptionBox.Text;
                p.CodeEmpresa = cnpjBox.Text;
                


                bllempresa.Incluir(p);

                MessageBox.Show("Empresa inserida com sucesso");

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
                    MessageBox.Show("Falha ao inserir errro:" + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao inserir errro geral:" + ex.Message);
            }
        }

        private void btn_cancelar_Click_1(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btn_deletar_Click_1(object sender, EventArgs e)
        {
            try
            {
                MODELOEmpresa a = new MODELOEmpresa();
                DadosDaConexao dc = new DadosDaConexao();
                DALConexao cx = new DALConexao(dc.StringDeConexao);
                BLLEmpresa bllempresa = new BLLEmpresa(cx);
                bllempresa.Excluir(guardar);
                MessageBox.Show("Empresa excluida com sucesso.");

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

        private void btn_alterar_Click_1(object sender, EventArgs e)
        {
            try
            {
                DadosDaConexao dc = new DadosDaConexao();
                DALConexao cx = new DALConexao(dc.StringDeConexao);
                BLLEmpresa bllempresa = new BLLEmpresa(cx);

                MODELOEmpresa p = new MODELOEmpresa();
                p.NomeEmpresa = nameBox.Text;
                p.Descricao = descriptionBox.Text;
                p.CodeEmpresa = cnpjBox.Text;
                p.IdEmpresa = guardar;


                bllempresa.Alterar(p);
                MessageBox.Show("Empresa alterada com sucesso.");

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
                    MessageBox.Show("Falha ao alterar erro:" + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao alterar erro geral:" + ex.Message);
            }
        }

        private void painel_campos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmCadastroEmpresa_Load(object sender, EventArgs e)
        {

        }
    }
}
