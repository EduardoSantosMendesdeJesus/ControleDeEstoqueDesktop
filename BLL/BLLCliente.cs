using Modelo;
using DAL;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ferramentas;
using System.Text.RegularExpressions;

namespace BLL
{    
    public class BLLCliente
    {
        private DALConexao conexao;

        public BLLCliente(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCliente modelo)
        {
            if (modelo.CliNome.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente é obrigatório");
            }

            if (modelo.CliCpfCnpj.Trim().Length == 0)
            {
                throw new Exception("O CPF/CNPJ é obrigatório");
            }

            //verificar CPF/CNPJ
            if (modelo.CliTipo == "PF")
            {
                //cpf
                if (Validacao.IsCpf(modelo.CliCpfCnpj) == false)
                {
                    throw new Exception("CPF Inválido");
                }
            }
            else
            {
                //cnpj
                if (Validacao.IsCnpj(modelo.CliCpfCnpj) == false)
                {
                    throw new Exception("CNPJ Inválido");
                }
            }
           

            if (modelo.CliRgIe.Trim().Length == 0)
            {
                throw new Exception("O RG/IE é obrigatório");
            }

            if (modelo.CliTelefone.Trim().Length == 0)
            {
                throw new Exception("O Telefone é obrigatório");
            }

            // Validação do email

            string strRegex = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}"
                + "\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\"
                + ".)+))([a-zA-Z]{2,4}|[0,9]{1,3})(\\]?)$";
            Regex re = new Regex(strRegex);
            if(!re.IsMatch(modelo.CliEmail))          
            {
                throw new Exception("Digite um e-mail valido");
            }

            // validação do cep
            /*
            if (Validacao.ValidaCep(modelo.CliCep) == false)
            {
                throw new Exception("CEP Inválido");
            }
            */

            DALCliente DALobj = new DALCliente(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloCliente modelo)
        {
            if (modelo.CliNome.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente é obrigatório");
            }

            if (modelo.CliCpfCnpj.Trim().Length == 0)
            {
                throw new Exception("O CPF/CNPJ é obrigatório");
            }
                        

            if (modelo.CliRgIe.Trim().Length == 0)
            {
                throw new Exception("O RG/IE é obrigatório");
            }

            if (modelo.CliTelefone.Trim().Length == 0)
            {
                throw new Exception("O Telefone é obrigatório");
            }

            DALCliente DALobj = new DALCliente(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALCliente DALobj = new DALCliente(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALCliente DALobj = new DALCliente(conexao);
            return DALobj.Localizar(valor);
        }

        public DataTable LocalizarPorNome(String valor)
        {
            DALCliente DALobj = new DALCliente(conexao);
            return DALobj.LocalizarPorNome(valor);
        }

        public DataTable LocalizarPorCPFCNPJ(String valor)
        {
            DALCliente DALobj = new DALCliente(conexao);
            return DALobj.LocalizarPorCPFCNPJ(valor);
        }

        public ModeloCliente CarregaModeloCliente(int codigo)
        {
            DALCliente DALobj = new DALCliente(conexao);
            return DALobj.CarregaModeloCliente(codigo);
        }

        public ModeloCliente CarregaModeloCliente(string cpfcnpj)
        {
            DALCliente DALobj = new DALCliente(conexao);
            return DALobj.CarregaModeloCliente(cpfcnpj);
        }
    }
}
