using System.Drawing;
using TechTalk.SpecFlow;

namespace mars_rover.specs
{
    [Binding]
    public class CommonRoverControlSystemSteps
    {
        private readonly RoverControlSystemStepsContext _context;

        public CommonRoverControlSystemSteps(RoverControlSystemStepsContext context)
        {
            _context = context;
        }

        [Given(@"I'm a shiny new Mars Rover with immaculate paintwork")]
        public void GivenImAShinyNewMarsRoverWithImmaculatePaintwork()
        {
            _context.Rover = new Rover();
        }

        [StepArgumentTransformation(@"at (\d+),(\d+) location")]
        public void PointTransformation(int x, int y) => new Point(x, y);

    }
}
