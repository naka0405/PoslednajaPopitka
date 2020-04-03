using System;

namespace Poslednjaja_popytka
{
    public class CheaterPlayer : BasePlayer
    {
        public CheaterPlayer()
        {
            TypeOfPlayer = TypeOfPlayer.cheater;
        }

        public override int GuessNumber(int r)
        {
            //int countOfGuess;
            int randNumber;
            bool IsFaund = false;

            do
            {
                IsFaund = false;
                //countOfGuess = 0;
                randNumber = new Random().Next(maxValue: MaxBoundary, minValue: MinBoundary);

                for (int i = 0; i < allGuessedNumbers.Count; i++)
                {
                    if (randNumber == allGuessedNumbers[i])
                    {
                        //countOfGuess++;
                        IsFaund = true;
                    }
                }
            }
            while (IsFaund == true);//countOfGuess != 0);

            allGuessedNumbers.Add(randNumber);

            return randNumber;
        }
    }
}
