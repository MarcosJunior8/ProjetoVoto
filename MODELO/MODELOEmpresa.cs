using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class MODELOEmpresa
    {
        int idEmpresa;
        string nomeEmpresa;
        string descricao;
        string codeEmpresa;

        public int IdEmpresa { get => idEmpresa; set => idEmpresa = value; }
        public string NomeEmpresa { get => nomeEmpresa; set => nomeEmpresa = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string CodeEmpresa { get => codeEmpresa; set => codeEmpresa = value; }
    }
}
