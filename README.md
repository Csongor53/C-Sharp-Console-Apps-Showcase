# Report:
## Tower of Hanoi Console Application

The code represents a console app that solves the Tower of Hanoi problem using either a recursive or an iterative strategy. The user has to input the number of disks and the chosen strategy (either -Recursive or -Iterative) as command line arguments.

### Implementation Overview
The program starts by checking the command line arguments and verifying that the number of disks is a valid integer. If they are invalid, the program outputs an error message and exits. If the arguments are valid, the program creates a HanoiSolver object corresponding to the chosen strategy and invokes the Solve() method to solve the problem.

The HanoiSolver abstract class defines a Move() method that moves a disk from one tower to another and updates the graphical representation of the towers in the console. The class also defines a moveCount variable to keep track of the number of moves made during the solution.

The RecursiveHanoiSolver and IterativeHanoiSolver classes inherit from the HanoiSolver class and implement the Solve() method using the recursive and iterative strategies, respectively. The MoveTower() method in the RecursiveHanoiSolver class is the recursive algorithm that solves the problem, while the iterative algorithm is implemented using a stack in the IterativeHanoiSolver class.