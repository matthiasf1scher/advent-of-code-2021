using System.Net;
using AdventOfCode2021.Parsers;

namespace AdventOfCode2021
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load
            var loader = new InputLoader();
            var linesDay1 = loader.Load(@".\inputs\input-day1.txt");
            var linesDay2 = loader.Load(@".\inputs\input-day2.txt");

            // Day 1
            var parser = new Parser();
            var ints = parser.ParseIntegers(linesDay1);

            var counter = new IncreasedCounter();
            var resultWindow1 = counter.CountWindow(ints, 1);
            var resultWindow3 = counter.CountWindow(ints, 3);

            // Day 2
            var commands = parser.ParseCommands(linesDay2);

            var yellowSubmarine = new Submarine();
            yellowSubmarine.Swim(commands);

            Console.WriteLine("Current position yellow: " + yellowSubmarine.CurrentPosition);

            var redSubmarine = new SubmarineWithAim();
            redSubmarine.Swim(commands);

            Console.WriteLine("Current position red: " + redSubmarine.CurrentPosition);
        }
    }
}