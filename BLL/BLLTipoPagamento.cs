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
    public class BLLTipoPagamento
    {
        private DALConexao conexao;
        public BLLTipoPagamento(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloTipoPagamento modelo)
        {
            if (modelo.TpaNome.Trim().Length == 0)
            {
                throw new Exception("O tipo de pagamento é obrigatório");
            }
            //modelo.TpaNome = modelo.TpaNome.ToUpper(); //Deixa todo o texto em letra MAIÚSCULA

            DALTipoPagamento DALobj = new DALTipoPagamento(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloTipoPagamento modelo)
        {
            if (modelo.TpaCod <= 0)
            {
                throw new Exception("O código do tipo de pagamento é obrigatório");
            }

            if (modelo.TpaNome.Trim().Length == 0)
            {
                throw new Exception("O tipo de pagamento é obrigatório");
            }
            //modelo.TpaNome = modelo.TpaNome.ToUpper(); //Deixa todo o texto em letra MAIÚSCULA

            DALTipoPagamento DALobj = new DALTipoPagamento(conexao);
            DALobj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALTipoPagamento DALobj = new DALTipoPagamento(conexao);
            DALobj.Excluir(codigo);
        }
        public DataTable Localizar(String valor)
        {
            DALTipoPagamento DALobj = new DALTipoPagamento(conexao);
            return DALobj.Localizar(valor);
        }
        public ModeloTipoPagamento CarregaModeloTipoPagamento(int codigo)
        {
            DALTipoPagamento DALobj = new DALTipoPagamento(conexao);
            return DALobj.CarregaModeloTipoPagamento(codigo);
        }
    }
}
