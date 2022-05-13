using System;
using System.Collections.Generic;
using System.Threading;

namespace ProblematicProblem
{
    public class Program
    {
        Random rng;
        static bool cont = true;
        static List<string> activities = new List<string>()
        { "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };
        static void Main(string[] args)
        {


            //    bool cont = true;
            //    List<string> activities = new List<string>()
            //{ "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };

            Console.Write("Hello, welcome to the random activity generator! \nWould you like to generate a random activity? yes/no: ");
            //bool cont = bool.Parse(Console.ReadLine());

            if (Console.ReadLine().ToLower() == "yes")
            {
                cont = true;
            }

            else
            {
                return;
            }
            Console.WriteLine();
            Console.Write("We are going to need your information first! What is your name? ");
            string userName = Console.ReadLine();
            Console.WriteLine();
            Console.Write("What is your age? ");
            int userAge = int.Parse(Console.ReadLine());



            Console.WriteLine();
            Console.Write("Would you like to see the current list of activities? Sure/No thanks: ");
            //bool seeList = bool.Parse(Console.ReadLine());

            if (Console.ReadLine() == "Sure")
            {
                foreach (string activity in activities)
                {
                    Console.Write($"{activity} ");
                    Thread.Sleep(250);
                }
                Console.WriteLine();
                Console.Write("Would you like to add any activities before we generate one? yes/no: ");
                // bool addToList = bool.Parse(Console.ReadLine());
                Console.WriteLine();
                while (Console.ReadLine().ToLower() == "yes")
                {
                    Console.Write("What would you like to add? ");
                    string userAddition = Console.ReadLine();
                    activities.Add(userAddition);
                    foreach (string activity in activities)
                    {
                        Console.Write($"{activity} ");
                        Thread.Sleep(250);
                    }

                    Console.WriteLine();
                    Console.WriteLine("Would you like to add more? yes/no: ");


                }
            }
            else
            {
                return;
            }

            while (cont)
            {
                Console.Write("Connecting to the database");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(200);
                }
                Console.WriteLine();
                Console.Write("Choosing your random activity");
                for (int i = 0; i < 9; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(200);
                }
                var rng = new Random();
                Console.WriteLine();
                int randomNumber = rng.Next(activities.Count);
                string randomActivity = activities[randomNumber - 1];
                if (userAge < 21 && randomActivity == "Wine Tasting")
                {

                    Console.WriteLine($"Oh no! Looks like you are too young to do Wine Tasting");
                    Console.WriteLine("Pick something else!");
                    activities.Remove("Wine Tasting");
                    randomNumber = (activities.Count);
                    randomActivity = activities[randomNumber];
                }
                Console.Write($"Ah got it! {userName}, your random activity is: {randomActivity}! Is this ok or do you want to grab another activity? Keep/Redo: ");
                if (Console.ReadLine() == "Redo")

                {
                    randomNumber = (activities.Count);
                    randomActivity = activities[randomNumber - 1];
                }
                else
                {
                    return;
                }
            }
        }
    }
}