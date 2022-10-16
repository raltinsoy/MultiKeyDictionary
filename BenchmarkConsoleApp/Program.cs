using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using System;

namespace BenchmarkConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args, new DebugInProcessConfig());

#if DEBUG
            var config = DefaultConfig.Instance.WithOptions(ConfigOptions.DisableOptimizationsValidator);
            //BenchmarkRunner.Run<AddBenchmark>(config);
            //BenchmarkRunner.Run<ContainsBenchmark>(config);
            //BenchmarkRunner.Run<ContainsKeyBenchmark>(config);
            //BenchmarkRunner.Run<RemoveBenchmark>(config);
            //BenchmarkRunner.Run<TryGetValueBenchmark>(config);
            //BenchmarkRunner.Run<WhereBenchmark>(config);
#else
            //BenchmarkRunner.Run<AddBenchmark>();
            //BenchmarkRunner.Run<ContainsBenchmark>();
            //BenchmarkRunner.Run<ContainsKeyBenchmark>();
            //BenchmarkRunner.Run<RemoveBenchmark>();
            //BenchmarkRunner.Run<TryGetValueBenchmark>();
            BenchmarkRunner.Run<WhereBenchmark>();
#endif

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
