using Bogus.DataSets;
using Bogus;
using Runner.Entities;

namespace Runner.Seed;
public static class DataGenerator
{
    public static List<UserDto> GetUsers(int numberOfUsers = 100)
    {
        var usersGenerator = GetUserGenerator();
        var users = usersGenerator.Generate(numberOfUsers);

        return users;
    }

    private static Faker<UserDto> GetUserGenerator()
    {
        return new Faker<UserDto>()
            .StrictMode(true)
            .RuleFor(c => c.UserId, f => f.IndexFaker)
            .RuleFor(c => c.FirstName, f => f.Person.FirstName)
            .RuleFor(c => c.LastName, f => f.Person.LastName)
            .RuleFor(c => c.Email, f => f.Person.Email)
            .FinishWith((f, c) =>
            {
                Console.WriteLine("Users created");
            });
    }
}
