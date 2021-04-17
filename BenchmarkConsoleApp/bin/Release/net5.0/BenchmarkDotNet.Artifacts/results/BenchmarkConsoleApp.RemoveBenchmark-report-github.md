``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
AMD Ryzen 5 3600, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]        : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  .NET 4.6.1    : .NET Framework 4.8 (4.8.4341.0), X64 RyuJIT
  .NET Core 5.0 : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|         Method |           Job |       Runtime |       N |           Mean |       Error |      StdDev |      Gen 0 | Gen 1 | Gen 2 |  Allocated |
|--------------- |-------------- |-------------- |-------- |---------------:|------------:|------------:|-----------:|------:|------:|-----------:|
|         **Remove** |    **.NET 4.6.1** |    **.NET 4.6.1** |    **1000** |       **4.589 μs** |   **0.0036 μs** |   **0.0030 μs** |          **-** |     **-** |     **-** |          **-** |
| RemoveMultiKey |    .NET 4.6.1 |    .NET 4.6.1 |    1000 |      93.612 μs |   0.2142 μs |   0.2004 μs |    43.4570 |     - |     - |    72214 B |
|         Remove | .NET Core 5.0 | .NET Core 5.0 |    1000 |       4.750 μs |   0.0029 μs |   0.0026 μs |          - |     - |     - |          - |
| RemoveMultiKey | .NET Core 5.0 | .NET Core 5.0 |    1000 |      54.508 μs |   0.2678 μs |   0.2505 μs |     8.4229 |     - |     - |    70880 B |
|         **Remove** |    **.NET 4.6.1** |    **.NET 4.6.1** | **1000000** |   **4,583.969 μs** |   **0.5436 μs** |   **0.4819 μs** |          **-** |     **-** |     **-** |          **-** |
| RemoveMultiKey |    .NET 4.6.1 |    .NET 4.6.1 | 1000000 | 114,703.365 μs | 132.8405 μs | 124.2591 μs | 53000.0000 |     - |     - | 88173694 B |
|         Remove | .NET Core 5.0 | .NET Core 5.0 | 1000000 |   4,743.523 μs |   0.6125 μs |   0.5430 μs |          - |     - |     - |          - |
| RemoveMultiKey | .NET Core 5.0 | .NET Core 5.0 | 1000000 |  51,923.830 μs | 302.5066 μs | 252.6067 μs |  9400.0000 |     - |     - | 79198880 B |
