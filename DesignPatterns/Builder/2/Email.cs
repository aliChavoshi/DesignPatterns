namespace DesignPatterns.Builder._2;

public class Email
{
    public string To { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
    public List<string> Attachments { get; set; } = new();

    public void Send() =>
        Console.WriteLine($"📧 ایمیل به {To} با موضوع '{Subject}' ارسال شد");
}