using BenchmarkDotNet.Running;

namespace ObjectMappers.Benchmark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<ObjectMapperBenchmark>();
        }
    }
}