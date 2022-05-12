using System;
using System.Linq;

namespace Code
{
    class Game
    {
        public int comparingRoll(int[] testArray)
        {
            int amountDup;
            amountDup = testArray.Length - testArray.Distinct().Count();
            Console.WriteLine("The amount of duplicates are "+ amountDup);
            amountDup = amountDup + 1;
            scoring(amountDup);
            return amountDup;
        }

        public void reRoll()
        {
            Die dieObj = new Die();

            int[] arrayValues = new int[3];
            arrayValues = dieObj.reRollDie();
            foreach(int i in arrayValues)
            {
               Console.WriteLine(i);
            }
            comparingRoll(arrayValues);
        }

        public void scoring(int roll)
        {

            if (roll < 2 )
            {
                int score = 0;
                Console.WriteLine("Your score is " + score);
            }

            else if (roll == 2)
            {
                reRoll();
            }

            else 
            {
                int score = roll;
                if (score == 4)
                {
                    score = 6;
                    Console.WriteLine("Your score is " + score);
                }

                else if (score == 5)
                {
                    score = 12;
                    Console.WriteLine("Your score is " + score);                    
                }

                else
                {
                    Console.WriteLine("Your score is " + score);                        
                }
            }
        }
    }
}
