namespace DesignPatterns.Structural.Facade._1;

public class HomeTheaterFacade
{
    private readonly Amplifier _amplifier = new();
    private readonly DvdPlayer _dvdPlayer = new();
    private readonly Projector _projector = new();
    private readonly Lights _lights = new();
    private readonly Screen _screen = new();
    private readonly SoundSystem _soundSystem = new();

    public void WatchMovie(string movie)
    {
        Console.WriteLine("\n we are preparing to watch a movie...");
        _lights.Dim(10);
        _screen.Down();
        _projector.On();
        _projector.WideScreenMode();
        _amplifier.On();
        _amplifier.SetVolume(5);
        _soundSystem.On();
        _soundSystem.SetSurroundSound();
        _dvdPlayer.On();
        _dvdPlayer.Play(movie);
        Console.WriteLine("\n Enjoy the movie!");
    }

    public void EndMovie()
    {
        Console.WriteLine("\n Stopping the home theater...");
        _dvdPlayer.Stop();
        _dvdPlayer.Off();
        _soundSystem.Off();
        _amplifier.Off();
        _projector.Off();
        _screen.Up();
        _lights.On();
        Console.WriteLine("\n Thank you for using the home theater!");
    }
}