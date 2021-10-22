using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe09_122.Entidades
{
    public class Comment
    {

        public String Text { get; set; }

        public Comment()
        {
        }

        public Comment(string texto)
        {
            Text = texto;
        }
    }
}
