``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i5-10300H CPU 2.50GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.300
  [Host]     : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT


```
|       Method |      Mean |     Error |    StdDev |    Median | Rank | Allocated |
|------------- |----------:|----------:|----------:|----------:|-----:|----------:|
|  WritingTest | 0.1197 ns | 0.0217 ns | 0.0169 ns | 0.1200 ns |    2 |         - |
| ChangingTest | 0.0008 ns | 0.0022 ns | 0.0027 ns | 0.0000 ns |    1 |         - |
|  ReadingTest | 0.0077 ns | 0.0126 ns | 0.0177 ns | 0.0000 ns |    1 |         - |
