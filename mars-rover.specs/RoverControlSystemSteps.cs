using System;
using TechTalk.SpecFlow;

namespace mars_rover.specs
{
    [Binding]
    public class RoverControlSystemSteps
    {
        [Given(@"I'm a shiny new Mars Rover with immaculate paintwork")]
        public void GivenIMAShinyNewMarsRoverWithImmaculatePaintwork()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I start my journey")]
        public void WhenIStartMyJourney()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should have (.*) scuffs")]
        public void ThenIShouldHaveScuffs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
