using System.Linq;

namespace OOPS
{
    public class CalculateEvenNumber : Calculator
    {
        public CalculateEvenNumber(int[] numbers):base(numbers)
        {

        }
        public override int Calculate() => _numbers.Where(x => x % 2 == 0).Sum();
    }
}
