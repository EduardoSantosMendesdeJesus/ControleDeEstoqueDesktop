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
    public class DALSubCategoria
    {
        private DALConexao conexao;
        public DALSubCategoria(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloSubCategoria modelo) // Método que Inclui uma categoria no banco
        {
            try
            {
                SqlCommand cmd = new SqlCommand(); // Criação do comando
                cmd.Connection = conexao.ObjetoConexao; // Definição de qual comando utilizar
                cmd.CommandText = "insert into subcategoria(cat_cod, scat_nome) values (@catcod, @nome); select @@IDENTITY;"; //Comando de inserção da tabela SubCategoria
                cmd.Parameters.AddWithValue("@catcod", modelo.CatCod); // Parametros 
                cmd.Parameters.AddWithValue("@nome", modelo.ScatNome);
                conexao.Conectar();
                // Executa o comando
                modelo.ScatCod = Convert.ToInt32(cmd.ExecuteScalar()); // ExecuteScalar é usado quando se quer ter pouca informação do banco de dado
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }
        public void Alterar(ModeloSubCategoria modelo) // Método para Altera uma categoria já existente
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "update subcategoria set scat_nome = @nome, cat_cod = @catcod where scat_cod = @scatcod;"; //Comando SQL
                cmd.Parameters.AddWithValue("@nome", modelo.ScatNome); // Parametros
                cmd.Parameters.AddWithValue("@catcod", modelo.CatCod);
                cmd.Parameters.AddWithValue("@scatcod", modelo.ScatCod);
                conexao.Conectar();
                cmd.ExecuteNonQuery(); // ExecuteNonQuery é usado quando não quer informação de retorno
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }
        public void Excluir(int codigo) // Método que Exclui uma categoria
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "delete from subcategoria where scat_cod = @codigo;";
                cmd.Parameters.AddWithValue("@codigo", codigo);
                conexao.Conectar();
                cmd.ExecuteNonQuery(); // ExecuteNonQuery é usado quando não quer informação de retorno
            }
            catch
            {
                throw new Exception("Este registro está sendo utilizado");
            }
            finally
            {
                conexao.Desconectar();
            }

        }
        public DataTable Localizar(String valor) // Método para localizar as categorias com base em um valor
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select sc.scat_cod, sc.scat_nome, sc.cat_cod, c.cat_nome" + 
                " from subcategoria sc inner join categoria c on sc.cat_cod = c.cat_cod where scat_nome like '%" +
                valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarPorCategoria(int categoria)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select sc.scat_cod, sc.scat_nome, sc.cat_cod, c.cat_nome" +
                " from subcategoria sc inner join categoria c on sc.cat_cod = c.cat_cod where sc.cat_cod = " +
                categoria.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloSubCategoria CarregaModeloSubCategoria(int codigo) //Método que pega informações de um registro específico do banco (na tabela categoria) e preencher um objeto no medelo categoria
        {
            ModeloSubCategoria modelo = new ModeloSubCategoria();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from subcategoria where scat_cod = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader(); //ExecuteReader é usado quando se quer ter varios registros/informações do banco de dados

            if (registro.HasRows)// Leitura da linha, caso exista uma
            {
                // Armazena os valores do modelo
                registro.Read();
                modelo.CatCod = Convert.ToInt32(registro["cat_cod"]);
                modelo.ScatNome = Convert.ToString(registro["scat_nome"]);
                modelo.ScatCod = Convert.ToInt32(registro["scat_cod"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
