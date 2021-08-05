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
    public class BLLSubCategoria
    {
        private DALConexao conexao;
        public BLLSubCategoria(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloSubCategoria modelo)
        {
            if (modelo.ScatNome.Trim().Length == 0)
            {
                throw new Exception("Nome da subcategoria é obrigatório");
            }
            if(modelo.CatCod <= 0)
            {
                throw new Exception("Código da categoria é obrigatório");
            }

            modelo.ScatNome = modelo.ScatNome.ToUpper(); //Deixa todo o texto em letra MAIÚSCULA

            DALSubCategoria DALobj = new DALSubCategoria(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloSubCategoria modelo)
        {
            if (modelo.ScatNome.Trim().Length == 0)
            {
                throw new Exception("Nome da subcategoria é obrigatório");
            }
            if (modelo.CatCod <= 0)
            {
                throw new Exception("Código da categoria é obrigatório");
            }
            if (modelo.ScatCod <= 0)
            {
                throw new Exception("Código da subcategoria é obrigatório");
            }
            
            DALSubCategoria DALobj = new DALSubCategoria(conexao);
            DALobj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALSubCategoria DALobj = new DALSubCategoria(conexao);
            DALobj.Excluir(codigo);
        }
        public DataTable Localizar(String valor)
        {
            DALSubCategoria DALobj = new DALSubCategoria(conexao);
            return DALobj.Localizar(valor);
        }
        public DataTable LocalizarPorCategoria(int categoria)
        {
            DALSubCategoria DALobj = new DALSubCategoria(conexao);
            return DALobj.LocalizarPorCategoria(categoria);
        }
        public ModeloSubCategoria CarregaModeloSubCategoria(int codigo)
        {
            DALSubCategoria DALobj = new DALSubCategoria(conexao);
            return DALobj.CarregaModeloSubCategoria(codigo);
        }
    }
}
