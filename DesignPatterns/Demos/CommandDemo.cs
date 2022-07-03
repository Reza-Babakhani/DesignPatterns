using DesignPatterns.Patterns.Command;
using DesignPatterns.Patterns.Command.Undoable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Demos
{
    internal static class CommandDemo
    {
        public static void Run()
        {

            Reciver service = new();
            SomethingCommand command = new(service);
            Invoker invoker = new Invoker(command);

            invoker.Invoke();
        }


        public static void RunCompositeCommand()
        {
            CompositeCommand commands = new();

            SomethingCommand something = new(new());

            OtherCommand other = new();

            commands.add(something);
            commands.add(other);

            commands.Execute();
        }

        public static void RunUndoableCommand()
        {
            Reciver2 service = new();
            service.setContent("foobar");
            History history = new();
            SomethingCommand2 command = new(service, history);

            Console.WriteLine(service.getContent());
            command.Execute();
            Console.WriteLine(service.getContent());
            command.UnExecute();
            Console.WriteLine(service.getContent());


        }


    }
}
