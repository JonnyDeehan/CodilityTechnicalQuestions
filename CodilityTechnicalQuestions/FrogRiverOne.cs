using System.Collections.Generic;

namespace CodilityTechnicalQuestions
{
    public class FrogRiverOne
    {
        public int DetermineFrogRiverJumpTime(int X, int[] A)
        {
            HashSet<int> leaves = new HashSet<int>();

            for(int time=0; time<A.Length; time++)
            {
                int leafPosition = A[time];
                if (!leaves.Contains(leafPosition))
                {
                    leaves.Add(leafPosition);

                    if(leaves.Count == X)
                    {
                        return time;
                    }
                }
            }

            return -1;
        }
    }
}
