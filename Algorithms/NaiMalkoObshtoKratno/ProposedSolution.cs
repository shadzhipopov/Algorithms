using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.NaiMalkoObshtoKratno
{
    class ProposedSolution
    {
        private int[] numbers;
        public int n;

        public long GreatestCommonDenominator(long a, long b)
        {
            return (0 == b) ? a : GreatestCommonDenominator(b, a % b);
        }

        public long Lcm(long[] numbers, int n)
        {
            
            this.n = numbers.GetLength(0);
            long b;
            if(n==2)
            {
                return (numbers[0] * numbers[1]) / GreatestCommonDenominator(numbers[0], numbers[1]);
            }
            else
            {
                b = Lcm(numbers, n - 1);
                return (numbers[n - 1] * b) / GreatestCommonDenominator(numbers[n - 1], (int)b);
            }
        }

    }
}
