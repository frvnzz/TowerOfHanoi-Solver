namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!IsValidInput(args, out int numDisks)) return;

            string method = args[0];
            int moves = 0;

            switch (method)
            {
                case "-Recursive":
                    Console.WriteLine($"Solving Tower of Hanoi recursively with {numDisks} disks:");
                    moves = SolveHanoiRecursive(numDisks, 'A', 'C', 'B');
                    PrintMoves("recursion", moves, ConsoleColor.Cyan);
                    break;

                case "-Iterative":
                    Console.WriteLine($"Solving Tower of Hanoi iteratively with {numDisks} disks:");
                    moves = SolveHanoiIterative(numDisks);
                    PrintMoves("iteration", moves, ConsoleColor.Magenta);
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
                PrintError("Usage: dotnet run -Recursive <number_of_disks> or dotnet run -Iterative <number_of_disks>");
                return false;
            }

            if (numDisks < 0)
            {
                PrintError("The number of disks cannot be negative. Please enter a positive number.");
                return false;
            }

            if (numDisks == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("You input zero discs (=____=)");
                Console.ResetColor();
                return false;
            }

            return true;
        }


        // helper method to print moves
        static void PrintMoves(string method, int moves, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"It took {moves} moves to solve using {method}.");
            Console.ResetColor();
        }

        // helper method for error messages
        static void PrintError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        // recursive logic
        static int SolveHanoiRecursive(int n, char fromRod, char toRod, char auxRod)
        {
            if (n == 0) return 0;
            int moves = SolveHanoiRecursive(n - 1, fromRod, auxRod, toRod);
            Console.WriteLine($"Move disk {n} from rod {fromRod} to rod {toRod}");
            return moves + 1 + SolveHanoiRecursive(n - 1, auxRod, toRod, fromRod);
        }

        // iterative logic
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
                    Console.WriteLine($"Move disk {disk} from rod {fromRod} to rod {toRod}");
                    moves++;
                }
                else
                {
                    stack.Push((disk - 1, auxRod, toRod, fromRod));
                    Console.WriteLine($"Move disk {disk} from rod {fromRod} to rod {toRod}");
                    moves++;
                    stack.Push((disk - 1, fromRod, auxRod, toRod));
                }
            }

            return moves;
        }
    }
}