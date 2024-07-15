A simple ASP.NET Core web application in C# to simulate a pair of loaded 6-sided dice. The program is controlled by the following information:

 - For each die, the face to be favored.

 - For each die, an integer factor in the range of 1 to 5 to apply to the favored face.  For example, if the “6” face of a die is favored by a factor of 2, the 6 is twice as likely to appear as each of the other faces, 1 to 5.

 - An integer value specifying the number of times the dice should be rolled with the current settings.

 - Stores the runtime results.

 The program reads the input from a web page and “rolls the dice” according to the settings found there and displays the results of each roll.

 