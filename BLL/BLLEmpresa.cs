using DAL;
using MODELO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
        public class BLLEmpresa
        {
            private DALEmpresa DALobj;

            public BLLEmpresa(DALConexao cx)
            {
                DALobj = new DALEmpresa(cx);
            }

            public void Incluir(MODELOEmpresa modelo)
            {
                try
                {
                   
                    if (modelo.NomeEmpresa == "")
                    {
                        throw new ArgumentNullException("nomeEmpresa", "Não pode estar vazio");
                    }
                    if (modelo.CodeEmpresa == "")
                    {
                        throw new ArgumentNullException("codeEmpresa", "Não pode estar vazio");
                    }

                    if(modelo.Descricao == "")
                    {
                        throw new ArgumentNullException("descricao", "Não pode estar vazio");
                    }

                    DALobj.Incluir(modelo);
                }
                catch (MySqlException e)
                {
                    throw e;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public void Alterar(MODELOEmpresa modelo)
            {
                try
                {


                    if (modelo.NomeEmpresa == "")
                    {
                        throw new ArgumentNullException("nomeEmpresa", "Não pode estar vazio");
                    }
                    if (modelo.CodeEmpresa == "")
                    {
                        throw new ArgumentNullException("codeEmpresa", "Não pode estar vazio");
                    }

                    if (modelo.Descricao == "")
                    {
                        throw new ArgumentNullException("descricao", "Não pode estar vazio");
                    }



                    DALobj.Alterar(modelo);
                }
                catch (MySqlException e)
                {
                    throw e;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public void Excluir(int codigo)
            {
                if (codigo <= 0)
                {
                    throw new ArgumentNullException("ID", "Para deletar código, não pode estar zerado!");
                }
                DALobj.Excluir(codigo);
            }

            public DataTable Localizar(string texto)
            {
                return DALobj.Localizar(texto);
            }
        }
    }

