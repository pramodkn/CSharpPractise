using System.Linq;

namespace OOPS
{
    public class CalculateSum : Calculator
    {
        public CalculateSum(int[] numbers) : base(numbers)
        {

        }
        public override int Calculate() => _numbers.Sum();
    }
}
