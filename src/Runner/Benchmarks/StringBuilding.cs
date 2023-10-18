using BenchmarkDotNet.Attributes;
using System.Text;
using Runner.Entities;
using BenchmarkDotNet.Jobs;

namespace Runner.Benchmarks;

[MemoryDiagnoser]
[SimpleJob(RuntimeMoniker.Net70, baseline:true)]
[SimpleJob(RuntimeMoniker.Net80)]
[Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class StringBuilding
{
    private readonly UserDto _user = new UserDto(1, "Jimmy", "Starbucks" , "Jimmy@mail.com");

    [Benchmark]
    public string? Concat3StringsStringBuilder()
    {
        var result = new StringBuilder();

        result.Append(_user.FirstName);
        result.Append(" ");
        result.Append(_user.LastName);
        
        return result.ToString();
    } 

    [Benchmark]
    public string? Concat3StringsWithPlus() => _user.FirstName + " " + _user.LastName;

    [Benchmark]
    public string? Concat3StringsWithConcat() => string.Concat(_user.FirstName, " ", _user.LastName);

    [Benchmark]
    public string? Concat3StringsWithInterpolation() => $"{_user.FirstName} {_user.LastName}";
}