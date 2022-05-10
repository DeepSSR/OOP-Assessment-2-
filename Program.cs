using System;

namespace Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Die dieObj = new Die();

            int[] arrayValues = new int[5];
            arrayValues = dieObj.RollStandardDie();
            foreach(int i in arrayValues)
            {
               Console.WriteLine(i);
            }
        }
    }
}
