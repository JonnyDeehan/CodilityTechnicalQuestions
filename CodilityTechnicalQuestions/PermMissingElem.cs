namespace CodilityTechnicalQuestions
{
    public class PermMissingElem
    {
        public int FindPermMissingElem(int[] A)
        {
            if(A.Length == 1)
            {
                if(A[0] == 1)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }

            // Determine the 'expected sum' if no elements were missing
            int maxNum = A.Length + 1;

            int expectedSum = ((maxNum * (maxNum + 1)) / 2);

            // Find the sum of elements in the array

            int actualSum = 0;

            foreach(var i in A)
            {
                actualSum += i;
            }

            // return the difference

            return expectedSum - actualSum;
        }
    }
}
