using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.classesBasicas
{
   public class Funcionario
    {
        private int codFuncionario;
        private string cpfFuncionario;
        private int senhaUsuario;
        private string funcaoFuncionario;
        private string nomeFuncionario;

        public int CodFuncionario { get => codFuncionario; set => codFuncionario = value; }
        public string CpfFuncionario { get => cpfFuncionario; set => cpfFuncionario = value; }
        public int SenhaUsuario { get => senhaUsuario; set => senhaUsuario = value; }
        public string FuncaoFuncionario { get => funcaoFuncionario; set => funcaoFuncionario = value; }
        public string NomeFuncionario { get => nomeFuncionario; set => nomeFuncionario = value; }
    }
}
