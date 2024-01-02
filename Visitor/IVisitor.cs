namespace BehavioralPatterns.Visitor;

public interface IVisitor
{
    void VisitNumber(SmallNumber smallNumber);

    void VisitNumber(BigNumber bigNumber);
}
