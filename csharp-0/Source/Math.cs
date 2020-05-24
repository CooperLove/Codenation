using System;
using System.Collections.Generic;

namespace Codenation.Challenge
{
    public class Math
    {
        public List<int> Fibonacci()
        {
            List<int> sequence = new List<int>();
            int i = 0, res = 0;
            while ( res < 350){
                res = DynamicFibonacci(i++);
                if (res < 350)
                    sequence.Add(res);
            }

            return sequence;
        }

        public int Fibonacci(int i){
            
            if (i == 0) 
                return 0;
            if (i == 1) 
                return 1;
            return Fibonacci (i-1) + Fibonacci (i-2);
        }

        public int DynamicFibonacci(int n){
            
            int[] nums = new int[n+1];
            if (n  == 0) return 0;
            if (n  == 1) return 1;
            nums[0] = 0; nums[1] = 1;
            int res = 0;
            
            for (int i = 2; i < n+1; i++)
            {
                nums[i] = nums[i-1] + nums[i-2];
            }
            res = nums[n];
            return res;
        }

        public bool IsFibonacci(int numberToTest)
        {
            List<int> seq = Fibonacci();
            return seq.Contains(numberToTest);
        }
    }
}
