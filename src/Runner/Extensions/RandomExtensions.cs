using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runner.Extensions;
public static class Extensions
{
    private static Random rnd = new Random();

    public static T PickRandom<T>(this IList<T> source)
    {
        int randIndex = rnd.Next(source.Count);
        return source[randIndex];
    }
}
