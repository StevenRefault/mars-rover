namespace MarsRover.Commands
{
    public class MovementsFactory
    {
        public MoveForward MoveForward { get; set; } = new MoveForward();
        public MoveLeft MoveLeft { get; set; } = new MoveLeft();
        public MoveRight MoveRight { get; set; } = new MoveRight();
    }
}
