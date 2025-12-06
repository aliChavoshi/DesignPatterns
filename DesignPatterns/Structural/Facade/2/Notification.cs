namespace DesignPatterns.Structural.Facade._2;

public class Notification
{
    public void SendConfirmation(string email)
    {
        Console.WriteLine($"send confirmation email to {email}");
    }
}