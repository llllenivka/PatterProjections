public class EmailNotificationCreator : NotificationCreator
{
    public override INotification CreatNotification()
    {
        return new EmailNotification();
    }
}