using MarsRover.Commands;
using MarsRover.Models;
using System.Drawing;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Xunit;

namespace MarsRover.specs
{
    [Binding]
    public class RoverControlSystemSteps
    {
        private readonly RoverControlSystemStepsContext _context;
        private readonly Rover _rover;

        public RoverControlSystemSteps(RoverControlSystemStepsContext context)
        {
            _context = context;
            _rover = context.Rover;
        }

        [When(@"I start my journey at this location +.*")]
        public void WhenIStartMyJourneyAtThisLocation(Table table)
        {
            dynamic startingLocation = table.CreateDynamicInstance();

            _rover.Location = new Location
            {
                Point = new Point(startingLocation.X, startingLocation.Y),
                Direction = ConvertDirectionToEnum(startingLocation.Direction)
            };
        }

        [Then(@"I should be in a (.*) x (.*) crater")]
        public void ThenIShouldBeInAXByYCrater(int x, int y)
        {
            Assert.Equal(x - 1, _context.Crater.Width);
            Assert.Equal(y - 1, _context.Crater.Height);
        }

        [Then(@"I should have (.*) scuffs")]
        public void ThenIShouldHaveThisManyScuffs(int scuffs)
        {
            Assert.Equal(scuffs, _rover.Scuffs);
        }

        [When(@"I make the following moves")]
        public void WhenIMakeTheFollowingMoves(Table table)
        {
            dynamic moveTable = table.CreateDynamicInstance();
            var commands = (moveTable.Moves as string)?.Split(',');

            var movementProcessor = new MovementProcessor(_rover, commands, _context.Crater);
            movementProcessor.Move();
        }

        [Then(@"My final position will be")]
        public void ThenMyFinalPositionWillBe(Table table)
        {
            dynamic finalLocation = table.CreateDynamicInstance();

            Assert.Equal(finalLocation.X, _rover.Location.Point.X);
            Assert.Equal(finalLocation.Y, _rover.Location.Point.Y);
            Assert.Equal(ConvertDirectionToEnum(finalLocation.Direction), _rover.Location.Direction);
        }

        private static Direction ConvertDirectionToEnum(dynamic direction)
        {
            if (direction == "N") return Direction.North;
            if (direction == "E") return Direction.East;
            if (direction == "S") return Direction.South;
            return Direction.West;
        }
    }
}
