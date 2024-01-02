namespace BehavioralPatterns.Visitor;

public class IncerementNumberVisitor : IVisitor
{
    public void VisitNumber(SmallNumber smallNumber)
    {
        Number number = smallNumber;

        int currentNumber = number.ValueNumber;
        System.Console.WriteLine($"current number is {currentNumber} after visit is {++currentNumber}");
    }

    public void VisitNumber(BigNumber bigNumber)
    {
        Number number = bigNumber;

        int current = number.ValueNumber;
        System.Console.WriteLine($"current number is {current} after visit is {current+10}");
    }
}
