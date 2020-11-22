using System;

namespace PlumbWorld
{
    class Program
    {
        public enum Difficulty
        {
            Easy = 1, Medium = 2, Hard = 3, Exit = 4
        };
        public const int easylowerbound = 1;
        public const int easyupperbound = 10;
        public const int easymaxgoes = 3;
        public const int mediumlowerbound = 1;
        public const int mediumupperbound = 100;
        public const int mediummaxgoes = 5;
        public const int hardlowerbound = 1;
        public const int hardupperbound = 1000;
        public const int hardmaxgoes = 4;

        static void Main(string[] args)
        {
            int difficulty = 0;

            do
            {
                Console.WriteLine("Please select an option\n1 - Easy\n2 - Medium\n3 - Difficult\n4 - Exit\n");
                try
                {
                    difficulty = Convert.ToInt32(Console.ReadLine());

                    if (difficulty == (int)Difficulty.Easy)
                    {
                        EasyNumber easyNumber = new EasyNumber(easymaxgoes, easylowerbound, easyupperbound);

                        easyNumber.GuessNumber();
                     }
                    else if (difficulty == (int)Difficulty.Medium)
                    {
                        MediumNumber mediumNumber = new MediumNumber(mediummaxgoes, mediumlowerbound, mediumupperbound);
                        mediumNumber.GuessNumber();
                    }
                    else if (difficulty == (int)Difficulty.Hard)
                    {
                        HardNumber hardNumber = new HardNumber(hardmaxgoes, hardlowerbound, hardupperbound);
                        hardNumber.GuessNumber();

                    }
                }
                catch(Exception exc)
                {
                    Console.WriteLine(exc.Message);
                    Console.WriteLine("Please select an option between 1 and 4.");
                }
            }
            while (difficulty != (int)Difficulty.Exit);
            
            Console.WriteLine("Thanks for playing. Call again soon.");
        }
    }       
}

