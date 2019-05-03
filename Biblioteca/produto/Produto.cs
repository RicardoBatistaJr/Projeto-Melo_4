using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.produto
{
    public class Produto
    {
        private int codigo;
        private string nome;
        private float preco;
        private string descricaoDetalhada;
        private bool ativo;
        public Produto()
        {
            this.ativo = false;
        }
        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public float Preco { get => preco; set => preco = value; }
        public string DescricaoDetalhada { get => descricaoDetalhada; set => descricaoDetalhada = value; }
        public bool Ativo { get => ativo; set => ativo = value; }
    }
}
