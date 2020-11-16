using System;
namespace PlumbWorld
{
    public class HardNumber:RandomNumber
    {
        private int initLowerBound;
        private int initUpperBound;
        private int initRandomNumber;

        public HardNumber(int initmaxgoes, int initlowerbound, int initupperbound)
            : base(initmaxgoes, initlowerbound, initupperbound)
        {
            initLowerBound = initlowerbound;
            initUpperBound = initupperbound;
        }


        public int GenerateNumber()
        {
            Random r = new Random();
            initRandomNumber = r.Next(initLowerBound, initUpperBound);
            return initRandomNumber;
        }

    }       

}
