using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyNumbersProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string playAgain;

            do
            {
                int userStart;
                int userEnd;
                Console.WriteLine("For this activity you will be choosing a range of numbers. \nPlease enter a whole number to serve as the STARTING number in your chosen range.");
                userStart = int.Parse(Console.ReadLine());
                Console.WriteLine("Thank you. Please enter a whole number to serve as the ENDING number in your chosen range.");
                userEnd = int.Parse(Console.ReadLine());
                Console.WriteLine("Six numbers in the range you specified will be chosen as 'LUCKY NUMBERS!' \nYou just might get lucky and win up to $13,000,000!");

                int[] userChoices = new int[6];

                for (int i = 0; i < userChoices.Length; i++)
                {
                    Console.WriteLine("Please enter a whole number in your chosen range.");
                    userChoices[i] = int.Parse(Console.ReadLine());

                    while (userChoices[i] < userStart || userChoices[i] > userEnd)
                    {
                        Console.WriteLine("Wrong. Enter a whole number in your chosen range.");
                        userChoices[i] = int.Parse(Console.ReadLine());
                    }
                }

                int[] randomPick = new int[6];
                Random winningNumbers = new Random();

                for (int j = 0; j < userChoices.Length; j++)
                {
                    randomPick[j] = winningNumbers.Next(userStart, userEnd);
                    Console.WriteLine("Lucky Number: " + randomPick[j]);
                }

                int numbersMatching = 0;
                for (int k = 0; k < userChoices.Length; k++)
                {
                    for (int l = 0; l < randomPick.Length; l++)
                    {
                        if (userChoices[k] == randomPick[l])
                        {
                            numbersMatching++;
                        }
                    }
                }

                Console.WriteLine("You've got " + numbersMatching + " matches!");

                double sum = numbersMatching * .16666667;
                double totalWinnings = sum * 13000000;

                Console.WriteLine("Your winnings are $" + totalWinnings + "!");

                Console.WriteLine("Would you like to play Lucky Numbers again? (YES/NO)");
                playAgain  =Console.ReadLine().ToUpper();
            }
            while (playAgain.ToUpper() == "YES");
            Console.WriteLine("Thanks for playing!");
       
            }
    }
}










