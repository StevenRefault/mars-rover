using MarsRover.Models;

namespace MarsRover.Commands
{
    public class MoveRight : IMovementCommand
    {
        public Rover PerformMovement(Rover rover, Crater? crater = null)
        {
            if (rover.Location.Direction == Direction.North)
            {
                rover.Location.Direction = Direction.East;
                return rover;
            }

            if (rover.Location.Direction == Direction.East)
            {
                rover.Location.Direction = Direction.South;
                return rover;
            }

            if (rover.Location.Direction == Direction.South)
            {
                rover.Location.Direction = Direction.West;
                return rover;
            }

            rover.Location.Direction = Direction.North;
            return rover;
        }
    }
}
