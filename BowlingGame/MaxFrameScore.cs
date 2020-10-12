namespace BowlingGame
{
    public class MaxFrameScore
    {
        private readonly BowlingRolls _rolls;

        public MaxFrameScore(BowlingRolls rolls)
        {
            _rolls = rolls;
        }

        public IScore Score(int howManyBonus)
        {
            return new Score(10).Add(_rolls.Bonus(howManyBonus));
        }
    }
}