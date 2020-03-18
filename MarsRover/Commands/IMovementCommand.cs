using MarsRover.Models;

namespace MarsRover.Commands
{
    public interface IMovementCommand
    {
        Rover PerformMovement(Rover rover, Crater crater = null);
    }
}
