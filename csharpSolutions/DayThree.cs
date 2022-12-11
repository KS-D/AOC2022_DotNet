namespace csharpSolutions;

public class DayThree : ISolver
{
    private List<(string firstBag, string secondBag)> _bags = new List<(string firstBag, string secondBag)>();

    private List<string[]> _elfGroups = new List<string[]>();
    public void Initialize(List<string> input)
    {
        foreach (var line in input)
        {
            var midPoint = line.Length / 2;
            var first = line.Substring(0, midPoint);
            var second = line.Substring(midPoint);
            _bags.Add((first, second));
        }

        _elfGroups = input.Chunk(3).ToList();
    }

    public string PartOne()
    {
        long result = 0;
        foreach (var bag in _bags)
        {
            var h1 = bag.firstBag.ToHashSet();
            var h2 = bag.secondBag.ToHashSet();
            h1.IntersectWith(h2);
            var val = CharToInt(h1.First());

            result += val;
        }

        return result.ToString();
    }

    public string PartTwo()
    {
        long result = 0;
        foreach (var elves in _elfGroups)
        {
            var elf1 = elves[0].ToHashSet();
            var elf2 = elves[1].ToHashSet();
            var elf3 = elves[2].ToHashSet();
            
            elf1.IntersectWith(elf2);
            elf1.IntersectWith(elf3);
            var val = CharToInt(elf1.First());
            
            result += val;
        }

        return result.ToString();
    }

    public long CharToInt(char c)
    {
        int val = c;
        if (val <= 90)
            val -= 38;
        else
            val -= 96;

        return val;
    }
}