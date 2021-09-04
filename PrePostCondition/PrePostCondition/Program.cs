using System;

namespace PrePostCondition
{
    class Program
    {
        static void Main(string[] args)
        {
            var sr = new SquareRootDerived();
            var ff = new SquareRootBase();
            ff.SquareRoot(1);
            var res = sr.SquareRoot(5.0);
            Console.WriteLine(res);
        }
    }
}
