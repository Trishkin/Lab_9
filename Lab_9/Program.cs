using Lab_9.Models;
using System;

namespace Lab_9
{
    class Program
    {

        static void Main(string[] args)
        {
            Game You = new Game("Charly", 100, 25, 15);
            You.Notify += DisplayMessage;
            Game Enemy1 = new Game("Zombi", 50, 10, 5);
            Game Enemy2 = new Game("Sceleton", 30, 15, 0);
            Enemy1.Status();
            You.Hit(Enemy1);
            Enemy1.Status();
            Console.WriteLine("_______________________________");
            Enemy2.Status();
            You.Healing(Enemy2);
            Enemy2.Status();

            Console.WriteLine("_______________________________");
            StringsMethods methods = new StringsMethods();
            string MyString = "Привет мой маленький мир столь большой вселенной";
            Console.WriteLine(MyString);

            Action<string> register = methods.RegisterToUpper;
            register(MyString);
            register = methods.RegisterToLower;
            register(MyString);

            Func<string, string, string, string> retFunc = methods.ChangeString;
            Console.WriteLine(retFunc(MyString, "е",""));

            Func<string, string, int, string> retFunc2 = methods.InsertString;
            Console.WriteLine(retFunc2(MyString, "Ну привет тебЕ", 9));
        }

        private static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
