// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using System.Diagnostics.Contracts;

public class SayaTubeUser
{
    int id;
    string username;

}

public class SayaTubeVideo
{
    int id;
    string title;
    int playCount;
    
    public SayaTubeVideo(string t)
    {
        this.title = t;
        Random x = new Random();
        id = x.Next(10000,99999);
        this.playCount= 0;
        Debug.Assert(t.Length < 100 && t != null);
    }

    public void IncreasePlayCount(int count)
    {
        Debug.Assert(count < 10000000);
        try
        {
            checked { this.playCount += count; }
        }
        catch(OverflowException error)
        {
            Console.WriteLine(error.Message);
        }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("Id        : " + this.id); 
        Console.WriteLine("Title     : " + this.title );
        Console.WriteLine("PlayCount : " + this.playCount);
    }

}
