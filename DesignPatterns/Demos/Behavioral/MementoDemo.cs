using DesignPatterns.Patterns.Behavioral.Memento;

namespace DesignPatterns.Demos.Behavioral
{
    internal static class MementoDemo
    {

        public static void Run()
        {

            Originator originator = new();
            CareTaker careTaker = new();
            originator.setStateA("stateA 1");
            originator.setStateB("stateB 1");
            careTaker.Push(originator.Save());

            Console.WriteLine(originator.getStateA());
            Console.WriteLine(originator.getStateB());


            originator.setStateA("stateA 2");
            originator.setStateB("stateB 2");

            Console.WriteLine(originator.getStateA());
            Console.WriteLine(originator.getStateB());

            originator.Undo(careTaker.Pop());

            Console.WriteLine(originator.getStateA());
            Console.WriteLine(originator.getStateB());

            originator.setStateA("stateA 3");


            Console.WriteLine(originator.getStateA());
            Console.WriteLine(originator.getStateB());


        }
    }
}
