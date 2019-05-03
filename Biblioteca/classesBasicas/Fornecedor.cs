using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.classesBasicas
{
   public class Fornecedor
    {
        private string cnpj;
        private string nomeFornecedor;

        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string NomeFornecedor { get => nomeFornecedor; set => nomeFornecedor = value; }
    }
}
