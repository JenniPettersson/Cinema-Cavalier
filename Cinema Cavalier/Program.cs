using System;

namespace Cinema_Cavalier
{
    class Program
    {
        static void Main(string[] args)
        {
            //I want the menu to come back in the console after every choice until the user actively chooses the exit the menu by choosing 0
            do
            {

                ShowMainMenu();

            } while (true);

            static void ShowMainMenu()

            {
                string userChoice;
                Console.WriteLine("Hello! This is the main menu.");
                Console.WriteLine("1. Check movie ticket prices depending on moviegoer's age");
                Console.WriteLine("2. Purchase movie tickets");
                Console.WriteLine("3. Have something repeated 10 times");
                Console.WriteLine("4. Write a sentence with at least three words and get the third word back");
                Console.WriteLine("0. Quit meny");
                userChoice = Console.ReadLine();

                //Depending on user choice, the switch is telling the program what to do next

                switch (userChoice)
                {
                    case "0":

                        Environment.Exit(0);
                        break;

                    case "1":

                        InformationTicketPrice();
                        break;

                    case "2":

                        ComputeTicketPrices();
                        break;

                    case "3":

                        RepeatTenTimes();
                        break;

                    case "4":

                        ThirdWordInASentenceBack();
                        break;

                    default:

                        Console.WriteLine("Wrong input");
                        break;

                }

            }

        }

        private static void RepeatTenTimes()
        {

            //This method repeats the input from the user 10 times back to the user. Needs validating input and error messages to user

            string userInput;

            Console.WriteLine("Write something that will be repeated ten times:");
            userInput = Console.ReadLine();
            for (int i = 0; i < 11; i++)
            {
                Console.Write($"{userInput} ");
            }

            Console.WriteLine();

        }

        private static void ThirdWordInASentenceBack()
        {

            //The user enters a sentence that is at least three words long. Needs error handling if sentence is two words or shorter. Perhaps also handling certain forbidden characters if there are any?

            string userSentence;

            Console.WriteLine("Please enter a sentence that is at least three words long:");
            userSentence = Console.ReadLine();
            string [] Sentence = userSentence.Split(" ");
            Console.WriteLine($"The third word is " + Sentence[2]);
           
            
        }

        private static void ComputeTicketPrices()
        {
            //Method to present a total sum to pay for the user's movie tickets, depending on visitor ages. Perhaps lowering max amount of tickets per purchase. Needs a payment solution. ;)

            string input;
            int tickets;
            int yearsOld;
            int ticketSum = 0;

            Console.WriteLine("How many tickets would you like to purchase?");
            input = Console.ReadLine();
            int.TryParse(input, out tickets);

            if (tickets > 20)
            {

                Console.WriteLine("Max amount of tickets is 20.  How many tickets would you like to purchase?");
                input = Console.ReadLine();
                int.TryParse(input, out tickets);

            }


            for (int i = 0; i < tickets; i++)
                {

                Console.WriteLine("How old is moviegoer?");
                input = Console.ReadLine();
                int.TryParse(input, out yearsOld);


               if (yearsOld < 5 && yearsOld > 0)
                {

                    ticketSum += 0;

                }

                else if (yearsOld < 20 && yearsOld > 5)
                    {

                        ticketSum += 80;
                   
                    }

                else if (yearsOld > 64 && yearsOld < 100)
                    {

                        ticketSum += 90;

                    }



                else if (yearsOld > 100)
                {

                    ticketSum += 0;

                }

                else
                    {
                        ticketSum += 120;
                    }

                }

            Console.WriteLine($"\nNumber of tickets: " + tickets + "\n");
            Console.WriteLine($"Total sum to pay is " + ticketSum + " crowns\n");
        }

        private static void InformationTicketPrice()
        {

            //Information on ticket prices in regards to age of moviegoer. Annoying green squiggly. ticketPrice greyed out in if statements

            string input;
            int yearsOld;
            int ticketPrice;

            Console.WriteLine("Write age in numbers (years old):");
            input = Console.ReadLine();
            int.TryParse(input, out yearsOld);

            if (yearsOld < 20 && yearsOld > 5 )
            {
                ticketPrice = 80;
                Console.WriteLine("Movie ticket is 80 crowns for moviegoers age 5-17\n");
            
            }

            else if (yearsOld < 100 && yearsOld > 64)
            {
                ticketPrice = 90;
                Console.WriteLine("Movie ticket is 90 crowns for moviegoers age 65-100\n");
            }

            else if (yearsOld < 5 && yearsOld > 0)
            {
                ticketPrice = 0;
                Console.WriteLine("Movie ticket is free for children younger than 5 years of age\n");
            }

            else if (yearsOld > 100)
            {
                ticketPrice = 0;
                Console.WriteLine("Movie ticket is free for moviegoers older than 100 years\n");
            }


            else
            {
                Console.WriteLine("Movie ticket for moviegoers age 18-64 is 120 crowns\n");
            }
        }
    }
}
