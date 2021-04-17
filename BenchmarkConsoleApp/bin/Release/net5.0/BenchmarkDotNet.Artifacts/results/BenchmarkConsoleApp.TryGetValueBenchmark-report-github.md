``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
AMD Ryzen 5 3600, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]        : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  .NET 4.6.1    : .NET Framework 4.8 (4.8.4341.0), X64 RyuJIT
  .NET Core 5.0 : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|              Method |           Job |       Runtime |       N |           Mean |       Error |      StdDev |      Gen 0 | Gen 1 | Gen 2 |   Allocated |
|-------------------- |-------------- |-------------- |-------- |---------------:|------------:|------------:|-----------:|------:|------:|------------:|
|         **TryGetValue** |    **.NET 4.6.1** |    **.NET 4.6.1** |    **1000** |       **8.898 μs** |   **0.0090 μs** |   **0.0080 μs** |          **-** |     **-** |     **-** |           **-** |
| TryGetValueMultiKey |    .NET 4.6.1 |    .NET 4.6.1 |    1000 |     148.265 μs |   0.5372 μs |   0.5025 μs |    62.7441 |     - |     - |    104309 B |
|         TryGetValue | .NET Core 5.0 | .NET Core 5.0 |    1000 |       5.568 μs |   0.0012 μs |   0.0010 μs |          - |     - |     - |           - |
| TryGetValueMultiKey | .NET Core 5.0 | .NET Core 5.0 |    1000 |     107.733 μs |   0.9688 μs |   0.9062 μs |    12.2070 |     - |     - |    102880 B |
|         **TryGetValue** |    **.NET 4.6.1** |    **.NET 4.6.1** | **1000000** |   **9,011.487 μs** |  **16.4229 μs** |  **13.7138 μs** |          **-** |     **-** |     **-** |           **-** |
| TryGetValueMultiKey |    .NET 4.6.1 |    .NET 4.6.1 | 1000000 | 207,022.609 μs | 868.8964 μs | 812.7662 μs | 72333.3333 |     - |     - | 120276213 B |
|         TryGetValue | .NET Core 5.0 | .NET Core 5.0 | 1000000 |   6,182.355 μs |  34.9904 μs |  31.0181 μs |          - |     - |     - |         1 B |
| TryGetValueMultiKey | .NET Core 5.0 | .NET Core 5.0 | 1000000 | 154,210.122 μs | 663.4487 μs | 620.5904 μs | 13250.0000 |     - |     - | 111201952 B |
