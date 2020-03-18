using System.Drawing;

namespace MarsRover.Models
{
    public class Location
    {
        public Point Point { get; set; }

        public Direction Direction { get; set; }
    }

    public enum Direction
    {
        North,
        East,
        South,
        West
    }
}