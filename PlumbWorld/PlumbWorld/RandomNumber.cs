using System;
namespace PlumbWorld
{
    public abstract class RandomNumber
    {
        protected int randomnumber;
        protected int maxgoes;
        protected int lowerbound;
        protected int upperbound;

        public int MaxGoes { get; set; }
        public int LowerBound { get; set; }
        public int UpperBound { get; set; }

        public RandomNumber(int initmaxgoes, int initlowerbound, int initupperbound)
        {
            
            maxgoes = initmaxgoes;
            lowerbound = initlowerbound;
            upperbound = initupperbound;
        }
    }
}
