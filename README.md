# TowerOfHanoi

## About The Project

This project is a solver for the Tower of Hanoi problem implemented in C#. The program uses two different approaches that the user can specify when running it:
- **Recursive Approach**
- **Iterative Approach**

### Built With
- **C#** (.NET 8.0.406)
- **.NET 8.0 SDK** for development and execution

## Getting Started

To get started with the Tower of Hanoi Solver, follow the steps below to install and run the program.

### Prerequisites

Before running the program, ensure that you have the following installed:
- **[.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)**

### Installation and Execution

1. Clone the repository or download the source code:
   ```bash
   git clone https://github.com/frvnzz/TowerOfHanoi.git
   cd TowerOfHanoi
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
