namespace AdventOfCode2021
{
    public class Submarine
    {
        public int CurrentDepth { get; protected set; }
        public int CurrentDistance { get; protected set; }
        public int CurrentPosition => CurrentDepth * CurrentDistance;

        public Submarine()
        {
            CurrentDepth = 0;
            CurrentDistance = 0;
        }

        public virtual void Down(int distance)
        {
            this.CurrentDepth += distance;
        }

        public virtual void Up(int distance)
        {
            this.CurrentDepth -= distance;
        }

        public virtual void Forward(int distance)
        {
            this.CurrentDistance += distance;
        }

        public virtual void Swim(List<Command> commands)
        {
            foreach (var command in commands)
            {
                switch (command.CommandDirection)
                {
                    case Command.Direction.down:
                        this.Down(command.Distance);
                        break;
                    case Command.Direction.up:
                        this.Up(command.Distance);
                        break;
                    case Command.Direction.forward:
                        this.Forward(command.Distance);
                        break;
                    default:
                        throw new Exception("Unkown command");
                }
            }
        }
    }
}