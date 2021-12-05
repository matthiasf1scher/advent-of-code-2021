namespace AdventOfCode2021
{
    public class Command
    {
        public enum Direction { up, down, forward }
        public Direction CommandDirection { get; set; }
        public int Distance { get; set; }

        public Command(Direction direction, int distance)
        {
            CommandDirection = direction;
            Distance = distance;
        }
    }
}
