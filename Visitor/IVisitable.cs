namespace Visitor
{
    public interface IVisitable
    {
        double Accept(ITaxVisitor visitor);
    }
}
