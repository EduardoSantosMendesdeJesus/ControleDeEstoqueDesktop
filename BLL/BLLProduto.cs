﻿using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLProduto
    {
        private DALConexao conexao;
        public BLLProduto(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloProduto obj)
        {
            if (obj.ProNome.Trim().Length == 0)
            {
                throw new Exception("Nome do produto é obrigatório");
            }
            obj.ProNome = obj.ProNome.ToUpper();

            if (obj.ProDescricao.Trim().Length == 0)
            {
                throw new Exception("Descrição do produto é obrigatório");
            }
            obj.ProNome = obj.ProNome.ToUpper();

            if (obj.ProValorVenda <= 0)
            {
                throw new Exception("O valor de venda do produto é obrigatório");
            }

            if (obj.ProQtde < 0)
            {
                throw new Exception("A quantidade do produto tem que ser maior ou igual a zero");
            }

            if (obj.ScatCod <= 0)
            {
                throw new Exception("O código da subcategoria é obrigatorio");
            }

            if (obj.CatCod <= 0)
            {
                throw new Exception("O código da categoria é obrigatorio");
            }

            if (obj.UmedCod <= 0)
            {
                throw new Exception("O código da unidade de medida é obrigatorio");
            }

            DALProduto DALobj = new DALProduto(conexao);
            DALobj.Incluir(obj);
        }
        public void Excluir(int codigo)
        {
            DALProduto DALobj = new DALProduto(conexao);
            DALobj.Excluir(codigo);
        }
        public void Alterar(ModeloProduto obj)
        {
            if (obj.ProNome.Trim().Length == 0)
            {
                throw new Exception("Nome do produto é obrigatório");
            }
            obj.ProNome = obj.ProNome.ToUpper();

            if (obj.ProDescricao.Trim().Length == 0)
            {
                throw new Exception("Descrição do produto é obrigatório");
            }
            obj.ProNome = obj.ProNome.ToUpper();

            if (obj.ProValorVenda <= 0)
            {
                throw new Exception("O valor de venda do produto é obrigatório");
            }

            if (obj.ProQtde < 0)
            {
                throw new Exception("A quantidade do produto tem que ser maior ou igual a zero");
            }

            if (obj.ScatCod <= 0)
            {
                throw new Exception("O código da subcategoria é obrigatorio");
            }

            if (obj.CatCod <= 0)
            {
                throw new Exception("O código da categoria é obrigatorio");
            }

            if (obj.UmedCod <= 0)
            {
                throw new Exception("O código da unidade de medida é obrigatorio");
            }

            if (obj.ProCod <= 0)
            {
                throw new Exception("O código do produto é obrigatorio");
            }

            DALProduto DALobj = new DALProduto(conexao);
            DALobj.Alterar(obj);
        }
        public DataTable Localizar(String valor)
        {
            DALProduto DALobj = new DALProduto(conexao);
            return DALobj.Localizar(valor);
        }
        public ModeloProduto CarregaModeloProduto(int codigo) 
        {
            DALProduto DALobj = new DALProduto(conexao);
            return DALobj.CarregaModeloProduto(codigo);
        }
    }
}
