=============================================================================
RobotWars by Alexander Karnadi
=============================================================================

Requirements
=============================================================================
A fleet of hand built robots are due to engage in battle for the annual “Robot Wars” competition. Each robot will be placed within a rectangular battle arena and will navigate their way around the arena using a built-in computer system.

A robot’s location and heading is represented by a combination of x and y co-ordinates and a letter representing one of the four cardinal compass points. The arena is divided up into a grid to simplify navigation. An example position might be 0, 0, N which means the robot is in the bottom left corner and facing North.

In order to control a robot, the competition organisers have provided a console for sending a simple string of letters to the on-board navigation system. The possible letters are ‘L’, ‘R’ and ‘M’. ‘L’ and ‘R’ make the robot spin 90 degrees to the left or right respectively without moving from its current spot while ‘M’ means move forward one grid point and maintain the same heading. Assume that the square directly North from (x, y) is (x, y+1).


Input
=============================================================================
The first line of input is the upper-right coordinates of the arena, the lower-left coordinates are assumed to be (0, 0).

The rest of the input is information pertaining to the robots that have been deployed. Each robot has two lines of input - the first gives the robot’s position and the second is a series of instructions telling the robot how to move within the arena.

The position is made up of two integers and a letter separated by spaces, corresponding to the x and y coordinates and the robot’s orientation. Each robot will finish moving sequentially, which means that the second robot won’t start to move until the first one has finished moving.


Output
=============================================================================
The output for each robot should be its final coordinates and heading.


Acceptance criteria
=============================================================================
In order to confirm your program is working correctly, we have provided some test input and output for your use. Implement these details however you consider most appropriate. We do expect this to be production ready code with appropriate tests and whatever you consider to be appropriate for code to go into production.

Although this can be fully implemented in a console window, credit will be given for representing the solution in WinForms to provide feedback to the user and a graphical representation of the arena and robots. This needn’t be pictorial graphics; text or basic WinForms controls will suffice.


Test input:
=============================================================================
5 5
1 2 N
LMLMLMLMM
3 3 E
MMRMMRMRRM

Expected output:
=============================================================================
1 3 N
5 1 E


Description
=============================================================================
There are two ways to start RobotWars. 
1. GUI
	This allows you to use regular and simple winform to enter robot details
	and to give commands to the robots using GUI controls. There are some
	simple validation for the input. The result of the input can be seen when
	"Commance Battle" button is pressed. It will open a Battle Form which has
	a simple grid to show exactly where the robots are. 
2. Console
	This allows you to use console for input and output. The input must be 
	in this order:
	1. Battle area or map size (line feed)
	2. Robot initial position (line feed). This needs to be in this format
		X Y Heading where X is the x coordinate in the map, Y is the y 
		coordinate in the map and Heading is E, W, S, or N. 
		If the X Y are not within the map then an error will occur.
	3. Robot set of commands (line feed). This needs to be L, R, or M.
		If other characters are given then an error will occur.
	4. If no more robot press line feed else repeat step no. 2
	5. Result will show you:
		* Position of each of robots you've entered.


Tests
=============================================================================
There are unit tests for:
1. RobotWars (Main project).
2. RobotWars.Console


Dependencies
=============================================================================
Unit test projects require:
1. NUnit version="3.2.1"
2. Moq version="4.5.9" 


TODO
=============================================================================
1. Logging
