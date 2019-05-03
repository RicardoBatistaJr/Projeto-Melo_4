using Biblioteca.conexao;
using Biblioteca.classesBasicas;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data;
using System.Collections.Generic;

namespace Biblioteca.dados
{
    public class DadosCliente : Conexao
    {
        //Método insert cliente
        public void CadastrarCliente(Cliente cliente)
        {
           try
            {
                this.AbrirConexao();
                string sql = "insert into Cliente (cpfCliente,nomeClienete,emailClienete,telCliente) ";
                sql += "values(@cpfClienete,@nomeCliente,@emailCliente,@telCliente)";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@cpfCliente", SqlDbType.VarChar);
                cmd.Parameters["@cpfCliente"].Value = cliente.CpfCliente;

                cmd.Parameters.Add("@nomeCliente", SqlDbType.VarChar);
                cmd.Parameters["@nomeCliente"].Value = cliente.NomeCliente;

                cmd.Parameters.Add("@emailCliente", SqlDbType.VarChar);
                cmd.Parameters["@emailCliente"].Value = cliente.EmailCliente;

                cmd.Parameters.Add("@telCliente", SqlDbType.Int);
                cmd.Parameters["@telCliente"].Value = cliente.TelCliente;

                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir " + ex.Message);
            }

        }
        //Método update cliente
        public void AlterarCliente (Cliente cliente)
        {
            try
            {
                //abrir a conexão
                this.AbrirConexao();
                string sql = " update cliente set ";
                sql += " nomeCliente = @nomeCliente ";
                sql += " emailCliente = @emailCliente ";
                sql += " telCliente = @telCliente ";
                sql += " where cpfCliente = @CpfCliente";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@cpfCliente", SqlDbType.VarChar);
                cmd.Parameters["@cpfCliente"].Value = cliente.CpfCliente;

                cmd.Parameters.Add("@nomeCliente", SqlDbType.VarChar);
                cmd.Parameters["@nomeCliente"].Value = cliente.NomeCliente;

                cmd.Parameters.Add("@emailCliente", SqlDbType.VarChar);
                cmd.Parameters["@emailCliente"].Value = cliente.EmailCliente;

                cmd.Parameters.Add("@telCliente", SqlDbType.Int);
                cmd.Parameters["@telCliente"].Value = cliente.TelCliente;

                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conecar e inserir " + ex.Message);
            }
        }
        //Método delete cliente
        public void DeletarCliente (Cliente cliente)
        {
            try
            {
                //abrir a conexão
                this.AbrirConexao();
                string sql = " delete from cliente ";
                sql += " where cpfCliente = @cpfCliente";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@cpfCliente", SqlDbType.VarChar);
                cmd.Parameters["@cpfCliente"].Value = cliente.CpfCliente;

                //executando a instrucao 
                cmd.ExecuteNonQuery();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conecar e inserir " + ex.Message);
            }
        }
        //Método select cliente
        public List<Cliente> ConsultarCliente (Cliente filtro)
        {
            List<Cliente> retorno = new List<Cliente>();
            try
            {
                this.AbrirConexao();
                //instrucao a ser executada
                string sql = "SELECT cpfCliente,nomeClienete,emailClienete,telCliente ";
                sql += " FROM cliente ";
                sql += " WHERE cpfCliente = cpfCliente ";
                //se foi passada uma matricula válida, esta matricula entrará como critério de filtro
                if (filtro.CpfCliente != null)
                {
                    sql += " and cpfCliente = @cpfCliente";
                }
                //se foi passada um nome válido, este nome entrará como critério de filtro
                if (filtro.NomeCliente != null && filtro.NomeCliente.Trim().Equals("") == false)
                {
                    sql += " and nome like @nomeCliente";
                }
                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                //se foi passada uma matricula válida, esta matricula entrará como critério de filtro
                if (filtro.CpfCliente != null)
                {
                    cmd.Parameters.Add("@cpfCliente", SqlDbType.VarChar);
                    cmd.Parameters["@cpfCliente"].Value = "%" + filtro.CpfCliente + "%";
                }
                //se foi passada um nome válido, este nome entrará como critério de filtro
                if (filtro.NomeCliente != null && filtro.NomeCliente.Trim().Equals("") == false)
                {
                    cmd.Parameters.Add("@nomeCliente", SqlDbType.VarChar);
                    cmd.Parameters["@nomeCliente"].Value = "%" + filtro.NomeCliente + "%";

                }
                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Cliente cliente = new Cliente();
                    //acessando os valores das colunas do resultado
                    cliente.CpfCliente = DbReader.GetString(DbReader.GetOrdinal("cpfCliente"));
                    cliente.NomeCliente = DbReader.GetString(DbReader.GetOrdinal("nomeCliente"));
                    cliente.EmailCliente = DbReader.GetString(DbReader.GetOrdinal("emailCliente"));
                    cliente.TelCliente = DbReader.GetInt32(DbReader.GetOrdinal("telCliente"));
                    retorno.Add(cliente);
                }
                //fechando o leitor de resultados
                DbReader.Close();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.FecharConexao();
            }

            catch (Exception ex)
            {
                throw new Exception("Erro ao conecar e selecionar " + ex.Message);
            }
            return retorno;
        }
        //Método select clientes
        public List<Cliente> ListarClientes ()
        {
            List<Cliente> clientes = new List<Cliente>();
            try
            {
                this.AbrirConexao();
                //instrucao a ser executada
                string sql = "SELECT * from cliente ";
                SqlCommand cmd = new SqlCommand(sql, sqlConn);               
                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Cliente cliente = new Cliente();               
                    //acessando os valores das colunas do resultado
                    cliente.CpfCliente = DbReader.GetString(DbReader.GetOrdinal("cpfCliente"));
                    cliente.NomeCliente = DbReader.GetString(DbReader.GetOrdinal("nomeCliente"));
                    cliente.EmailCliente = DbReader.GetString(DbReader.GetOrdinal("emailCliente"));
                    cliente.TelCliente = DbReader.GetInt32(DbReader.GetOrdinal("telCliente"));
                    clientes.Add(cliente);                  
                }
                //fechando o leitor de resultados
                DbReader.Close();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.FecharConexao();
                return clientes;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conecar e selecionar " + ex.Message);
            }
        }
        public List<Venda> ListarVendaCliente (Cliente cliente)
        {
            List<Venda> vendas = new List<Venda>();
            try
            {
                this.AbrirConexao();
                //instrucao a ser executada
                string sql = "SELECT * from vendas ";
                sql += "WHERE cpfCliente = " + cliente.CpfCliente;
                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Venda venda = new Venda();
                    //acessando os valores das colunas do resultado
                    venda.NumVenda = DbReader.GetInt32(DbReader.GetOrdinal("numVenda"));
                    venda.DataVenda = DbReader.GetDateTime(DbReader.GetOrdinal("dataVenda"));
                    venda.Cliente.CpfCliente = DbReader.GetString(DbReader.GetOrdinal("cpfCliente"));
                    venda.Funcionario.CodFuncionario = DbReader.GetInt32(DbReader.GetOrdinal("codFuncionario"));
                    vendas.Add(venda);
                }
                //fechando o leitor de resultados
                DbReader.Close();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.FecharConexao();
                return vendas;


            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conecar e selecionar " + ex.Message);
            }
        }
    }
}
