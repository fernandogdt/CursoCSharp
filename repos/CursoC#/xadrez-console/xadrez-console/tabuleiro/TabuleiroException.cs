using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    class TabuleiroException : AccessViolationException
    {

        public TabuleiroException(string msg) : base(msg)
        {

        }

    }
}
