using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodilityTechnicalQuestions
{
    public class TechnicalTest
    {
        public int MaximumA(string S)
        {
            int currentSubStringOfAs = 0;

            int numOfOtherLetters = 0;

            for(int index = 0; index < S.Length; index++)
            {
                if(S[index] == 'a')
                {
                    currentSubStringOfAs++;
                }
                else
                {
                    currentSubStringOfAs = 0;

                    numOfOtherLetters++;
                }

                // Check if current substring has 3 consecutive 'a's 
                if (currentSubStringOfAs == 3)
                {
                    return -1;
                }
            }

            // Logic to determine that total num of As 
            return ((numOfOtherLetters + 1) * 2) - (S.Length - numOfOtherLetters);
        }

        public int DetermineLongestUniqueCharacterConcatenationString(string[] A)
        {
            Hashtable subStringUniquenessCheck = new Hashtable();
            HashSet<int> indexesOfStringsToIgnore = new HashSet<int>();

            int longestSubstring = 0;

            List<string> subStrings = A.ToList();

            StringBuilder currentConcatenation = new StringBuilder();

            for(int index = 0; index < A.Length; index++)
            {
                subStringUniquenessCheck.Clear();

                var substring = A[index];
                // First check for uniqueness
                bool isSubstringUnique = DetermineIfSubstringIsUnique(substring, ref subStringUniquenessCheck);

                if (!isSubstringUnique)
                {
                    indexesOfStringsToIgnore.Add(index);
                    continue;
                }

                // Append to current concatenation
                currentConcatenation.Clear();
                currentConcatenation.Append(substring);

                int indexInSubstringsToCheck = -1;
                // If unique, then try concatenate with other strings
                foreach (var currentSubstring in subStrings)
                {
                    indexInSubstringsToCheck++;

                    if (indexInSubstringsToCheck == index || indexesOfStringsToIgnore.Contains(indexInSubstringsToCheck))
                    {
                        continue;
                    }

                    // Determine if this substring to combine with is unique
                    if(DetermineIfSubstringIsUnique(currentSubstring, ref subStringUniquenessCheck))
                    {
                        currentConcatenation.Append(currentSubstring);
                    }
                }

                // if not, then record longest length so far
                if(currentConcatenation.Length > longestSubstring)
                {
                    longestSubstring = currentConcatenation.Length;
                }
            }

            return longestSubstring;
        }

        private bool DetermineIfSubstringIsUnique(string substring, ref Hashtable subStringUniquenessCheck)
        {
            foreach (var character in substring)
            {
                if (subStringUniquenessCheck.Contains(character))
                {
                    return false;
                }
                else
                {
                    subStringUniquenessCheck.Add(character, 1);
                }
            }

            return true;
        }

    }
}
