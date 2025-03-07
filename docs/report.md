
# Assignment1 Report

Course: C# Development SS2025 (4 ECTS, 3 SWS)

Student ID: cc231014

BCC Group: A

Name: Franz-Aurel Huber

## Methodology: 
The task was to implement a solver for the Tower of Hanoi problem using Iteration and Recursion. For Recursion, I used the standard divide-and-conquer strategy. The program first moves `n-1` disks to the middle / auxiliary rod. After that, the largest disk gets moved to the destination rod, and then `n-1` disks get moved onto the destination rod as well.  
For iteration, I used an explicit stack that simulates recalls of the operations.   

The code is structure into `SolveHanoiRecursively`, `SolveHanoiIteratively` and `SolveHanoiRecursive`, `SolveHanoiIterative`:

1. `SolveHanoiRecursively` and `SolveHanoiIteratively` serve as wrappers that print the initial and final messages as well as the moves by calling the other functions.
2. `SolveHanoiRecursive` and `SolveHanoiIterative` are the functions that actually contain the algorithms.

-> `SolveHanoiRecursively` and `SolveHanoiIteratively` call `SolveHanoiRecursive` and `SolveHanoiIterative`.

## Additional Features
1. Checking the user inputs: I implemented a positive integer check and a special console output when the user inputs 0 disks.
2. Color Coding: The warnings as well as the Recursion / Iteration output are color coded for readability inside the console. For this, I implemented separate helper functions for writing to the console, that can be called depending on what color should be displayed (`PrintMoves`, `PrintError`, `PrintWarning`).

## Discussion / Conclusion
Understanding the game / problem in the first place and boiling it down to logic that can be implemented using C# was the biggest problem I had.

## Work with: 
/

## Reference: 
### Websites:
[Iterative Tower of Hanoi](https://www.geeksforgeeks.org/iterative-tower-of-hanoi/)  
[Program for Tower of Hanoi Algorithm](https://www.geeksforgeeks.org/c-program-for-tower-of-hanoi/)  

### Videos:
[C# 10.0 - How to Code the Tower of Hanoi Recursive Solution in C#](https://www.youtube.com/watch?v=VhcY7ySH51g)  
[Tower of Hanoi | Recursion Problem | GeeksforGeeks](https://www.youtube.com/watch?v=YstLjLCGmgg&t=152s)
[🐐 C# Tutorial - Master the Towers of Hanoi Recursive Algorithm using C# | Computer Science](https://www.youtube.com/watch?v=TZPbMGRltpA)