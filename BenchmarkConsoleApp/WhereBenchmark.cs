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
    public class WhereBenchmark
    {
        [Params(1000, 1000000)]
        public int N;

        private Dictionary<int, string> _dictionarySimple;
        private Dictionary<Tuple<int, bool>, string> _dictionaryTuple;
        private Dictionary<DoubleKey, string> _dictionaryStructDoubleKey;
        private Dictionary<Dictionary<int, bool>, string> _dictionaryDoubleDictionary;
        private Dictionary<int, bool, string> _dictionaryMultiKey;

        [GlobalSetup]
        public void Setup()
        {
            _dictionarySimple = new Dictionary<int, string>();
            _dictionaryTuple = new Dictionary<Tuple<int, bool>, string>();
            _dictionaryStructDoubleKey = new Dictionary<DoubleKey, string>();
            _dictionaryDoubleDictionary = new Dictionary<Dictionary<int, bool>, string>();
            _dictionaryMultiKey = new Dictionary<int, bool, string>();

            for (int i = 0; i < N; i++)
            {
                _dictionarySimple.Add(i, "ASD" + i);
            }

            for (int i = 0; i < N; i++)
            {
                _dictionaryTuple.Add(new Tuple<int, bool>(i, true), "ASD" + i);
            }

            for (int i = 0; i < N; i++)
            {
                _dictionaryStructDoubleKey.Add(new DoubleKey() { Key1 = i, Key2 = true }, "ASD" + i);
            }

            for (int i = 0; i < N; i++)
            {
                var key1 = new Dictionary<int, bool>();
                key1.Add(i, true);
                _dictionaryDoubleDictionary.Add(key1, "ASD" + i);
            }

            for (int i = 0; i < N; i++)
            {
                _dictionaryMultiKey.Add(i, true, "ASD" + i);
            }
        }

        [Benchmark]
        public void WhereNotFound_Simple()
        {
            for (int i = 0; i < N; i++)
            {
                _ = _dictionarySimple.Where(x => x.Key == -1);
            }
        }

        [Benchmark]
        public void WhereNotFound_Tuple()
        {
            for (int i = 0; i < N; i++)
            {
                _ = _dictionaryTuple.Where(x => x.Key.Item1 == -1);
            }
        }

        [Benchmark]
        public void WhereNotFound_StructDoubleKey()
        {
            for (int i = 0; i < N; i++)
            {
                _ = _dictionaryStructDoubleKey.Where(x => x.Key.Key1 == -1);
            }
        }

        [Benchmark]
        public void WhereNotFound_DoubleDictionary()
        {
            for (int i = 0; i < N; i++)
            {
                _ = _dictionaryDoubleDictionary.SelectMany(x => x.Key.Where(y => y.Key == -1));
            }
        }

        [Benchmark]
        public void WhereNotFound_MultiKey()
        {
            for (int i = 0; i < N; i++)
            {
                _ = _dictionaryMultiKey.Where(x => x.Key.Key1 == -1);
            }
        }

        [Benchmark]
        public void WhereFound_Simple()
        {
            for (int i = 0; i < N; i++)
            {
                _ = _dictionarySimple.Where(x => x.Key == i);
            }
        }

        [Benchmark]
        public void WhereFound_Tuple()
        {
            for (int i = 0; i < N; i++)
            {
                _ = _dictionaryTuple.Where(x => x.Key.Item1 == i);
            }
        }

        [Benchmark]
        public void WhereFound_StructDoubleKey()
        {
            for (int i = 0; i < N; i++)
            {
                _ = _dictionaryStructDoubleKey.Where(x => x.Key.Key1 == i);
            }
        }

        [Benchmark]
        public void WhereFound_DoubleDictionary()
        {
            for (int i = 0; i < N; i++)
            {
                _ = _dictionaryDoubleDictionary.SelectMany(x => x.Key.Where(y => y.Key == i));
            }
        }

        [Benchmark]
        public void WhereFound_MultiKey()
        {
            for (int i = 0; i < N; i++)
            {
                _ = _dictionaryMultiKey.Where(x => x.Key.Key1 == i);
            }
        }
    }
}
