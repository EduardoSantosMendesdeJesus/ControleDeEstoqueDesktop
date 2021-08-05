using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALCategoria
    {
        private DALConexao conexao;
        public DALCategoria(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloCategoria modelo) // Método que Inclui uma categoria no banco
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into categoria(cat_nome) values (@nome); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", modelo.CatNome);
            conexao.Conectar();
            modelo.CatCod = Convert.ToInt32(cmd.ExecuteScalar()); // ExecuteScalar é usado quando se quer ter pouca informação do banco de dado
            conexao.Desconectar();
        }
        public void Alterar(ModeloCategoria modelo) // Método para Altera uma categoria já existente
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update categoria set cat_nome = @nome where cat_cod = @codigo;";
            cmd.Parameters.AddWithValue("@nome", modelo.CatNome);
            cmd.Parameters.AddWithValue("@codigo", modelo.CatCod);
            conexao.Conectar();
            cmd.ExecuteNonQuery(); // ExecuteNonQuery é usado quando não quer informação de retorno
            conexao.Desconectar();
        }
        public void Excluir(int codigo) // Método que Exclui uma categoria
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from categoria where cat_cod = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery(); // ExecuteNonQuery é usado quando não quer informação de retorno
            conexao.Desconectar();
        }
        public DataTable Localizar(String valor) // Método para localizar as categorias com base em um valor
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from categoria where cat_nome like '%" + 
                valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public ModeloCategoria CarregaModeloCategoria(int codigo) //Método que pega informações de um registro específico do banco (na tabela categoria) e preencher um objeto no medelo categoria
        {
            ModeloCategoria modelo = new ModeloCategoria();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from categoria where cat_cod = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader(); //ExecuteReader é usado quando se quer ter varios registros/informações do banco de dados
            
            if (registro.HasRows)
            {
                registro.Read();
                modelo.CatCod = Convert.ToInt32(registro["cat_cod"]);
                modelo.CatNome = Convert.ToString(registro["cat_nome"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
