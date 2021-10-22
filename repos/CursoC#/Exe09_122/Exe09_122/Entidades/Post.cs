using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe09_122.Entidades
{
    public class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        
        
        
        public List<Comment> Comments { get; set; }  = new List<Comment>();

        public Post() { }

        public Post(DateTime momento, string titulo, string conteudo, int gostas)
        {
            Moment = momento;
            Title = titulo;
            Content = conteudo;
            Likes = gostas;
        }


        public override string ToString()
        {
            /*
            string saida;
            
            saida = Title + "\n" + Likes + " Likes - " + Moment + "\n" + Content + " \nComments:\n";

            foreach (Comment x in Comments)
            {
                saida = saida + x.Text + "\n";
            }

            return saida;
            */

            StringBuilder sb = new StringBuilder();

            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString());
            sb.AppendLine(Content);
            sb.AppendLine("Comments:");

            foreach (Comment x in Comments)
            {
                sb.AppendLine(x.Text);
            }

            return sb.ToString();

        }

        public void insereComentario(Comment comment)
        {
           Comments.Add(comment);
        }


    }
}
