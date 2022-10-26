# MarsTerrainRobotConsoleApp
The input of the app will be a series of commands to move the robot on the plateau. Mars plateau is a grid defined by the initial input of the app, such as 5x5, 3x4, etc.<br/>
The second input line will be a string containing multiple commands as described below:<br/>
L: Turn the robot left<br/>
R: Turn the robot right<br/>
F: Move forward on it's facing direction<br/>
Sample command string: LFLRFLFF<br/>
The robot will always start at X: 1, Y: 1 facing NORTH. If the robot reaches the limits of the plateau the command must be ignored.<br/>
Your goal is to navigate the robot and print the final position.<br/>
Example:<br/><br/>
Input:<br/><br/>
<i>5x5<br/>
FFRFLFLF</i><br/><br/>
Result:<br/><br>
<i>1,4,West</i><br/><br/>
There is no limit for the Plateau size<br/>
Inputs will always be valid, so there is no need to validate them<br/>
There is no 0,0 position
