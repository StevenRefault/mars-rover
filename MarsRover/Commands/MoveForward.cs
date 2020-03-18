using MarsRover.Models;
using System.Drawing;

namespace MarsRover.Commands
{
    public class MoveForward : IMovementCommand
    {
        public Rover PerformMovement(Rover rover, Crater? crater)
        {
            return crater != null ? AttemptToMove(rover, crater) : rover;
        }

        private static Rover AttemptToMove(Rover rover, Crater crater)
        {
            if (rover.Location.Direction == Direction.East && rover.Location.Point.X == crater.Width
                || rover.Location.Direction == Direction.West && rover.Location.Point.X == 0
                || rover.Location.Direction == Direction.South && rover.Location.Point.Y == 0
                || rover.Location.Direction == Direction.North && rover.Location.Point.Y == crater.Height)
            {
                rover.Scuffs++;
                return rover;
            }

            if (rover.Location.Direction == Direction.North)
            {
                rover.Location.Point = new Point(rover.Location.Point.X, rover.Location.Point.Y + 1);
            }

            if (rover.Location.Direction == Direction.East)
            {
                rover.Location.Point = new Point(rover.Location.Point.X + 1, rover.Location.Point.Y);
            }

            if (rover.Location.Direction == Direction.South)
            {
                rover.Location.Point = new Point(rover.Location.Point.X, rover.Location.Point.Y - 1);
            }

            if (rover.Location.Direction == Direction.West)
            {
                rover.Location.Point = new Point(rover.Location.Point.X - 1, rover.Location.Point.Y);
            }

            return rover;
        }
    }
}
