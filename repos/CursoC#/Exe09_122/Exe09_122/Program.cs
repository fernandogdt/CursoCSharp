using Exe09_122.Entidades;
using System;

namespace Exe09_122
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2018, 6, 21, 13, 5, 44);

            Post post1 = new Post(d, "Traveling to New Zealand", "I'm going to visit this wonderful country!", 12);

            Comment c1 = new Comment("Have a nice trip");
            post1.insereComentario(c1);
            c1 = new Comment("Wow that's awesome!");
            post1.insereComentario(c1);

            Console.WriteLine(post1);
            /*-----------------------*/

            

            d = DateTime.Parse("28/07/2018 23:14:19");

            post1 = new Post(d, "Good night guys", "See you tomorrow", 5);
            
            c1 = new Comment("Good night");
            post1.insereComentario(c1);
            c1 = new Comment("May the Force be with you");
            post1.insereComentario(c1);

            Console.WriteLine(post1);
        }
    }
}
