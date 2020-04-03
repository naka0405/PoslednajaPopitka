using System;
using System.Collections.Generic;

namespace Poslednjaja_popytka
{
    public class NotepadPlayer : BasePlayer
    {
        private readonly List<int> passedGuessings;

        public NotepadPlayer()
        {
            TypeOfPlayer = TypeOfPlayer.notepad;
            passedGuessings = new List<int>();
        }

        public override int GuessNumber(int r)
        {
            //int countOfGuess;
            int randNumber;

            //do
            //{
            //    countOfGuess = 0;
            //    randNumber = new Random(new Random(r).Next(9)).Next(maxValue: MaxBoundary, minValue: MinBoundary);

            //    for (int i = 0; i < passedGuessings.Count; i++)
            //    {
            //        if (randNumber == passedGuessings[i])
            //        {
            //            countOfGuess++;
            //        }
            //    }
            //}
            //while (countOfGuess != 0);
            bool IsFaund = false;

            do
            {
                // countOfGuess = 0;
                randNumber = new Random(new Random(r).Next(9)).Next(maxValue: MaxBoundary, minValue: MinBoundary);

                for (int i = 0; i < passedGuessings.Count; i++)
                {
                    IsFaund = false;
                    if (randNumber == passedGuessings[i])
                    {
                        IsFaund = true;
                    }
                }
            }
            while (IsFaund == true);//(countOfGuess != 0);
            passedGuessings.Add(randNumber);
            allGuessedNumbers.Add(randNumber);

            return randNumber;
        }
    }
}
