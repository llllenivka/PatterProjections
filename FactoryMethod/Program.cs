class Program
{
    static void Main()
    {
        bool exit = false;
        NotificationCreator creator;
        while(!exit)
        {
            Console.WriteLine("Отправить уведомление через:");
            Console.WriteLine("1 - Email");
            Console.WriteLine("2 - SMS");
            Console.WriteLine("3 - Push");
            Console.WriteLine("4 - Exit");

            string ? input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    // creator = new
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Incorrect input. Please, try again");
                    break;
            }
        }
        
        
        
    }
}
