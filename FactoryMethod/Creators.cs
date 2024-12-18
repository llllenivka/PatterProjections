public abstract class NotificationCreator
{
    public abstract INotification CreatNotification();
}

public class EmailNotificationCreator : NotificationCreator
{
    public override INotification CreatNotification()
    {
        return new EmailNotification();
    }
}

public class SMShNotificationCreator : NotificationCreator
{
    public override INotification CreatNotification()
    {
        return new SMSNotification();
    }
}

public class PushNotificationCreator : NotificationCreator
{
    public override INotification CreatNotification()
    {
        return new PushNotification();
    }
}
