using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class MODELOEleicao
    {
        private int ideleicao;
        private int idempresa;
        private string nome;
        private string descricao;
        private byte tipovoto;
        private string mensagemencerrado;
        private string mensagemfim;
        private DateTime datainicio;
        private DateTime datafim;

        public int Ideleicao { get => ideleicao; set => ideleicao = value; }
        public int Idempresa { get => idempresa; set => idempresa = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public byte Tipovoto { get => tipovoto; set => tipovoto = value; }
        public string Mensagemencerrado { get => mensagemencerrado; set => mensagemencerrado = value; }
        public string Mensagemfim { get => mensagemfim; set => mensagemfim = value; }
        public DateTime Datainicio { get => datainicio; set => datainicio = value; }
        public DateTime Datafim { get => datafim; set => datafim = value; }
    }
}
