using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using MultiKeyDictionary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BenchmarkConsoleApp
{
    [SimpleJob(RuntimeMoniker.NetCoreApp50)]
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    [SimpleJob(RuntimeMoniker.Net461)]
    //[RyuJitX64Job, LegacyJitX64Job]
    [MemoryDiagnoser]
    public class AddBenchmark
    {
        [Params(1000, 1000000)]
        public int N;

        [GlobalSetup]
        public void Setup()
        {
        }

        [Benchmark]
        public void Add()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            for (int i = 0; i < N; i++)
            {
                dictionary.Add(i, "ASD" + i);
            }
        }

        [Benchmark]
        public void AddMultiKey()
        {
            Dictionary<int, string, bool> dictionary = new Dictionary<int, string, bool>();
            for (int i = 0; i < N; i++)
            {
                dictionary.Add(i, "ASD" + i, true);
            }
        }
    }
}
