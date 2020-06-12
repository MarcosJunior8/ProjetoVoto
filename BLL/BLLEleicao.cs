using DAL;
using System;
using MODELO;
using MySql.Data.MySqlClient;
using System.Data;
using System.Text.RegularExpressions;

namespace BLL
{
    public class BLLEleicao
    {
        private DALEleicao DALobj;

        public BLLEleicao(DALConexao cx)
        {
            DALobj = new DALEleicao(cx);
        }

        public void Incluir(MODELOEleicao modelo)
        {
            try
            {

                /* TRATAMENTO ID EMPRESA--------------------------------------------------------------------------------------------------------------------------------------------------------------*/
                if (modelo.Idempresa <= 0)
                {

                    throw new ArgumentNullException("Codigo", "Codigo não pode conter números menores ou iguais a zero");
                }

                if (Convert.ToString(modelo.Idempresa) == "")
                {

                    throw new ArgumentNullException("Codigo", "O campo Codigo não pode estar vazio");
                }

                /*------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ */

           
                /* TRATAMENTO NOME--------------------------------------------------------------------------------------------------------------------------------------------------------------*/

                bool CaracterIndevido = Regex.IsMatch(modelo.Nome, (@"[!""#$%&'()*+,-./:;?@[\\\]_`{|}~]"));
                if (CaracterIndevido == true)
                {
                    throw new ArgumentNullException("Nome", "Nome não pode conter caractéres especiais");
                }
                if (modelo.Nome == "")
                {

                    throw new ArgumentNullException("Nome", "O Campo Nome não pode estar vazio");
                }

                /*------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ */

                /* TRATAMENTO MENSAGEM ENCERRAR--------------------------------------------------------------------------------------------------------------------------------------------------------------*/

                if (modelo.Mensagemencerrado == "")
                {

                    throw new ArgumentNullException("Mensagem de encerrar", "O Campo Mensagem encerrar não pode estar vazio");
                }

                /*------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ */

                /* TRATAMENTO MENSAGEM FIM--------------------------------------------------------------------------------------------------------------------------------------------------------------*/

                if (modelo.Mensagemfim == "")
                {

                    throw new ArgumentNullException("Mensagem fim", "O Campo Mensagem fim não pode estar vazio");
                }

                /*------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ */

                /* TRATAMENTO DATA INICIO--------------------------------------------------------------------------------------------------------------------------------------------------------------*/

                if ( Convert.ToString(modelo.Datainicio) == "")
                {

                    throw new ArgumentNullException("Data inicio", "O Campo Data Inicio não pode estar vazio");
                }
                if(modelo.Datafim <= modelo.Datainicio)
                {

                    throw new ArgumentNullException("Data inicio", "A Data de fim não pode ser menor ou igual a data de inicio ");
                }

                /*------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ */

                /* TRATAMENTO DATA FIM--------------------------------------------------------------------------------------------------------------------------------------------------------------*/

                if (Convert.ToString(modelo.Datafim) == "")
                {

                    throw new ArgumentNullException("Data fim", "O Campo Data fim não pode estar vazio");
                }
                if (modelo.Datafim < modelo.Datainicio)
                {

                    throw new ArgumentNullException("Data fim", "A Data de inicio não pode ser maior que a data de fim ");
                }

                /*------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ */

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

        public void Alterar(MODELOEleicao modelo)
        {
            try
            {
                /* TRATAMENTO ID EMPRESA--------------------------------------------------------------------------------------------------------------------------------------------------------------*/
                if (modelo.Idempresa <= 0)
                {

                    throw new ArgumentNullException("Codigo", "Codigo não pode conter números menores ou iguais a zero");
                }

                if (Convert.ToString(modelo.Idempresa) == "")
                {

                    throw new ArgumentNullException("Codigo", "O campo Codigo não pode estar vazio");
                }

                /*------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ */


                /* TRATAMENTO NOME--------------------------------------------------------------------------------------------------------------------------------------------------------------*/

                bool CaracterIndevido = Regex.IsMatch(modelo.Nome, (@"[!""#$%&'()*+,-./:;?@[\\\]_`{|}~]"));
                if (CaracterIndevido == true)
                {
                    throw new ArgumentNullException("Nome", "Nome não pode conter caractéres especiais");
                }
                if (modelo.Nome == "")
                {

                    throw new ArgumentNullException("Nome", "O Campo Nome não pode estar vazio");
                }

                /*------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ */

                /* TRATAMENTO MENSAGEM ENCERRAR--------------------------------------------------------------------------------------------------------------------------------------------------------------*/

                if (modelo.Mensagemencerrado == "")
                {

                    throw new ArgumentNullException("Mensagem de encerrar", "O Campo Mensagem encerrar não pode estar vazio");
                }

                /*------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ */

                /* TRATAMENTO MENSAGEM FIM--------------------------------------------------------------------------------------------------------------------------------------------------------------*/

                if (modelo.Mensagemfim == "")
                {

                    throw new ArgumentNullException("Mensagem fim", "O Campo Mensagem fim não pode estar vazio");
                }

                /*------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ */

                /* TRATAMENTO DATA INICIO--------------------------------------------------------------------------------------------------------------------------------------------------------------*/

                if (Convert.ToString(modelo.Datainicio) == "")
                {

                    throw new ArgumentNullException("Data inicio", "O Campo Data Inicio não pode estar vazio");
                }
                if (modelo.Datafim <= modelo.Datainicio)
                {

                    throw new ArgumentNullException("Data inicio", "A Data de fim não pode ser menor ou igual a data de inicio ");
                }

                /*------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ */

                /* TRATAMENTO DATA FIM--------------------------------------------------------------------------------------------------------------------------------------------------------------*/

                if (Convert.ToString(modelo.Datafim) == "")
                {

                    throw new ArgumentNullException("Data fim", "O Campo Data fim não pode estar vazio");
                }
                if (modelo.Datafim < modelo.Datainicio)
                {

                    throw new ArgumentNullException("Data fim", "A Data de inicio não pode ser maior que a data de fim ");
                }

                /*------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ */



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
            
            DALobj.Excluir(codigo);
        }

        public DataTable Localizar(string texto)
        {
            return DALobj.Localizar(texto);
        }
    }
}

