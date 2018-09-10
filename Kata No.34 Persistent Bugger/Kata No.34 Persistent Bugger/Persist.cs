using System.Linq;

namespace Kata_No._34_Persistent_Bugger
{
    public class Persist
    {
        public static int Persistence(long n)
        {
            return (int)((n / 10).Equals(0) ? 
                0 : 
                1 + Persistence(n.ToString().ToCharArray().Select(x => (long)char.GetNumericValue(x)).ToArray().Aggregate((x, y) => x * y)));
        }
    }
}