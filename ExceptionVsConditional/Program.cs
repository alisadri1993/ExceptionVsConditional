using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace ExceptionVsConditional;

internal class Program
{
    static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run<ExceptionVsConditionalBenchmark>();
    }

    public class ExceptionVsConditionalBenchmark
    {
        private int Numerator = 10;
        private int Denominator = 0;

        [Benchmark]
        public int DivideWithConditional()
        {
            if (Denominator == 0)
            {
                return -1; // Indicate an error
            }
            return Numerator / Denominator;
        }

        [Benchmark]
        public int DivideWithException()
        {
            try
            {
                return Numerator / Denominator;
            }
            catch (DivideByZeroException)
            {
                return -1; // Indicate an error
            }
        }
    }

}
