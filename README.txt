=============================================================================
RobotWars by Alexander Karnadi
=============================================================================

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