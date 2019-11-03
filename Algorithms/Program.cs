using Algorithms.NaiMalkoObshtoKratno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {


        public static int Fact(int n)
        {
            if (n==0 || n == 1)
            {
                return 1;
            }
            else
            {
                return (n * (Fact(n - 1)));
            }
        }

        static void Main(string[] args)
        {
            var p = new Permutations(2);
            p.IterativeSolutionPattern();
            var recP = new RecursivePermite();
            
            recP.Start(4);

            var perm = new Permutations(4);
            perm.NumDepth();
            var found = perm.permutations.Distinct().Count();

            var ps = new ProposedSolution();

            var nums = new List<long>();
            for (int i = 0; i < 1000; i++)
            {
                nums.Add(i);
            }
            var res = ps.Lcm(nums.ToArray(), 1000);
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
