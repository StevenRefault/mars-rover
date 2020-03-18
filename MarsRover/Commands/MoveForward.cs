using MarsRover.Models;
using System.Drawing;

namespace MarsRover.Commands
{
    public class MoveForward : IMovementCommand
    {
        public Rover PerformMovement(Rover rover, Crater? crater)
        {
            if (crater != null)
            {
                return AttemptToMove(rover, crater);
            }

            return rover;
        }

        private static Rover AttemptToMove(Rover rover, Crater crater)
        {
            if (rover.Location.Direction == "E" && rover.Location.Point.X == crater.Width
                || rover.Location.Direction == "W" && rover.Location.Point.X == 0
                || rover.Location.Direction == "S" && rover.Location.Point.Y == 0
                || rover.Location.Direction == "N" && rover.Location.Point.Y == crater.Height)
            {
                rover.Scuffs++;
                return rover;
            }

            if (rover.Location.Direction == "N")
            {
                rover.Location.Point = new Point(rover.Location.Point.X, rover.Location.Point.Y + 1);
            }

            if (rover.Location.Direction == "E")
            {
                rover.Location.Point = new Point(rover.Location.Point.X + 1, rover.Location.Point.Y);
            }

            if (rover.Location.Direction == "S")
            {
                rover.Location.Point = new Point(rover.Location.Point.X, rover.Location.Point.Y - 1);
            }

            if (rover.Location.Direction == "W")
            {
                rover.Location.Point = new Point(rover.Location.Point.X - 1, rover.Location.Point.Y);
            }

            return rover;
        }
    }
}
