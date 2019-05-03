using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.classesBasicas
{
   public class Venda
    {
        private int numVenda;
        private DateTime dataVenda;
        private Funcionario funcionario;
        private Cliente cliente;

        public int NumVenda { get => numVenda; set => numVenda = value; }
        public DateTime DataVenda { get => dataVenda; set => dataVenda = value; }
        public Funcionario Funcionario { get => funcionario; set => funcionario = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
    }
}
