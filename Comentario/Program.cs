using System;
using Comentario.Entities;

namespace Comentario {
    class Program {
        static void Main(string[] args) {
            DateTime d1 = DateTime.Parse("21/06/2018 13:05:44");
            string t1 = "Travelling to New Zealand";
            string c1 = "I'm going to visit this wonderful country!";
            int l1 = 12;
            Post p1 = new Post(d1, t1, c1, l1);

            Comment com1 = new Comment("Have a nice trip");
            Comment com2 = new Comment("Wow that's awesome!");
            p1.addComment(com1);
            p1.addComment(com2);

            DateTime d2 = DateTime.Parse("28/07/2018 23:14:19");
            string t2 = "Good night guys";
            string c2 = "See you tomorrow";
            int l2 = 5;
            Post p2 = new Post(d2, t2, c2, l2);

            Comment com3 = new Comment("Good night");
            Comment com4 = new Comment("May the Force be with you");
            p2.addComment(com3);
            p2.addComment(com4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
