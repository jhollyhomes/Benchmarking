using BenchmarkDotNet.Running;
using Runner.Benchmarks;

Console.WriteLine("Starting Benchmarking");

var stringBuildingResult = BenchmarkRunner.Run<StringBuilding>();

// To run :  dotnet run -c Release -f net7.0