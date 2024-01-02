using BehavioralPatterns.Visitor;

namespace Visitor
{
    public class NumbetCollection
    {
        List<Number> numberList = new List<Number>();

        public NumbetCollection()
        {
            numberList = new List<Number> {
                new SmallNumber(12, "small 1"),
                new SmallNumber(43, "small 2"),
                new SmallNumber(16, "small 3"),
                new BigNumber(131, "big 1"),
                new BigNumber(255, "big 2"),
                new BigNumber(1710, "big 3"),
            };
        }

        public void AddToNumbers(Number number)
        {
            numberList.Add(number);
        }

        public void RemoveFromNumbers(Number number)
        {
            numberList.Remove(number);
        }

        public void DisplayNumbers()
        {
            foreach (var number in numberList)
            {
                System.Console.WriteLine($"{number.ValueType} {number.ValueNumber}");
            }
        }

        public void Accept(IVisitor visitor)
        {
            foreach (var number in numberList)
            {
                number.Accept(visitor);
            }
        }
    }
}