using System;

namespace Poslednjaja_popytka
{
    public class UsualPlayer : BasePlayer
    {
        public UsualPlayer()
        {
            TypeOfPlayer = TypeOfPlayer.usual;
        }

        public override int GuessNumber(int i)
        {
            var startrandom = new Random(i).Next(i, 780);
            var randNumber = new Random(startrandom).Next(maxValue: MaxBoundary, minValue: MinBoundary);
            allGuessedNumbers.Add(randNumber);
            Console.WriteLine(randNumber);
            return randNumber;
        }
    }
}
