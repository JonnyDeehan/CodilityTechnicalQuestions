using System.Collections.Generic;
using System.Linq;

namespace CodilityTechnicalQuestions
{
    public class OddOccurrencesInArray
    {
        public int FindOddOccurrencesInArray(int[] A)
        {
			var set = new HashSet<int>();
			foreach (var i in A)
				if (set.Contains(i))
					set.Remove(i);
				else
					set.Add(i);

            if (set.Any())
            {
                return set.First();
            }
			return 0;
		}
    }
}
