using BenchmarkDotNet.Attributes;
using Runner.Entities;
using Runner.Seed;
using Runner.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runner.Benchmarks;

[MemoryDiagnoser]
[Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class LinqCommands
{
    private List<UserDto> _users;
    private static Random rnd = new Random();
    private UserDto _randomUser;

    [GlobalSetup]
    public void GlobalSetup()
    {
        _users = DataGenerator.GetUsers(500);
        _randomUser = _users.PickRandom();
    }

    [GlobalCleanup]
    public void CleanUp()
    { 
    }

    [Benchmark]
    public UserDto? FindSingleOrDefault() 
        => _users.SingleOrDefault(x => x.FirstName == _randomUser.FirstName && 
                                  x.LastName == _randomUser.LastName &&
                                  x.Email == _randomUser.Email);
    
    [Benchmark]
    public UserDto? FindFirstOrDefault()
        => _users.FirstOrDefault(x => x.FirstName == _randomUser.FirstName &&
                                  x.LastName == _randomUser.LastName &&
                                  x.Email == _randomUser.Email);

    [Benchmark]
    public UserDto? FindIndexOf() => _users[_users.IndexOf(_randomUser)];


}

