Feature: RoverControlSystem
	In order to control the Mars Rover
	As a member of the project ground control crew
	I want to be able to input movement controls to the rover and monitor any damage

Background: 
	Given I'm a shiny new Mars Rover with immaculate paintwork
		
		
Scenario: A new rover has no scuffs to its paintwork
	When I start my journey at this location
		| X | Y | Direction |
		| 0 | 0 | E         |
	Then I should have 0 scuffs
