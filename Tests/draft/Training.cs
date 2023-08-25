using System.Linq;

namespace Tests.draft;

public class Training
{
    public static bool Exists(int[] ints, int k)
    {
        return ints.ToList().Exists(e => e == k);
    }
    
    public static int FindLargest(int[] numbers)
    {
        return numbers.ToList().Max();
    }
}