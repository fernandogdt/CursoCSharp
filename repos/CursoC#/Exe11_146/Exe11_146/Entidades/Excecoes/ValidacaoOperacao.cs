using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe11_146.Entidades.Excecoes
{
    public class ValidacaoOperacao : ApplicationException
    {
        public ValidacaoOperacao(string mensagem) : base(mensagem)
        {

        }



    }
}
