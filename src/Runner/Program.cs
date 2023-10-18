using BenchmarkDotNet.Running;
using Runner.Benchmarks;

Console.WriteLine("Starting Benchmarking");

//var stringBuildingResult = BenchmarkRunner.Run<StringBuilding>();
var stringLinqCommands = BenchmarkRunner.Run<StringBuilding>();