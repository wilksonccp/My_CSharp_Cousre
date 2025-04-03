namespace InterfaceExercise;

public class VideoPlayer : IMediaPlayer
{
    public void Play()
    {
        Console.WriteLine("Playing Video");
    }

    public void Stop()
    {
        Console.WriteLine("Stopping Video");
    }
}
