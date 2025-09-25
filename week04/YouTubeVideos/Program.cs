using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("", "", 0);
        video1.NewComment("", "");
        video1.NewComment("", "");
        video1.NewComment("", "");
        video1.NewComment("", "");

        Video video2 = new Video("", "", 0);
        video2.NewComment("", "");
        video2.NewComment("", "");
        video2.NewComment("", "");
        video2.NewComment("", "");

        Video video3 = new Video("", "", 0);
        video3.NewComment("", "");
        video3.NewComment("", "");
        video3.NewComment("", "");
        video3.NewComment("", "");

        Video video4 = new Video("", "", 0);
        video4.NewComment("", "");
        video4.NewComment("", "");
        video4.NewComment("", "");
        video4.NewComment("", "");
    }
}