Feature: RoverControlSystem
	In order to control the Mars Rover
	As a member of the project ground control crew
	I want to be able to input movement controls to the rover and monitor any damage

Background: 
	Given I'm a shiny new Mars Rover with immaculate paintwork
		And I'm in a 5 x 5 crater
		
###  Starting condition tests		
Scenario: A new rover has no scuffs to its paintwork
	When I start my journey at this location 0,0,E
		| X | Y | Direction |
		| 0 | 0 | E         |
	Then I should have 0 scuffs

Scenario: A crater is created of the correct size
	When I start my journey at this location 0,0,E
		| X | Y | Direction |
		| 0 | 0 | E         |
	Then I should be in a 5 x 5 crater

### Starting condition tests end



Scenario: Start at location 0,2 facing East
	When I start my journey at this location 0,2,E
		| X | Y | Direction |
		| 0 | 2 | E         |

		And I make the following moves
			| Moves        |
			| F,L,F,R,F,F,F,R,F,F,R,R |
			
	Then My final position will be 
		| X | Y | Direction |
		| 4 | 1 | N         |
		And I should have 0 scuffs 

Scenario: Start at location 4,4 facing South
	When I start my journey at this location 4,4,S
		| X | Y | Direction |
		| 4 | 4 | S         |

	And I make the following moves
		| Moves                     |
		| L,F,L,L,F,F,L,F,F,F,R,F,F |
			
	Then My final position will be 
		| X | Y | Direction |
		| 0 | 1 | W         |
		And I should have 1 scuffs 

Scenario: Start at location 2,2, facing west
	When I start my journey at this location 2,2,W
		| X | Y | Direction |
		| 2 | 2 | W         |

	And I make the following moves
		| Moves                         |
		| F,L,F,L,F,L,F,R,F,R,F,R,F,R,F |
			
	Then My final position will be 
		| X | Y | Direction |
		| 2 | 2 | N         |
		And I should have 0 scuffs 

Scenario: Start at location 1,3, facing north

	When I start my journey at this location 1,3,N
		| X | Y | Direction |
		| 1 | 3 | N         |

	And I make the following moves
		| Moves                 |
		| F,F,L,F,F,L,F,F,F,F,F |
			
	Then My final position will be 
		| X | Y | Direction |
		| 0 | 0 | S         |
		And I should have 3 scuffs 
