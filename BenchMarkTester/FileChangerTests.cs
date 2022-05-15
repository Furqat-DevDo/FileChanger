using BenchmarkDotNet.Attributes;


namespace BenchMarkTester
{
    [RankColumn]
    [MemoryDiagnoser]
    public class FileChangerTests
    {
        [Benchmark]
        public void WritingTest()
        {

        }

        [Benchmark]
        public void ChangingTest()
        {

        }

        [Benchmark]
        public void ReadingTest()
        {

        }
    }
}
