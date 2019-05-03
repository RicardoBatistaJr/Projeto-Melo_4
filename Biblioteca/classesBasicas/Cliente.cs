using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.classesBasicas
{
    public class Cliente
    {
        private string cpfCliente;
        private string nomeCliente;
        private string emailCliente;
        private int telCliente;
        private string testedealteracao;

        public string CpfCliente { get => cpfCliente; set => cpfCliente = value; }
        public string NomeCliente { get => nomeCliente; set => nomeCliente = value; }
        public string EmailCliente { get => emailCliente; set => emailCliente = value; }
        public int TelCliente { get => telCliente; set => telCliente = value; }
        public string Testedealteracao { get => testedealteracao; set => testedealteracao = value; }
    }
}
