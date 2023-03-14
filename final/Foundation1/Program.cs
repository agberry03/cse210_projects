using System;

class Program
{
    static void Main(string[] args)
    {
        // Video list.
        List<Video> videos = new List<Video>();

        // Video 1 and comments. Add Video to videos.
        Video video1 = new Video("Videoname1", "Authorname1", 624);
        video1.AddComment("commenterName1-1", "comment1-1");
        video1.AddComment("commenterName1-2", "comment1-2");
        video1.AddComment("commenterName1-3", "comment1-3");
        video1.AddComment("commenterName1-4", "comment1-4");
        videos.Add(video1);

        // Video 2 and comments. Add Video to videos.
        Video video2 = new Video("Videoname2", "Authorname2", 2043);
        video2.AddComment("commenterName2-1", "comment2-1");
        video2.AddComment("commenterName2-2", "comment2-2");
        video2.AddComment("commenterName2-3", "comment2-3");
        videos.Add(video2);

        // Video 3 and comments. Add Video to videos.
        Video video3 = new Video("Videoname3", "Authorname3", 107);
        video3.AddComment("commenterName3-1", "comment3-1");
        video3.AddComment("commenterName3-2", "comment3-2");
        video3.AddComment("commenterName3-3", "comment3-3");
        video3.AddComment("commenterName3-4", "comment3-4");
        videos.Add(video3);

        // Video 4 and comments. Add Video to videos.
        Video video4 = new Video("Videoname4", "Authorname4", 1099);
        video4.AddComment("commenterName4-1", "comment4-1");
        video4.AddComment("commenterName4-2", "comment4-2");
        video4.AddComment("commenterName4-3", "comment4-3");
        videos.Add(video4);

        foreach (Video video in videos)
        {
            video.GetVideoDetails();
        }
    }
}