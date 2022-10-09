namespace Delegate_Exercise_CL
{
    public class BasicArithmeticOp : IBasicArithmeticOp
    {
        public int Result { get; private set; }

        public BasicArithmeticOp(int startingValue)
        {
            Result = startingValue;
        }
    }
}