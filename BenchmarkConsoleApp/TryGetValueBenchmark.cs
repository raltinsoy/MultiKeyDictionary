using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using MultiKeyDictionary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkConsoleApp
{
    [SimpleJob(RuntimeMoniker.Net50)]
    [SimpleJob(RuntimeMoniker.Net461)]
    [MemoryDiagnoser]
    public class TryGetValueBenchmark
    {
        [Params(1000, 1000000)]
        public int N;

        private Dictionary<int, string> _dictionary;
        private Dictionary<int, string, bool> _multiKeyDictionary;

        [GlobalSetup]
        public void Setup()
        {
            _dictionary = new Dictionary<int, string>();
            _multiKeyDictionary = new Dictionary<int, string, bool>();

            for (int i = 0; i < N; i++)
            {
                _dictionary.Add(i, "ASD" + i);
            }

            for (int i = 0; i < N; i++)
            {
                _multiKeyDictionary.Add(i, "ASD" + i, true);
            }
        }

        [Benchmark]
        public void TryGetValue()
        {
            for (int i = 0; i < N; i++)
            {
                _dictionary.TryGetValue(i, out _);
            }
        }

        [Benchmark]
        public void TryGetValueMultiKey()
        {
            for (int i = 0; i < N; i++)
            {
                _multiKeyDictionary.TryGetValue(i, "ASD" + i, out _);
            }
        }
    }
}
