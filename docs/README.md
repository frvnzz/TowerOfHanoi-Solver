# TowerOfHanoi Solver

<p align="center">
  <img width="800" src="/docs/Tower_Of_Hanoi.gif">
</p> 

The objective of the Tower of Hanoi game is to move a given amount of disks from Tower 1 over to Tower 3. The challenge of the game is, that you cannot place a larger disk onto a smaller one.

## About The Project

This project is a solver for the Tower of Hanoi problem implemented in C#. The program uses two different approaches that the user can specify when running it:
- **Recursive Approach**
- **Iterative Approach**

### Built With
- **C#**
- **.NET 8.0 SDK** for development and execution/compilation

## Getting Started

To get started with the Tower of Hanoi Solver, follow the steps below to install and run the program.

### Prerequisites

Before running the program, ensure that you have the following installed:
- **[.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)**

### Installation and Execution

1. Clone the repository or download the source code from [here](https://github.com/frvnzz/TowerOfHanoi/archive/refs/heads/main.zip):
   ```bash
   git clone https://github.com/frvnzz/TowerOfHanoi.git
   cd TowerOfHanoi-Solver
   ```

2. Run the program using one of the following commands:

   **Recursive Approach:**  
   dotnet run -Recursive <number_of_disks>,
   e.g.:  
   ```bash
   dotnet run -Recursive 3
   ```

   **Iterative Approach:**  
   dotnet run -Iterative <number_of_disks>,
   e.g.:  
   ```bash
   dotnet run -Iterative 2
   ```

## Licence

Distributed under the Unlicense License. See `/docs/LICENSE.txt` for more information.

## Contact

Franz-Aurel Huber – [cc231014@fhstp.ac.at](mailto:cc231014@fhstp.ac.at)

## Acknowledgments

*Tower of Hanoi Animation  
`/docs/Tower_Of_Hanoi.gif`  
Source: [Wikimedia Commons](https://commons.wikimedia.org/wiki/File:Iterative_algorithm_solving_a_6_disks_Tower_of_Hanoi.gif), licensed under [Creative Commons Attribution-Share Alike 3.0 Unported](https://creativecommons.org/licenses/by-sa/3.0/deed.en).*
