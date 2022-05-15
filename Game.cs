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
            if (amountDup == 0)
            {
            Console.WriteLine("The amount of duplicates are "+ amountDup);                
            amountDup = amountDup + 1;
            return amountDup;
            }
            else
            {
            amountDup = amountDup + 1;
            Console.WriteLine("The amount of duplicates are "+ amountDup);
            return amountDup;
            }
            //scoring(amountDup);
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

        public int scoring(int roll)
        {

            if (roll < 2 )
            {
                int score = 0;
                Console.WriteLine("Your score is " + score);
                return score;
            }

            else if (roll == 2)
            {
                reRoll();
                int score = 0;
                return score;
            }

            else 
            {
                int score = roll;
                if (score == 4)
                {
                    score = 6;
                    Console.WriteLine("Your score is " + score);
                    return score;
                }

                else if (score == 5)
                {
                    score = 12;
                    Console.WriteLine("Your score is " + score);   
                    return score;                 
                }

                else
                {
                    Console.WriteLine("Your score is " + score);             
                    return score;           
                }
            }
        }
    }
}
