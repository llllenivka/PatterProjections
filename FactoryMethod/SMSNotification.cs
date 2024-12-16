public class SMSNotification : INotification
{
    public void Send()
    {
        Console.WriteLine("Отправка SMS уведомлением...");
    }
}