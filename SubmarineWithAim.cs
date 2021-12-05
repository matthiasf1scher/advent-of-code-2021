namespace AdventOfCode2021
{
    public class SubmarineWithAim: Submarine
    {
        public int CurrentAim { get; private set; }

        public SubmarineWithAim(): base()
        {
            this.CurrentAim = 0;
        }

        public override void Up(int distance)
        {
            this.CurrentAim -= distance;
        }

        public override void Down(int distance)
        {
            this.CurrentAim += distance;
        }

        public override void Forward(int distance)
        {
            this.CurrentDistance += distance;
            this.CurrentDepth += distance * this.CurrentAim;
        }
    }
}