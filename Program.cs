using System;

namespace Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Player plyObj = new Player();

            plyObj.input();
        }

        public int program()
        {
            Die dieObj = new Die();

            int[] arrayValues = new int[5];
            arrayValues = dieObj.RollStandardDie();
            foreach(int i in arrayValues)
            {
               Console.WriteLine(i);
            }

            Game gamObj = new Game();

            int dup;
            dup = gamObj.comparingRoll(arrayValues);

            int score;
            score = gamObj.scoring(dup);
            return score;
        }
    }
}
