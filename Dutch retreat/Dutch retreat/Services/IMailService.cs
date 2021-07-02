namespace dutch_retreat.Services
{
    public interface IMailService
    {
        void SendMessage(string To , string Subject , string Body );
    }
}