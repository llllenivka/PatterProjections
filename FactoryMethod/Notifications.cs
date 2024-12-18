public interface INotification
{
    public void Send();
}

public class EmailNotification : INotification
{
    public void Send()
    {
        Console.WriteLine("Отправка Email уведомлением...");
    }
}

public class SMSNotification : INotification
{
    public void Send()
    {
        Console.WriteLine("Отправка SMS уведомлением...");
    }
}

public class PushNotification : INotification
{
    public void Send()
    {
        Console.WriteLine("Отправка Push уведомлением...");
    }
}