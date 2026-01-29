using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_RJ
{
    // ARMAZENAMENTO DE DADOS DO USUÁRIO LOGADO NA SESSÃO
    public static class SessaoUsuario
    {
        public static int Id { get; set; } // CLASSE PÚBLICA, ESTÁTICA E COM PROPRIEDADE PEGAR E DEFINIR ==> GET ; SET;
        public static string Nome { get; set; }
        public static string Login { get; set; }
        public static string Email { get; set; }
        public static string NivelAcesso { get; set; }
        public static string FotoBase64 { get; set; }
    }
}
