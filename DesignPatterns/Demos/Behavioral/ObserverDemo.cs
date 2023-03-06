using DesignPatterns.Patterns.Behavioral.Observer;

namespace DesignPatterns.Demos.Behavioral
{
    internal static class ObserverDemo
    {
        public static void Run()
        {
            ConcreteSubject source = new ConcreteSubject();
            ConcreteObserverA observerA = new ConcreteObserverA(source);
            ConcreteObserverB observerB = new ConcreteObserverB(source);
            //source.attach(observerA); //attached in constructor; is it ok?
            //source.attach(observerB); //attached in constructor; is it ok?


            source.setValue("foo");

            source.setValue("bar");

            source.detach(observerB);

            source.setValue("baz");

        }
    }
}
