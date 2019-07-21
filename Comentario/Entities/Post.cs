using System;
using System.Collections.Generic;


namespace Comentario.Entities {
    class Post {
        public DateTime Momment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post() {
        }

        public Post(DateTime momment,string title,string content,int likes) {
            Momment = momment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void addComment(Comment comment) {
            Comments.Add(comment);
        }
        public void removeComent(Comment comment) {
            Comments.Remove(comment);
        }

        public override string ToString() {
            return Title + "\n" +
                   Likes + " Likes - " + Momment.ToString("DD/MM/YYYY HH:MM:SS") + "\n" +
                   Content + "\n" +
                   "Comments:\n";
                   //foreach(Comment obj in Comments)

        }
    }
}
