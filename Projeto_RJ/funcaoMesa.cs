using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_RJ
{
    public class funcaoMesa 
    {
        public static string Servico { get; set; } = SessaoUsuario.tipoAtendimento; // Obtém o tipo de atendimento do usuário
        public static string TipoAtendimento { get; set; } = SessaoUsuario.servico; // Obtém o servico do usuário
    }
}
