namespace InterfaceExercise;

public class DvdPlayer : IMediaPlayer
{
    public void Play()
    {
        Console.WriteLine("Playing DVD");
    }

    public void Stop()
    {
        Console.WriteLine("Stopping DVD");
    }
}
