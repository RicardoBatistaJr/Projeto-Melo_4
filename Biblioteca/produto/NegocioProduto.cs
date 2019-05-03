using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.produto
{
    public class NegocioProduto : InterfaceProduto
    {
        public void AlterarProduto(Produto p)
        {
            throw new NotImplementedException();
        }

        public void AtivarProduto(Produto p)
        {
            throw new NotImplementedException();
        }

        public void CadastrarProduto(Produto p)
        {
            if(p == null)
            {
                throw new Exception("Informar os dados do produto");
            }
            if (p.Codigo <= 0)
            {
                throw new Exception("Informar o código do produto");
            }
            if (string.IsNullOrEmpty(p.Nome) == true)
            {
                throw new Exception("Informar o nome do produto");
            }
            if (string.IsNullOrWhiteSpace(p.Nome) == true)
            {
                throw new Exception("Informar o nome do produto");
            }
            //colocar as demais validações, viu!!!
            new DadosProduto().CadastrarProduto(p);
        }

        public void DesativarProduto(Produto p)
        {
            throw new NotImplementedException();
        }

        public List<Produto> ListarProdutos(Produto p)
        {
            throw new NotImplementedException();
        }

        public void RemoverProduto(Produto p)
        {
            throw new NotImplementedException();
        }
    }
}
