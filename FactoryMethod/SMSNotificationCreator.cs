public class SMShNotificationCreator : NotificationCreator
{
    public override INotification CreatNotification()
    {
        return new SMSNotification();
    }
}