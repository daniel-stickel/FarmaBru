using Metadata.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata
{
    public class Produto
    {
        public int ID{ get; set; }
        public string Descricao { get; set; }
        public double Preco{ get; set; }
        public double Estoque{ get; set; }
        public UnidadeMedida UnidadeMedida { get; set; }
        public bool Ativo { get; set; }
    }
}
