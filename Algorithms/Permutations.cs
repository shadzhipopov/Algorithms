using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Permutations
    {
        private int[] permutation;
        private int n;
        private int[] numbers;

        public List<int[]> permutations = new List<int[]>();

        public void PatternRec(IEnumerable<int> numbers)
        {
            foreach (var num in numbers.ToList())
            {
                permutation[n-numbers.Count()] = num;
                var remainingNumbers = numbers.ToList().Except(new[] { num }).ToList();
                if (remainingNumbers.Count == 0)
                {
                    print();
                    break;
                }
                PatternRec(remainingNumbers);
            }
        }

        public void IterativeSolutionPattern()
        {
            var startNumbers = Enumerable.Range(1, n).ToList();
            Dictionary<int, List<int>> remainingNumbers = new Dictionary<int, List<int>>();
            remainingNumbers[0] = startNumbers;
            int i = 0;
            var currentRemaining = remainingNumbers[0];
            while (currentRemaining.Count > 0)
            {
                int j = i;
                foreach (var num in currentRemaining)
                {
                    permutation[j] = num;
                    remainingNumbers[j+1] = remainingNumbers[j].ToList().Except(new[] { num }).ToList();
                    currentRemaining = remainingNumbers[j + 1];

                    j++;
                    if (currentRemaining.Count == 0)
                    {
                        print();
                        i++;
                        break;
                    }

                }
            }
            
        }

        public void FoundPattern()
        {
            foreach (var num in numbers.ToList())
            {
                permutation[0] = num;
                var remainingNumbers = numbers.ToList().Except(new[] { num }).ToList();
                if (remainingNumbers.Count == 0)
                {
                    print();
                    break;
                }

                foreach (var item in remainingNumbers)
                {
                    permutation[1] = item;
                    var lev2Nums = remainingNumbers.Except(new int[] { item }).ToList();
                    if (lev2Nums.Count == 0)
                    {
                        print();
                        break;
                    }

                    foreach (var lev3 in lev2Nums)
                    {
                        permutation[2] = lev3;
                        var lev3It = lev2Nums.Except(new int[] { lev3 }).ToList();
                        if(lev3It.Count==0)
                        {
                            print();
                            break;
                        }
                    }
                }
            }
        }

        public int Fact(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return (n * (Fact(n - 1)));
            }
        }

        public Permutations(int n)
        {
            this.permutation = new int[n];
            this.n = n;
            this.numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = i + 1;
            }
        }
        public void PermRec(int startIndex)
        {

            for (int i = startIndex; i < n; i++)
            {
                permutation[i] = i + 1;
                if (i + 1 == n)
                {
                    print();
                    return;
                }
                PermRec(i + 1);
            }
        }

        //working with 4
        public void permute()
        {
            permutation = new int[n];

            foreach (var num in numbers.ToList())
            {
                permutation[0] = num;
                var remainingNumbers = numbers.ToList().Except(new[] { num }).ToList();

                foreach (var item in remainingNumbers)
                {
                    permutation[1] = item;
                    var toIterate = remainingNumbers.Except(new int[] { item }).ToList();


                    while (toIterate.Count > 0)
                    {
                        var currentIndex = n - toIterate.Count;
                        var copy = toIterate.ToList();

                        if (copy.Count == 2)
                        {
                            permutation[n - 2] = toIterate.First();
                            permutation[n - 1] = toIterate.Last();
                            print();
                            permutation[n - 2] = toIterate.Last();
                            permutation[n - 1] = toIterate.First();
                            print();
                            break;
                        }
                        foreach (var c in copy)
                        {
                            permutation[currentIndex] = c;

                            currentIndex++;
                            if (currentIndex == n)
                            {
                                print();
                                break;
                            }
                        }
                        toIterate.RemoveAt(0);
                    }
                }
            }
        }
        int depth = 0;

        public void NumDepth()
        {
            var currentDepth = 0;
            for (int i = 0; i < n; i++)
            {
                var depthNumbers = numbers.ToList().Except(new int[] { currentDepth + 1 }).ToList();
                

            }

        }

        public void Itera()
        {

            for (int i = 0; i < n; i++)
            {
                permutation[0] = numbers[i];
                var remainingNumbers = numbers.ToList().Except(new[] { numbers[i] }).ToList();

                foreach (var num in remainingNumbers)
                {
                    var nextLevel = remainingNumbers.ToList();
                    int depth = 1;
                    while (nextLevel.Count > 2)
                    {
                        depth++;
                        permutation[depth] = nextLevel[0];
                        nextLevel.RemoveAt(0);
                    }

                    permutation[n - 2] = nextLevel.First();
                    permutation[n - 1] = nextLevel.Last();
                    print();
                    permutation[n - 2] = nextLevel.Last();
                    permutation[n - 1] = nextLevel.First();
                    print();

                }

            }
            //foreach (var num in numbers.ToList())
            //{
            //    permutation[0] = num;
            //    var remainingNumbers = numbers.ToList().Except(new[] { num }).ToList();

            //    while (remainingNumbers > 2)
            //    {

            //    }
            //    foreach (var item in remainingNumbers)
            //    {
            //        permutation[1] = item;
            //        var toIterate = remainingNumbers.Except(new int[] { item }).ToList();
            //        while (toIterate.Count > 0)
            //        {
            //            var currentIndex = n - toIterate.Count;
            //            var copy = toIterate.ToList();

            //            if (copy.Count == 2)
            //            {
            //                permutation[n - 2] = toIterate.First();
            //                permutation[n - 1] = toIterate.Last();
            //                print();
            //                permutation[n - 2] = toIterate.Last();
            //                permutation[n - 1] = toIterate.First();
            //                print();
            //                break;
            //            }
            //            foreach (var c in copy)
            //            {
            //                permutation[currentIndex] = c;

            //                currentIndex++;
            //                if (currentIndex == n)
            //                {
            //                    print();
            //                    break;
            //                }
            //            }
            //            toIterate.RemoveAt(0);
            //        }
            //    }
            //}
        }

        private void print()
        {
            this.permutations.Add((int[])this.permutation.Clone());
            foreach (var item in permutation)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
