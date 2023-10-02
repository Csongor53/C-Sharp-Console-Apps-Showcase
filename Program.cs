namespace Assignment2CsongorJanosi
{

    // User can Input: $ hanoi -Recursive 4 or $ hanoi -Iterative 4 (4 means the user specified number of disks.) The app solves the Tower of Hanoi problem using the following two strategies: Recursive, Iterative. Adapt ASCII art in the console to visualize the movements.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args);
            if ( !int.TryParse(args[1], out int numDisks))
            {
                Console.WriteLine("Usage: hanoi [-Recursive|-Iterative] numDisks");
                return;
            }

            HanoiSolver solver;
            if (args[0] == "-Recursive")
            {
                solver = new RecursiveHanoiSolver();
            }
            else if (args[0] == "-Iterative")
            {
                solver = new IterativeHanoiSolver();
            }
            else
            {
                Console.WriteLine("Invalid strategy specified. Valid options are -Recursive or -Iterative.");
                return;
            }

            solver.Solve(numDisks);
        }
    }

    abstract class HanoiSolver
    {
        protected int moveCount = 0;

        public abstract void Solve(int numDisks);

        protected void Move(int disk, int from, int to, int[] tower)
        {
            Console.WriteLine($"Move disk {disk} from {from} to {to}");
            moveCount++;

            // Update the graphical representation of the tower
            tower[from - 1]--;
            tower[to - 1]++;
            for (int i = tower.Length - 1; i >= 0; i--)
            {
                Console.Write("|");
                for (int j = 0; j < tower[i]; j++)
                {
                    Console.Write("=");
                }
                Console.WriteLine("|");
            }
            Console.WriteLine();
        }
    }

    class RecursiveHanoiSolver : HanoiSolver
    {
        public override void Solve(int numDisks)
        {
            Console.WriteLine($"Solving Tower of Hanoi recursively with {numDisks} disks...");

            int[] tower = new int[] { numDisks, 0, 0 };
            MoveTower(numDisks, 1, 3, 2, tower);

            Console.WriteLine($"Solved in {moveCount} moves.");
        }

        private void MoveTower(int numDisks, int from, int to, int via, int[] tower)
        {
            if (numDisks == 0) return;

            MoveTower(numDisks - 1, from, via, to, tower);
            Move(numDisks, from, to, tower);
            MoveTower(numDisks - 1, via, to, from, tower);
        }
    }

    class IterativeHanoiSolver : HanoiSolver
    {
        public override void Solve(int numDisks)
        {
            Console.WriteLine($"Solving Tower of Hanoi iteratively with {numDisks} disks...");

            int[] tower = new int[] { numDisks, 0, 0 };
            int currentDisk = 1;
            Stack<int[]> stack = new Stack<int[]>();
            stack.Push(new int[] { numDisks, 1, 2, 3 });

            while (stack.Count > 0)
            {
                int[] args = stack.Pop();
                int n = args[0];
                int from = args[1];
                int to = args[2];
                int via = args[3];

                if (n == 1)
                {
                    Move(currentDisk, from, to, tower);
                    currentDisk++;
                }
                else
                {
                    stack.Push(new int[] { n - 1, via, to, from });
                    stack.Push(new int[] { 1, from, to, via });
                    stack.Push(new int[] { n - 1, from, via, to });
                }
            }

            Console.WriteLine($"Solved in {moveCount} moves.");
        }
    }
}
