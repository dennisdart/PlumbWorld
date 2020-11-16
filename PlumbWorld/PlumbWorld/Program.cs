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
        public const int easymaxgoes = 6;
        public const int mediumlowerbound = 1;
        public const int mediumupperbound = 100;
        public const int mediummaxgoes = 5;
        public const int hardlowerbound = 1;
        public const int hardupperbound = 1000;
        public const int hardmaxgoes = 4;

        static void Main(string[] args)
        {
            int difficulty = 0;
            int numbertoguess = 0;
            do
            {
                Console.WriteLine("Please select an option\n1 - Easy\n2 - Medium\n3 - Difficult\n4 - Exit\n");
                difficulty = Convert.ToInt32(Console.ReadLine());

                if (difficulty == (int)Difficulty.Easy)
                {
                    EasyNumber easynumber = new EasyNumber(easymaxgoes, easylowerbound, easyupperbound);
                    numbertoguess = easynumber.GenerateNumber();
                }
                else if (difficulty == (int)Difficulty.Medium)
                {
                    MediumNumber mediumnumber = new MediumNumber(mediummaxgoes, mediumlowerbound, mediumupperbound);
                    numbertoguess = mediumnumber.GenerateNumber();
                }
                else if (difficulty == (int)Difficulty.Hard)
                {
                    HardNumber hardnumber = new HardNumber(hardmaxgoes, hardlowerbound, hardupperbound);
                    numbertoguess = hardnumber.GenerateNumber();
                }
            }
            while (difficulty != (int)Difficulty.Exit);
            
            Console.WriteLine("Hello");
        }
    }       
}

