using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using MultiKeyDictionary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BenchmarkConsoleApp
{
    [SimpleJob(RuntimeMoniker.Net50)]
    [SimpleJob(RuntimeMoniker.Net461)]
    //[RyuJitX64Job, LegacyJitX64Job]
    [MemoryDiagnoser]
    public class AddBenchmark
    {
        [Params(1000, 1000000)]
        public int N;

        //[GlobalSetup]
        //public void Setup()
        //{
        //}

        [Benchmark]
        public void Add()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            for (int i = 0; i < N; i++)
            {
                bool temp = true; //for momery allocate
                dictionary.Add(i, "ASD" + i);
            }
        }

        [Benchmark]
        public void AddTuple()
        {
            Dictionary<Tuple<int, bool>, string> dictionary = new Dictionary<Tuple<int, bool>, string>();
            for (int i = 0; i < N; i++)
            {
                dictionary.Add(new Tuple<int, bool>(i, true), "ASD" + i);
            }
        }

        [Benchmark]
        public void AddStructDoubleKey()
        {
            Dictionary<DoubleKey, string> dictionary = new Dictionary<DoubleKey, string>();
            for (int i = 0; i < N; i++)
            {
                dictionary.Add(new DoubleKey() { Key1 = i, Key2 = true }, "ASD" + i);
            }
        }

        [Benchmark]
        public void AddDoubleDictionary()
        {
            Dictionary<Dictionary<int, bool>, string> dictionary = new Dictionary<Dictionary<int, bool>, string>();
            for (int i = 0; i < N; i++)
            {
                var key1 = new Dictionary<int, bool>();
                key1.Add(i, true);
                dictionary.Add(key1, "ASD" + i);
            }
        }

        [Benchmark]
        public void AddMultiKey()
        {
            Dictionary<int, bool, string> dictionary = new Dictionary<int, bool, string>();
            for (int i = 0; i < N; i++)
            {
                dictionary.Add(i, true, "ASD" + i);
            }
        }
    }

    public struct DoubleKey
    {
        public int Key1 { get; set; }
        public bool Key2 { get; set; }
    }
}
