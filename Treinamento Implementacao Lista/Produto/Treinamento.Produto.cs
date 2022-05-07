using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento_Implementacao_Lista
{
    internal interface IProduto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }

        public double Quantidade { get; set; }
    }
}
