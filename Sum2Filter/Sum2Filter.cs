using System;
using System.Collections.Generic;

namespace Sum2FilterLib
{
    public class Sum2Filter
    {
        private long lowerBound;
        private long upperBound;
        private HashSet<long> inputs = new HashSet<long>();

        public Sum2Filter(long lowerBound, long upperBound)
        {
            this.lowerBound = lowerBound;
            this.upperBound = upperBound;
        }

        public int Count { private set; get; } = 0;

        public void Add(long value)
        {
            inputs.Add(value);
        }

        public void ApplyFilter()
        {
            for (long i = lowerBound; i <= upperBound; i++)
            {
                foreach (long l in inputs)
                {
                    if (inputs.Contains(i - l))
                    {
                        Count += 1;
                        break;
                    }
                }
            }
        }


    }
}
