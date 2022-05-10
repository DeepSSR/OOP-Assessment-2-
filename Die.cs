using System;
using System.Collections.Generic;
using System.Linq;

namespace Code
{
    class Die
    {
        public int[] RollStandardDie()
        {
            int playerRandomNum;
            int[] dieValues = new int[4];
 
            Random random = new Random();
            
            for (int i = 0; i < dieValues.Length; i++)
            {
                Console.WriteLine("Press any key to roll the dice.");
                Console.ReadKey();
            
                playerRandomNum = random.Next(1, 7);
                dieValues[i] = playerRandomNum;
                Console.WriteLine("You rolled a " + playerRandomNum);

            }

            return dieValues;
        }
    }
}
