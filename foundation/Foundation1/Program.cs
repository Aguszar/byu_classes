using System;

class Program
{
    static void Main(string[] args){
        
        Video video1 = new Video("Funny Cats", "ThatDude", 300);
        Comment c11 = new Comment("user1", "0:46 hahahaha");
        Comment c12 = new Comment("user2", "The orange cat was crazy !!!");
        Comment c13 = new Comment("user3", "black cats are weird");
        Comment c14 = new Comment("user4", "keep it up :)");

        video1.AddComment(c11);
        video1.AddComment(c12);
        video1.AddComment(c13);
        video1.AddComment(c14);
        video1.ShowAllComments();


        Video video2 = new Video("Funny falls", "gravityWins", 230);
        
        Comment c21 = new Comment("user1", "Congratulations on the 6 million");
        Comment c22 = new Comment("user2", "I'm watching these videos to overcome my fear nd anxiety");
        Comment c23 = new Comment("user3", "Girl : Don't hurt yourself, please\nGuy : Proceeds to hurt himself");
        Comment c24 = new Comment("user4", "The laughter at 2:36 is so fun");

        video1.AddComment(c21);
        video1.AddComment(c22);
        video1.AddComment(c23);
        video1.AddComment(c24);
        video1.ShowAllComments();


        Video video3 = new Video("meme compilations - part 4", "shrek is life", 430);
        Comment c31 = new Comment("user1", "no way those wood planks worked 4:33");
        Comment c32 = new Comment("user2", "The last one was the most confusing one");
        Comment c33 = new Comment("user3", "We got robots stopping criminals before GTA 6");
        Comment c34 = new Comment("user4", "That cake wasn't just firm it was stone solid");

        video1.AddComment(c31);
        video1.AddComment(c32);
        video1.AddComment(c33);
        video1.AddComment(c34);
        video1.ShowAllComments();



    }
}