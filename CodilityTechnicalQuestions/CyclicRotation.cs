namespace CodilityTechnicalQuestions
{
    public class CyclicRotation
    {
        public int[] FindCyclicRotation(int[] A, int K)
        {
            int len = A.Length;
            int[] B = new int[len];
            if (len > 0 && K % len != 0)
            {
                for (int i = 0; i < len; i++)
                {
                    B[(K + i) % len] = A[i];
                }
            }
            else
            {
                return A;
            }
            return B;
        }
    }
}
