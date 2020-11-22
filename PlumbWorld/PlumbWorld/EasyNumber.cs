using System;

namespace PlumbWorld
{
    public class EasyNumber : RandomNumber
    {

        public EasyNumber(int initmaxgoes, int initlowerbound, int initupperbound)
            : base(initmaxgoes, initlowerbound, initupperbound)
        {
        }

        public override void GuessNumber()
        {
            int count = 0;
            NumberToGuess = GenerateNumber();
            for (count = MaxGoes - 1; count >= 0; count--)
            {
                NumberEntered = EnterNumber();
                if (ValidateNumber())
                {
                    break;
                }
                else
                {
                    GoesLeft(count);
                }
            }
        }

        public override int GenerateNumber()
        {
            Random r = new Random();
            return r.Next(LowerBound, UpperBound);
        }

        public override int EnterNumber()
        {
            string numberEntered = string.Empty;
            Console.WriteLine("Enter a number between {0} and {1}", LowerBound, UpperBound);
            numberEntered = Console.ReadLine();
            try
            {
                return int.Parse(numberEntered);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                Console.WriteLine("You have not entered a number!");
            }
            return 0;
        }

        public override bool ValidateNumber()
        {
            if (NumberToGuess == NumberEntered)
            {
                Console.WriteLine("Correct");
                return true;
            }
            else if (NumberToGuess > NumberEntered)
            {
                Console.WriteLine("Incorrect - try higher");

            }
            else if (NumberToGuess < NumberEntered)
            {
                Console.WriteLine("Incorrect - try lower");
            }
            return false;
        }

        public override void GoesLeft(int count)
        {
            if (count == 1)
            {
                Console.WriteLine("You have 1 go left.");
            }
            else if (count == 0)
            {
                Console.WriteLine("Bad Luck, out of guesses. The correct number was {0}", NumberToGuess);
            }
            else
            {
                Console.WriteLine("You have {0} goes left", count);
            }

        }
    }
}
