using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DadosDaConexao
    {

        // Data Source=DESKTOP-E9A5U1H\SQLEXPRESS;Initial Catalog=ControleDeEstoque2;Integrated Security=True 26 ultima maquina
        // Data Source=ALUNO\SQLEXPRESS;Initial Catalog=ControleDeEstoque2;Integrated Security=True / Laboratorio 21 ultima maquina
        // Data Source=DESKTOP-88MR9P2\sa;Initial Catalog=ControleDeEstoque2;Integrated Security=True /Laboratorio 23 penultima maquina
        // Data Source=DESKTOP-E9A5U1H\SQLEXPRESS;Initial Catalog=ControleDeEstoque2;Integrated Security=True /Laboratorio 25 ultima maquina

        public static String servidor = @"LAPTOP-EK32SKAI\SQLEXPRESS"; // altere o nome servidor para o que você etiver utilizando
        public static String banco = "controledeestoque2"; // coloque o nome do seu banco de dados
        public static String usuario = ""; // se houver login prencha o usuário, se não deixe como está
        public static String senha = ""; // caso houver senha coloque sua senha, se não pode deixar como está
        public static String StringDeConexao
        {
            get
            {
                // Para alterar o banco é nescessario alterar os parametros do return: para eu nao esquecer
                // EXEMPLO DE COMO DEVE FICAR 
                 return @"Data Source= LAPTOP-EK32SKAI\SQLEXPRESS; Initial Catalog= controledeestoque2;Integrated Security=True";

                //Essa conexão é para acesso ao banco de dados através de usiario do Windows que não é necessário senha
                // Caso seu banco de dados utilizar Login e Senha Comentar este código

               // return @"Data Source=" + servidor + "; Initial Catalog=" + banco + ";Integrated Security=True";

                // Essa conexão é para acesso ao banco de dados com Login e Senha
                // Caso utilize desse tipo de acesso retirar o comentário do código e prencha os campos servidor, banco, usuario e senha.

                //return @"Data Source=" + servidor + "; Initial Catalog=" + banco + "; User ID =" + usuario + "; Password=" + senha;

            }
        }
    }
}
