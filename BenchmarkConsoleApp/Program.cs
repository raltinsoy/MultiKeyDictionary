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
            BenchmarkRunner.Run<AddBenchmark>(config);
#else
            BenchmarkRunner.Run<AddBenchmark>();
#endif

            //BenchmarkRunner.Run<ContainsBenchmark>();
            //BenchmarkRunner.Run<ContainsKeyBenchmark>();
            //BenchmarkRunner.Run<RemoveBenchmark>();
            //BenchmarkRunner.Run<TryGetValueBenchmark>();
            //BenchmarkRunner.Run<WhereBenchmark>();

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
