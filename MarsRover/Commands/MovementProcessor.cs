using MarsRover.Models;
using System.Diagnostics;

namespace MarsRover.Commands
{
    public class MovementProcessor
    {
        private Rover _rover;
        private readonly string[] _commands;
        private readonly Crater _crater;
        private readonly MovementsFactory _movement;

        public MovementProcessor(Rover rover, string[] commands, Crater crater)
        {
            _rover = rover;
            _commands = commands;
            _crater = crater;
            _movement = new MovementsFactory();
        }

        public void Move()
        {
            foreach (var command in _commands)
            {
                if (command == "L")
                {
                    _rover = _movement.MoveLeft.PerformMovement(_rover);
                }

                if (command == "R")
                {
                    _rover = _movement.MoveRight.PerformMovement(_rover);
                }

                if (command == "F")
                {
                    _rover = _movement.MoveForward.PerformMovement(_rover, _crater);
                }

#if DEBUG
                Debug.WriteLine($"Rover is at {_rover.Location.Point.X}, {_rover.Location.Point.Y} facing {_rover.Location.Direction}");
#endif
            }
        }
    }
}
