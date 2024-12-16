public class EmailNotification : INotification
{
    public void Send()
    {
        Console.WriteLine("Отправка Email уведомлением...");
    }
}