using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento_Implementacao_Lista
{
    internal class ListaProduto: IListaProduto
    {
        private int _proximaPosicaoArray;
        private IProduto[] _arrayProduto;
        public ListaProduto(int quantidadeInicial = 5)
        {
            _arrayProduto = new IProduto[quantidadeInicial]; ;
            _proximaPosicaoArray = 0;
        }
        public void Adicionar(IProduto produto)
        {
            int tamanhoNecessario = _proximaPosicaoArray + 1;

            ControleCapacidadeArray(tamanhoNecessario);

            _arrayProduto[_proximaPosicaoArray] = produto;

            _proximaPosicaoArray++;
        }

        private void ControleCapacidadeArray(int tamanhoNecessario)
        {
            if (_arrayProduto.Length > tamanhoNecessario)
                return;

            int novaCapacidade = _arrayProduto.Length * 2;

            if (novaCapacidade < tamanhoNecessario)
                novaCapacidade = tamanhoNecessario;

            AtualizarCapacidadeArray(novaCapacidade);

        }

        private void AtualizarCapacidadeArray(int novaCapacidade)
        {
            IProduto[] novoArray = new IProduto[novaCapacidade];
            
            for(int i=0; i< _arrayProduto.Length; i++)
            {
                novoArray[i] = _arrayProduto[i];
            }

            _arrayProduto = novoArray;
        }

        public void Remover(IProduto produto)
        {
            int indiceDoItemARemover = -1;

            for(int i = 0; i < _proximaPosicaoArray; i++)
            {
                if(_arrayProduto[i].Equals(produto))
                {
                    indiceDoItemARemover = i;
                    break;
                }
            }

            for (int i= indiceDoItemARemover; i < _proximaPosicaoArray - 1; i++)
                _arrayProduto[i] = _arrayProduto[i + 1];

            _proximaPosicaoArray --;
        }

        public IProduto RetornarPeloIndice(int indice)
        {
            VerificarValidadeIndice(indice);

            return _arrayProduto[indice];
        }

        private void VerificarValidadeIndice(int indice)
        {
            if ((indice < 0) || (indice >= _proximaPosicaoArray))
                throw new ArgumentException(nameof(indice));
        }

        public int QuantidadeLista()
        {
            return _proximaPosicaoArray;
        }
    }
}
