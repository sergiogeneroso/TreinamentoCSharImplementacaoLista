using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento_Implementacao_Lista
{
    internal interface IListaProduto
    {
        public void Adicionar(IProduto produto);
        public void Remover(IProduto produto);

        public IProduto RetornarPeloIndice(int indice);

        public int QuantidadeLista();
    }
}
