using System;

namespace Code
{
    class Player
    {
        public static int p1s { get; set; }
        public static int p2s { get; set; }
        public static int count { get; set; }
        public void input()
        {
            Console.WriteLine("Player 1 - Press any key");
            Console.ReadKey();

            Program proObj = new Program();
            int player1Score;
            player1Score = proObj.program();

            Console.WriteLine("Player 2 - Press any key");
            Console.ReadKey();

            int player2Score;
            player2Score = proObj.program();

            count = count + 1;

            comparingScores(player1Score, player2Score, count);
        }

        public void comparingScores(int player1S, int player2S, int count)
        {
            int maximumScore = 13;

            if (count <= 1)
            {
                //int p1s;
                p1s += player1S;
                //int p2s;
                p2s += player2S;
                input();
            }

            else
            {
                // player1S = player1S + p1s;
                // Console.WriteLine(p1s);
                // Console.WriteLine(player1S);
                // player2S = player2S + p2s;
                // Console.WriteLine(p2s);
                // Console.WriteLine(player2S);
                p1s += player1S;
                p2s += player2S;

                if (p1s >= maximumScore)
                {
                    Console.WriteLine("Player 1 wins!");
                }

                else if (p2s >= maximumScore)
                {
                    Console.WriteLine("Player 2 wins!");
                }

                else
                {
                    input();
                }
            }
        }
    }
}
