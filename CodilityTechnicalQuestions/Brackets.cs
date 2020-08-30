using System.Collections.Generic;

namespace CodilityTechnicalQuestions
{
    public class Brackets
    {
        public int DetermineIfProperlyNested(string S)
        {
            if (string.IsNullOrEmpty(S))
            {
                return 1;
            }

            var bracketStack = new Stack<int>();

            const string openingBrackets = "({[";
            const string closingBrackets = ")}]";

            foreach (var bracket in S) 
            {
                int bracketIndex = openingBrackets.IndexOf(bracket);
                if (bracketIndex != -1)
                {
                    bracketStack.Push(bracketIndex);
                }
                else
                {
                    if(bracketStack.Count == 0)
                    {
                        return 0;
                    }
                    var closingBracketIndex = closingBrackets.IndexOf(bracket);

                    var topOfStack = bracketStack.Pop();

                    if(topOfStack != closingBracketIndex)
                    {
                        return 0;
                    }
                }
            }

            if(bracketStack.Count == 0)
            {
                return 1;
            }

            return 0;
        }
    }
}
