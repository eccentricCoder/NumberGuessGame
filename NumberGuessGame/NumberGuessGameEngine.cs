using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberGuessGame
{
    public class NumberGuessGameEngine
    {
        static Random rnd;

        public int SecretNumber { get; private set; }
        public int UpperLimit { get; set; }
        public int LowerLimit { get; set; }

        public NumberGuessGameEngine() :this(0, 100)
        {
            //rnd = new Random(DateTime.Now.Millisecond);
        }

        public NumberGuessGameEngine(int lowerLimit, int upperLimit)
        {
            Init(lowerLimit, upperLimit);
        }

        public void Init(int lowerLimit, int upperLimit)
        {
            UpperLimit = upperLimit; LowerLimit = lowerLimit;
            rnd = new Random(DateTime.Now.Millisecond);
            SecretNumber = rnd.Next(LowerLimit, UpperLimit + 1);
        }

        public void GenerateNewSecretNumber()
        { 
            SecretNumber = rnd.Next(LowerLimit, UpperLimit+1);
        }
    }
}
