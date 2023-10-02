# Code Review Report

Name: Csongor Janosi

Flood Fill Algorithm

### A Short Summary about the Algorithm: 
The Flood Fill Algorithm is a recursive algorithm used to fill a contiguous area with a specific color. The algorithm is commonly used in computer graphics to fill areas with color, for example in paint programs. The motivation behind the algorithm is to provide an efficient and easy-to-use method for filling areas with color.

### Implementation Detail

#### Implementation Logic Explanation:
The program reads the input data from a file called "input.txt". It parses the input into a 2D char array and displays the initial state of the grid. Then it finds the starting point for the flood fill and runs the algorithm by recursively filling the neighboring cells. Finally, it writes the output data to a file named "output.txt". The FloodFill method takes the grid and starting position as parameters and recursively fills the adjacent cells with the specified color using the Flood Fill algorithm. The WriteGrid method writes the current state of the grid to the console.

#### Achievements:
1. The program correctly finds the starting point for the flood fill algorithm.
2. The FloodFill method correctly fills the adjacent cells with the specified color using the Flood Fill algorithm.
3. Writing the output after each step in the console in a user friendly way.

### Learned Knowledge from the Project

#### Major Challenges and Solutions:
1. Using a starting point so the user can further customize the input.
2. An other challenge was displaying the current state of the grid in the console. 
The solution was to use the Console.SetCursorPosition method to move the cursor to the upper left corner of the console and then write the grid to the console.

#### Minor Challenges and Solutions:
1. Finding the boundaries of the input square.

### Reflections on the Own Project:
1. The efficiency could be improved so the program is capable to handle larger grids.
2. Either a tutorial or error handling could be added to make the user's job easier when creating the input grid.

### Reflections on the Projects learned during the Presentation:
1. Item
2. Item, and so forth