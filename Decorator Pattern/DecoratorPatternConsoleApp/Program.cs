class Program
{
    static void Main()
    {
        // Basit bir ConcreteComponent
        IComponent component = new ConcreteComponent();

        // ConcreteDecoratorA ile genişletme
        IComponent decoratedA = new ConcreteDecoratorA(component);
        decoratedA.Operation();

        // ConcreteDecoratorB ile genişletme
        IComponent decoratedB = new ConcreteDecoratorB(component);
        decoratedB.Operation();

        // ConcreteDecoratorA ve ConcreteDecoratorB'yi kombinleme
        IComponent combinedDecorators = new ConcreteDecoratorA(new ConcreteDecoratorB(component));
        combinedDecorators.Operation();
    }
}