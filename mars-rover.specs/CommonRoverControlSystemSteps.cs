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

        [Given(@"I'm in a (.*) x (.*) Crater")]
        public void GivenImInAXByYCrater(int x, int y)
        {
            _context.Crater = new Crater
            {
                Width = x,
                Height = y
            };
        }

        [StepArgumentTransformation(@"at (\d+),(\d+) location")]
        public void PointTransformation(int x, int y) => new Point(x, y);

    }
}
