using BenchmarkDotNet.Running;
using BenchMarkTester;

public class Program
{
    public static void Main(string[] Args)
    {
        BenchmarkRunner.Run<FileChangerTests>();
    }
}