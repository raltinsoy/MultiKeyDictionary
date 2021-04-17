``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
AMD Ryzen 5 3600, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]        : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  .NET 4.6.1    : .NET Framework 4.8 (4.8.4341.0), X64 RyuJIT
  .NET Core 5.0 : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|              Method |           Job |       Runtime |       N |           Mean |         Error |        StdDev |      Gen 0 | Gen 1 | Gen 2 |   Allocated |
|-------------------- |-------------- |-------------- |-------- |---------------:|--------------:|--------------:|-----------:|------:|------:|------------:|
|         **ContainsKey** |    **.NET 4.6.1** |    **.NET 4.6.1** |    **1000** |       **6.476 μs** |     **0.0070 μs** |     **0.0066 μs** |          **-** |     **-** |     **-** |           **-** |
| ContainsKeyMultiKey |    .NET 4.6.1 |    .NET 4.6.1 |    1000 |     148.555 μs |     1.0450 μs |     0.9264 μs |    62.7441 |     - |     - |    104309 B |
|         ContainsKey | .NET Core 5.0 | .NET Core 5.0 |    1000 |       5.210 μs |     0.0132 μs |     0.0123 μs |          - |     - |     - |           - |
| ContainsKeyMultiKey | .NET Core 5.0 | .NET Core 5.0 |    1000 |     113.173 μs |     0.7345 μs |     0.6133 μs |    12.2070 |     - |     - |    102880 B |
|         **ContainsKey** |    **.NET 4.6.1** |    **.NET 4.6.1** | **1000000** |   **6,771.196 μs** |    **30.7905 μs** |    **28.8014 μs** |          **-** |     **-** |     **-** |           **-** |
| ContainsKeyMultiKey |    .NET 4.6.1 |    .NET 4.6.1 | 1000000 | 207,157.256 μs | 1,424.7703 μs | 1,332.7310 μs | 72333.3333 |     - |     - | 120276213 B |
|         ContainsKey | .NET Core 5.0 | .NET Core 5.0 | 1000000 |   5,371.502 μs |    21.3448 μs |    19.9659 μs |          - |     - |     - |           - |
| ContainsKeyMultiKey | .NET Core 5.0 | .NET Core 5.0 | 1000000 | 154,119.940 μs |   606.3408 μs |   506.3220 μs | 13250.0000 |     - |     - | 111202966 B |
