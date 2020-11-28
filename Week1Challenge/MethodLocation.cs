using System;
using System.Collections.Generic;
using System.Text;

namespace Week1Challenge
{
    class MethodLocation
    {

        public void NameChallenge()
        {
            string firstName = "Mike";
            string lastName = "Riley";
            Console.WriteLine("My first name is {0}, and my last name is {1} \n", firstName, lastName);

        }

        public void CarTitles()
        { 
            string[] carArray = { "porshe", "ferrari", "Lambo", "Tesla" };

            int l = carArray.Length-1;


            for (int i = 0; i <= l; i++)
            {
                Console.WriteLine("{0} ", carArray[i]);

            }

            Console.WriteLine("I love this car: " + carArray[1] + "\n");

        }

        public void TimeChallenge()
        {

            List<string> TimeList = new List<string>();

            TimeList.Add(DateTime.Now.ToString("h:mm:ss tt"));
            TimeList.Add("10:50:00 PM");
            TimeList.Add("12:50:00 PM");
            TimeList.Add("18:50:00 PM");


            TimeList.ForEach(Console.WriteLine);
        
        }

        public void AgeChallenge()

        {
            int age = 35;
            int addAge = 7;
            int newAge = addAge + age;

            Console.WriteLine("My age + 7 is: " + newAge + "\n");

        }
        public void AmountOfSleep(DateTime goToSleepTime, DateTime awakeTime)
        {
            TimeSpan sleepTime = awakeTime- goToSleepTime;
            double hoursASleep = sleepTime.TotalHours;

            Console.WriteLine("Total number of hours: {0}", hoursASleep);

            if (hoursASleep >= 10) {

                Console.WriteLine("Wow! That is a lot of sleep");

            } else if (hoursASleep < 10 || hoursASleep >= 8) {

                Console.WriteLine("You shoud be pretty rested");
            
            } else if (hoursASleep < 8 || hoursASleep >= 4) {
                
                Console.WriteLine("Bummer!");
            
            } else {
                
                Console.WriteLine("Oh man, get some sleep!!!!");
            
            }

        }

        public void HowHasYourDayBeen()
        {

            bool keepRunning = true;

            while (keepRunning)
            {
                Console.WriteLine("How has your day bee? \n" +
                    "1. Great \n" +
                    "2. Good \n" +
                    "3. OK \n" +
                    "4. Bad \n" +
                    "5. :( \n" +
                    "6. Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("I love Great Days!!!!!!");
                        break;
                    case "2":
                        Console.WriteLine("Good is Good");
                        break;
                    case "3":
                        Console.WriteLine("OK. Lets see how I can help make your day great");
                        break;
                    case "4":
                        Console.WriteLine("Bad is soooooo sad.");
                        break;
                    case "5":
                        Console.WriteLine("You need a hug!!!");
                        break;
                    case "6":
                        Console.WriteLine("Good Bye!!");
                        keepRunning = false; // breaks while loop
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;
                }
            }

            Console.WriteLine("Press any key to conitnue...");
            Console.ReadKey();
            Console.Clear();

        }

        public void PrintCharactersInAString()
        {



            Console.WriteLine("\n\nprint individual characters of string.\n");
            Console.WriteLine("------------------------------------------------------\n");
            Console.WriteLine("Input the string : ");
            string input = Console.ReadLine();


            char[] inputArray = input.ToCharArray();

            int length = inputArray.Length - 1;

            Console.WriteLine("This word has " + length + " letters.");

            // Print each letter
            for (int i = 0; i <= length; i++)
            {
                Console.WriteLine("{0} ", input[i]);

            }

            // find i and print i
            for (int r = 0; r <= length; r++)
            {

                if (input[r] == 'i') 
                {
                    
                    Console.WriteLine("i");
                
                } else {
                    
                    Console.WriteLine("Not an i");
                }

            }

            //Reverse Print
            Console.WriteLine("\n\n");

           for (int i = length; i >=0; i-- )
            {
                Console.WriteLine("{0}", input[i]);
            }

        }

        


    }
}
