namespace BehavioralPatterns.Visitor;
public abstract class Number
{
    readonly int valueNumber;
    readonly string type;

    protected Number(int valueNumber, string type)
    {
        this.valueNumber = valueNumber;
        this.type = type;

    }

    public int ValueNumber => valueNumber;

    public string ValueType => type;

    public abstract void Accept(IVisitor visitor);
}

public class SmallNumber : Number
{
    public SmallNumber(int valueNumber, string type) : base(valueNumber, type)
    {
    }

    public override void Accept(IVisitor visitor)
    {
        visitor.VisitNumber(this);
    }

}

public class BigNumber : Number
{
    public BigNumber(int valueNumber, string type) : base(valueNumber, type)
    {
    }

    public override void Accept(IVisitor visitor)
    {
        visitor.VisitNumber(this); 
    }
}