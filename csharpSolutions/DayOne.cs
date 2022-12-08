namespace csharpSolutions;

public class DayOne : ISolver
{
    private readonly List<long> _elfCalories = new();
    
    public void Initialize(List<string> input)
    {
        long currentCalories = 0;
        foreach (var line in input)
        {
            if (string.IsNullOrWhiteSpace(line))
            {
                _elfCalories.Add(currentCalories);
                currentCalories = 0;
            }
            else
            {
                currentCalories += long.Parse(line);
            }
        }
        _elfCalories.Sort();
    }

    public long PartOne()
    {
        return GetNMostCalories(1);
    }

    public long PartTwo()
    {
        return GetNMostCalories(3);
    }

    private long GetNMostCalories(ushort elfCount)
    {
        return _elfCalories.TakeLast(elfCount).Sum();
    }
}