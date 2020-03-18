using MarsRover.Models;

namespace MarsRover.Commands
{
    public class MoveLeft : IMovementCommand
    {
        public Rover PerformMovement(Rover rover, Crater crater = null)
        {
            if (rover.Location.Direction == "N")
            {
                rover.Location.Direction = "W";
                return rover;
            }

            if (rover.Location.Direction == "E")
            {
                rover.Location.Direction = "N";
                return rover;
            }

            if (rover.Location.Direction == "S")
            {
                rover.Location.Direction = "E";
                return rover;
            }

            if (rover.Location.Direction == "W")
            {
                rover.Location.Direction = "S";
                return rover;
            }

            return rover;
        }
    }
}
