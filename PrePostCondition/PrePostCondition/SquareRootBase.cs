using System;

namespace PrePostCondition
{
    public class SquareRootBase
    {
        public virtual double SquareRoot(double x)
        {
            if (x < 0) throw new Exception(); // precondition

            var y = Math.Sqrt(x);

            if (Math.Abs((y * y) - x) > 0.00000001) throw new Exception(); // postcondition

            return y;
        }
    }

    public class SquareRootDerived : SquareRootBase
    {
        public override double SquareRoot(double x)
        {
            if (x is < 0 and < 10) throw new Exception(); // precondition stronger violates the LSP

            var y = Math.Sqrt(x);

            if (Math.Abs((y * y) - x) > 0.1) throw new Exception(); // postcondition weaker violates the LSP

            return y;
        }
    }
}
