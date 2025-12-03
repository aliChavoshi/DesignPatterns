namespace DesignPatterns.Creational.Builder._2;

public class EmailBuilder : IEmailBuilder
{
    private readonly Email _email = new();

    public IEmailBuilder SetTo(string to)
    {
        _email.To = to;
        return this;
    }

    public IEmailBuilder SetSubject(string subject)
    {
        _email.Subject = subject;
        return this;
    }

    public IEmailBuilder SetBody(string body)
    {
        _email.Body = body;
        return this;
    }

    public IEmailBuilder SetAttachments(string attachment)
    {
        _email.Attachments.Add(attachment);
        return this;
    }

    public Email Build()
    {
        return _email;
    }
}