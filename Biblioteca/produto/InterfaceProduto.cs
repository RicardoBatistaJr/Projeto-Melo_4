using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.produto
{
    public interface InterfaceProduto
    {
        void CadastrarProduto(Produto p);
        void AlterarProduto(Produto p);
        void RemoverProduto(Produto p);
        List<Produto> ListarProdutos(Produto p);
        void AtivarProduto(Produto p);
        void DesativarProduto(Produto p);
    }
}
