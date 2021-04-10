using BenchmarkDotNet.Running;
using System;

namespace BenchmarkConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args, new DebugInProcessConfig());

            BenchmarkRunner.Run<AddBenchmark>();
            BenchmarkRunner.Run<ContainsBenchmark>();
            BenchmarkRunner.Run<ContainsKeyBenchmark>();
            BenchmarkRunner.Run<RemoveBenchmark>();
            BenchmarkRunner.Run<TryGetValueBenchmark>();

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
