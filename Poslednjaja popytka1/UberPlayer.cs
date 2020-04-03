﻿using System.Collections.Generic;

namespace Poslednjaja_popytka
{
    public class UberPlayer : BasePlayer
    {
        private int currentGuess = MinBoundary;

        public List<int> uberList = new List<int>();

        public UberPlayer()
        {
            TypeOfPlayer = TypeOfPlayer.uber;
        }

        public override int GuessNumber(int i)
        {

            allGuessedNumbers.Add(currentGuess);

            return currentGuess++;
        }
    }
}
