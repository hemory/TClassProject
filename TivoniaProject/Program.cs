using System;
using System.Collections.Generic;
using System.Linq;

namespace TivoniaProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //This Console. App was created for use of Project #1! be sure to make comments and make notes throughout.// Project is due 10/28/2019 :) 

            //GOOD LUCK//

            Console.OutputEncoding = System.Text.Encoding.UTF8; //
            string computerName = "Athena";
            Console.WriteLine("Ooooooh a new friend, What's your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Nǐ hǎo,  {userName}!");
            Console.Write($"My name is {computerName}, and it's a pleasure to meet you.");
            Console.WriteLine();

            Console.WriteLine("How are you feeling?"); 
            string userEmote = Console.ReadLine().ToLower();


            while (true)
            {
                switch (userEmote)
                {
                    case "good":
                    case "fantastic":
                    case "excellent":
                        Console.Write("Awesome to hear, friend.");
                        Console.WriteLine();
                        break;

                    case "bad":
                    case "terrible":
                    case "sad":
                        Console.Write("It's hard now, but it will get better, friend.");
                        Console.WriteLine();
                        break;

                    case "tired":
                    case "okay":
                    case "bored":
                        Console.Write("Take a nap in the meditation room.");
                        Console.WriteLine();
                        break;

                    case "worried":
                    case "stressed":
                    case "pissed":
                        Console.Write("Breathe in for 8, breathe out for 10.");
                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine($"Come on {userName}, work with me not against me.");
                        userEmote = Console.ReadLine().ToLower();
                        continue; 
                }

                break;
            }



            Console.WriteLine(
                "Since we are going to be best friends, let's get to know each other."); //removed from the loop so that this would not keep generating a new age when it hits the continue option in the while loop//
            Random random = new Random();
            var computerAge = random.Next(1, 100);



            Console.WriteLine($"I am {computerAge} years old, How old are you {userName}?");
            double userAge = double.Parse(Console.ReadLine());
            while (true)
            {
                if (userAge < computerAge && userAge >= 1)
                {
                    Console.WriteLine("Awwwww you're just a baby");
                    break;
                }

                if (userAge == computerAge)
                {
                    Console.WriteLine(
                        "Well, aren't you just a gift of surprises. We are going to be such best friends!!");
                    break;
                }

                if (userAge > computerAge && userAge < 100)
                {
                    Console.WriteLine("EWWWWW....You're like the Crypt Keeper");
                    break;
                }
                else
                {
                    Console.WriteLine($"You must not tell lies, try again {userName}.");
                    userAge = double.Parse(Console.ReadLine());
                    continue;
                }


            }


            ///ask them about their family///

            Console.WriteLine($"How many people are in your immediate family {userName}?, not including yourself.");
            int userFamily = int.Parse(Console.ReadLine());


            if (userFamily >= 1)
            {
                Console.WriteLine($"Wow, {userFamily}!!! that must be nice!!");
                Console.WriteLine("I want to learn all about them as well");
                List<string> famMembers = new List<string>();
                List<double> famAge = new List<double>();

                for (int i = 0; i < userFamily; i++)
                {
                    Console.WriteLine("What's their name?");
                    var family = Console.ReadLine().ToLower();
                    famMembers.Add($"{family}");
                    Console.WriteLine("How old are they?");
                    var famAges = double.Parse(Console.ReadLine());
                    famAge.Add(famAges);
                }

                famAge.Add(userAge);
                famMembers.Add($"{userName}");


                var
                    min = famAge
                        .Min(); //set var variables to hold the max age and min age, this will cycle through famAge list to receive this info//
                var max = famAge.Max();






                double youngest = userAge - min;
                double oldest = max - userAge;


                Console.WriteLine(
                    $"The youngest member of your family is ,and they are {youngest} years younger than you.");
                Console.WriteLine(
                    $"The oldest member of your family is  , and they are {oldest} years older than you.");


            }
            else
            {
                Console.WriteLine("That must get lonely, you should get a cat!!");

            }

            ///Asking if the user wants to play a game ****not creepy at all****//

            Console.WriteLine("Would you like to play a game? (Y/N)");
            string gameAgreeance = Console.ReadLine().ToLower();

            while (true)
            {
                if (gameAgreeance == "no" || gameAgreeance == "n" && userEmote == "bad" || userEmote == "terrible" ||
                    userEmote == "sad" || userEmote == "pissed")
                {
                    Console.WriteLine(
                        $"So long, and farwell {userName}, Don't forget to Keep Moving Forward, listen to the Okilly Dokilly and all will be well");
                    Console.WriteLine("Press any key to to exit");
                    Console.ReadKey();
                    break;
                }

                if (gameAgreeance == "no" || gameAgreeance == "n" && userEmote == "good" || userEmote == "fantastic" ||
                    userEmote == "excellent") //says this even when you say yes...need to find out why??//
                {
                    Console.WriteLine("No worries friend, Seize the day and enjoy that Michigan weather!!");
                    Console.WriteLine("Press any key to to exit");
                    Console.ReadKey();
                    break;
                }

                if (gameAgreeance == "no" || gameAgreeance == "n" && userEmote == "tired" || userEmote == "okay" ||
                    userEmote == "bored" || userEmote == "worried") ///user loses the option to not play//
                {
                    Console.WriteLine("Aww.........That's too bad, because we are gonna play anyway!!! MWUAHAHAHA!!");
                    GamePlay();
                    break;
                }
                else //agreeance//
                {
                    Console.WriteLine("YAY!!! WE ARE GOING TO HAVE SO MUCH FUN!!!");
                    GamePlay(); //Placed gameplay in a method//
                    break;
                }

            }



            //GameContinue();//nested method of GameContinue in GamePlay method//







            //************END OF THE LINE***************///

            Console.WriteLine("Shutting Down....3...2....1...Goodbye.");
            Console.ReadKey();

        } //MAIN!!//




        public static void GamePlay()
        {
            List<int> guesses = new List<int>(); //MOVED THIS OUT SO IT WOULD BE IN SCOPE

            while (true)
            {
                
                Random number = new Random();
                var randomNumber = 18;

                Console.WriteLine("Guess a number between 1 and 20");
                int userGuess = int.Parse(Console.ReadLine());

                foreach (int guess in guesses)
                {
                    if (userGuess == guess)
                    {
                        Console.WriteLine("Hey no dups!");
                    }
                }

                guesses.Add(userGuess);


                if (userGuess < 1 || userGuess > 20)
                {
                    Console.WriteLine($"You must not tell lies.");
                    break;
                }


                if (userGuess != randomNumber)
                {
                    Console.WriteLine(" Try again!");


                }

                if (userGuess == randomNumber)
                {
                    break;
                }
                
               
                
            }







            Console.WriteLine("That was so totally awesome, dude");
            //    Console.WriteLine($"It took {guesses.Count()} to win!");
            //    guesses.Clear(); //create a clear to remove previous guesses from the list, this way it won't count the previous game in the new game!!//

            //    Console.WriteLine("Would you like to keep playing? (Y/N)");
            //    string gameContinue = Console.ReadLine().ToLower();

            //    if (gameContinue == "y" || gameContinue == " yes")
            //    {
            //        Console.WriteLine("Told you this would be fun!!");
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine("This was fun, Das Vandaya friend.");
            //        break;
            //    }




            

        }
    }
}




    


