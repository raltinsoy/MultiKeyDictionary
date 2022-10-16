``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19043.2130/21H1/May2021Update)
AMD Ryzen 5 3600, 1 CPU, 12 logical and 6 physical cores
  [Host]               : .NET Framework 4.8 (4.8.4515.0), X64 RyuJIT VectorSize=256
  .NET 5.0             : .NET 5.0.17 (5.0.1722.21314), X64 RyuJIT AVX2
  .NET Framework 4.6.1 : .NET Framework 4.8 (4.8.4515.0), X64 RyuJIT VectorSize=256


```
|                         Method |                  Job |              Runtime |       N |         Mean |      Error |     StdDev |       Median |       Gen0 |    Allocated |
|------------------------------- |--------------------- |--------------------- |-------- |-------------:|-----------:|-----------:|-------------:|-----------:|-------------:|
|           WhereNotFound_Simple |             .NET 5.0 |             .NET 5.0 |    1000 |     27.66 μs |   0.225 μs |   0.200 μs |     27.67 μs |     7.6294 |      62.5 KB |
|            WhereNotFound_Tuple |             .NET 5.0 |             .NET 5.0 |    1000 |     27.53 μs |   0.147 μs |   0.138 μs |     27.56 μs |     7.6294 |      62.5 KB |
|  WhereNotFound_StructDoubleKey |             .NET 5.0 |             .NET 5.0 |    1000 |     25.55 μs |   0.510 μs |   0.681 μs |     26.03 μs |     7.6294 |      62.5 KB |
| WhereNotFound_DoubleDictionary |             .NET 5.0 |             .NET 5.0 |    1000 |     14.75 μs |   0.292 μs |   0.527 μs |     15.13 μs |     7.6447 |      62.5 KB |
|         **WhereNotFound_MultiKey** |             .NET 5.0 |             .NET 5.0 |    1000 |     24.69 μs |   0.491 μs |   0.656 μs |     25.04 μs |     7.6294 |      62.5 KB |
|              WhereFound_Simple |             .NET 5.0 |             .NET 5.0 |    1000 |     31.39 μs |   0.213 μs |   0.189 μs |     31.38 μs |    15.2588 |    125.02 KB |
|               WhereFound_Tuple |             .NET 5.0 |             .NET 5.0 |    1000 |     30.33 μs |   0.062 μs |   0.055 μs |     30.34 μs |    15.2893 |    125.02 KB |
|     WhereFound_StructDoubleKey |             .NET 5.0 |             .NET 5.0 |    1000 |     31.76 μs |   0.134 μs |   0.125 μs |     31.77 μs |    15.2588 |    125.02 KB |
|    WhereFound_DoubleDictionary |             .NET 5.0 |             .NET 5.0 |    1000 |     18.64 μs |   0.133 μs |   0.124 μs |     18.66 μs |    15.2893 |    125.03 KB |
|            **WhereFound_MultiKey** |             .NET 5.0 |             .NET 5.0 |    1000 |     29.34 μs |   0.209 μs |   0.195 μs |     29.34 μs |    15.2588 |    125.02 KB |
|           WhereNotFound_Simple | .NET Framework 4.6.1 | .NET Framework 4.6.1 |    1000 |     22.67 μs |   0.259 μs |   0.242 μs |     22.68 μs |    10.1929 |     62.68 KB |
|            WhereNotFound_Tuple | .NET Framework 4.6.1 | .NET Framework 4.6.1 |    1000 |     19.88 μs |   0.062 μs |   0.052 μs |     19.87 μs |    10.1929 |     62.68 KB |
|  WhereNotFound_StructDoubleKey | .NET Framework 4.6.1 | .NET Framework 4.6.1 |    1000 |     22.25 μs |   0.211 μs |   0.197 μs |     22.26 μs |    10.1929 |     62.68 KB |
| WhereNotFound_DoubleDictionary | .NET Framework 4.6.1 | .NET Framework 4.6.1 |    1000 |     13.54 μs |   0.033 μs |   0.031 μs |     13.52 μs |    12.7411 |     78.36 KB |
|         **WhereNotFound_MultiKey** | .NET Framework 4.6.1 | .NET Framework 4.6.1 |    1000 |     23.24 μs |   0.249 μs |   0.220 μs |     23.27 μs |    10.1929 |     62.68 KB |
|              WhereFound_Simple | .NET Framework 4.6.1 | .NET Framework 4.6.1 |    1000 |     29.51 μs |   0.145 μs |   0.121 μs |     29.54 μs |    20.3857 |    125.39 KB |
|               WhereFound_Tuple | .NET Framework 4.6.1 | .NET Framework 4.6.1 |    1000 |     25.52 μs |   0.051 μs |   0.045 μs |     25.52 μs |    20.3857 |    125.39 KB |
|     WhereFound_StructDoubleKey | .NET Framework 4.6.1 | .NET Framework 4.6.1 |    1000 |     29.58 μs |   0.234 μs |   0.219 μs |     29.62 μs |    20.3857 |    125.39 KB |
|    WhereFound_DoubleDictionary | .NET Framework 4.6.1 | .NET Framework 4.6.1 |    1000 |     19.53 μs |   0.056 μs |   0.047 μs |     19.52 μs |    22.9492 |    141.07 KB |
|            **WhereFound_MultiKey** | .NET Framework 4.6.1 | .NET Framework 4.6.1 |    1000 |     30.22 μs |   0.163 μs |   0.144 μs |     30.22 μs |    20.3857 |    125.39 KB |
|           WhereNotFound_Simple |             .NET 5.0 |             .NET 5.0 | 1000000 | 25,298.75 μs | 503.498 μs | 470.972 μs | 25,448.47 μs |  7625.0000 |     62500 KB |
|            WhereNotFound_Tuple |             .NET 5.0 |             .NET 5.0 | 1000000 | 27,145.12 μs | 170.752 μs | 159.722 μs | 27,164.44 μs |  7625.0000 |     62500 KB |
|  WhereNotFound_StructDoubleKey |             .NET 5.0 |             .NET 5.0 | 1000000 | 28,334.26 μs | 259.160 μs | 229.739 μs | 28,381.60 μs |  7625.0000 |     62500 KB |
| WhereNotFound_DoubleDictionary |             .NET 5.0 |             .NET 5.0 | 1000000 | 15,030.88 μs |  16.501 μs |  15.435 μs | 15,028.97 μs |  7640.6250 |     62500 KB |
|         **WhereNotFound_MultiKey** |             .NET 5.0 |             .NET 5.0 | 1000000 | 34,747.25 μs | 169.989 μs | 159.007 μs | 34,679.63 μs |  7600.0000 |     62500 KB |
|              WhereFound_Simple |             .NET 5.0 |             .NET 5.0 | 1000000 | 29,373.45 μs | 143.208 μs | 133.957 μs | 29,349.83 μs | 15281.2500 | 125000.02 KB |
|               WhereFound_Tuple |             .NET 5.0 |             .NET 5.0 | 1000000 | 32,484.12 μs | 111.676 μs | 104.461 μs | 32,471.08 μs | 15250.0000 | 125000.02 KB |
|     WhereFound_StructDoubleKey |             .NET 5.0 |             .NET 5.0 | 1000000 | 32,542.56 μs |  78.081 μs |  69.217 μs | 32,558.52 μs | 15250.0000 | 125000.02 KB |
|    WhereFound_DoubleDictionary |             .NET 5.0 |             .NET 5.0 | 1000000 | 18,046.34 μs |  56.460 μs |  50.050 μs | 18,025.21 μs | 15281.2500 | 125000.03 KB |
|            **WhereFound_MultiKey** |             .NET 5.0 |             .NET 5.0 | 1000000 | 31,672.58 μs | 125.521 μs | 117.413 μs | 31,662.94 μs | 15250.0000 | 125000.02 KB |
|           WhereNotFound_Simple | .NET Framework 4.6.1 | .NET Framework 4.6.1 | 1000000 | 23,196.86 μs | 111.528 μs | 104.323 μs | 23,202.25 μs | 10187.5000 |  62684.13 KB |
|            WhereNotFound_Tuple | .NET Framework 4.6.1 | .NET Framework 4.6.1 | 1000000 | 20,055.12 μs | 233.519 μs | 218.434 μs | 20,064.75 μs | 10187.5000 |  62684.13 KB |
|  WhereNotFound_StructDoubleKey | .NET Framework 4.6.1 | .NET Framework 4.6.1 | 1000000 | 23,209.74 μs | 167.290 μs | 156.483 μs | 23,265.23 μs | 10187.5000 |  62684.12 KB |
| WhereNotFound_DoubleDictionary | .NET Framework 4.6.1 | .NET Framework 4.6.1 | 1000000 | 13,497.56 μs |  27.508 μs |  24.385 μs | 13,488.07 μs | 12750.0000 |  78355.67 KB |
|         **WhereNotFound_MultiKey** | .NET Framework 4.6.1 | .NET Framework 4.6.1 | 1000000 | 23,833.85 μs | 192.384 μs | 179.956 μs | 23,859.51 μs | 10187.5000 |  62684.13 KB |
|              WhereFound_Simple | .NET Framework 4.6.1 | .NET Framework 4.6.1 | 1000000 | 28,663.92 μs | 262.600 μs | 245.636 μs | 28,685.33 μs | 20375.0000 |    125368 KB |
|               WhereFound_Tuple | .NET Framework 4.6.1 | .NET Framework 4.6.1 | 1000000 | 25,389.65 μs |  13.878 μs |  12.982 μs | 25,387.31 μs | 20375.0000 |    125368 KB |
|     WhereFound_StructDoubleKey | .NET Framework 4.6.1 | .NET Framework 4.6.1 | 1000000 | 28,760.92 μs | 160.660 μs | 150.281 μs | 28,802.44 μs | 20375.0000 |    125368 KB |
|    WhereFound_DoubleDictionary | .NET Framework 4.6.1 | .NET Framework 4.6.1 | 1000000 | 19,214.84 μs |  41.882 μs |  37.127 μs | 19,207.34 μs | 22937.5000 | 141039.24 KB |
|            **WhereFound_MultiKey** | .NET Framework 4.6.1 | .NET Framework 4.6.1 | 1000000 | 30,072.92 μs | 593.008 μs | 608.975 μs | 29,963.73 μs | 20375.0000 |    125368 KB |
