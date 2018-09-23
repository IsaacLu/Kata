using System;
using System.Linq;

namespace SumOfDigitsOrDigitalRoot
{
    public class Number
    {
        public int DigitalRoot(long n) => n > 10
            ? DigitalRoot(n.ToString().Select(x => int.Parse(x.ToString())).Sum())
            : unchecked((int)n);
    }
}
