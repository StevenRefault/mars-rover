using System.Drawing;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Xunit;

namespace mars_rover.specs
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

        [When(@"I start my journey at this location")]
        public void WhenIStartMyJourneyAtThisLocation(Table table)
        {
            dynamic startingLocation = table.CreateDynamicInstance();

            _rover.Location = new Location
            {
                Point = new Point(startingLocation.X, startingLocation.Y),
                Direction = startingLocation.Direction
            };
        }

        [Then(@"I should have (.*) scuffs")]
        public void ThenIShouldHaveScuffs(int scuffs)
        {
            Assert.Equal(scuffs, _rover.Scuffs);
        }
    }
}
