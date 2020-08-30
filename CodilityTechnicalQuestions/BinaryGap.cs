using System;

namespace CodilityTechnicalQuestions
{
    public class BinaryGap
    {
        public int FindBinaryGap(int N)
        {
            int maxGap = 0;
            int currentGap = 0;

            char mask = '0';

            string binary = Convert.ToString(N, 2);

            int startPosition = 0;

            // Iterate until we reach the first bit
            while(startPosition < binary.Length && binary[startPosition] != mask)
            {
                startPosition++;
            }

            // Iterate through until we enounter another bit
            for(int i=startPosition; i<binary.Length; ++i)
            {
                // Check if the current bit is a 1
                if(binary[i] == mask)
                {
                    currentGap++;
                }
                else
                {
                    if (currentGap > maxGap)
                    {
                        maxGap = currentGap;
                    }

                    currentGap = 0;
                }
            }

            return maxGap;
        }
    }
}
