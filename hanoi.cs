namespace Assignment1;

class Program
{
    static void Main(string[] args)
    {
        if (!IsValidInput(args, out int numDisks)) return;

        switch (args[0])
        {
            case "-Recursive":
                Console.WriteLine($"Solving Tower of Hanoi recursively with {numDisks} disks:");
                int recursiveMoves = SolveHanoiRecursive(numDisks, 'A', 'C', 'B');

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"It took {recursiveMoves} moves to solve using recursion.");
                Console.ResetColor();

                break;

            case "-Iterative":
                Console.WriteLine($"Solving Tower of Hanoi iteratively with {numDisks} disks:");
                int iterativeMoves = SolveHanoiIterative(numDisks);

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"It took {iterativeMoves} moves to solve using iteration.");
                Console.ResetColor();

                break;

            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid method. Use -Recursive or -Iterative.");
                Console.ResetColor();

                break;
        }
    }

    static bool IsValidInput(string[] args, out int numDisks)
    {
        numDisks = 0;
        if (args.Length < 2 || !int.TryParse(args[1], out numDisks))
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Usage: dotnet run -Recursive <number_of_disks> or dotnet run -Iterative <number_of_disks>");
            Console.ResetColor();
            return false;
        }
        if (numDisks < 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: The number of disks cannot be negative. Please enter a positive number.");
            Console.ResetColor();
            return false;
        }
        if (numDisks == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You input zero discs (=____=)");
            Console.ResetColor();
            return false;
        }
        return true;
    }

    //recursive logic
    static int SolveHanoiRecursive(int n, char fromRod, char toRod, char auxRod)
    {
        if (n == 0) return 0;
        int moves = SolveHanoiRecursive(n - 1, fromRod, auxRod, toRod);
        Console.WriteLine($"Move disk {n} from rod {fromRod} to rod {toRod}");
        return moves + 1 + SolveHanoiRecursive(n - 1, auxRod, toRod, fromRod);
    }

    //iterative logic
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