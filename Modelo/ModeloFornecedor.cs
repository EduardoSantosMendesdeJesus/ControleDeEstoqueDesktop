using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloFornecedor
    {
        public ModeloFornecedor()
        {
            this.ForCod = 0;
            this.ForNome = "";
            this.ForCnpj = "";
            this.ForIe = "";
            this.ForRSocial = "";            
            this.ForCep = "";
            this.ForEndereco = "";
            this.ForBairro = "";
            this.ForTelefone = "";
            this.ForCelular = "";
            this.ForEmail = "";
            this.ForNumeroEnd = "";
            this.ForCidade = "";
            this.ForEstado = "";
        }

        public ModeloFornecedor(int cod, string nome, string cnpj, string ie, string rsocial, string cep, string endereco,
            string bairro, string telefone, string celular, string email, string numeroend, string cidade, string estado)
        {
            this.ForCod = cod;
            this.ForNome = nome;
            this.ForCnpj = cnpj;
            this.ForIe = ie;
            this.ForRSocial = rsocial;            
            this.ForCep = cep;
            this.ForEndereco = endereco;
            this.ForBairro = bairro;
            this.ForTelefone = telefone;
            this.ForCelular = celular;
            this.ForEmail = email;
            this.ForNumeroEnd = numeroend;
            this.ForCidade = cidade;
            this.ForEstado = estado;
        }

        //Propridades
        private int for_cod;

        public int ForCod
        {
            get { return this.for_cod; }
            set { this.for_cod = value; }
        }
        private string for_nome;

        public String ForNome
        {
            get { return this.for_nome; }
            set { this.for_nome = value; }
        }

        private string for_cnpj;

        public String ForCnpj
        {
            get { return this.for_cnpj; }
            set { this.for_cnpj = value; }
        }

        private string for_ie;

        public String ForIe
        {
            get { return this.for_ie; }
            set { this.for_ie = value; }
        }

        private string for_rsocial;

        public String ForRSocial
        {
            get { return this.for_rsocial; }
            set { this.for_rsocial = value; }
        }       

        private string for_cep;

        public String ForCep
        {
            get { return this.for_cep; }
            set { this.for_cep = value; }
        }

        private string for_endereco;

        public String ForEndereco
        {
            get { return this.for_endereco; }
            set { this.for_endereco = value; }
        }

        private string for_bairro;

        public String ForBairro
        {
            get { return this.for_bairro; }
            set { this.for_bairro = value; }
        }

        private string for_telefone;

        public String ForTelefone
        {
            get { return this.for_telefone; }
            set { this.for_telefone = value; }
        }

        private string for_celular;

        public String ForCelular
        {
            get { return this.for_celular; }
            set { this.for_celular = value; }
        }

        private string for_email;

        public String ForEmail
        {
            get { return this.for_email; }
            set { this.for_email = value; }
        }

        private string for_numeroend;

        public String ForNumeroEnd
        {
            get { return this.for_numeroend; }
            set { this.for_numeroend = value; }
        }

        private string for_cidade;

        public String ForCidade
        {
            get { return this.for_cidade; }
            set { this.for_cidade = value; }
        }

        private string for_estado;

        public String ForEstado
        {
            get { return this.for_estado; }
            set { this.for_estado = value; }
        }
    }
}
