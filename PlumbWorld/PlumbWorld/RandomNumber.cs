using System;
namespace PlumbWorld
{
    public abstract class RandomNumber
    {
        private int maxGoes;
        private int lowerBound;
        private int upperBound;
        private int numberToGuess;
        private int numberEntered;
       

        public int MaxGoes
        {
            get { return maxGoes; }
            set { maxGoes = value; }
        }

        public int LowerBound
        {
            get { return lowerBound; }
        }

        public int UpperBound
        {
            get { return upperBound; }
        }

        public int NumberToGuess
        {
            get { return numberToGuess; }
            set { numberToGuess = value; }
        }

        public int NumberEntered
        {
            get { return numberEntered; }
            set { numberEntered = value; }
        }

        public RandomNumber(int initmaxgoes, int initlowerbound, int initupperbound)
        {
            
            maxGoes = initmaxgoes;
            lowerBound = initlowerbound;
            upperBound = initupperbound;
        }

        public abstract void GuessNumber();
        public abstract int GenerateNumber();
        public abstract int EnterNumber();
        public abstract bool ValidateNumber();
        public abstract void GoesLeft(int count);
    }
}
