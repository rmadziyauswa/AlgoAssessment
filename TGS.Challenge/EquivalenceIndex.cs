using System.Linq;
namespace TGS.Challenge
{
  /*
       Given a zero-based integer array of length N, the equivalence index (i) is the index where the sum of all the items to the left of the index
       are equal to the sum of all the items to the right of the index.

       Constraints: 0 <= N <= 100 000

       Example: Given the following array [1, 2, 3, 4, 5, 7, 8, 10, 12]
       Your program should output "6" because 1 + 2 + 3 + 4 + 5 + 7 = 10 + 12

       If no index exists then output -1

       There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */

    public class EquivalenceIndex
    {
        private const int START_INDEX = 1;
        private const int DEFAULT_INDEX = -1;
        public int Find(int[] numbers)
      {
            if(numbers.Length > START_INDEX)
            {
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    var leftSide = numbers.Where((val, index) => index < i).Sum();
                    var rightSide = numbers.Where((val, index) => index > i).Sum();
                    if(leftSide.Equals(rightSide))
                    {
                        return i;
                    }
                }
            }
            return DEFAULT_INDEX;
      }
    }
}
