using System.Collections;

namespace AdventOfCode2021.Parsers
{
    public class Parser
    {
        public List<int> ParseIntegers(List<string> input)
        {
            List<int> integers = new List<int>();

            foreach (string line in input)
            {
                integers.Add(Int32.Parse(line));
            }

            return integers;
        }

        public List<Command> ParseCommands(List<string> input)
        {
            List<Command> commands = new List<Command>();

            foreach (string line in input)
            {
                string[] splitted = line.Split(' ');
                Command.Direction dir = (Command.Direction) Enum.Parse(typeof(Command.Direction), splitted[0]);
                commands.Add(new Command(dir, Int32.Parse(splitted[1])));
            }

            return commands;
        }
    }
}
