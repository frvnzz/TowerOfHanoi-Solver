namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!IsValidInput(args, out int numDisks)) return;

            string method = args[0];

            switch (method)
            {
                case "-Recursive":
                    SolveHanoiRecursively(numDisks);
                    break;
                case "-Iterative":
                    SolveHanoiIteratively(numDisks);
                    break;
                default:
                    PrintError("Invalid method. Use -Recursive or -Iterative.");
                    break;
            }
        }

        static bool IsValidInput(string[] args, out int numDisks)
        {
            numDisks = 0;

            if (args.Length < 2 || !int.TryParse(args[1], out numDisks))
            {
                PrintWarning("Usage: dotnet run -Recursive <number_of_disks> or dotnet run -Iterative <number_of_disks>");
                return false;
            }

            if (numDisks < 0)
            {
                PrintError("The number of disks cannot be negative. Please enter a positive number.");
                return false;
            }

            if (numDisks == 0)
            {
                PrintWarning("You input zero disks (=____=)");
                return false;
            }

            return true;
        }

        static void SolveHanoiRecursively(int numDisks)
        {
            Console.WriteLine($"Solving Tower of Hanoi recursively with {numDisks} disks:");
            int moves = SolveHanoiRecursive(numDisks, 'A', 'C', 'B');
            PrintMoves("recursion", moves, ConsoleColor.Cyan);
        }

        static void SolveHanoiIteratively(int numDisks)
        {
            Console.WriteLine($"Solving Tower of Hanoi iteratively with {numDisks} disks:");
            int moves = SolveHanoiIterative(numDisks);
            PrintMoves("iteration", moves, ConsoleColor.Magenta);
        }

        static int SolveHanoiRecursive(int n, char fromRod, char toRod, char auxRod)
        {
            if (n == 0) return 0;
            int moves = SolveHanoiRecursive(n - 1, fromRod, auxRod, toRod);
            Console.WriteLine($"Move disk {n} from {fromRod} to {toRod}");
            return moves + 1 + SolveHanoiRecursive(n - 1, auxRod, toRod, fromRod);
        }

        static int SolveHanoiIterative(int numDisks)
        {
            Stack<(int, char, char, char)> stack = new();
            int moves = 0;
            stack.Push((numDisks, 'A', 'C', 'B'));

            while (stack.Count > 0)
            {
                var (disk, fromRod, toRod, auxRod) = stack.Pop();
                if (disk == 1)
                {
                    Console.WriteLine($"Move disk {disk} from {fromRod} to {toRod}");
                    moves++;
                }
                else
                {
                    stack.Push((disk - 1, auxRod, toRod, fromRod));
                    Console.WriteLine($"Move disk {disk} from {fromRod} to {toRod}");
                    moves++;
                    stack.Push((disk - 1, fromRod, auxRod, toRod));
                }
            }
            return moves;
        }

        // Console.WriteLine functions with styling
        static void PrintMoves(string method, int moves, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"It took {moves} moves to solve using {method}.");
            Console.ResetColor();
        }

        static void PrintError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        static void PrintWarning(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}