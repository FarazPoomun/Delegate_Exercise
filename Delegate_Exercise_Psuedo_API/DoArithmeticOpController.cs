using Delegate_Exercise_CL;

namespace Delegate_Exercise_Psuedo_API
{
    public class DoArithmeticOpController
    {
        public IDoArithmeticOp GetNewInstance(int startingValue)
        {
            return new DoArithmeticOp(startingValue);
        }
    }
}
