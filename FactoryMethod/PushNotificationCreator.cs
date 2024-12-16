public class PushNotificationCreator : NotificationCreator
{
    public override INotification CreatNotification()
    {
        return new PushNotification();
    }
}