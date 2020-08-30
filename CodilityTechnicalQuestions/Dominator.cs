using System.Collections.Generic;

namespace CodilityTechnicalQuestions
{
    public class Dominator
    {

        public int DetermineDominator(int [] A)
        {
            int indexOfCandidate = -1;
            int stackCounter = 0, value = -1, i = 0;

            foreach (int element in A)
            {
                if (stackCounter == 0)
                {
                    value = element;
                    ++stackCounter;
                    indexOfCandidate = i;
                }
                else
                {
                    if (value == element)
                    {
                        ++stackCounter;
                    }
                    else
                    {
                        --stackCounter;
                    }
                }
                ++i;
            }

            int candidate;
            if (stackCounter > 0)
            {
                candidate = value;
            }
            else
            {
                return -1;
            }

            int countRepetitions = 0;
            foreach (int element in A)
            {
                if (element == candidate)
                {
                    ++countRepetitions;

                }
                if (countRepetitions > (A.Length / 2))
                {
                    return indexOfCandidate;
                }
            }
            return -1;
        }

        public int DetermineDominatorOptimized(int[] A)
        {
            if (A.Length < 1)
                return -1;

            int size = 0; 
            int value = 0;

            for (var i = -1; ++i < A.Length;)
            {
                if (size == 0)
                {
                    ++size;
                    value = A[i];
                }
                else if (value != A[i])
                    --size;
                else
                    ++size;
            }
            if (size > 0)
            {
                int count = 0;
                for (var i = -1; ++i < A.Length;)
                    if (A[i] == value && ++count > A.Length / 2)
                        return i;
            }
            return -1;
        }

        public int DetermineDominatorAttempt1(int[] A)
        {
            if(A.Length == 1)
            {
                return 0;
            }

            Dictionary<int, int> integerOccurences = new Dictionary<int, int>();

            int maxOccurences = 0;
            int dominator = -1;

            for (int i=0; i< A.Length; i++)
            {
                var leftPointer = A[i];
                var rightPointer = A[A.Length - 1 - i];

                int leftVal;
                var valueFound = integerOccurences.TryGetValue(leftPointer, out leftVal);

                if (valueFound)
                {
                    integerOccurences[leftPointer] = leftVal + 1;
                }
                else
                {
                    integerOccurences.Add(leftPointer, 1);
                }

                if(i == (A.Length - 1 - i))
                {
                    break;
                }

                int rightVal;
                valueFound = integerOccurences.TryGetValue(rightPointer, out rightVal);

                if (valueFound)
                {
                    integerOccurences[rightPointer] = rightVal + 1;
                }
                else
                {
                    integerOccurences.Add(rightPointer, 1);
                }

                if(leftVal > maxOccurences)
                {
                    maxOccurences = leftVal;
                    dominator = i;
                }
                else if(rightVal > maxOccurences)
                {
                    maxOccurences = rightVal;
                    dominator = i;
                }
            }

            return dominator;
        }
    }
}
