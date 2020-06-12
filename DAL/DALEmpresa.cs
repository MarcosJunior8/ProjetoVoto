using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAL
{
   
        public class DALEmpresa
        {
            private DALConexao conexao;

            public DALEmpresa(DALConexao cx)
            {
                this.conexao = cx;
            }

            public void Incluir(MODELOEmpresa modelo)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = this.conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO Empresa (idEmpresa, nomeEmpresa, descricao, codeEmpresa)" +
                    "VALUES (NULL, @nome, @descri, @code);";
                        
                    cmd.Parameters.AddWithValue("@nome", modelo.NomeEmpresa);
                    cmd.Parameters.AddWithValue("@descri", modelo.Descricao);
                    cmd.Parameters.AddWithValue("@code", modelo.CodeEmpresa);

                    conexao.Conectar();
                    int idInserido = Convert.ToInt32(cmd.ExecuteScalar());
                    modelo.IdEmpresa = idInserido;
                }
                catch (MySqlException e)
                {
                    throw e;
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    this.conexao.Desconectar();
                }

            }

            public void Alterar(MODELOEmpresa modelo)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = this.conexao.ObjetoConexao;
                    cmd.CommandText = "UPDATE Empresa SET nomeEmpresa = @nome," +
                                      " descricao = @descri," +
                                      " codeEmpresa = @code" +
                                      " WHERE " +
                                      " idEmpresa = @id";                   
                    cmd.Parameters.AddWithValue("@nome", modelo.NomeEmpresa);
                    cmd.Parameters.AddWithValue("@descri",modelo.Descricao);
                    cmd.Parameters.AddWithValue("@code", modelo.CodeEmpresa);
                    cmd.Parameters.AddWithValue("@id", modelo.IdEmpresa);

                    this.conexao.Conectar();
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException e)
                {
                    throw e;
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    this.conexao.Desconectar();
                }
            }

            public void Excluir(int codigo)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = this.conexao.ObjetoConexao;

                    cmd.CommandText = "DELETE FROM Empresa WHERE idEmpresa = @id";
                    cmd.Parameters.AddWithValue("@id", codigo);
                    this.conexao.Conectar();
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException e)
                {
                    throw e;
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    this.conexao.Desconectar();
                }
            }

            public DataTable Localizar(string texto)
            {
                DataTable tabela = new DataTable();
                string SQL = "SELECT * FROM Empresa WHERE nomeEmpresa LIKE '%" + texto + "%'";
                MySqlDataAdapter adapter = new MySqlDataAdapter(SQL, this.conexao.ObjetoConexao);
                adapter.Fill(tabela);

                return tabela;
            }
        }
    }



