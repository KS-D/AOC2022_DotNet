
using AOCSolutionRunner;
using csharpSolutions;

void PrintSolution(int day, ISolver solver, InputParser parser)
{
    solver.Initialize(parser.GetAllLine($"./input/{day}.txt"));
    Console.WriteLine(solver.PartOne());
    Console.WriteLine(solver.PartTwo());
}

void GetSolver(List<ISolver> solvers, int day, InputParser parser)
{
    var adjustDay = day - 1;
    if (adjustDay >= solvers.Count || adjustDay < 0)
    {
        Console.WriteLine("☃️ Looks like I haven't solved this one yet, or the day is invalid...");
    }
    else
    {
        PrintSolution(day, solvers[adjustDay], parser);
    }
}
    

void Menu()
{
    var day = 15;
    var solvers = new List<ISolver>{ new DayOne(), new DayTwo(), new DayThree(), new DayFour() };
    InputParser parser = new();
    
    Console.WriteLine("Welcome to advent of code 2022! 🎅");
    while (day > 0)
    {
        Console.Write("🎄Please enter a number to get the answer for the day: ");
        var input = Console.ReadLine();
        if (!int.TryParse(input, out day))
        {
            Console.Write("🚫🎁 Please only enter a number or you'll end up on the naughty list!");
        }
        else
        {
            GetSolver(solvers, day, parser);
        }
    }
    
}

Menu();
