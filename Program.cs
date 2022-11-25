namespace RochaBank
{
    class program
    {
        static void Main(string[] args)
        {
            Menus.MainMenu();
            int option = 1;
            while (option < 3 && option >= 0)
            {
                option = int.Parse(Console.ReadLine());
                Console.Clear();


                switch (option)
                {
                    case 1:
                        Menus.ClientMenu();
                        break;

                    case 2:
                        Menus.ManagerMenu();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("BYE, SEE YOU SOON!");
                        break;

                    default:
                        Console.WriteLine("Invalid option. enter a number from 1 to 3");
                        option = 0;
                        break;
                }
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            }
        }
    }
}