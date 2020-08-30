namespace CodilityTechnicalQuestions
{
    public class CountDiv
    {
        public int FindValsDivisibleByKInRange(int A, int B, int K)
        {
            var mod = A % K;
            return (mod == 0 ? 1 : 0) + (B + mod - A) / K;
        }
    }
}
