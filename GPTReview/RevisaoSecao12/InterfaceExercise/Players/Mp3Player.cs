namespace InterfaceExercise;

public class Mp3Player : IMediaPlayer
{
    public void Play()
    {
        Console.WriteLine("Playing MP3");
    }

    public void Stop()
    {
        Console.WriteLine("Stopping MP3");
    }
}

