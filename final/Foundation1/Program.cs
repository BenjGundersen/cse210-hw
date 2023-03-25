using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video("How to avoid tax fraud", "Yoshi", 42);
        Comment c1 = new Comment("didnt work 0/10", "mairo");
        Comment c2 = new Comment("worked for me", "dragon dude");
        Comment c3 = new Comment("i had mixed results, not in jail but police are looking for me", "cool guy");
        v1.AddComment(c1);
        v1.AddComment(c2);
        v1.AddComment(c3);
        videos.Add(v1);
        
        Video v2 = new Video("top 6 epic moments of all time", "mairo", 60);
        Comment c4 = new Comment("cant belive you didnt mention your failed tax fraud", "yoshi");
        Comment c5 = new Comment("i agree with this list", "yeah man");
        Comment c6 = new Comment("i disagree with number 4. the leaning tower of pisa never fell", "some italian dude");
        v2.AddComment(c4);
        v2.AddComment(c5);
        v2.AddComment(c6);
        videos.Add(v2);

        Video v3 = new Video("epic rap battle of history - darth vader VS kanye west", "ERB (fake)", 34);
        Comment c7 = new Comment("that was so good", "mairo");
        Comment c8 = new Comment("my favorite video", "dragon dude");
        Comment c9 = new Comment("burger king should have won", "cool guy");
        v3.AddComment(c7);
        v3.AddComment(c8);
        v3.AddComment(c9);
        videos.Add(v3);

        Video v4 = new Video("How to pay taxes", "mario", 21);
        Comment c10 = new Comment("didnt work 0/10", "yoshi");
        Comment c11 = new Comment("worked for me", "dragon dude");
        Comment c12 = new Comment("those websites look like a scam", "cool guy");
        v4.AddComment(c10);
        v4.AddComment(c11);
        v4.AddComment(c12);
        videos.Add(v4);
        

        foreach (Video video in videos)
        {
            video.GetVideo();
            Console.WriteLine("");
        }
    }
}