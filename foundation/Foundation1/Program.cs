using System;

class Program
{
    static void Main(string[] args){
        
        Video video = new Video("Funny Cats", "ThatDude", 300);

        Comment c1 = new Comment("user1", "jajjaja");
        Comment c2 = new Comment("user2", "The orange cat was crazy !!!");
        Comment c3 = new Comment("user3", "black cats are weird");
        Comment c4 = new Comment("user4", "keep it up :)");

        video.AddComment(c1);
        video.AddComment(c2);
        video.AddComment(c3);
        video.AddComment(c4);
        video.ShowAllComments();

    }
}