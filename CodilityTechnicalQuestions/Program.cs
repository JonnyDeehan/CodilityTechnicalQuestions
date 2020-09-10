using System;

namespace CodilityTechnicalQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            TechnicalTest test = new TechnicalTest();

            var A = new string[3];
            A[0] = "co";
            A[1] = "dil";
            A[2] = "ity";

            var result = test.DetermineLongestUniqueCharacterConcatenationString(A);

            Console.WriteLine("Longest substring length: {0}", result);
        }
    }
}
