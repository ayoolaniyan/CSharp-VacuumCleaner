using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotCleaner.Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            //accept a set of input from standard in
            CommandFactory commandFactory = new CommandFactory();

            while (!commandFactory.InputsAreComplete)
            {
                Console.WriteLine(">");
                commandFactory.AddInput(Console.ReadLine());
            }
            Console.WriteLine("Input is Complete. Press any key to continue");
            Console.ReadLine();
            
            //robot cleaner should execute cleaning commands
            SimpleReporter repoter = new SimpleReporter();
            Robot vacuum = new Robot(commandFactory.GetCommandSet(), repoter, new Location(0,0), new Location(7,7) );
            vacuum.ExecuteCommands();

            //robot cleaner should output the number of places cleaned
            Console.WriteLine(vacuum.PrintReport());
        }
    }
}
