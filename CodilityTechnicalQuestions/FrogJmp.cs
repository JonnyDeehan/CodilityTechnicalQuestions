using System;

namespace CodilityTechnicalQuestions
{
    public class FrogJmp
    {
        public int FindNumberOfFrogJumps(int X, int Y, int D)
        {
            return (int)Math.Ceiling(((double)Y - X) / D);
        }
    }
}
