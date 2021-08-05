using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    // classe responsavel por interagir com a interface, pega os dados verifica esta tudo em ordem 
    // chama a classe DALL e executa as operações no banco
    public class BLLCategoria
    {
        private DALConexao conexao;
        public BLLCategoria(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloCategoria modelo)
        {
            if (modelo.CatNome.Trim().Length == 0)
            {
                throw new Exception("Nome da categoria é obrigatório");
            }
            modelo.CatNome = modelo.CatNome.ToUpper(); //Deixa todo o texto em letra MAIÚSCULA

            DALCategoria DALobj = new DALCategoria(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloCategoria modelo)
        {
            if (modelo.CatCod <= 0)
            {
                throw new Exception("Código da categoria é obrigatório");
            }

            if (modelo.CatNome.Trim().Length == 0)
            {
                throw new Exception("Nome da categoria é obrigatório");
            }
            modelo.CatNome = modelo.CatNome.ToUpper(); //Deixa todo o texto em letra MAIÚSCULA

            DALCategoria DALobj = new DALCategoria(conexao);
            DALobj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALCategoria DALobj = new DALCategoria(conexao);
            DALobj.Excluir(codigo);
        }
        public DataTable Localizar(String valor)
        {
            DALCategoria DALobj = new DALCategoria(conexao);
            return DALobj.Localizar(valor);
        }
        public ModeloCategoria CarregaModeloCategoria(int codigo)
        {
            DALCategoria DALobj = new DALCategoria(conexao);
            return DALobj.CarregaModeloCategoria(codigo);
        }
    }
}
