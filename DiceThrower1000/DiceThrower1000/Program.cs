using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceThrower1000
{
    class Program
    {
        static void Main(string[] args)
        {
            //call the function ThrowDice
           // ThrowDice("10d6");
            
           // ThrowDice("3d20");

            ThrowDice("100d6");

            //keep console open
            Console.ReadKey();

        }

        //create a function ThrowDice that gives a random roll 
        static void ThrowDice(string diceString) 
        {
            //declare a variable to hold the value of the random roll
            int results = 0;
            //print to console the intial input
            Console.WriteLine("Throwing: " + diceString);
            //take our input split it by 'd', and store the values 
            //into a string array
            string[] inputNum = diceString.Split('d');
            //convert the stored values into integer by using int.Parse
            //and storing those values into new integer variables
            int rolls = int.Parse(inputNum[0]);
            int diceSides = int.Parse(inputNum[1]);
            //call the Random constructor and create a new Random generator
            Random randomnumbergenerator = new Random();
            
            //print to console Results
            Console.Write("Results: ");

            //create a for loop that loops through the rpg and gives the number of rolls
            for (int i = 0; i < rolls; i++)
            {
                //store every roll into the randomNuber variable
                int randomNumber = randomnumbergenerator.Next(1, diceSides + 1);
                //print to the console every random roll generated.
               Console.Write(randomNumber + " ");
            }

            

        }

    }
}
