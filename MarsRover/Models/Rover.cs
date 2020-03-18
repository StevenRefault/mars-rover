using System.Drawing;

namespace MarsRover.Models
{
    public class Rover
    {
        public Location Location { get; set; }

        public int Scuffs { get; set; }
    }

    public class Location
    {
        public Point Point { get; set; }
        public string Direction { get; set; }
    }
}
