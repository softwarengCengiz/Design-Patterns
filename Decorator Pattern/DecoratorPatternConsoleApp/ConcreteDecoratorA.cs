// ConcreteDecoratorA
public class ConcreteDecoratorA : Decorator
{
    public ConcreteDecoratorA(IComponent component) : base(component)
    {
    }

    public override void Operation()
    {
        base.Operation();
        Console.WriteLine("The operation has been changed for A.");
    }
}