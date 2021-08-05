using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloCliente
    {
        //Construtores
        public ModeloCliente()
        {
            this.CliCod = 0;
            this.CliNome = "";
            this.CliCpfCnpj = "";
            this.CliRgIe = "";
            this.CliRSocial = "";
            this.CliTipo = "PF";  //clitipo -> PF pessoa fisica, PJ -> pessoa juridica
            this.CliCep = "";
            this.CliEndereco = "";
            this.CliBairro = "";
            this.CliTelefone = "";
            this.CliCelular = "";
            this.CliEmail = "";
            this.CliNumeroEnd = "";
            this.CliCidade = "";
            this.CliEstado = "";
        }

        public ModeloCliente(int cod, string nome, string cpfcnpj, string cli_foto /*foto*/, string rgie, string rsocial, string tipo, string cep,
            string endereco, string bairro, string telefone, string celular, string email, string numeroend, string cidade, string estado)
        {
            this.CliCod = cod;
            this.CliNome = nome;
            this.CliCpfCnpj = cpfcnpj;
            this.CliRgIe = rgie;
            this.CliRSocial = rsocial;
            this.CliTipo = tipo; //clitipo -> PF pessoa fisica, PJ -> pessoa juridica
            this.CliCep = cep;
            this.CliEndereco = endereco;
            this.CliBairro = bairro;
            this.CliTelefone = telefone;
            this.CliCelular = celular;
            this.CliEmail = email;
            this.CliNumeroEnd = numeroend;
            this.CliCidade = cidade;
            this.CliEstado = estado;
            this.CarregaImagem(cli_foto); //foto
        }

        public ModeloCliente(int cod, string nome, string cpfcnpj, Byte[] cli_foto /*foto*/, string rgie, string rsocial, string tipo, string cep, string endereco,
            string bairro, string telefone, string celular, string email, string numeroend, string cidade, string estado)
        {
            this.CliCod = cod;
            this.CliNome = nome;
            this.CliCpfCnpj = cpfcnpj;
            this.CliRgIe = rgie;
            this.CliRSocial = rsocial;
            this.CliTipo = tipo; //clitipo -> PF pessoa fisica, PJ -> pessoa juridica
            this.CliCep = cep;
            this.CliEndereco = endereco;
            this.CliBairro = bairro;
            this.CliTelefone = telefone;
            this.CliCelular = celular;
            this.CliEmail = email;
            this.CliNumeroEnd = numeroend;
            this.CliCidade = cidade;
            this.CliEstado = estado;
            this.CliFoto = cli_foto; //foto
        }


        //Propridades

            //foto
        private byte[] _cli_foto;
        public byte[] CliFoto
        {
            get { return this._cli_foto; }
            set { this._cli_foto = value; }
        }

        public void CarregaImagem(String imgCaminho)
        {
            try
            {
                if (string.IsNullOrEmpty(imgCaminho))
                    return;
                //fornece propriedades e métodos de instância para criar, copiar,
                //excluir, mover, e abrir arquivos, e ajuda na criação de objetos FileStream.

                FileInfo arqImagem = new FileInfo(imgCaminho);

                //Expõe um Stream ao redor de um arquivo de suporte
                //sincrono e assíncrono operações de leitura e gravar.

                FileStream fs = new FileStream(imgCaminho, FileMode.Open, FileAccess.Read, FileShare.Read);

                //Aloca memória para o vetor.

                this.CliFoto = new byte[Convert.ToInt32(arqImagem.Length)];

                //Lê um bloco de bytes do fluxo e grava os dados em um buffer fornecido.

                int iBytesRead = fs.Read(this.CliFoto, 0, Convert.ToInt32(arqImagem.Length));
                fs.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
        //foto fim


        private int cli_cod;

        public int CliCod
        {
            get { return this.cli_cod; }
            set { this.cli_cod = value; }
        }
        private string cli_nome;

        public string CliNome
        {
            get { return this.cli_nome; }
            set { this.cli_nome = value; }
        }

        private string cli_cpfcnpj;

        public string CliCpfCnpj
        {
            get { return this.cli_cpfcnpj; }
            set { this.cli_cpfcnpj = value; }
        }

        private string cli_rgie;

        public string CliRgIe
        {
            get { return this.cli_rgie; }
            set { this.cli_rgie = value; }
        }

        private string cli_rsocial;

        public string CliRSocial
        {
            get { return this.cli_rsocial; }
            set { this.cli_rsocial = value; }
        }

        private string cli_tipo;

        public string CliTipo
        {
            get { return this.cli_tipo; }
            set { this.cli_tipo = value; }
        }

        private string cli_cep;

        public string CliCep
        {
            get { return this.cli_cep; }
            set { this.cli_cep = value; }
        }

        private string cli_endereco;

        public string CliEndereco
        {
            get { return this.cli_endereco; }
            set { this.cli_endereco = value; }
        }

        private string cli_bairro;

        public string CliBairro
        {
            get { return this.cli_bairro; }
            set { this.cli_bairro = value; }
        }

        private string cli_telefone;

        public string CliTelefone
        {
            get { return this.cli_telefone; }
            set { this.cli_telefone = value; }
        }

        private string cli_celular;

        public string CliCelular
        {
            get { return this.cli_celular; }
            set { this.cli_celular = value; }
        }

        private string cli_email;

        public string CliEmail
        {
            get { return this.cli_email; }
            set { this.cli_email = value; }
        }

        private string cli_numeroend;

        public string CliNumeroEnd
        {
            get { return this.cli_numeroend; }
            set { this.cli_numeroend = value; }
        }

        private string cli_cidade;

        public string CliCidade
        {
            get { return this.cli_cidade; }
            set { this.cli_cidade = value; }
        }

        private string cli_estado;

        public string CliEstado
        {
            get { return this.cli_estado; }
            set { this.cli_estado = value; }
        }
    }
}
