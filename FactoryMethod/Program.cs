class Program
{
    static void Main()
    {
        NotificationCreator ? creator = null;
        NewNotification(ref creator);
        if(creator != null) {
            INotification notification = creator.CreatNotification();
            notification.Send();
        }
    }

    static void NewNotification(ref NotificationCreator ? creator)
    {    
        bool exit = false;
        while(!exit)
        {
            exit = true;

            Console.WriteLine("Отправить уведомление через:");
            Console.WriteLine("1 - Email");
            Console.WriteLine("2 - SMS");
            Console.WriteLine("3 - Push");

            string ? input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    creator = new EmailNotificationCreator();
                    break;
                case "2":
                    creator = new SMShNotificationCreator();
                    break;
                case "3":
                    creator = new PushNotificationCreator();
                    break;
                default:
                    Console.WriteLine("Incorrect input. Please, try again");
                    exit = false;
                    break;
            }
        }

    }
}
