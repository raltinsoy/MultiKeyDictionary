``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19043.2130/21H1/May2021Update)
AMD Ryzen 5 3600, 1 CPU, 12 logical and 6 physical cores
  [Host]               : .NET Framework 4.8 (4.8.4515.0), X64 RyuJIT VectorSize=256
  .NET 5.0             : .NET 5.0.17 (5.0.1722.21314), X64 RyuJIT AVX2
  .NET Framework 4.6.1 : .NET Framework 4.8 (4.8.4515.0), X64 RyuJIT VectorSize=256


```
|              Method |                  Job |              Runtime |       N |          Mean |         Error |        StdDev |       Gen0 |       Gen1 |      Gen2 |    Allocated |
|-------------------- |--------------------- |--------------------- |-------- |--------------:|--------------:|--------------:|-----------:|-----------:|----------:|-------------:|
|                 Add |             .NET 5.0 |             .NET 5.0 |    1000 |      42.59 μs |      0.126 μs |      0.112 μs |    20.6299 |     4.1504 |         - |    169.04 KB |
|            AddTuple |             .NET 5.0 |             .NET 5.0 |    1000 |     116.35 μs |      0.246 μs |      0.230 μs |    29.1748 |     8.6670 |         - |    239.35 KB |
|  AddStructDoubleKey |             .NET 5.0 |             .NET 5.0 |    1000 |     107.80 μs |      0.263 μs |      0.246 μs |    23.4375 |     5.8594 |         - |    192.48 KB |
| AddDoubleDictionary |             .NET 5.0 |             .NET 5.0 |    1000 |     123.53 μs |      0.347 μs |      0.324 μs |    43.4570 |    21.7285 |         - |    356.54 KB |
|       **AddMultiKey** |             .NET 5.0 |             .NET 5.0 |    1000 |      53.89 μs |      0.295 μs |      0.276 μs |    20.6299 |     4.1504 |         - |    169.04 KB |
|                 Add | .NET Framework 4.6.1 | .NET Framework 4.6.1 |    1000 |     104.92 μs |      0.328 μs |      0.307 μs |    27.7100 |     6.3477 |         - |    170.48 KB |
|            AddTuple | .NET Framework 4.6.1 | .NET Framework 4.6.1 |    1000 |     195.31 μs |      0.699 μs |      0.620 μs |    39.0625 |     0.9766 |         - |       241 KB |
|  AddStructDoubleKey | .NET Framework 4.6.1 | .NET Framework 4.6.1 |    1000 |     202.30 μs |      0.305 μs |      0.270 μs |    31.4941 |     8.7891 |         - |    193.99 KB |
| AddDoubleDictionary | .NET Framework 4.6.1 | .NET Framework 4.6.1 |    1000 |     216.14 μs |      1.359 μs |      1.271 μs |    58.1055 |    24.9023 |         - |    358.53 KB |
|       **AddMultiKey** | .NET Framework 4.6.1 | .NET Framework 4.6.1 |    1000 |     129.07 μs |      0.409 μs |      0.363 μs |    27.5879 |     6.3477 |         - |    170.48 KB |
|                 Add |             .NET 5.0 |             .NET 5.0 | 1000000 | 254,996.41 μs |  2,761.616 μs |  2,583.217 μs | 12000.0000 |  6000.0000 | 3000.0000 | 151020.79 KB |
|            AddTuple |             .NET 5.0 |             .NET 5.0 | 1000000 | 412,793.43 μs |  8,120.190 μs |  7,975.113 μs | 21000.0000 | 10000.0000 | 4000.0000 | 221331.07 KB |
|  AddStructDoubleKey |             .NET 5.0 |             .NET 5.0 | 1000000 | 298,068.63 μs |  4,435.637 μs |  4,149.098 μs | 15000.0000 |  6500.0000 | 3000.0000 | 174459.55 KB |
| AddDoubleDictionary |             .NET 5.0 |             .NET 5.0 | 1000000 | 678,859.04 μs | 13,223.097 μs | 11,041.885 μs | 36000.0000 | 19000.0000 | 4000.0000 | 338518.12 KB |
|       **AddMultiKey** |             .NET 5.0 |             .NET 5.0 | 1000000 | 284,687.67 μs |  5,029.049 μs |  4,704.175 μs | 12000.0000 |  6000.0000 | 3000.0000 | 151020.73 KB |
|                 Add | .NET Framework 4.6.1 | .NET Framework 4.6.1 | 1000000 | 326,742.33 μs |  1,980.290 μs |  1,852.365 μs | 16500.0000 |  7500.0000 | 3500.0000 | 159783.23 KB |
|            AddTuple | .NET Framework 4.6.1 | .NET Framework 4.6.1 | 1000000 | 519,759.17 μs | 10,189.638 μs | 10,007.587 μs | 29000.0000 | 11000.0000 | 5000.0000 |  230323.8 KB |
|  AddStructDoubleKey | .NET Framework 4.6.1 | .NET Framework 4.6.1 | 1000000 | 382,876.46 μs |  7,508.372 μs | 11,909.073 μs | 21000.0000 |  9000.0000 | 5000.0000 | 183335.59 KB |
| AddDoubleDictionary | .NET Framework 4.6.1 | .NET Framework 4.6.1 | 1000000 | 887,237.50 μs | 11,794.676 μs | 11,032.747 μs | 48000.0000 | 19000.0000 | 5000.0000 | 347838.13 KB |
|       **AddMultiKey** | .NET Framework 4.6.1 | .NET Framework 4.6.1 | 1000000 | 351,255.78 μs |  4,709.120 μs |  3,932.329 μs | 18000.0000 |  9000.0000 | 5000.0000 | 159787.99 KB |
