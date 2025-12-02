namespace DesignPatterns.Builder._2;

public interface IEmailBuilder
{
    IEmailBuilder SetTo(string to);

    IEmailBuilder SetSubject(string subject);

    IEmailBuilder SetBody(string body);

    IEmailBuilder SetAttachments(string attachment);

    Email Build();
}