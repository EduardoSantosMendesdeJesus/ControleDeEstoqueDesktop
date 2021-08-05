﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using DAL;
using System.Data;

namespace BLL
{
    public class BLLUnidadeDeMedida
    {
        private DALConexao conexao;
        public BLLUnidadeDeMedida(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloUnidadeDeMedida modelo)
        {
            if (modelo.UmedNome.Trim().Length == 0)
            {
                throw new Exception("Nome da da unidade de medida é obrigatório");
            }          

            modelo.UmedNome = modelo.UmedNome.ToUpper(); //Deixa todo o texto em letra MAIÚSCULA

            DALUnidadeDeMedida DALobj = new DALUnidadeDeMedida(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloUnidadeDeMedida modelo)
        {
            if (modelo.UmedCod <= 0)
            {
                throw new Exception("Código da unidade de medida é obrigatório");
            }

            if (modelo.UmedNome.Trim().Length == 0)
            {
                throw new Exception("Nome da unidade de medida é obrigatório");
            }

            modelo.UmedNome = modelo.UmedNome.ToUpper(); //Deixa todo o texto em letra MAIÚSCULA

            DALUnidadeDeMedida DALobj = new DALUnidadeDeMedida(conexao);
            DALobj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            DALUnidadeDeMedida DALobj = new DALUnidadeDeMedida(conexao);
            DALobj.Excluir(codigo);
        }
        public DataTable Localizar(String valor)
        {
            DALUnidadeDeMedida DALobj = new DALUnidadeDeMedida(conexao);
            return DALobj.Localizar(valor);
        }
        public int VerificaUnidadeDeMedida(String valor) // 0 - não existe no banco || numero > 0 existe no banco
        {
            DALUnidadeDeMedida DALobj = new DALUnidadeDeMedida(conexao);
            return DALobj.VerificaUnidadeDeMedida(valor);
        }
        public ModeloUnidadeDeMedida CarregaModeloUnidadeDeMedida(int codigo)
        {
            DALUnidadeDeMedida DALobj = new DALUnidadeDeMedida(conexao);
            return DALobj.CarregaModeloUnidadeDeMedida(codigo);
        }
    }
}
