namespace RochaBank
{
    public static class Menus
    {
        public static void MainMenu()
        {
            Console.WriteLine("CHOSE AN OPTION - PUT A NUMBER");
            Console.WriteLine();
            Console.WriteLine("1- I am client");
            Console.WriteLine("2- I am bank manager");
            Console.WriteLine("3- Exit");
        }

        public static void ClientMenu()
        {
            Console.WriteLine("YOU ARE WELCOME!!");
            Console.WriteLine("CHOSE AN OPTION - PUT A NUMBER");
            Console.WriteLine();
            Console.WriteLine("1- See bank balance");
            Console.WriteLine("2- Withdraw money");
            Console.WriteLine("3- Deposit");
            Console.WriteLine("4- Exit");
        }
    }

}
}