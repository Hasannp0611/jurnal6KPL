// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

class SayaTubeUser
{
    private int id;
    private List<SayaTubeVideo> uploadedVideos;
    public string Username;

    public SayaTubeUser(string Username)
    { 
        this.Username = Username;
        Random random = new Random();
        id = random.Next(10000, 99999);
        uploadedVideos = new List<SayaTubeVideo>();
    }

    public int GetTotalVideoPlayCount()
    {
        if (uploadedVideos.Count != 0)
        {
            int total = 0;
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                total += uploadedVideos.ElementAt(i).GetPlayCount();
            }
            return total;
        }
        else
        {
            return 0;
        }
    }

    public void AddVideo(SayaTubeVideo video)
    {
        uploadedVideos.Add(video);
    }

    public void PrintAllVideoPlaycount()
    {
        Console.WriteLine($"Username: {Username}");
        for (int i = 0; i < uploadedVideos.Count; i++) {
            Console.WriteLine("Video " + (i+1) + " judul: " + uploadedVideos[i].getTitle());
        }
    }
}

class SayaTubeVideo
{ 
    private int videoId;
    private string title;
    private int playCount;

    public SayaTubeVideo(String title)
    { 
        Debug.Assert(title.Length <= 200, "Maaf judul video terlalu panjang");
        Debug.Assert(!string.IsNullOrEmpty(title));

        this.title = title;
        Random random = new Random();
        videoId = random.Next(10000, 99999);
        playCount = 0;
    }

    public void IncreasePlayCount(int tambahan)
    {
        playCount += tambahan;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("\n" + $"Video ID: {videoId}");
        Console.WriteLine($"Video Title: {title}");
        Console.WriteLine($"PlayCount Video: {playCount}");
    }

    public int GetPlayCount()
    { 
        return playCount;
    }

    public string getTitle()
    { 
        return title;
    }
}

class Program 
{
    static void Main(String[] args)
    { 
        SayaTubeUser user1 = new SayaTubeUser("Hasan");

        SayaTubeVideo video1 = new SayaTubeVideo("Review Film Kungfu Panda - Hasan");
        SayaTubeVideo video2 = new SayaTubeVideo("Review Film Kungfu Panda 2 - Hasan");
        SayaTubeVideo video3 = new SayaTubeVideo("Review Film Kungfu Panda 3 - Hasan");
        SayaTubeVideo video4 = new SayaTubeVideo("Review Film Avengers: EndGame - Hasan");
        SayaTubeVideo video5 = new SayaTubeVideo("Review Film Karate Kid - Hasan");
        SayaTubeVideo video6 = new SayaTubeVideo("Review Film Exhuma - Hasan");
        SayaTubeVideo video7 = new SayaTubeVideo("Review Film Parasite - Hasan");
        SayaTubeVideo video8 = new SayaTubeVideo("Review Film Penyalin Cahaya - Hasan");
        SayaTubeVideo video9 = new SayaTubeVideo("Review Film Man Of Steel - Hasan");
        SayaTubeVideo video10 = new SayaTubeVideo("Review Film The Batman - Hasan");

        user1.AddVideo(video1);
        user1.AddVideo(video2);
        user1.AddVideo(video3);
        user1.AddVideo(video4);
        user1.AddVideo(video5);
        user1.AddVideo(video6);
        user1.AddVideo(video7);
        user1.AddVideo(video8);
        user1.AddVideo(video9);
        user1.AddVideo(video10);

        user1.PrintAllVideoPlaycount();
        video4.PrintVideoDetails();
    }

}

