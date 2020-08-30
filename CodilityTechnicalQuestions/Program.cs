using System;

namespace CodilityTechnicalQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Brackets test = new Brackets();

            var result = test.DetermineIfProperlyNested("{[()()]}");
        }
    }
}
