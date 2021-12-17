using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsCopy
{
    internal class FibonacciNumberFinder
    {
        private const int first = 0, second = 1;
        private int num1, num2;

        public FibonacciNumberFinder()
        {
            num1 = first;
            num2 = second;
        }

        public int Next()
        {
            int num3 = num1 + num2;
            num1 = num2;
            num2 = num3;
            return num2;
        }

        public async Task<int> NextAsync()
        {
            return await Task.Run(Next);
        }

        public async Task<int> CountNumbers(int start, int end)
        {
            return await Task.Run(async () =>
            {
                int i = 0;
                Reset();
                if (start == 0)
                {
                    ++i;
                }
                if (start <= 1)
                {
                    ++i;
                }
                while (await NextAsync() < end)
                {
                    if (num2 >= start)
                    {
                        ++i;
                    }
                }
                return i;
            });
        }

        public void Reset()
        {
            num1 = first;
            num2 = second;
        }
    }
}
