``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
AMD Ryzen 5 3600, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]        : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  .NET 4.6.1    : .NET Framework 4.8 (4.8.4341.0), X64 RyuJIT
  .NET Core 5.0 : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|                Method |           Job |       Runtime |       N |         Mean |      Error |     StdDev |      Gen 0 | Gen 1 | Gen 2 |    Allocated |
|---------------------- |-------------- |-------------- |-------- |-------------:|-----------:|-----------:|-----------:|------:|------:|-------------:|
|         **WhereNotFound** |    **.NET 4.6.1** |    **.NET 4.6.1** |    **1000** |     **22.97 μs** |   **0.139 μs** |   **0.130 μs** |    **38.6353** |     **-** |     **-** |     **62.69 KB** |
| WhereNotFoundMultiKey |    .NET 4.6.1 |    .NET 4.6.1 |    1000 |     24.05 μs |   0.033 μs |   0.029 μs |    43.4875 |     - |     - |     70.52 KB |
|            WhereFound |    .NET 4.6.1 |    .NET 4.6.1 |    1000 |     31.65 μs |   0.559 μs |   0.523 μs |    77.3315 |     - |     - |     125.4 KB |
|    WhereFoundMultiKey |    .NET 4.6.1 |    .NET 4.6.1 |    1000 |     33.10 μs |   0.071 μs |   0.059 μs |    82.1533 |     - |     - |    133.23 KB |
|         WhereNotFound | .NET Core 5.0 | .NET Core 5.0 |    1000 |     28.62 μs |   0.045 μs |   0.035 μs |     7.6294 |     - |     - |      62.5 KB |
| WhereNotFoundMultiKey | .NET Core 5.0 | .NET Core 5.0 |    1000 |     28.10 μs |   0.298 μs |   0.278 μs |     8.6060 |     - |     - |     70.31 KB |
|            WhereFound | .NET Core 5.0 | .NET Core 5.0 |    1000 |     36.08 μs |   0.254 μs |   0.226 μs |    15.2588 |     - |     - |    125.02 KB |
|    WhereFoundMultiKey | .NET Core 5.0 | .NET Core 5.0 |    1000 |     37.49 μs |   0.196 μs |   0.183 μs |    16.2354 |     - |     - |    132.84 KB |
|         **WhereNotFound** |    **.NET 4.6.1** |    **.NET 4.6.1** | **1000000** | **22,261.55 μs** |  **16.430 μs** |  **13.720 μs** | **38656.2500** |     **-** |     **-** |  **62685.59 KB** |
| WhereNotFoundMultiKey |    .NET 4.6.1 |    .NET 4.6.1 | 1000000 | 26,565.03 μs | 293.233 μs | 274.290 μs | 43468.7500 |     - |     - |  70521.52 KB |
|            WhereFound |    .NET 4.6.1 |    .NET 4.6.1 | 1000000 | 31,169.84 μs | 203.854 μs | 190.685 μs | 77312.5000 |     - |     - | 125371.18 KB |
|    WhereFoundMultiKey |    .NET 4.6.1 |    .NET 4.6.1 | 1000000 | 32,658.46 μs |  38.594 μs |  36.101 μs | 82125.0000 |     - |     - | 133209.91 KB |
|         WhereNotFound | .NET Core 5.0 | .NET Core 5.0 | 1000000 | 30,617.73 μs | 131.755 μs | 123.244 μs |  7625.0000 |     - |     - |     62500 KB |
| WhereNotFoundMultiKey | .NET Core 5.0 | .NET Core 5.0 | 1000000 | 34,692.41 μs |  40.108 μs |  35.555 μs |  8600.0000 |     - |     - |   70312.5 KB |
|            WhereFound | .NET Core 5.0 | .NET Core 5.0 | 1000000 | 34,518.26 μs |  64.218 μs |  56.928 μs | 15266.6667 |     - |     - | 125000.02 KB |
|    WhereFoundMultiKey | .NET Core 5.0 | .NET Core 5.0 | 1000000 | 36,319.10 μs | 283.244 μs | 264.947 μs | 16214.2857 |     - |     - | 132812.52 KB |
