using Biblioteca.classesBasicas;
using Biblioteca.dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.negocio
{
    public class ClienteNegocio : IClienteDados
    {
        void IClienteDados.AlterarCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        void IClienteDados.CadastrarCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        List<Cliente> IClienteDados.ConsultarCliente(Cliente filtro)
        {
            throw new NotImplementedException();
        }

        void IClienteDados.DeletarCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        List<Cliente> IClienteDados.ListarClientes()
        {
            throw new NotImplementedException();
        }

        List<Venda> IClienteDados.ListarVendaCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}
