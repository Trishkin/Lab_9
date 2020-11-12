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

        }

        private static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
