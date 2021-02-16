namespace DesignPatterns.ChainOfResponsibility
{
    public class HttpRequest
    {
        public string Password { get; }
        public string Username { get; }

        public HttpRequest(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}