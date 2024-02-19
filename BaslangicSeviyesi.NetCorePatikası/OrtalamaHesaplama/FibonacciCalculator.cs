using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrtalamaHesaplama
{
    public class FibonacciCalculator
    {
        public double GetFibonacciAverage(int depth)
        {
            if (depth <= 0)
            {
                return 0;
            }

            long[] fibonacciSeries = GenerateFibonacciSeries(depth);
            double sum = 0;

            foreach (long num in fibonacciSeries)
            {
                sum += num;
            }

            return sum / depth;
        }

        private long[] GenerateFibonacciSeries(int depth)
        {
            long[] series = new long[depth];
            series[0] = 0;
            if (depth == 1)
            {
                return series;
            }
            series[1] = 1;

            for (int i = 2; i < depth; i++)
            {
                series[i] = series[i - 1] + series[i - 2];
            }

            return series;
        }
    }
}

