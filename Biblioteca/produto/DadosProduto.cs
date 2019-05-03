using Biblioteca.conexao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.produto
{
    public class DadosProduto : Conexao, InterfaceProduto
    {
        public void AlterarProduto(Produto p)
        {
            
        }

        public void AtivarProduto(Produto p)
        {
            
        }

        public void CadastrarProduto(Produto p)
        {
            try
            {
                //abrir a conexão
                this.AbrirConexao();
                string sql = "insert into produto (codigo, nome, preco, descricaodetalhada) ";
                sql += "values(@codigo, @nome, @preco, @descricaodetalhada)";
                //instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConn);

                cmd.Parameters.Add("@codigo", SqlDbType.Int);
                cmd.Parameters["@codigo"].Value = p.Codigo;

                cmd.Parameters.Add("@nome", SqlDbType.VarChar);
                cmd.Parameters["@nome"].Value = p.Nome;

                cmd.Parameters.Add("@descricaodetalhada", SqlDbType.VarChar);
                cmd.Parameters["@descricaodetalhada"].Value = p.DescricaoDetalhada;

                cmd.Parameters.Add("@preco", SqlDbType.Float);
                cmd.Parameters["@preco"].Value = p.Preco;

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

        public void DesativarProduto(Produto p)
        {
            
        }

        public List<Produto> ListarProdutos(Produto p)
        {
            return null;
        }

        public void RemoverProduto(Produto p)
        {
            
        }
    }
}
