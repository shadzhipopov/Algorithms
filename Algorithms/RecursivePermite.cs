using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class RecursivePermite
    {
        private int n = 3;
        int[] used;
        int[] mp;

        public void print()
        {
            int i;
            for (i = 0; i < n; i++)
            {
                Console.Write(mp[i] + 1 + " ");
            }
            Console.WriteLine();
        }

        void permute(int i)
        {
            int k;
            if (i >= n)
            {
                print();
                return;
            }
            for (k = 0; k < n; k++)
            {
                if (used[k] == 0)
                {
                    used[k] = 1;
                    mp[i] = k;
                    permute(i + 1); /* if (ако има смисъл да продължава генерирането) */
                    used[k] = 0;
                }
            }
        }

        public void Start(int num)
        {
            this.n = num;
            this.mp = new int[n];
            this.used = new int[n];
            int i;
            for (i = 0; i < n; i++)
                used[i] = 0;
            permute(0);
        }
    }
}
