using System;
using System.Linq;

namespace CodilityTechnicalQuestions
{
    public class TapeEquilibrium
    {
        public int DetermineTapeEquilibrium(int[] A)
        {
            int minDifference = int.MaxValue;
            int leftSide = A[0];

            int rightSide = A.Sum() - leftSide;

            int currentDifference = Math.Abs(leftSide - rightSide);

            if(currentDifference < minDifference)
            {
                minDifference = currentDifference;

                if(minDifference == 0)
                {
                    return 0;
                }
            }

            // 0 < p < N
            for (int p = 1; p < A.Length; p++)
            {
                var pointer = A[p];
                leftSide += pointer;
                rightSide -= pointer;

                currentDifference = Math.Abs(leftSide - rightSide);

                if (currentDifference < minDifference)
                {
                    minDifference = currentDifference;

                    if (minDifference == 0)
                    {
                        return 0;
                    }
                }
            }

            return minDifference;
        }
    }
}
