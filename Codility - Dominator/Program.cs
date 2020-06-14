using System;
using System.Collections.Generic;

namespace Codility___Dominator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// Dominator - 100/100
        public int solution(int[] A)
        {
            Dictionary<int, int> numsCout = new Dictionary<int, int>();
            int maxV = 0;
            int maxI = 0;
            int index = 0;
            foreach(var i in A)
            {
                if (numsCout.ContainsKey(i)) numsCout[i]++;
                else numsCout.Add(i, 1);

                if(numsCout[i] > maxV)
                {
                    maxV = numsCout[i];
                    maxI = index;
                }

                index++;
            }

            if (maxV > A.Length / 2)
                return maxI;
            return -1;
        }
    }
}
